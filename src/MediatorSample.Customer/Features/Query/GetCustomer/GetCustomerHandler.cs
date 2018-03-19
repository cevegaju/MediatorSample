using MediatR;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using MediatorSample.CustomerApi.Models;
using MediatorSample.CustomerApi.DataAccess;

namespace MediatorSample.CustomerApi.Features.Query
{
    public class GetCustomerHandler : IRequestHandler<CustomerId, Customer>
    {
        private IDatabase _db;
        public GetCustomerHandler(IDatabase db)
        {
            _db = db;
        }
        public async Task<Customer> Handle(CustomerId request, CancellationToken cancellationToken)
        {
            using (var connection = new SqlConnection(_db.ConnectionString))
            {
                return await connection.GetAsync<Customer>(request.Id);
            }
        }

    }
}
