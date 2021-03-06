﻿using MediatorSample.CustomerApi.DataAccess;
using MediatorSample.CustomerApi.Models;
using MediatR;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace MediatorSample.CustomerApi.Features.Query
{
    public class GetCustomerList : IRequestHandler<CustomerList, IEnumerable<Customer>>
    {
        private readonly IDatabase _db;
        public GetCustomerList(IDatabase db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Customer>> Handle(CustomerList request, CancellationToken cancellationToken)
        {
            using (var connection = new SqlConnection(_db.ConnectionString))
            {
                return await connection.GetAllAsync<Customer>();
            }
        }
    }

    public class CustomerList : IRequest<IEnumerable<Customer>>
    {

    }
}
