using CQRS.Example.Med.ResponseModels;
using MediatR;

namespace CQRS.Example.Med.Queries.GetProductById
{
    public class GetProductByIdQueryRequest : IRequest<ProductDTO>
    {
        public Guid Id { get; set; }
    }
}
