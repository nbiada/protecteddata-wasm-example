using Microsoft.AspNetCore.Hosting;
using ProtectedDataWasmExample.Server.Areas.Identity;

[assembly: HostingStartup(typeof(IdentityHostingStartup))]
namespace ProtectedDataWasmExample.Server.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}