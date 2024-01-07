namespace CQRS.Data.Interfaces
{
    public interface IEntity<T>
    {
        public T Id { get; set; }
    }
}
