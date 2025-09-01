using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class NHistorial
    {
        #region Métodos CRUD para Historial

        /// <summary>
        /// Inserta un nuevo historial médico
        /// </summary>
        public static string Insertar(int animalId, string notasGenerales, string alergias = "", string condicionesMedicas = "")
        {
            // Validaciones de negocio
            if (!ValidarHistorial(animalId, notasGenerales))
                return "Error: Datos de historial inválidos";

            // Verificar si ya existe un historial para este animal
            DHistorial objHistorial = new DHistorial();
            if (objHistorial.ExisteHistorialParaAnimal(animalId))
                return "Error: Ya existe un historial médico para este animal";

            objHistorial.AnimalId = animalId;
            objHistorial.NotasGenerales = notasGenerales?.Trim();
            objHistorial.Alergias = alergias?.Trim();
            objHistorial.CondicionesMedicas = condicionesMedicas?.Trim();

            return objHistorial.Insertar();
        }

        /// <summary>
        /// Edita un historial médico existente
        /// </summary>
        public static string Editar(int id, int animalId, string notasGenerales, string alergias = "", string condicionesMedicas = "")
        {
            // Validaciones de negocio
            if (id <= 0)
                return "Error: ID de historial inválido";

            if (!ValidarHistorial(animalId, notasGenerales))
                return "Error: Datos de historial inválidos";

            // Verificar si ya existe otro historial para este animal (excluyendo el actual)
            DHistorial objHistorial = new DHistorial();
            if (objHistorial.ExisteHistorialParaAnimal(animalId, id))
                return "Error: Ya existe un historial médico para este animal";

            objHistorial.Id = id;
            objHistorial.AnimalId = animalId;
            objHistorial.NotasGenerales = notasGenerales?.Trim();
            objHistorial.Alergias = alergias?.Trim();
            objHistorial.CondicionesMedicas = condicionesMedicas?.Trim();

            return objHistorial.Editar();
        }

        /// <summary>
        /// Elimina un historial médico
        /// </summary>
        public static string Eliminar(int id)
        {
            if (id <= 0)
                return "Error: ID de historial inválido";

            // Verificar si el historial tiene detalles asociados
            if (TieneDetallesAsociados(id))
                return "Error: No se puede eliminar el historial porque tiene detalles médicos asociados";

            DHistorial objHistorial = new DHistorial()
            {
                Id = id
            };
            return objHistorial.Eliminar();
        }

        /// <summary>
        /// Muestra todos los historiales médicos
        /// </summary>
        public static DataTable Mostrar()
        {
            return new DHistorial().Mostrar();
        }

        /// <summary>
        /// Busca historiales por texto
        /// </summary>
        public static DataTable BuscarTexto(string textoBuscar)
        {
            if (string.IsNullOrWhiteSpace(textoBuscar))
                return Mostrar();

            DHistorial objHistorial = new DHistorial()
            {
                TextoBuscar = textoBuscar.Trim()
            };
            return objHistorial.BuscarTexto();
        }

        /// <summary>
        /// Busca historiales por ID de mascota/animal
        /// </summary>
        public static DataTable BuscarPorMascota(int animalId)
        {
            if (animalId <= 0)
                return Mostrar(); // Si no hay ID válido, mostrar todos

            try
            {
                DHistorial objHistorial = new DHistorial()
                {
                    AnimalId = animalId
                };
                return objHistorial.BuscarPorAnimal();
            }
            catch (Exception)
            {
                // Si hay error, devolver tabla vacía
                return new DataTable();
            }
        }

        /// <summary>
        /// Obtiene un historial por ID
        /// </summary>
        public static DataTable ObtenerPorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("ID de historial inválido");

            return new DHistorial().ObtenerPorId(id);
        }

        /// <summary>
        /// Obtiene todos los animales disponibles para historial
        /// </summary>
        public static DataTable ObtenerAnimales()
        {
            return new DHistorial().ObtenerAnimales();
        }

        #endregion

        #region Métodos CRUD para Detalle Historial

        /// <summary>
        /// Inserta un nuevo detalle de historial médico
        /// </summary>
        public static string InsertarDetalle(int historialId, string tipoEvento, DateTime fechaEvento, 
            string observaciones, string tratamiento = "", string medicamentos = "", string dosis = "", 
            int veterinarioId = 0, decimal? pesoAnimal = null, decimal? temperatura = null, 
            bool cobrado = false, decimal costo = 0)
        {
            // Validaciones de negocio
            if (!ValidarDetalleHistorial(historialId, tipoEvento, fechaEvento, observaciones))
                return "Error: Datos de detalle de historial inválidos";

            try
            {
                DDetalleHistorial objDetalle = new DDetalleHistorial()
                {
                    HistorialId = historialId,
                    TipoEvento = tipoEvento.Trim(),
                    FechaEvento = fechaEvento,
                    Observaciones = observaciones?.Trim(),
                    Tratamiento = tratamiento?.Trim(),
                    Medicamentos = medicamentos?.Trim(),
                    Dosis = dosis?.Trim(),
                    VeterinarioId = veterinarioId > 0 ? veterinarioId : (int?)null,
                    PesoAnimal = pesoAnimal,
                    Temperatura = temperatura,
                    Cobrado = cobrado,
                    Costo = costo
                };

                return objDetalle.Insertar();
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        /// <summary>
        /// Edita un detalle de historial médico
        /// </summary>
        public static string EditarDetalle(int id, int historialId, string tipoEvento, DateTime fechaEvento,
            string observaciones, string tratamiento = "", string medicamentos = "", string dosis = "",
            int veterinarioId = 0, decimal? pesoAnimal = null, decimal? temperatura = null,
            bool cobrado = false, decimal costo = 0)
        {
            // Validaciones de negocio
            if (id <= 0)
                return "Error: ID de detalle inválido";

            if (!ValidarDetalleHistorial(historialId, tipoEvento, fechaEvento, observaciones))
                return "Error: Datos de detalle de historial inválidos";

            try
            {
                DDetalleHistorial objDetalle = new DDetalleHistorial()
                {
                    Id = id,
                    HistorialId = historialId,
                    TipoEvento = tipoEvento.Trim(),
                    FechaEvento = fechaEvento,
                    Observaciones = observaciones?.Trim(),
                    Tratamiento = tratamiento?.Trim(),
                    Medicamentos = medicamentos?.Trim(),
                    Dosis = dosis?.Trim(),
                    VeterinarioId = veterinarioId > 0 ? veterinarioId : (int?)null,
                    PesoAnimal = pesoAnimal,
                    Temperatura = temperatura,
                    Cobrado = cobrado,
                    Costo = costo
                };

                return objDetalle.Editar();
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        /// <summary>
        /// Elimina un detalle de historial médico
        /// </summary>
        public static string EliminarDetalle(int id)
        {
            if (id <= 0)
                return "Error: ID de detalle inválido";

            DDetalleHistorial objDetalle = new DDetalleHistorial()
            {
                Id = id
            };
            return objDetalle.Eliminar();
        }

        /// <summary>
        /// Obtiene todos los detalles de un historial específico
        /// </summary>
        public static DataTable ObtenerDetallesPorHistorial(int historialId)
        {
            if (historialId <= 0)
                throw new ArgumentException("ID de historial inválido");

            return new DDetalleHistorial().ObtenerPorHistorial(historialId);
        }

        /// <summary>
        /// Obtiene un detalle específico por ID
        /// </summary>
        public static DataTable ObtenerDetallePorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("ID de detalle inválido");

            return new DDetalleHistorial().ObtenerPorId(id);
        }

        /// <summary>
        /// Obtiene todos los veterinarios disponibles
        /// </summary>
        public static DataTable ObtenerVeterinarios()
        {
            return new DDetalleHistorial().ObtenerVeterinarios();
        }

        /// <summary>
        /// Obtiene los tipos de eventos válidos
        /// </summary>
        public static List<string> ObtenerTiposEvento()
        {
            return new List<string>
            {
                "Consulta",
                "Cirugia",
                "Vacunacion",
                "Control",
                "Tratamiento",
                "Diagnostico"
            };
        }

        #endregion

        #region Validaciones de Negocio

        /// <summary>
        /// Valida los datos básicos de un historial médico
        /// </summary>
        private static bool ValidarHistorial(int animalId, string notasGenerales)
        {
            if (animalId <= 0)
                return false;

            if (string.IsNullOrWhiteSpace(notasGenerales))
                return false;

            if (notasGenerales.Length > 2000)
                return false;

            return true;
        }

        /// <summary>
        /// Valida los datos de un detalle de historial
        /// </summary>
        private static bool ValidarDetalleHistorial(int historialId, string tipoEvento, DateTime fechaEvento, string observaciones)
        {
            if (historialId <= 0)
                return false;

            if (string.IsNullOrWhiteSpace(tipoEvento))
                return false;

            // Validar que el tipo de evento sea válido
            var tiposValidos = ObtenerTiposEvento();
            if (!tiposValidos.Contains(tipoEvento))
                return false;

            if (fechaEvento == default(DateTime) || fechaEvento > DateTime.Now)
                return false;

            if (string.IsNullOrWhiteSpace(observaciones))
                return false;

            if (observaciones.Length > 1000)
                return false;

            return true;
        }

        /// <summary>
        /// Valida que el peso del animal esté en un rango razonable
        /// </summary>
        public static bool ValidarPesoAnimal(decimal? peso)
        {
            if (!peso.HasValue)
                return true; // Peso es opcional

            return peso.Value > 0 && peso.Value <= 999.99m;
        }

        /// <summary>
        /// Valida que la temperatura esté en un rango razonable para animales
        /// </summary>
        public static bool ValidarTemperatura(decimal? temperatura)
        {
            if (!temperatura.HasValue)
                return true; // Temperatura es opcional

            return temperatura.Value >= 35.0m && temperatura.Value <= 45.0m;
        }

        /// <summary>
        /// Valida que el costo sea un valor positivo
        /// </summary>
        public static bool ValidarCosto(decimal costo)
        {
            return costo >= 0;
        }

        #endregion

        #region Métodos Auxiliares

        /// <summary>
        /// Verifica si un historial tiene detalles asociados
        /// </summary>
        private static bool TieneDetallesAsociados(int historialId)
        {
            try
            {
                var detalles = ObtenerDetallesPorHistorial(historialId);
                return detalles.Rows.Count > 0;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Obtiene estadísticas generales de historiales médicos
        /// </summary>
        public static DataTable ObtenerEstadisticas()
        {
            DataTable estadisticas = new DataTable();
            estadisticas.Columns.Add("Concepto", typeof(string));
            estadisticas.Columns.Add("Valor", typeof(string));

            try
            {
                var totalHistoriales = Mostrar().Rows.Count;
                estadisticas.Rows.Add("Total de Historiales", totalHistoriales.ToString());

                // Aquí se pueden agregar más estadísticas según se necesite
            }
            catch (Exception ex)
            {
                estadisticas.Rows.Add("Error", ex.Message);
            }

            return estadisticas;
        }

        /// <summary>
        /// Obtiene el historial completo de un animal específico
        /// </summary>
        public static DataTable ObtenerHistorialCompletoAnimal(int animalId)
        {
            if (animalId <= 0)
                throw new ArgumentException("ID de animal inválido");

            // Primero obtener el historial base del animal
            var historial = new DHistorial().Mostrar();
            var historialAnimal = historial.AsEnumerable()
                .Where(row => row.Field<int>("animal_id") == animalId)
                .CopyToDataTable();

            return historialAnimal;
        }

        #endregion
    }
}
