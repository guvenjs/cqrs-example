using CQRS.Data.Interfaces;

namespace CQRS.Data.Entities
{
    public class OrderProduct : IEntity<Guid>
    {
        public Guid Id { get; set; }

        public int Amount { get; set; }

        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }

        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
