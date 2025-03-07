    using Grpc.Core;
using ShadowScan_Client;

namespace ShadowScan_Client.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            Console.WriteLine("New Server: " + request.TeacherHostname);
            Console.WriteLine(request.BannedRessouces);
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            return Task.FromResult(new HelloReply
            {
                Status = true,
                UserName = username
                
            });
        }
    }
}