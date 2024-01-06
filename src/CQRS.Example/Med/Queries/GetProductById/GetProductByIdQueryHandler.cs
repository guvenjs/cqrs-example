using CQRS.Example.Med.ResponseModels;
using MediatR;

namespace CQRS.Example.Med.Queries.GetProductById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQueryRequest, ProductDTO>
    {
        public Task<ProductDTO> Handle(GetProductByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var product = new ProductDTO()
            {
                Id = Guid.NewGuid(),
                Name = "iPhone 13",
                Price = 24599
            };

            return Task.FromResult(product);
        }
    }
}
