using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Grpc.Net.Client;
using System.Net.Http;
using ShadowScan_Server;
using Grpc;
using System.Net.NetworkInformation;
using ShadowScan_Client;
using System.Diagnostics;

namespace ShadowScan_Server
{
    public class Program
    {
        byte _maxPingTest = 1;

        static async Task Main(string[] args)
        {
            // thisProgram.connectToGRPCServer("INF-A23-P203");                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               );
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

        public async void connectToGRPCServer(string hostname)
        {
            
            var input = new HelloRequest { Name = "LeBoss" };

            var httpHandler = new HttpClientHandler();
            // httpHandler.DefaultRequestVersion = HttpVersion.Version11;
            var channel = GrpcChannel.ForAddress("http://" + hostname + ":55052", new GrpcChannelOptions
            {
                HttpHandler = httpHandler
            });


            var client = new Greeter.GreeterClient(channel);
            var response = await client.SayHelloAsync(new HelloRequest { Name = ".AAAAAAAAAA" });
            
            Debug.WriteLine(response.Message);
        }
    }
}
