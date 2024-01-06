using CQRS.Example.Med.Commands;
using CQRS.Example.Med.Queries.GetAllProducts;
using CQRS.Example.Med.Queries.GetProductById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Example.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly MediatR.IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var query = new GetProductByIdQueryRequest() { Id = Guid.NewGuid() };
            return Ok(await _mediator.Send(query));
        }

        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllProductsQueryRequest() { };

            return Ok(await _mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
