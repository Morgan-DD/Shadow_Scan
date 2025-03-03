using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShadowScan_Client.Services
{
    public class LongLiveStream
    {

        public async Task SubscribeToUpdates(SubscriptionRequest request,
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