using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorSample.Customer.DataAccess
{
    public interface IDatabase
    {
        string ConnectionString { get; }
    }
}
