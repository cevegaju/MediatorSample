using System.Threading.Tasks;
using MediatorSample.Customer.Features.Query.GetCustomer;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorSample.Customer.Features.Query
{
    [Produces("application/json")]
    [Route("api/customer")]
    public class QueryController : Controller
    {
        private readonly IMediator mediator;
        public QueryController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetCustomer(int id)
        {
            var result = await mediator.Send(new CustomerId(id));
            return Ok(result);
        }
    }
}
