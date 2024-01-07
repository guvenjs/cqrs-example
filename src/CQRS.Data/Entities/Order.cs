using CQRS.Data.Interfaces;

namespace CQRS.Data.Entities
{
    public class Order : IEntity<Guid>
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
