using Demo.Configuration;
using Demo.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.Api
{
    public partial class Startup
    {
        private readonly string _dbConnectionString = DemoConfiguration.DbConnectionString;

        public void Database(IServiceCollection services)
        {
            services.AddDbContextPool<DemoContext>(c =>
            {
                c.UseSqlServer(_dbConnectionString,
                        builder => builder.UseRowNumberForPaging())
                    .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });
        }
    }
}
