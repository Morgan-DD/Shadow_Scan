using Grpc.Core;
using ShadowScan_Client;

namespace ShadowScan_Client.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        // private readonly ShadowScan_Logic _shadowScanLogic; // ✅ Add this

        private static List<string> _bannedSites = new List<string>();

        // ✅ Inject ShadowScan_Logic in the constructor
        public GreeterService(ILogger<GreeterService> logger /*, ShadowScan_Logic shadowScanLogic */)
        {
            _logger = logger;
            //_shadowScanLogic = shadowScanLogic;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            Console.WriteLine("New Server: " + request.TeacherHostname);
            Console.WriteLine(request.BannedRessouces);
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            if (!string.IsNullOrEmpty(request.BannedRessouces))
            {
                lock (_bannedSites) // Ensure thread safety
                {
                    var resources = request.BannedRessouces.Split(',');
                    _bannedSites.AddRange(resources);
                }
            }

            // ✅ Call StartScan() when SayHello() is invoked
            // _shadowScanLogic.StartScan();

            return Task.FromResult(new HelloReply
            {
                Status = true,
                UserName = username
            });
        }

        public List<string> getBannedRessourceList()
        {
            return _bannedSites;
        }
    }
}
