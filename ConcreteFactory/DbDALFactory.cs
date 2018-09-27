using System;
using ConcreteProducts;
using Factory;
using Product;
namespace ConcreteFactory
{
    public class DbDALFactory : DALFactory
    {
        public override DALBaseClass GetDataAccessLayer(DataProviderType dataProviderType)
        {
            // construct specific data access provider class
            switch (dataProviderType)
            {
                case DataProviderType.Access:
                case DataProviderType.OleDb:
                    return new OleDbDAL();

                case DataProviderType.Odbc:
                    return new OdbcDAL();

                case DataProviderType.Oracle:
                    return new OracleDAL();

                case DataProviderType.Sql:
                    return new SqlDAL();

                default:
                    throw new ArgumentException("Invalid data access layer provider type.");
            }
        }
    }
}
