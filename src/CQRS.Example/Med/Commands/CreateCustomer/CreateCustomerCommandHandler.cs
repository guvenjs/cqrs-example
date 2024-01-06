using MediatR;

namespace CQRS.Example.Med.Commands.CreateCustomer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Guid>
    {
        public Task<Guid> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            // will data add context in here 

            return Task.FromResult(Guid.NewGuid());
        }
    }
}
