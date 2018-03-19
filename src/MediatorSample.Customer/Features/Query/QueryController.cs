using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorSample.CustomerApi.Features.Query
{
    [Produces("application/json")]
    [Route("api/customer")]
    public class QueryController : Controller
    {
        private readonly IMediator _mediator;
        public QueryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetCustomer(int id)
        {
            var result = await _mediator.Send(new CustomerId(id));
            return Ok(result);
        }

        [HttpGet]
        [Route("list")]
        public async Task<IActionResult> GetCustomerList()
        {
            var result = await _mediator.Send(new CustomerList());
            return Ok(result);
        }        
    }
}
