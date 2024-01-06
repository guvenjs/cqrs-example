using MediatR;

namespace CQRS.Example.Med.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
    {
        public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            // data add to context in here

            return Task.FromResult(Guid.NewGuid());
        }
    }
}
