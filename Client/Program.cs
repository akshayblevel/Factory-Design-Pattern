using System;
using ConcreteFactory;
using Factory;

namespace FPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = string.Empty, dbProvider = string.Empty;
            bool done = false;
            do
            {
                Console.Clear();
                Console.WriteLine("\t Select one of the Database Providers \n");
                Console.WriteLine("\t 1. Access / OleDb");
                Console.WriteLine("\t 2. Odbc");
                Console.WriteLine("\t 3. Oracle");
                Console.WriteLine("\t 4. Sql \n");
                Console.WriteLine("================================================================================");
                Console.Write("\t Enter Your Selection (0 to exit) : ");
                choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "0" :
                        done = true;
                        break;

                    case "1":
                        dbProvider = "Access";
                        break;

                    case "2":
                        dbProvider = "Odbc";
                        break;

                    case "3":
                        dbProvider = "Oracle";
                        break;

                    case "4":
                        dbProvider = "Sql";
                        break;
                }
                if (choice != "0")
                {
                    Console.WriteLine("================================================================================");
                    DALFactory Factory = new DbDALFactory();
                    var DAL = Factory.GetDataAccessLayer((DataProviderType)Enum.Parse(typeof(DataProviderType), dbProvider));
                    Console.WriteLine(DAL.OpenConnection());
                    Console.ReadKey();
                }
            } while (!done);
        }
    }
}
