using CQRS.Data.Interfaces;

namespace CQRS.Data.Entities
{
    public class Product : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
