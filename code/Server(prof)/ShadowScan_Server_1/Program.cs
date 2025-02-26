using Grpc.Net.Client;
using ShadowScan_Client;
using Grpc.Net.Compression;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Grpc.Net.Client;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Threading;


namespace ShadowScan_Server
{
    public class Program
    {
        byte _maxPingTest = 1;

        


        static void Main(string[] args)
        {
            var input = new HelloRequest { Name = "LeBoss" };
            /*
            var httpHandler = new SocketsHttpHandler
            {
                PooledConnectionLifetime = TimeSpan.FromMinutes(5) // Optional: Helps with DNS changes
            };
            

            var channel = GrpcChannel.ForAddress("https://your-grpc-server", new GrpcChannelOptions
            {
                HttpHandler = httpHandler
            });
            var client = new Greeter.GreeterClient(channel);
            var response = await client.SayHelloAsync(new HelloRequest { Name = ".NET" });

            var reply = await client.SayHelloAsync(input);

            Console.WriteLine(reply.Message);

            Console.ReadLine();
            */

            Program thisProgram = new Program();
            thisProgram.connectToGRPCServer("https://INF-A23-P203:55052");
            Console.ReadKey();


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
                        return (Convert.ToByte(pingStatus),ip);
                    }
                }
                catch (Exception e) 
                {
                }
            }
            return (0, "NONE");
        }

        private async void connectToGRPCServer(string hostname) 
        {
            var input = new HelloRequest { Name = "LeBoss" };

            /*
            var httpHandler = new SocketsHttpHandler
            {
                PooledConnectionLifetime = TimeSpan.FromMinutes(5) // Optional: Helps with DNS changes
            };

            var channel = GrpcChannel.ForAddress("hostname", new GrpcChannelOptions
            {
                HttpHandler = httpHandler
            });
            */

            /*
            var channel = GrpcChannel.ForAddress(hostname);
            var client = new Greeter.GreeterClient(channel);
            var response = await client.SayHelloAsync(new HelloRequest { Name = ".NET" });

            var reply = await client.SayHelloAsync(input);

            Console.WriteLine(reply.Message);

            Console.ReadLine();*/

            var channel = GrpcChannel.ForAddress("https://localhost:5001", new GrpcChannelOptions
            {
                //HttpHandler = new GrpcWebHandler(new HttpClientHandler())
            });

            var client = new Greeter.GreeterClient(channel);
            var response = await client.SayHelloAsync(new HelloRequest { Name = ".NET" });

            /*
            // Create a gRPC channel
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            // Create a client instance
            var client = new Greeter.GreeterClient(channel);

            // Call the RPC method
            var response = await client.SayHelloAsync(new HelloRequest { Name = "John" });

            Console.WriteLine($"Server Response: {response.Message}");
            */
        }
    }
}
