using Grpc.Core;
using System.Threading.Tasks;

namespace ShadowScan_Client.Services
{
    public class HeartBeatService : HeartBeat.HeartBeatBase
    {
        public override async Task GetHeartBeatInfo(HeartBeatLookupModel request, IServerStreamWriter<HeartBeatModel> responseStream, ServerCallContext context)
        {
            while (!context.CancellationToken.IsCancellationRequested)
            {
                var heartBeat = new HeartBeatModel { Answer = "Server is alive" };
                await responseStream.WriteAsync(heartBeat);
                await Task.Delay(5000); // Wait for 5 seconds before sending the next heartbeat
            }
        }
    }
}
