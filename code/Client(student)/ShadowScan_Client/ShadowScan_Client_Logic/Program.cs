using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PcapDotNet;
using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.Dns;
using PcapDotNet.Packets.Ethernet;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;
using ShadowScan_Client;

namespace ShadowScan_Client_Logic
{
    internal class ShadowScan_Logic
    {
        public static Dictionary<string, string> _ipHostname = new Dictionary<string, string>();

        static ShadowScan_Logic _this = new ShadowScan_Logic();

        static List<string> _bannedSites = new List<string>();

        LongLiveStreamService _longLiveStreamService = new LongLiveStreamService();

        static async Task Main(string[] args)
        {
            List<string> bannedSites = new List<string>();

            _bannedSites.Add("chatgpt.com");
            _bannedSites.Add("etml.ch");

            Task.Run(async () => scanForInfractions_WebSite());

            Console.ReadKey();
        }

        private static void scanForInfractions_WebSite()
        {
            Thread.Sleep(1000);
            Console.WriteLine("SCAN INFRACTIONS");

            // Take the selected adapter
            List<PacketDevice> networkInterfaces = new List<PacketDevice>();
            foreach (LivePacketDevice device in LivePacketDevice.AllLocalMachine)
            {
                networkInterfaces.Add(device);
                Task.Run(async () => startScanOnInterFace(device));
            }
        }

        private static void reportInfraction(string webSite)
        {
            Console.WriteLine("INFRACTION!!!  --> " + webSite);
        }

        private static void startScanOnInterFace(LivePacketDevice device)
        {
            using (PacketCommunicator communicator =
                   device.Open(65536,
                               PacketDeviceOpenAttributes.Promiscuous,
                               1000))
            {
                communicator.ReceivePackets(0, packet =>
                {
                    var ethernet = packet.Ethernet;
                    if (ethernet.EtherType == EthernetType.IpV4)
                    {
                        var ip = ethernet.IpV4;
                        if (ip.Protocol == IpV4Protocol.Udp)
                        {
                            var udp = ip.Udp;
                            if (udp.DestinationPort == 53 || udp.SourcePort == 53) // DNS Port
                            {
                                var dns = udp.Dns;
                                if (dns != null && dns.IsQuery && dns.QueryCount > 0)
                                {
                                    foreach (DnsQueryResourceRecord query in dns.Queries)
                                    {
                                        CheckIfBanned(query.DomainName.ToString());
                                    }
                                }
                            }
                        }
                    }
                });
            }
        }

        private static void CheckIfBanned(string webSite)
        {
            foreach (string bannedWebSite in _bannedSites) 
            {
                if (webSite.Contains(bannedWebSite))
                {
                    reportInfraction(webSite);
                }
            }
        }
    }
}