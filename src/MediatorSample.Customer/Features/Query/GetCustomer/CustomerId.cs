using MediatR;

namespace MediatorSample.Customer.Features.Query.GetCustomer
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
