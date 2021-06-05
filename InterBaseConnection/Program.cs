using InterBaseSql.Data.InterBaseClient;
using System;
using System.Data;

namespace InterBaseConnection
{
    class Program
    {

        static void Main(string[] args)
        {
            string conString = "Server=localhost;Database=127.0.0.1:\\ProgramData\\Embarcadero\\InterBase\\gds_db\\examples\\database\\employee.gdb;Uid=SYSDBA;password=masterkey";
            IBConnection connection = new IBConnection(conString);
            try
            {
                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    Console.WriteLine("Connected to InterBase database!");
                }
            }
            catch(IBException ex)
            {
                throw ex;
            }
            
        }

        
    }
}
