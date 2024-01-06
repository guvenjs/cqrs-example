using CQRS.Example.Med.ResponseModels;
using MediatR;

namespace CQRS.Example.Med.Queries.GetAllCustomer
{
    public class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomerQueryRequest, List<CustomerDTO>>
    {
        public Task<List<CustomerDTO>> Handle(GetAllCustomerQueryRequest request, CancellationToken cancellationToken)
        {
            var data = new List<CustomerDTO> {
                new CustomerDTO()
                {
                    Id=Guid.NewGuid(),
                    Name="Enes Güven",
                    Age=25,
                },
                new CustomerDTO()
                {
                    Id=Guid.NewGuid(),
                    Name="Cihan Aksoy",
                    Age=27,
                }
            };

            return Task.FromResult(data);
        }
    }
}
