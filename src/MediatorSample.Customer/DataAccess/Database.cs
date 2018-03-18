namespace MediatorSample.Customer.DataAccess
{
    public class Database : IDatabase
    {
        public Database(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public string ConnectionString { get; private set; }
    }
}
