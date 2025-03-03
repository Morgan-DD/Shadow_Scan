using Grpc.Core;
using Grpc.Net.Client;
using ShadowScan_Client;
using System.Diagnostics;
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
            // thisProgram.isGRPCServerReachabel("INF-A23-P203");                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               );
            await thisProgram.StartLongLiveStream("INF-A23-P203");

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

        public async Task<bool> isGRPCServerReachabel(string hostname)
        {
            var input = new HelloRequest { TeacherHostname = hostname };

            var client = new Greeter.GreeterClient(GetChannel(hostname));
            bool response = false;
            try
            {
                response = (await client.SayHelloAsync(input)).Status;
            }
            catch { }
            Debug.WriteLine(response);
            return response;
        }

        public async Task StartLongLiveStream(string hostname)
        {
            Console.WriteLine("Start stream with : {0}", hostname);

            // using var channel = GrpcChannel.ForAddress(hostname);
            var client = new ShadowService.ShadowServiceClient(GetChannel(hostname));

            var request = new SubscriptionRequest { ClientId = "Client_1" };

            using var call = client.SubscribeToUpdates(request);

            Console.WriteLine(call);

            try
            {
                await foreach (var update in call.ResponseStream.ReadAllAsync())
                {
                    Console.WriteLine("a");
                }
            }
            catch
            {

            }

            /*try
            {
                await foreach (var update in call.ResponseStream.ReadAllAsync())
                {
                    Console.WriteLine($"Received update: {update.Message} at {update.Timestamp}");
                }
            }
            catch (RpcException ex) when (ex.StatusCode == Grpc.Core.StatusCode.Cancelled)
            {
                Console.WriteLine("Stream cancelled.");
            }*/
        }
    }
}
