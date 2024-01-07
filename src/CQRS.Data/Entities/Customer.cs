using CQRS.Data.Interfaces;

namespace CQRS.Data.Entities
{
    public class Customer : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte Age { get; set; }
        public Guid CustomerPhoneId { get; set; }
        public virtual CustomerPhone CustomerPhone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}
