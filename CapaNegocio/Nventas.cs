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
    }
}
