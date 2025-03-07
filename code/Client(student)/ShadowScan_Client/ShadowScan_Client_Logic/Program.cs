using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using Microsoft.AspNetCore.Builder;
using ShadowScan_Client.Services;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace ShadowScan_Client_Logic
{
    internal class ShadowScan_Logic
    {
        // list of banned websites
        static List<string> _bannedSites = new List<string>();

        // initialisation of the methode of the long steam
        LongLiveStreamService _longLiveStreamService = new LongLiveStreamService();

        // if true, we show notification
        static bool _showNotificaiton {  get; set; }

        // notification manager
        static InfractionManager _InfractionManager = new InfractionManager(false);

        static NotifyIcon notifyIcon = new NotifyIcon();
        static bool Visible = true;

        private IHost _host;

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        public static void SetConsoleWindowVisibility(bool visible)
        {
            IntPtr hWnd = FindWindow(null, Console.Title);
            if (hWnd != IntPtr.Zero)
            {
                if (visible) ShowWindow(hWnd, 1); //1 = SW_SHOWNORMAL           
                else ShowWindow(hWnd, 0); //0 = SW_HIDE               
            }
        }

        static async Task Main(string[] args)
        {
            ShadowScan_Logic thisForm = new ShadowScan_Logic();

            /*
            _bannedSites.Add("openai.com");
            _bannedSites.Add("chatgpt.com");
            _bannedSites.Add("anthropic.com");
            _bannedSites.Add("bard.google.com");
            _bannedSites.Add("deepmind.com");
            _bannedSites.Add("huggingface.co");
            _bannedSites.Add("stability.ai");
            _bannedSites.Add("midjourney.com");
            _bannedSites.Add("runwayml.com");
            _bannedSites.Add("elevenlabs.io");
            _bannedSites.Add("perplexity.ai");
            _bannedSites.Add("cohere.com");
            _bannedSites.Add("mistral.ai");
            _bannedSites.Add("meta.ai");
            _bannedSites.Add("nvidia.ai");
            _bannedSites.Add("scale.com");
            _bannedSites.Add("replicate.com");
            _bannedSites.Add("playgroundai.com");
            _bannedSites.Add("pika.art");
            _bannedSites.Add("character.ai");
            _bannedSites.Add("fakeyou.com");
            _bannedSites.Add("voicify.ai");
            _bannedSites.Add("notion.ai");
            _bannedSites.Add("scribehow.com");
            _bannedSites.Add("fotor.com");
            _bannedSites.Add("veed.io");
            _bannedSites.Add("descript.com");
            _bannedSites.Add("copy.ai");
            _bannedSites.Add("jasper.ai");
            _bannedSites.Add("synthesia.io");
            _bannedSites.Add("deepgram.com");
            _bannedSites.Add("gptzero.me");
            _bannedSites.Add("krisp.ai");
            _bannedSites.Add("soundraw.io");
            _bannedSites.Add("riverside.fm");
            _bannedSites.Add("podcastle.ai");
            */

            Task.Run(async () => thisForm.StartGrpcServerAsync());

            

            changeNotificationStatus(true);
            notifyIcon.Icon = Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);
            notifyIcon.Visible = true;
            notifyIcon.Text = System.Windows.Forms.Application.ProductName;

            var contextMenu = new ContextMenuStrip();
            // contextMenu.Items.Add("Activer Les Notifications", null, (s, e) => { System.Windows.Forms.Application.Exit(); });
            notifyIcon.ContextMenuStrip = contextMenu;

            Console.WriteLine("Running!");


            // Standard message loop to catch click-events on notify icon
            // Code after this method will be running only after Application.Exit()
            System.Windows.Forms.Application.Run();

            // Console.ReadKey();
            notifyIcon.Visible = false;
        }

        public async Task StartGrpcServerAsync()
        {
            var builder = WebApplication.CreateBuilder();

            builder.Services.AddGrpc();

            builder.WebHost.ConfigureKestrel(options =>
            {
                options.ListenAnyIP(55052); // Bind to all network interfaces
            });

            var app = builder.Build();

            app.MapGrpcService<GreeterService>();
            app.MapGrpcService<HeartBeatService>();
            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client.");

            _host = app;

            await _host.StartAsync();
        }

        public async Task StopGrpcServerAsync()
        {
            if (_host != null)
            {
                await _host.StopAsync();
                _host.Dispose();
            }
        }

        private static void changeNotificationStatus(bool NewStatus)
        {
            _showNotificaiton = NewStatus;
            _InfractionManager._showNotification= NewStatus;
        }

        public void StartScan()
        {
            Task.Run(async () => scanForInfractions_WebSite());
        }

        private static void scanForInfractions_WebSite()
        {
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
            List<string> test = new List<string>();
            _InfractionManager.ReportInfraction(1, webSite, "pg66hua");
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
                    reportInfraction(bannedWebSite);
                }
            }
        }
    }
}