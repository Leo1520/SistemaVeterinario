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
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Sistema_Veterinario;Integrated Security=True;TrustServerCertificate=True;Connection Timeout=60;Command Timeout=300";

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Método mejorado con reintentos para operaciones críticas
        protected SqlConnection GetConnectionWithRetry(int maxRetries = 3)
        {
            int attempt = 0;
            while (attempt < maxRetries)
            {
                try
                {
                    var connection = new SqlConnection(connectionString);
                    connection.Open();
                    connection.Close(); // Test successful
                    return new SqlConnection(connectionString);
                }
                catch (SqlException ex) when (attempt < maxRetries - 1)
                {
                    attempt++;
                    System.Threading.Thread.Sleep(1000 * attempt); // Wait progressively longer
                    continue;
                }
                catch
                {
                    // Re-throw on final attempt or non-SQL exceptions
                    throw;
                }
            }
            return new SqlConnection(connectionString);
        }

        // Método para probar la conexión
        public static bool TestConnection()
        {
            try
            {
                var dbConn = new DbConnection();
                using (var connection = dbConn.GetConnection())
                {
                    connection.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        // Método para crear la base de datos si no existe
        public static bool CreateDatabaseIfNotExists()
        {
            try
            {
                // Primero intentar conectar al master para crear la BD
                string masterConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True;Connection Timeout=60;";
                
                using (var connection = new SqlConnection(masterConnectionString))
                {
                    connection.Open();
                    
                    // Verificar si la base de datos existe
                    string checkDbQuery = "SELECT COUNT(*) FROM sys.databases WHERE name = 'Sistema_Veterinario'";
                    using (var checkCmd = new SqlCommand(checkDbQuery, connection))
                    {
                        int dbExists = (int)checkCmd.ExecuteScalar();
                        if (dbExists == 0)
                        {
                            // Crear la base de datos
                            string createDbQuery = "CREATE DATABASE Sistema_Veterinario";
                            using (var createCmd = new SqlCommand(createDbQuery, connection))
                            {
                                createCmd.ExecuteNonQuery();
                            }
                            return true; // Base de datos creada
                        }
                        return false; // Base de datos ya existía
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        // Método para verificar conexión al servidor (no a la BD específica)
        public static bool TestServerConnection()
        {
            try
            {
                string masterConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True;Connection Timeout=30;";
                using (var connection = new SqlConnection(masterConnectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}