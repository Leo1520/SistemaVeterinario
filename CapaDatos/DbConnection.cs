using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DbConnection
    {
        private string connectionString = "Data Source=DESKTOP-DCKO72L\\SQLEXPRESS;Initial Catalog=dbveterinaria;Integrated Security=True";

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}