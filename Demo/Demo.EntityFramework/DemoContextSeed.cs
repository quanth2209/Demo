using Demo.Core;
using Demo.Entities;
using System.Linq;

namespace Demo.EntityFramework
{
    public class DemoContextSeed
    {
        public static void Seed(DemoContext demoContext)
        {
            demoContext.Database.EnsureCreated();

            SeedAdmins(demoContext);

            demoContext.SaveChanges();
        }

        private static void SeedAdmins(DemoContext demoContext)
        {
            if(demoContext.Users.Any())
                return;

            var admin = new UserEntity
            {
                Email = "admin@gmail.com",
                Password = "123123",
                Name = "Red",
                Role = DemoEnums.Role.Admin,
                Status = DemoEnums.Status.Active
            };

            demoContext.Add(admin);
        }
    }
}
