using MediatR;
using MediatorSample.CustomerApi.Models;

namespace MediatorSample.CustomerApi.Features.Query
{
    public class CustomerId:IRequest<Customer>
    {
        public CustomerId(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
