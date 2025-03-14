using Grpc.Core;
using ShadowScan_Client;
using System;
using System.Threading.Tasks;
using ShadowScan_Client.Services;

namespace ShadowScan_Client
{
    public class LongLiveStreamService : ShadowService.ShadowServiceBase // ✅ Inherit from gRPC base class
    {
        public override async Task SubscribeToUpdates(SubscriptionRequest request,
            IServerStreamWriter<UpdateMessage> responseStream, ServerCallContext context)
        {
            Console.WriteLine($"Client {request.ClientId} subscribed.");

            while (!context.CancellationToken.IsCancellationRequested)
            {
                var update = new UpdateMessage
                {
                    Message = "New update at " + DateTime.UtcNow,
                    Timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds()
                };

                await responseStream.WriteAsync(update);
                await Task.Delay(5000); // Simulate periodic updates every 5 seconds
            }

            Console.WriteLine($"Client {request.ClientId} disconnected.");
        }
    }
}
