using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorSample.CustomerApi.DataAccess
{
    public interface IDatabase
    {
        string ConnectionString { get; }
    }
}
