using Demo.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Demo.EntityFramework
{
    public class DbContextFactory : IDesignTimeDbContextFactory<DemoContext>
    {
        private readonly string _dbConnectionString = DemoConfiguration.DbConnectionString;

        public DemoContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DemoContext>();
            builder.UseSqlServer(_dbConnectionString);
            return new DemoContext(builder.Options);
        }
    }
}
