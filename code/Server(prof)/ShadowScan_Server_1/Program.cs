using Grpc.Net.Client;
using ShadowScan_Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Grpc.Net.Client;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Threading;


namespace ShadowScan_Server
{
    public class Program
    {
        byte _maxPingTest = 1;

        static async Task Main(string[] args)
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

            Program test = new Program();

            Console.WriteLine(test.pingPc("inf-a11-m213"));

            Console.ReadKey();
        }

        /// <summary>
        /// Ping a pc
        /// </summary>
        /// <param name="hostname">hostname of the pc to ping</param>
        /// <returns>[True] if the pc is pingable, else [false]</returns>
        public (byte, string) pingPc(string hostname) //List<string> hostnames
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
                        return (Convert.ToByte(reply.Status == IPStatus.Success), reply.Address.ToString());
                    }
                }
                catch (Exception e) 
                {
                }
            }
            return (0, "NONE");
        }
    }
}
