using Demo.Entities;
using Demo.EntityFramework.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Demo.EntityFramework
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {
        }

        #region DbSet

        public DbSet<UserEntity> Users { get; set; }
        
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Mapping(modelBuilder);
        }

        private void Mapping(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEMap());
        }
    }
}
