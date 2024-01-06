using CQRS.Example.Med.ResponseModels;
using MediatR;

namespace CQRS.Example.Med.Queries.GetAllCustomer
{
    public class GetAllCustomerQueryRequest : IRequest<List<CustomerDTO>>
    {
    }
}
