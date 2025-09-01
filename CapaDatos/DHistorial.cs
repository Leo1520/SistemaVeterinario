using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DHistorial
    {
        #region Variables Privadas
        private int _id;
        private int _animalId;
        private string _notasGenerales = string.Empty;
        private string _alergias = string.Empty;
        private string _condicionesMedicas = string.Empty;
        private DateTime _createdAt;
        private DateTime _updatedAt;
        private string _textoBuscar = string.Empty;
        #endregion

        #region Propiedades
        public int Id { get => _id; set => _id = value; }
        public int AnimalId { get => _animalId; set => _animalId = value; }
        public string NotasGenerales { get => _notasGenerales; set => _notasGenerales = value; }
        public string Alergias { get => _alergias; set => _alergias = value; }
        public string CondicionesMedicas { get => _condicionesMedicas; set => _condicionesMedicas = value; }
        public DateTime CreatedAt { get => _createdAt; set => _createdAt = value; }
        public DateTime UpdatedAt { get => _updatedAt; set => _updatedAt = value; }
        public string TextoBuscar { get => _textoBuscar; set => _textoBuscar = value; }
        #endregion

        #region Constructores
        public DHistorial()
        {
            _createdAt = DateTime.Now;
            _updatedAt = DateTime.Now;
        }

        public DHistorial(int animalId, string notasGenerales)
        {
            _animalId = animalId;
            _notasGenerales = notasGenerales;
            _createdAt = DateTime.Now;
            _updatedAt = DateTime.Now;
        }
        #endregion

        #region Métodos Principales CRUD

        /// <summary>
        /// Inserta un nuevo registro de historial médico
        /// </summary>
        /// <returns>Resultado de la operación</returns>
        public string Insertar()
        {
            string resultado = "";
            SqlConnection connection = new SqlConnection();

            try
            {
                connection.ConnectionString = DbConnection.GetConnectionString();
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_insertar_historial";

                // Parámetros
                command.Parameters.Add("@animal_id", SqlDbType.Int).Value = this.AnimalId;
                command.Parameters.Add("@notas_generales", SqlDbType.NVarChar, 2000).Value = 
                    string.IsNullOrEmpty(this.NotasGenerales) ? (object)DBNull.Value : this.NotasGenerales;
                command.Parameters.Add("@alergias", SqlDbType.NVarChar, 500).Value = 
                    string.IsNullOrEmpty(this.Alergias) ? (object)DBNull.Value : this.Alergias;
                command.Parameters.Add("@condiciones_medicas", SqlDbType.NVarChar, 500).Value = 
                    string.IsNullOrEmpty(this.CondicionesMedicas) ? (object)DBNull.Value : this.CondicionesMedicas;

                SqlParameter resultadoParam = new SqlParameter("@resultado", SqlDbType.VarChar, 50);
                resultadoParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(resultadoParam);

                command.ExecuteNonQuery();
                resultado = resultadoParam.Value.ToString();
            }
            catch (Exception ex)
            {
                resultado = $"Error: {ex.Message}";
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return resultado;
        }

        /// <summary>
        /// Edita un registro de historial médico existente
        /// </summary>
        /// <returns>Resultado de la operación</returns>
        public string Editar()
        {
            string resultado = "";
            SqlConnection connection = new SqlConnection();

            try
            {
                connection.ConnectionString = DbConnection.GetConnectionString();
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_editar_historial";

                // Parámetros
                command.Parameters.Add("@id", SqlDbType.Int).Value = this.Id;
                command.Parameters.Add("@animal_id", SqlDbType.Int).Value = this.AnimalId;
                command.Parameters.Add("@notas_generales", SqlDbType.NVarChar, 2000).Value = 
                    string.IsNullOrEmpty(this.NotasGenerales) ? (object)DBNull.Value : this.NotasGenerales;
                command.Parameters.Add("@alergias", SqlDbType.NVarChar, 500).Value = 
                    string.IsNullOrEmpty(this.Alergias) ? (object)DBNull.Value : this.Alergias;
                command.Parameters.Add("@condiciones_medicas", SqlDbType.NVarChar, 500).Value = 
                    string.IsNullOrEmpty(this.CondicionesMedicas) ? (object)DBNull.Value : this.CondicionesMedicas;

                SqlParameter resultadoParam = new SqlParameter("@resultado", SqlDbType.VarChar, 50);
                resultadoParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(resultadoParam);

                command.ExecuteNonQuery();
                resultado = resultadoParam.Value.ToString();
            }
            catch (Exception ex)
            {
                resultado = $"Error: {ex.Message}";
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return resultado;
        }

        /// <summary>
        /// Elimina un registro de historial médico
        /// </summary>
        /// <returns>Resultado de la operación</returns>
        public string Eliminar()
        {
            string resultado = "";
            SqlConnection connection = new SqlConnection();

            try
            {
                connection.ConnectionString = DbConnection.GetConnectionString();
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_eliminar_historial";

                command.Parameters.Add("@id", SqlDbType.Int).Value = this.Id;

                SqlParameter resultadoParam = new SqlParameter("@resultado", SqlDbType.VarChar, 50);
                resultadoParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(resultadoParam);

                command.ExecuteNonQuery();
                resultado = resultadoParam.Value.ToString();
            }
            catch (Exception ex)
            {
                resultado = $"Error: {ex.Message}";
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return resultado;
        }

        /// <summary>
        /// Muestra todos los registros de historial médico con información de animales
        /// </summary>
        /// <returns>DataTable con los registros</returns>
        public DataTable Mostrar()
        {
            DataTable resultado = new DataTable();
            SqlConnection connection = new SqlConnection();

            try
            {
                connection.ConnectionString = DbConnection.GetConnectionString();
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_mostrar_historial";

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(resultado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener historiales médicos: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return resultado;
        }

        /// <summary>
        /// Busca registros de historial médico por texto
        /// </summary>
        /// <returns>DataTable con los resultados de la búsqueda</returns>
        public DataTable BuscarTexto()
        {
            DataTable resultado = new DataTable();
            SqlConnection connection = new SqlConnection();

            try
            {
                connection.ConnectionString = DbConnection.GetConnectionString();
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_buscar_historial_texto";

                command.Parameters.Add("@texto", SqlDbType.VarChar, 100).Value = 
                    string.IsNullOrEmpty(this.TextoBuscar) ? (object)DBNull.Value : this.TextoBuscar;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(resultado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en la búsqueda de historiales: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return resultado;
        }

        /// <summary>
        /// Busca registros de historial médico por ID de animal/mascota
        /// </summary>
        /// <returns>DataTable con los historiales del animal especificado</returns>
        public DataTable BuscarPorAnimal()
        {
            DataTable resultado = new DataTable();
            SqlConnection connection = new SqlConnection();

            try
            {
                connection.ConnectionString = DbConnection.GetConnectionString();
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_buscar_historial_por_animal";

                command.Parameters.Add("@animal_id", SqlDbType.Int).Value = this.AnimalId;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(resultado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al buscar historiales por animal: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return resultado;
        }
        #endregion

        #region Métodos Auxiliares

        /// <summary>
        /// Obtiene un historial médico por ID
        /// </summary>
        /// <param name="id">ID del historial</param>
        /// <returns>DataTable con el registro encontrado</returns>
        public DataTable ObtenerPorId(int id)
        {
            DataTable resultado = new DataTable();
            SqlConnection connection = new SqlConnection();

            try
            {
                connection.ConnectionString = DbConnection.GetConnectionString();
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = @"
                    SELECT h.*, 
                           a.nombre as animal_nombre,
                           a.especie,
                           a.raza,
                           p.nombres + ' ' + p.apellidos as propietario_nombre
                    FROM historico h
                    INNER JOIN animal a ON h.animal_id = a.id
                    INNER JOIN persona p ON a.persona_id = p.id
                    WHERE h.id = @id";

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(resultado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener historial por ID: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return resultado;
        }

        /// <summary>
        /// Obtiene todos los animales disponibles para el historial médico
        /// </summary>
        /// <returns>DataTable con los animales</returns>
        public DataTable ObtenerAnimales()
        {
            DataTable resultado = new DataTable();
            SqlConnection connection = new SqlConnection();

            try
            {
                connection.ConnectionString = DbConnection.GetConnectionString();
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = @"
                    SELECT a.id, 
                           a.nombre + ' - ' + a.especie + ' (' + p.nombres + ' ' + p.apellidos + ')' as nombre_completo,
                           a.nombre,
                           a.especie,
                           a.raza,
                           p.nombres + ' ' + p.apellidos as propietario
                    FROM animal a
                    INNER JOIN persona p ON a.persona_id = p.id
                    WHERE a.activo = 1
                    ORDER BY a.nombre";

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(resultado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener animales: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return resultado;
        }

        /// <summary>
        /// Verifica si ya existe un historial para un animal específico
        /// </summary>
        /// <param name="animalId">ID del animal</param>
        /// <param name="historialId">ID del historial actual (para edición)</param>
        /// <returns>True si existe, False si no existe</returns>
        public bool ExisteHistorialParaAnimal(int animalId, int historialId = 0)
        {
            bool existe = false;
            SqlConnection connection = new SqlConnection();

            try
            {
                connection.ConnectionString = DbConnection.GetConnectionString();
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = @"
                    SELECT COUNT(*) 
                    FROM historico 
                    WHERE animal_id = @animal_id 
                    AND (@historial_id = 0 OR id != @historial_id)";

                command.Parameters.Add("@animal_id", SqlDbType.Int).Value = animalId;
                command.Parameters.Add("@historial_id", SqlDbType.Int).Value = historialId;

                existe = Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al verificar historial existente: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return existe;
        }
        #endregion
    }
}
