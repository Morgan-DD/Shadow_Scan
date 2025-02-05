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

namespace ShadowScan_Server
{
    public class Program
    {
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
        }

        private void pingPc(List<string> hostnames)
        {

        }

        public string TestFromScanPart()
        {
            return "aaaaaaaa";
        }

    }
}
