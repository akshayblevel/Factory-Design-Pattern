using System.Data;
using System.Data.SqlClient;
using Product;
namespace ConcreteProducts
{
    public class SqlDAL : DALBaseClass
    {
        // Provide class constructors
        public SqlDAL() { }

        public SqlDAL(string connectionString) 
        {
            this.ConnectionString = "Data Source=xxxx;Initial Catalog=xxxx;User ID=xxxx;Password=xxxx"; 
        }

        // DALBaseClass Members
        public override IDbConnection GetDataProviderConnection()
        {
            return new SqlConnection();
        }

        public override IDbCommand GeDataProviderCommand()
        {
            return new SqlCommand();
        }

        public override IDbDataAdapter GetDataProviderDataAdapter()
        {
            return new SqlDataAdapter();
        }
    }
}
