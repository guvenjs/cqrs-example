using CQRS.Example.Med.ResponseModels;
using MediatR;

namespace CQRS.Example.Med.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, List<ProductDTO>>
    {
        public Task<List<ProductDTO>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = new List<ProductDTO>()
            {
                new ProductDTO()
                {
                      Id = Guid.NewGuid(),
                      Name = "iPhone 13",
                      Price = 24599
                },
                new ProductDTO()
                {
                      Id = Guid.NewGuid(),
                      Name = "Samsung Galaxy S22",
                      Price = 18949
                },
                new ProductDTO()
                {
                      Id = Guid.NewGuid(),
                      Name = "Oppo Reno 4",
                      Price = 9489
                }
            };

            return Task.FromResult(data);
        }
    }
}
