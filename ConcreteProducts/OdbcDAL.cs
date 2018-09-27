using System.Data;
using System.Data.Odbc;
using Product;

namespace ConcreteProducts
{
    public class OdbcDAL : DALBaseClass
    {
        // Provide class constructors
        public OdbcDAL() { }

        public OdbcDAL(string connectionString) 
        {
            this.ConnectionString = "DSN=dsnname"; 
        }


        // DALBaseClass Members
        public override IDbConnection GetDataProviderConnection()
        {
            return new OdbcConnection();
        }

        public override IDbCommand GeDataProviderCommand()
        {
            return new OdbcCommand();
        }

        public override IDbDataAdapter GetDataProviderDataAdapter()
        {
            return new OdbcDataAdapter();
        }
    }
}
