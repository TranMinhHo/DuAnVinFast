using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Vinfast.web.Data;

[assembly: HostingStartup(typeof(Vinfast.web.Areas.Identity.IdentityHostingStartup))]
namespace Vinfast.web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<VinfastwebContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("VinfastwebContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<VinfastwebContext>();
            });
        }
    }
}