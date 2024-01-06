using CQRS.Example.Med.ResponseModels;
using MediatR;

namespace CQRS.Example.Med.Queries.GetCustomerById
{
    public class GetCustomerByIdQueryRequest : IRequest<CustomerDTO>
    {
        public Guid Id { get; set; }
    }
}
