using Dapper.Contrib.Extensions;

namespace MediatorSample.CustomerApi.DataAccess
{
    public class Database : IDatabase
    {
        public Database(string connectionString)
        {
            SqlMapperExtensions.TableNameMapper = (type) => { return $"{ type.Name }"; };
            ConnectionString = connectionString;
        }
        public string ConnectionString { get; private set; }
    }
}
