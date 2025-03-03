using System;
using System.Net;
using System.Threading.Tasks;
using PcapDotNet;
using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;

namespace ShadowScan_Client_Logic
{
    internal class ShadowScan_Logic
    {
        static async Task Main(string[] args)
        {
            List<string> bannedSites = new List<string>();

            bannedSites.Add("chatgpt.com");

            Task.Run(async () => scanForInfractions_WebSite(bannedSites));

            ccc();
            Console.ReadKey();
        }

        private static void scanForInfractions_WebSite(List<string> webSiteList)
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

        private static void startScanOnInterFace(LivePacketDevice device)
        {
            // Open the device
            using (PacketCommunicator communicator =
                device.Open(65536,                                  // portion of the packet to capture
                                                                    // 65536 guarantees that the whole packet will be captured on all the link layers
                                    PacketDeviceOpenAttributes.Promiscuous, // promiscuous mode
                                    1000))                                  // read timeout
            {
                Console.WriteLine("Listening on " + device.Description + "...");

                // start the capture
                communicator.ReceivePackets(0, PacketHandler);
            }
        }

        private static void ccc()
        {


            // Retrieve the device list from the local machine
            IList<LivePacketDevice> allDevices = LivePacketDevice.AllLocalMachine;

            if (allDevices.Count == 0)
            {
                Console.WriteLine("No interfaces found! Make sure WinPcap is installed.");
                return;
            }

            // Print the list
            for (int i = 0; i != allDevices.Count; ++i)
            {
                LivePacketDevice device = allDevices[i];
                Console.Write((i + 1) + ". " + device.Name);
                if (device.Description != null)
                    Console.WriteLine(" (" + device.Description + ")");
                else
                    Console.WriteLine(" (No description available)");
            }

            int deviceIndex = 0;
            do
            {
                Console.WriteLine("Enter the interface number (1-" + allDevices.Count + "):");
                string deviceIndexString = Console.ReadLine();
                if (!int.TryParse(deviceIndexString, out deviceIndex) ||
                    deviceIndex < 1 || deviceIndex > allDevices.Count)
                {
                    deviceIndex = 0;
                }
            } while (deviceIndex == 0);

            // Take the selected adapter
            PacketDevice selectedDevice = allDevices[deviceIndex - 1];

            // Open the device
            using (PacketCommunicator communicator =
                selectedDevice.Open(65536,                                  // portion of the packet to capture
                                                                            // 65536 guarantees that the whole packet will be captured on all the link layers
                                    PacketDeviceOpenAttributes.Promiscuous, // promiscuous mode
                                    1000))                                  // read timeout
            {
                Console.WriteLine("Listening on " + selectedDevice.Description + "...");

                // start the capture
                communicator.ReceivePackets(0, PacketHandler);
            }
        }

        // Callback function invoked by Pcap.Net for every incoming packet
        private static void PacketHandler(Packet packet)
        {
            Console.WriteLine(packet.Ethernet.IpV4.Destination);
            /*
            IPAddress hostIPAddress = IPAddress.Parse(packet.Ethernet.IpV4.Destination.ToString());
            IPHostEntry hostInfo = Dns.GetHostByAddress(hostIPAddress);
            Console.WriteLine(hostInfo.HostName + " | " + packet.Ethernet.IpV4.Destination);
            */
            //  Console.WriteLine(packet.Timestamp.ToString("yyyy-MM-dd hh:mm:ss.fff") + " length:" + packet.Length);
        }
    }
}