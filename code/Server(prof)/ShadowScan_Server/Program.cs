﻿using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Grpc.Net.Client;
using System.Net.Http;
using ShadowScan_Server;

namespace ShadowScan_Server
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var input = new HelloRequest { Name = "LeBogoss" };

            var channel = GrpcChannel.ForAddress("http://localhost:5000");
            var client = new Greeter.GreeterClient(channel);

            var reply = await client.SayHelloAsync(input);

            Console.WriteLine(reply.Message);

            Console.ReadLine();
        }
    }
}
