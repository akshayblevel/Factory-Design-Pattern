using System.Data;
using System.Data.OleDb;
using Product;
namespace ConcreteProducts
{
    public class OleDbDAL : DALBaseClass
    {
         // Provide class constructors
        public OleDbDAL() { }

        public OleDbDAL(string connectionString) 
        { 
            this.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\\Development\\Mine\\DataAccessLayer\\Northwind.mdb"; 
        }


        // DALBaseClass Members
        public override IDbConnection GetDataProviderConnection()
        {
            return new OleDbConnection();
        }
        public override IDbCommand GeDataProviderCommand()
        {
            return new OleDbCommand();
        }

        public override IDbDataAdapter GetDataProviderDataAdapter()
        {
            return new OleDbDataAdapter();
        }
    }
}
