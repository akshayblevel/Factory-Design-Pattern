using Product;

namespace Factory
{
    public enum DataProviderType
    {
        Access,
        Odbc,
        OleDb,
        Oracle,
        Sql
    }
    public abstract class DALFactory
    {
        public abstract DALBaseClass GetDataAccessLayer(DataProviderType dataProviderType);
    }
      
}
