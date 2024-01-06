using MediatR;

namespace CQRS.Example.Med.Commands.CreateCustomer
{
    public class CreateCustomerCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte Age { get; set; }
    }
}
