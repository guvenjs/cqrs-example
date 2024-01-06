using CQRS.Example.Med.ResponseModels;
using MediatR;

namespace CQRS.Example.Med.Queries.GetAllProducts
{
    public class GetAllProductsQueryRequest : IRequest<List<ProductDTO>>
    {
    }
}
