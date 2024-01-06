using CQRS.Example.Med.Commands.CreateCustomer;
using CQRS.Example.Med.Queries.GetAllCustomer;
using CQRS.Example.Med.Queries.GetCustomerById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Example.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var query = new GetCustomerByIdQueryRequest() { Id = id };
            return Ok(await _mediator.Send(query));
        }

        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllCustomerQueryRequest();

            return Ok(await _mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateCustomerCommand data)
        {
            return Ok(await _mediator.Send(data));
        }
    }
}
