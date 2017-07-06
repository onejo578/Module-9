using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AcmeInsuranceDB.Data_Access_Layer
{
    public class ConnectionManager
    {

        /* Establishing connection between the application and database
         * Instantiating SqlConnection object */
        public static SqlConnection DatabaseConnection()
        {
            string connection = "Data Source=JON-PC\\SQLEXPRESS;Initial Catalog=Acme;User ID=sa;Password=sqlexpress";
            try
            {
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
 
        }

    }
}

