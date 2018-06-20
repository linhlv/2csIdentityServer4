using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace TCS.Security.AuthServer.Api
{
    public class Startup
    {
        public void ConfigureServices(
            IServiceCollection services)
        {
            services.AddMvcCore()
              .AddAuthorization()
              .AddJsonFormatters();

            services                    
                    .AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)                    
                    .AddIdentityServerAuthentication(options =>
                     {
                         options.Authority = "http://localhost:5000"; // Auth Server
                         options.RequireHttpsMetadata = false;
                         options.ApiName = "2cs_auth_api"; // API Resource Id
                     });

            services.AddMvc();
        }

        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
