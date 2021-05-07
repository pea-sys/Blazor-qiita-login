using System;
using Blazor_qiita_login.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Blazor_qiita_login.Areas.Identity.IdentityHostingStartup))]
namespace Blazor_qiita_login.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                //services.AddDbContext<IdentityContext>(options =>
                //    options.UseSqlServer(
                //        context.Configuration.GetConnectionString("DefaultConnection")));
                services.AddEntityFrameworkNpgsql().AddDbContext<IdentityContext>(opt =>
                opt.UseNpgsql(context.Configuration.GetConnectionString("DefaultConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<IdentityContext>();
            });
        }
    }
}