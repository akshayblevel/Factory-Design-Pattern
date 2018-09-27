using System.Data;
using System.Data.OracleClient;
using Product;

namespace ConcreteProducts
{
    public class OracleDAL : DALBaseClass
    {
        // Provide class constructors
        public OracleDAL() { }

        public OracleDAL(string connectionString) 
        { 
            this.ConnectionString = "Data Source=Oracle8i;Integrated Security=yes"; 
        }


        // DALBaseClass Members
        public override IDbConnection GetDataProviderConnection()
        {
            return new OracleConnection();
        }
        public override IDbCommand GeDataProviderCommand()
        {
            return new OracleCommand();
        }

        public override IDbDataAdapter GetDataProviderDataAdapter()
        {
            return new OracleDataAdapter();
        }
    }
}
