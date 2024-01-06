using CQRS.Example.Med.ResponseModels;
using MediatR;

namespace CQRS.Example.Med.Queries.GetCustomerById
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQueryRequest, CustomerDTO>
    {
        public Task<CustomerDTO> Handle(GetCustomerByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = new CustomerDTO
            {
                Id = Guid.NewGuid(),
                Name = "Enes Güven",
                Age = 25
            };

            return Task.FromResult(data);
        }
    }
}
