using Demo.Core;
using Demo.Entities.Base;

namespace Demo.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public DemoEnums.Role Role { get; set; }
    }
}
