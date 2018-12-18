using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.Api
{
    public partial class Startup
    {
        public void Mvc(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Mvc(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}
