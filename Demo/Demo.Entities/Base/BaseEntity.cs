using Demo.Core;

namespace Demo.Entities.Base
{
    public class BaseEntity
    {
        public long Id { get; set; }

        public DemoEnums.Status Status { get; set; }
    }
}
