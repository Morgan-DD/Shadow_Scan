﻿using Grpc.Core;
using Grpc.Net.Client;
using ShadowScan_Client;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;

namespace ShadowScan_Server
{
    public class Program
    {
        byte _maxPingTest = 1;

        static async Task Main(string[] args)
        {
            Console.WriteLine("aaaaaaa");
            Program thisProgram = new Program();
            // thisProgram.isGRPCServerReachabel("INF-A23-P203");

            var cts = new CancellationTokenSource();
            await thisProgram.StartLongLiveStream("INF-A23-P203", cts.Token);

            Console.WriteLine("FIN");
            Console.ReadLine();
        }

        /// <summary>
        /// Ping a pc
        /// </summary>
        /// <param name="hostname">hostname of the pc to ping</param>
        /// <returns>[True] if the pc is pingable, else [false]</returns>
        public (byte, string) pingPc(string hostname)
        {
            // Debug.WriteLine(hostname);
            // do multiple tries
            for (int i = 0; i < _maxPingTest; i++)
            {
                try
                {
                    // Thread.Sleep(500);
                    using (Ping pinger = new Ping())
                    {
                        PingReply reply = pinger.Send(hostname);
                        bool pingStatus = reply.Status == IPStatus.Success;
                        string ip = "";
                        if (pingStatus)
                        {
                            ip = reply.Address.ToString();
                        }
                        return (Convert.ToByte(pingStatus), ip);
                    }
                }
                catch (Exception e)
                {
                }
            }
            return (0, "NONE");
        }

        private dynamic GetChannel(string hostname)
        {
            var input = new HelloRequest { TeacherHostname = hostname };

            var httpHandler = new HttpClientHandler();
            var channel = GrpcChannel.ForAddress("http://" + hostname + ":55052", new GrpcChannelOptions
            {
                HttpHandler = httpHandler
            });

            return channel;
        }

        public async Task<(bool, string)> isGRPCServerReachabel(string hostname, List<string> bannedRessources)
        {
            string username = "";
            var input = new HelloRequest
            {
                TeacherHostname = hostname,
                BannedRessources = String.Join("&", bannedRessources)
            };

            var client = new Greeter.GreeterClient(GetChannel(hostname));
            bool response = false;
            try
            {
                var returnValue = (await client.SayHelloAsync(input));
                response = returnValue.Status;
                string fullhostname = returnValue.UserName;
                username = fullhostname.Split("\\")[fullhostname.Split("\\").Count()-1];

            }
            catch { }
            Debug.WriteLine(response);
            return (response, username);
        }
        
        public async Task StartLongLiveStream(string hostname, CancellationToken cancellationToken) // , InfractionManager parent
        {
            Console.WriteLine("Start stream with: {0}", hostname);

            var client = new HeartBeat.HeartBeatClient(GetChannel(hostname));
            var request = new HeartBeatLookupModel { ServerName = "Client_1" };

            using var call = client.GetHeartBeatInfo(request);

            try
            {
                await foreach (var update in call.ResponseStream.ReadAllAsync(cancellationToken))
                {
                    Console.WriteLine("Received heartbeat: " + update.Answer);
                }
            }
            catch (RpcException ex)
            {
                Console.WriteLine($"Stream error: {ex.Status}");
            }
        }
    }
}
