using CQRS.Data.Interfaces;

namespace CQRS.Data.Entities
{
    public class CustomerPhone : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string PhoneNumber { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
