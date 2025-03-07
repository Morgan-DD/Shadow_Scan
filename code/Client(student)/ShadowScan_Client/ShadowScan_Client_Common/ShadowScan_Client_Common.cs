using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShadowScan_Client;
using ShadowScan_Client.Services;
using ShadowScan_Client_Logic;

namespace ShadowScan_Client_Common
{
    public class ShadowScan_Client_Common
    {
        // initialisation of the methode of the long steam
        LongLiveStreamService _longLiveStreamService = new LongLiveStreamService();

        ShadowScan_Logic _Logic = new ShadowScan_Logic();

        private IHost _host;

        private WebApplication _gRPC;


        public ShadowScan_Client_Common()
        {
            _Logic._bannedSites = new List<string>();
            Task.Run(async () => StartGrpcServerAsync());
        }

        public async Task StartGrpcServerAsync()
        {
            var builder = WebApplication.CreateBuilder();

            builder.Services.AddGrpc();

            // Register ShadowScan_Logic as a singleton
            builder.Services.AddSingleton<ShadowScan_Logic>();

            // Register GreeterService and inject ShadowScan_Logic
            builder.Services.AddSingleton<GreeterService>();

            builder.WebHost.ConfigureKestrel(options =>
            {
                options.ListenAnyIP(55052); // Bind to all network interfaces
            });

            _gRPC = builder.Build();

            _gRPC.MapGrpcService<GreeterService>();
            _gRPC.MapGrpcService<HeartBeatService>();
            _gRPC.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client.");

            _host = _gRPC;

            await _host.StartAsync();
        }

        public async Task StopGrpcServerAsync()
        {
            if (_host != null)
            {
                await _host.StopAsync();
                _host.Dispose();
            }
        }

        public void StartScan()
        {

            _Logic._bannedSites = _gRPC.Services.GetRequiredService<GreeterService>().getBannedRessourceList();
            Task.Run(async () => _Logic.scanForInfractions_WebSite());
            
        }
    }
}
