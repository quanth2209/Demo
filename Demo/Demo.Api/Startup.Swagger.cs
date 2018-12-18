using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;

namespace Demo.Api
{
    public partial class Startup
    {
        private const string Version = "1.0";

        public void Swagger(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc($"v{Version}", new Info
                {
                    Version = $"v{Version}",
                    Title = "Demo API"
                });

                // Set the comments path for the Swagger JSON and UI.
                var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                var xmlPath = Path.Combine(basePath, "Demo.Api.xml");
                c.IncludeXmlComments(xmlPath);
                c.AddSecurityDefinition("Bearer", new ApiKeyScheme() { In = "header", Description = "Please insert: \"bearer [access_token]\"", Name = "Authorization", Type = "apiKey" });
                c.DescribeAllEnumsAsStrings();
            });
        }

        public void Swagger(IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/v{Version}/swagger.json", $"Demo V{Version}");
            });

        }
    }
}
