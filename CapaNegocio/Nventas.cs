using CapaDatos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NVentas
    {
        public static string Insertar(int personaId, string numeroFactura, DateTime? fechaVencimiento,
            string notas, string productosJson, string serviciosJson, decimal impuestos, 
            decimal descuentos, bool finalizar)
        {
            DVentas objVenta = new DVentas()
            {
                PersonaId = personaId,
                NumeroFactura = numeroFactura,
                FechaVencimiento = fechaVencimiento,
                Notas = notas,
                ProductosJson = productosJson,
                ServiciosJson = serviciosJson,
                Impuestos = impuestos,
                Descuentos = descuentos,
                Estado = "Pendiente",
                Finalizar = finalizar
            };
            return objVenta.Insertar(objVenta);
        }

        public static string Editar(int idFactura, int personaId, string numeroFactura, 
            DateTime? fechaVencimiento, string notas, string productosJson, string serviciosJson, 
            decimal impuestos, decimal descuentos, string estado, bool finalizar)
        {
            DVentas objVenta = new DVentas()
            {
                IdFactura = idFactura,
                PersonaId = personaId,
                NumeroFactura = numeroFactura,
                FechaVencimiento = fechaVencimiento,
                Notas = notas,
                ProductosJson = productosJson,
                ServiciosJson = serviciosJson,
                Impuestos = impuestos,
                Descuentos = descuentos,
                Estado = estado,
                Finalizar = finalizar
            };
            return objVenta.Editar(objVenta);
        }

        public static DataTable Mostrar()
        {
            return new DVentas().Mostrar();
        }

        public static DataTable BuscarPorPersona(int personaId)
        {
            DVentas objVenta = new DVentas()
            {
                PersonaId = personaId
            };
            return objVenta.BuscarPorPersona(objVenta);
        }

        public static DataTable ObtenerDetalle(int idFactura)
        {
            DVentas objVenta = new DVentas()
            {
                IdFactura = idFactura
            };
            return objVenta.ObtenerDetalle(objVenta);
        }

        public static bool ValidarFactura(string numeroFactura)
        {
            if (string.IsNullOrWhiteSpace(numeroFactura))
                return false;
            
            if (numeroFactura.Length < 5)
                return false;
                
            // Validar formato básico (solo letras, números y guiones)
            return System.Text.RegularExpressions.Regex.IsMatch(numeroFactura, @"^[A-Za-z0-9\-]+$");
        }

        public static bool ValidarPersonaExiste(int personaId)
        {
            // Verificar que la persona existe antes de crear factura
            try
            {
                var facturas = BuscarPorPersona(personaId);
                return facturas != null;
            }
            catch
            {
                return false;
            }
        }

        public static string CrearFacturaCompleta(int personaId, string numeroFactura, 
            DateTime? fechaVencimiento, string notas, string productosJson, string serviciosJson, 
            decimal impuestos, decimal descuentos, bool finalizar = false)
        {
            // Validaciones de negocio
            if (!ValidarFactura(numeroFactura))
                return "Error: Número de factura inválido";
                
            if (!ValidarPersonaExiste(personaId))
                return "Error: La persona especificada no existe";

            return Insertar(personaId, numeroFactura, fechaVencimiento, notas, 
                productosJson, serviciosJson, impuestos, descuentos, finalizar);
        }

        // ============================================
        // MÉTODOS PARA REPORTES DE VENTAS
        // ============================================

        public static DataTable ReporteVentasPorRango(DateTime fechaInicio, DateTime fechaFin, string estado = null)
        {
            return new DVentas().ReporteVentasPorRango(fechaInicio, fechaFin, estado);
        }

        public static DataTable ReporteVentasResumen(DateTime fechaInicio, DateTime fechaFin, string agrupacion = "DIA")
        {
            return new DVentas().ReporteVentasResumen(fechaInicio, fechaFin, agrupacion);
        }

        public static DataTable ReporteVentasDetalle(DateTime fechaInicio, DateTime fechaFin, int? facturaId = null)
        {
            return new DVentas().ReporteVentasDetalle(fechaInicio, fechaFin, facturaId);
        }

        public static DataTable ReporteVentasPeriodosPredefinidos(string periodo)
        {
            return new DVentas().ReporteVentasPeriodosPredefinidos(periodo);
        }

        public static DataTable ReporteVentasTopClientes(DateTime fechaInicio, DateTime fechaFin, int topCount = 10)
        {
            return new DVentas().ReporteVentasTopClientes(fechaInicio, fechaFin, topCount);
        }

        public static DataTable ReporteVentasProductosTop(DateTime fechaInicio, DateTime fechaFin, int topCount = 10)
        {
            return new DVentas().ReporteVentasProductosTop(fechaInicio, fechaFin, topCount);
        }

        public static DataTable ReporteVentasServiciosTop(DateTime fechaInicio, DateTime fechaFin, int topCount = 10)
        {
            return new DVentas().ReporteVentasServiciosTop(fechaInicio, fechaFin, topCount);
        }

        public static DataTable ReporteVentasEstadisticasGenerales()
        {
            return new DVentas().ReporteVentasEstadisticasGenerales();
        }

        public static DataTable ReporteVentasAgrupadas(DateTime fechaInicio, DateTime fechaFin, string agrupamiento)
        {
            return DVentas.ReporteVentasAgrupadas(fechaInicio, fechaFin, agrupamiento);
        }

        // ============================================
        // MÉTODOS UTILITARIOS PARA REPORTES
        // ============================================

        public static List<string> ObtenerPeriodosPredefinidos()
        {
            return new List<string>
            {
                "HOY",
                "AYER", 
                "ULTIMOS_7_DIAS",
                "MES_ACTUAL",
                "ULTIMOS_30_DIAS",
                "AÑO_ACTUAL"
            };
        }

        public static List<string> ObtenerTiposAgrupacion()
        {
            return new List<string>
            {
                "DIA",
                "SEMANA", 
                "MES",
                "AÑO"
            };
        }

        public static string ObtenerNombrePeriodo(string periodo)
        {
            periodo = periodo.Trim().ToUpper();
            switch(periodo)
            {
                case "HOY":
                    return "Ventas de Hoy";
                case "AYER":
                    return "Ventas de Ayer";
                case "ULTIMOS_7_DIAS":
                    return "Últimos 7 Días";
                case "MES_ACTUAL":
                    return "Mes Actual";
                case "ULTIMOS_30_DIAS":
                    return "Últimos 30 Días";
                case "AÑO_ACTUAL":
                    return "Año Actual";
                default:
                    return "Período Personalizado";
            }
        }

        public static (DateTime fechaInicio, DateTime fechaFin) CalcularFechasPeriodo(string periodo)
        {
            DateTime hoy = DateTime.Now.Date;
            // pertiodo eliminar el espacio y pasar a minusculas
            periodo = periodo.Trim().ToUpper();
            switch(periodo)
            {
                case "HOY":
                    return (hoy, hoy);
                case "AYER":
                    DateTime ayer = hoy.AddDays(-1);
                    return (ayer, ayer);
                case "ULTIMOS_7_DIAS":
                    return (hoy.AddDays(-6), hoy);
                case "MES_ACTUAL":
                    DateTime primerDiaMes = new DateTime(hoy.Year, hoy.Month, 1);
                    DateTime ultimoDiaMes = primerDiaMes.AddMonths(1).AddDays(-1);
                    return (primerDiaMes, ultimoDiaMes);
                case "ULTIMOS_30_DIAS":
                    return (hoy.AddDays(-29), hoy);
                case "AÑO_ACTUAL":
                    DateTime primerDiaAño = new DateTime(hoy.Year, 1, 1);
                    DateTime ultimoDiaAño = new DateTime(hoy.Year, 12, 31);
                    return (primerDiaAño, ultimoDiaAño);
                default:
                    return (hoy, hoy); // Por defecto retorna hoy
            }
        }
        
        /// <summary>
        /// Genera un XML completo de una factura con todos sus datos y detalles
        /// </summary>
        /// <param name="facturaId">ID de la factura a convertir a XML</param>
        /// <returns>XML serializado de la factura completa o mensaje de error</returns>
        public static string VentaToXML(int facturaId)
        {
            try
            {
                var facturaCompleta = new Models.FacturaCompleta();
                
                // 1. Cargar datos principales de la factura
                facturaCompleta.DatosPrincipales = CargarDatosPrincipales(facturaId);
                if (facturaCompleta.DatosPrincipales == null)
                {
                    return "Error: No se encontró la factura especificada o no tiene permisos para acceder a ella.";
                }

                // 2. Cargar detalle de productos
                facturaCompleta.DetalleProductos = CargarDetalleProductos(facturaId);

                // 3. Cargar detalle de servicios
                facturaCompleta.DetalleServicios = CargarDetalleServicios(facturaId);

                // 4. Serializar a XML
                return SerializarFacturaAXML(facturaCompleta);
            }
            catch (Exception ex)
            {
                return $"Error al generar XML de la factura: {ex.Message}";
            }
        }

        /// <summary>
        /// Carga los datos principales de una factura
        /// </summary>
        private static Models.FacturaDatosPrincipales CargarDatosPrincipales(int facturaId)
        {
            SqlConnection connection = DbConnection.Instance.GetConnection();
            using (SqlCommand command = new SqlCommand("sp_factura_datos_principales", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@factura_id", SqlDbType.Int) { Value = facturaId });

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                        return null;

                    DataRow row = dataTable.Rows[0];
                    return new Models.FacturaDatosPrincipales
                    {
                        FacturaId = Convert.ToInt32(row["factura_id"]),
                        NumeroFactura = row["numero_factura"].ToString(),
                        FechaEmision = Convert.ToDateTime(row["fecha_emision"]),
                        FechaVencimiento = row["fecha_vencimiento"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(row["fecha_vencimiento"]),
                        Subtotal = Convert.ToDecimal(row["subtotal"]),
                        Impuestos = Convert.ToDecimal(row["impuestos"]),
                        Descuentos = Convert.ToDecimal(row["descuentos"]),
                        Total = Convert.ToDecimal(row["total"]),
                        Estado = row["estado"].ToString(),
                        Notas = row["notas"].ToString(),

                        // Datos del cliente
                        ClienteId = Convert.ToInt32(row["cliente_id"]),
                        ClienteTipo = row["cliente_tipo"].ToString(),
                        ClienteEmail = row["cliente_email"].ToString(),
                        ClienteDireccion = row["cliente_direccion"].ToString(),
                        ClienteTelefono = row["cliente_telefono"].ToString(),
                        ClienteNombreCompleto = row["cliente_nombre_completo"].ToString(),
                        ClienteDocumento = row["cliente_documento"].ToString(),

                        // Datos adicionales para persona física
                        ClienteNombres = row["cliente_nombres"].ToString(),
                        ClienteApellidos = row["cliente_apellidos"].ToString(),
                        ClienteCi = row["cliente_ci"].ToString(),
                        ClienteFechaNacimiento = row["cliente_fecha_nacimiento"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(row["cliente_fecha_nacimiento"]),
                        ClienteGenero = row["cliente_genero"].ToString(),

                        // Datos adicionales para persona jurídica
                        ClienteRazonSocial = row["cliente_razon_social"].ToString(),
                        ClienteNit = row["cliente_nit"].ToString(),
                        ClienteEncargadoNombre = row["cliente_encargado_nombre"].ToString(),
                        ClienteEncargadoCargo = row["cliente_encargado_cargo"].ToString()
                    };
                }
            }
        }

        /// <summary>
        /// Carga el detalle de productos de una factura
        /// </summary>
        private static List<Models.FacturaDetalleProducto> CargarDetalleProductos(int facturaId)
        {
            var productos = new List<Models.FacturaDetalleProducto>();

            SqlConnection connection = DbConnection.Instance.GetConnection();
            using (SqlCommand command = new SqlCommand("sp_factura_detalle_productos", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@factura_id", SqlDbType.Int) { Value = facturaId });

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        productos.Add(new Models.FacturaDetalleProducto
                        {
                            DetalleId = Convert.ToInt32(row["detalle_id"]),
                            Cantidad = Convert.ToInt32(row["cantidad"]),
                            PrecioUnitario = Convert.ToDecimal(row["precio_unitario"]),
                            DescuentoUnitario = Convert.ToDecimal(row["descuento_unitario"]),
                            Subtotal = Convert.ToDecimal(row["subtotal"]),
                            RecetaVerificada = Convert.ToBoolean(row["receta_verificada"]),
                            Lote = row["lote"].ToString(),
                            FechaVencimientoProducto = row["fecha_vencimiento_producto"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(row["fecha_vencimiento_producto"]),

                            // Datos del producto
                            ProductoId = Convert.ToInt32(row["producto_id"]),
                            ProductoCodigo = row["producto_codigo"].ToString(),
                            ProductoNombre = row["producto_nombre"].ToString(),
                            ProductoDescripcion = row["producto_descripcion"].ToString(),
                            ProductoPrecioCatalogo = Convert.ToDecimal(row["producto_precio_catalogo"]),
                            ProductoRequiereReceta = Convert.ToBoolean(row["producto_requiere_receta"]),

                            // Datos de la categoría
                            CategoriaId = Convert.ToInt32(row["categoria_id"]),
                            CategoriaNombre = row["categoria_nombre"].ToString(),
                            CategoriaDescripcion = row["categoria_descripcion"].ToString(),

                            // Cálculos adicionales
                            SubtotalBruto = Convert.ToDecimal(row["subtotal_bruto"]),
                            DescuentoTotal = Convert.ToDecimal(row["descuento_total"]),
                            SubtotalNeto = Convert.ToDecimal(row["subtotal_neto"])
                        });
                    }
                }
            }

            return productos;
        }

        /// <summary>
        /// Carga el detalle de servicios de una factura
        /// </summary>
        private static List<Models.FacturaDetalleServicio> CargarDetalleServicios(int facturaId)
        {
            var servicios = new List<Models.FacturaDetalleServicio>();

            SqlConnection connection = DbConnection.Instance.GetConnection();
            using (SqlCommand command = new SqlCommand("sp_factura_detalle_servicios", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@factura_id", SqlDbType.Int) { Value = facturaId });

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        servicios.Add(new Models.FacturaDetalleServicio
                        {
                            DetalleId = Convert.ToInt32(row["detalle_id"]),
                            Cantidad = Convert.ToInt32(row["cantidad"]),
                            PrecioUnitario = Convert.ToDecimal(row["precio_unitario"]),
                            DescuentoUnitario = Convert.ToDecimal(row["descuento_unitario"]),
                            Subtotal = Convert.ToDecimal(row["subtotal"]),

                            // Datos del diagnóstico/servicio
                            DiagnosticoId = Convert.ToInt32(row["diagnostico_id"]),
                            DiagnosticoCodigo = row["diagnostico_codigo"].ToString(),
                            DiagnosticoNombre = row["diagnostico_nombre"].ToString(),
                            DiagnosticoDescripcion = row["diagnostico_descripcion"].ToString(),
                            DiagnosticoPrecioBase = Convert.ToDecimal(row["diagnostico_precio_base"]),
                            DiagnosticoCategoria = row["diagnostico_categoria"].ToString(),
                            DiagnosticoRequiereEquipamiento = Convert.ToBoolean(row["diagnostico_requiere_equipamiento"]),

                            // Datos del veterinario (si aplica)
                            VeterinarioId = row["veterinario_id"] == DBNull.Value ? null : (int?)Convert.ToInt32(row["veterinario_id"]),
                            VeterinarioLicencia = row["veterinario_licencia"].ToString(),
                            VeterinarioEspecialidad = row["veterinario_especialidad"].ToString(),
                            VeterinarioNombreCompleto = row["veterinario_nombre_completo"].ToString(),

                            // Datos del detalle histórico (si está vinculado)
                            HistoricoDetalleId = row["historico_detalle_id"] == DBNull.Value ? null : (int?)Convert.ToInt32(row["historico_detalle_id"]),
                            HistoricoTipoEvento = row["historico_tipo_evento"].ToString(),
                            HistoricoFechaEvento = row["historico_fecha_evento"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(row["historico_fecha_evento"]),
                            HistoricoObservaciones = row["historico_observaciones"].ToString(),
                            HistoricoTratamiento = row["historico_tratamiento"].ToString(),

                            // Datos del animal (si hay detalle histórico)
                            AnimalId = row["animal_id"] == DBNull.Value || Convert.ToInt32(row["animal_id"]) == 0 ? null : (int?)Convert.ToInt32(row["animal_id"]),
                            AnimalNombre = row["animal_nombre"].ToString(),
                            AnimalEspecie = row["animal_especie"].ToString(),
                            AnimalRaza = row["animal_raza"].ToString(),

                            // Cálculos adicionales
                            SubtotalBruto = Convert.ToDecimal(row["subtotal_bruto"]),
                            DescuentoTotal = Convert.ToDecimal(row["descuento_total"]),
                            SubtotalNeto = Convert.ToDecimal(row["subtotal_neto"])
                        });
                    }
                }
            }

            return servicios;
        }

        /// <summary>
        /// Serializa una factura completa a formato XML
        /// </summary>
        private static string SerializarFacturaAXML(Models.FacturaCompleta facturaCompleta)
        {
            try
            {
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Models.FacturaCompleta));
                
                using (var stringWriter = new System.IO.StringWriter())
                {
                    using (var xmlWriter = System.Xml.XmlWriter.Create(stringWriter, new System.Xml.XmlWriterSettings 
                    { 
                        Indent = true, 
                        IndentChars = "  ",
                        OmitXmlDeclaration = false,
                        Encoding = System.Text.Encoding.UTF8
                    }))
                    {
                        serializer.Serialize(xmlWriter, facturaCompleta);
                        return stringWriter.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error al serializar factura a XML: {ex.Message}";
            }
        }

        /// <summary>
        /// Valida si una factura existe y está en estado válido para generar XML
        /// </summary>
        /// <param name="facturaId">ID de la factura a validar</param>
        /// <returns>True si la factura es válida, false en caso contrario</returns>
        public static bool ValidarFacturaParaXML(int facturaId)
        {
            try
            {
                SqlConnection connection = DbConnection.Instance.GetConnection();
                using (SqlCommand command = new SqlCommand(
                    "SELECT COUNT(*) FROM factura WHERE id = @facturaId AND estado != 'Anulada'", connection))
                {
                    command.Parameters.AddWithValue("@facturaId", facturaId);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Obtiene información resumida de una factura para validaciones rápidas
        /// </summary>
        /// <param name="facturaId">ID de la factura</param>
        /// <returns>Información básica de la factura o null si no existe</returns>
        public static object ObtenerInfoFacturaResumida(int facturaId)
        {
            try
            {
                SqlConnection connection = DbConnection.Instance.GetConnection();
                using (SqlCommand command = new SqlCommand(@"
                    SELECT f.id, f.numero_factura, f.fecha_emision, f.total, f.estado,
                           p.nombre_mostrar as cliente_nombre
                    FROM factura f
                    INNER JOIN VW_PersonasCompletas p ON f.persona_id = p.id
                    WHERE f.id = @facturaId", connection))
                {
                    command.Parameters.AddWithValue("@facturaId", facturaId);
                    
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new
                            {
                                Id = reader["id"],
                                NumeroFactura = reader["numero_factura"].ToString(),
                                FechaEmision = Convert.ToDateTime(reader["fecha_emision"]),
                                Total = Convert.ToDecimal(reader["total"]),
                                Estado = reader["estado"].ToString(),
                                ClienteNombre = reader["cliente_nombre"].ToString()
                            };
                        }
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
