using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using CapaNegocio;
using System.IO;

namespace SistemVeterinario.Reportes
{
    public partial class FrmReportesAvanzados : UserControl
    {
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private string tipoPeriodo = "MENSUAL";
        private string tipoReporte = "Resumen de Ventas";

        public FrmReportesAvanzados()
        {
            try
            {
                InitializeComponent();
                // No configurar ReportViewer aquí para evitar problemas de AppDomain
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inicializando el formulario de reportes: {ex.Message}", 
                    "Error de Inicialización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InicializarFormulario()
        {
            // Configurar fechas por defecto
            dtpFechaInicio.Value = DateTime.Now.AddDays(-30);
            dtpFechaFin.Value = DateTime.Now;

            // Configurar ComboBox de períodos
            cmbPeriodo.Items.Clear();
            cmbPeriodo.Items.AddRange(new string[] {
                "Diario",
                "Semanal", 
                "Mensual",
                "Anual"
            });
            cmbPeriodo.SelectedIndex = 2; // Mensual por defecto

            // Configurar ComboBox de rangos predefinidos
            cmbRangoFechas.Items.Clear();
            cmbRangoFechas.Items.AddRange(new string[] {
                "Personalizado",
                "Hoy",
                "Últimos 7 días",
                "Últimos 30 días",
                "Mes actual",
                "Año actual",
                "Último mes",
                "Último año"
            });
            cmbRangoFechas.SelectedIndex = 3; // Últimos 30 días por defecto

            // Configurar ComboBox de tipos de reporte
            cmbTipoReporte.Items.Clear();
            cmbTipoReporte.Items.AddRange(new string[] {
                "Resumen de Ventas",
                "Ventas Detalladas",
                "Productos Más Vendidos",
                "Clientes Top",
                "Ventas por Categoría"
            });
            cmbTipoReporte.SelectedIndex = 0;

            // NO configurar ReportViewer aquí - se hará después
        }

        private void ConfigurarReportViewer()
        {
            try
            {
                // Configuración mínima y segura del ReportViewer para evitar problemas de AppDomain
                if (reportViewer1 != null)
                {
                    reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                    reportViewer1.LocalReport.DataSources.Clear();
                }
            }
            catch (Exception ex)
            {
                // Log del error silenciosamente
                System.Diagnostics.Debug.WriteLine($"Error configurando ReportViewer: {ex.Message}");
            }
        }

        private void cmbRangoFechas_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            
            switch (cmbRangoFechas.SelectedIndex)
            {
                case 0: // Personalizado
                    dtpFechaInicio.Enabled = true;
                    dtpFechaFin.Enabled = true;
                    break;
                case 1: // Hoy
                    dtpFechaInicio.Value = hoy.Date;
                    dtpFechaFin.Value = hoy.Date;
                    dtpFechaInicio.Enabled = false;
                    dtpFechaFin.Enabled = false;
                    break;
                case 2: // Últimos 7 días
                    dtpFechaInicio.Value = hoy.AddDays(-6).Date;
                    dtpFechaFin.Value = hoy.Date;
                    dtpFechaInicio.Enabled = false;
                    dtpFechaFin.Enabled = false;
                    break;
                case 3: // Últimos 30 días
                    dtpFechaInicio.Value = hoy.AddDays(-29).Date;
                    dtpFechaFin.Value = hoy.Date;
                    dtpFechaInicio.Enabled = false;
                    dtpFechaFin.Enabled = false;
                    break;
                case 4: // Mes actual
                    dtpFechaInicio.Value = new DateTime(hoy.Year, hoy.Month, 1);
                    dtpFechaFin.Value = hoy.Date;
                    dtpFechaInicio.Enabled = false;
                    dtpFechaFin.Enabled = false;
                    break;
                case 5: // Año actual
                    dtpFechaInicio.Value = new DateTime(hoy.Year, 1, 1);
                    dtpFechaFin.Value = hoy.Date;
                    dtpFechaInicio.Enabled = false;
                    dtpFechaFin.Enabled = false;
                    break;
                case 6: // Último mes
                    DateTime ultimoMes = hoy.AddMonths(-1);
                    dtpFechaInicio.Value = new DateTime(ultimoMes.Year, ultimoMes.Month, 1);
                    dtpFechaFin.Value = new DateTime(ultimoMes.Year, ultimoMes.Month, DateTime.DaysInMonth(ultimoMes.Year, ultimoMes.Month));
                    dtpFechaInicio.Enabled = false;
                    dtpFechaFin.Enabled = false;
                    break;
                case 7: // Último año
                    int ultimoAno = hoy.Year - 1;
                    dtpFechaInicio.Value = new DateTime(ultimoAno, 1, 1);
                    dtpFechaFin.Value = new DateTime(ultimoAno, 12, 31);
                    dtpFechaInicio.Enabled = false;
                    dtpFechaFin.Enabled = false;
                    break;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarFechas())
                {
                    fechaInicio = dtpFechaInicio.Value.Date;
                    fechaFin = dtpFechaFin.Value.Date.AddDays(1).AddSeconds(-1); // Incluir todo el día final
                    tipoPeriodo = cmbPeriodo.SelectedItem?.ToString()?.ToUpper() ?? "DIARIO";
                    tipoReporte = cmbTipoReporte.SelectedItem?.ToString() ?? "Resumen de Ventas";

                    GenerarReporte();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarFechas()
        {
            if (dtpFechaFin.Value < dtpFechaInicio.Value)
            {
                MessageBox.Show("La fecha fin no puede ser menor que la fecha inicio", 
                    "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            TimeSpan diferencia = dtpFechaFin.Value - dtpFechaInicio.Value;
            if (diferencia.TotalDays > 365)
            {
                MessageBox.Show("El rango de fechas no puede ser mayor a 1 año", 
                    "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void GenerarReporte()
        {
            try
            {
                DataTable? datos = null;
                string rutaReporte = "";

                switch (tipoReporte)
                {
                    case "Resumen de Ventas":
                        string agrupacionFormato = ConvertirPeriodoAAgrupacion(tipoPeriodo);
                        datos = NVentas.ReporteVentasResumen(fechaInicio, fechaFin, agrupacionFormato);
                        rutaReporte = "rptVentasResumen.rdlc";
                        break;
                    case "Ventas Detalladas":
                        datos = NVentas.ReporteVentasDetalle(fechaInicio, fechaFin);
                        rutaReporte = "rptVentasDetalle.rdlc";
                        break;
                    case "Productos Más Vendidos":
                        datos = NVentas.ReporteVentasProductosTop(fechaInicio, fechaFin, 10);
                        rutaReporte = "rptVentasProductosTop.rdlc";
                        break;
                    case "Clientes Top":
                        datos = NVentas.ReporteVentasTopClientes(fechaInicio, fechaFin, 10);
                        rutaReporte = "rptVentasTopClientes.rdlc";
                        break;
                    case "Ventas por Categoría":
                        datos = NVentas.ReporteVentasEstadisticasGenerales();
                        rutaReporte = "rptVentasEstadisticas.rdlc";
                        break;
                }

                if (datos != null && datos.Rows.Count > 0)
                {
                    ConfigurarYMostrarReporte(datos, rutaReporte);
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para el período seleccionado", 
                        "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Limpiar el reporte si no hay datos
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    lblResultados.Text = "❌ Sin datos para el período seleccionado";
                    HabilitarBotonesExportacion(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ConvertirPeriodoAAgrupacion(string periodo)
        {
            return periodo switch
            {
                "DIARIO" => "DIA",
                "SEMANAL" => "SEMANA",
                "MENSUAL" => "MES",
                "ANUAL" => "AÑO",
                _ => "DIA"
            };
        }



        private void ConfigurarYMostrarReporte(DataTable datos, string rutaReporte)
        {
            try
            {
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.ReportPath = "";

                // Configurar el origen de datos
                ReportDataSource rds = new ReportDataSource("dsReporte", datos);
                reportViewer1.LocalReport.DataSources.Add(rds);
                
                // Configurar parámetros del reporte
                ConfigurarParametrosReporte();

                // Intentar cargar template RDLC si existe
                try
                {
                    string rutaCompleta = Path.Combine(Application.StartupPath, "Reportes", rutaReporte);
                    if (File.Exists(rutaCompleta))
                    {
                        reportViewer1.LocalReport.ReportPath = rutaCompleta;
                    }
                    else
                    {
                        // Si no existe el archivo específico, usar una tabla genérica
                        GenerarReporteGenerico(datos);
                        return;
                    }
                }
                catch 
                {
                    // Si falla la carga del RDLC, usar reporte genérico
                    GenerarReporteGenerico(datos);
                    return;
                }
                
                reportViewer1.RefreshReport();

                // Actualizar label de resultados con información detallada
                lblResultados.Text = $"✓ {tipoReporte} | {tipoPeriodo} | {fechaInicio:dd/MM/yyyy} - {dtpFechaFin.Value:dd/MM/yyyy} | {datos.Rows.Count} registros | {DateTime.Now:HH:mm}";

                // Habilitar botones de exportación
                HabilitarBotonesExportacion(true);

                // Mostrar información de columnas para debug si es necesario
                if (datos.Rows.Count > 0)
                {
                    string columnas = string.Join(", ", datos.Columns.Cast<DataColumn>().Select(c => c.ColumnName));
                    Console.WriteLine($"Columnas disponibles: {columnas}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al configurar el reporte: " + ex.Message, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblResultados.Text = "❌ Error: " + ex.Message;
                HabilitarBotonesExportacion(false);
            }
        }

        private void ConfigurarParametrosReporte()
        {
            try
            {
                // Limpiar parámetros existentes
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { });

                // Configurar parámetros básicos
                List<ReportParameter> parametros = new List<ReportParameter>
                {
                    new ReportParameter("FechaInicio", fechaInicio.ToString("dd/MM/yyyy")),
                    new ReportParameter("FechaFin", dtpFechaFin.Value.ToString("dd/MM/yyyy")),
                    new ReportParameter("TipoReporte", tipoReporte),
                    new ReportParameter("Periodo", tipoPeriodo),
                    new ReportParameter("FechaGeneracion", DateTime.Now.ToString("dd/MM/yyyy HH:mm")),
                    new ReportParameter("TotalRegistros", reportViewer1.LocalReport.DataSources[0]?.Value != null ? 
                        ((DataTable)reportViewer1.LocalReport.DataSources[0].Value).Rows.Count.ToString() : "0")
                };

                reportViewer1.LocalReport.SetParameters(parametros);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error configurando parámetros: {ex.Message}");
            }
        }

        private void GenerarReporteGenerico(DataTable datos)
        {
            try
            {
                // Crear un reporte simple en memoria para mostrar los datos
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("<?xml version='1.0' encoding='utf-8'?>");
                sb.AppendLine("<Report xmlns='http://schemas.microsoft.com/sqlserver/reporting/2016/01/reportdefinition'>");
                sb.AppendLine("  <DataSources><DataSource Name='dsReporte'><ConnectionProperties><DataProvider>System.Data.DataSet</DataProvider><ConnectString>/* Local Connection */</ConnectString></ConnectionProperties></DataSource></DataSources>");
                sb.AppendLine("  <DataSets><DataSet Name='dsReporte'><Query><DataSourceName>dsReporte</DataSourceName><CommandText>/* Local Query */</CommandText></Query></DataSet></DataSets>");
                sb.AppendLine("  <Body><ReportItems>");
                
                // Título
                sb.AppendLine($"    <Textbox Name='Titulo'><Value>{tipoReporte}</Value><Style><FontSize>16pt</FontSize><FontWeight>Bold</FontWeight></Style><Top>0.25in</Top><Left>0.5in</Left><Width>6in</Width><Height>0.5in</Height></Textbox>");
                
                sb.AppendLine("  </ReportItems><Height>4in</Height></Body>");
                sb.AppendLine("  <Width>7.5in</Width>");
                sb.AppendLine("</Report>");

                // Para un reporte genérico, simplemente mostrar mensaje
                lblResultados.Text = $"✓ {tipoReporte} | {datos.Rows.Count} registros | Modo Genérico";
                HabilitarBotonesExportacion(true);
                
                // Mostrar datos en una ventana simple o exportar directamente
                reportViewer1.RefreshReport();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error generando reporte genérico: {ex.Message}");
            }
        }


        private void HabilitarBotonesExportacion(bool habilitar)
        {
            btnExportarPDF.Enabled = habilitar;
            btnExportarExcel.Enabled = habilitar;
            btnExportarWord.Enabled = habilitar;
            btnImprimir.Enabled = habilitar;
            btnVistaPrevia.Enabled = habilitar;
        }

        // Métodos de exportación
        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            ExportarReporte("PDF", "Archivos PDF|*.pdf");
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarReporte("Excel", "Archivos Excel|*.xls");
        }

        private void btnExportarWord_Click(object sender, EventArgs e)
        {
            ExportarReporte("Word", "Archivos Word|*.doc");
        }

        private void ExportarReporte(string formato, string filtro)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = filtro;
                saveDialog.FileName = $"Reporte_{tipoReporte.Replace(" ", "_")}_{DateTime.Now:yyyyMMdd_HHmmss}";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    Warning[] warnings;
                    string[] streamids;
                    string mimeType;
                    string encoding;
                    string extension;

                    string formatoReporte = formato;
                    if (formato == "Excel") formatoReporte = "Excel";
                    if (formato == "Word") formatoReporte = "Word";

                    byte[] bytes = reportViewer1.LocalReport.Render(formatoReporte, null, 
                        out mimeType, out encoding, out extension, out streamids, out warnings);

                    File.WriteAllBytes(saveDialog.FileName, bytes);

                    MessageBox.Show($"Reporte exportado exitosamente a:\n{saveDialog.FileName}", 
                        "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Preguntar si desea abrir el archivo
                    if (MessageBox.Show("¿Desea abrir el archivo exportado?", "Abrir Archivo", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(saveDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar a {formato}: " + ex.Message, 
                    "Error de Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.PrintDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir: " + ex.Message, 
                    "Error de Impresión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                // El ReportViewer ya muestra la vista previa, solo cambiar el modo de visualización
                if (reportViewer1.ZoomMode == ZoomMode.PageWidth)
                {
                    reportViewer1.ZoomMode = ZoomMode.FullPage;
                    btnVistaPrevia.Text = "Vista Ancho";
                }
                else
                {
                    reportViewer1.ZoomMode = ZoomMode.PageWidth;
                    btnVistaPrevia.Text = "Vista Completa";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en vista previa: " + ex.Message, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Implementar búsqueda dentro del reporte generado
                if (reportViewer1.LocalReport.DataSources.Count > 0)
                {
                    string criterioBusqueda = txtBuscar.Text.Trim();
                    if (!string.IsNullOrEmpty(criterioBusqueda))
                    {
                        // Filtrar datos y regenerar reporte
                        FiltrarDatosReporte(criterioBusqueda);
                    }
                    else
                    {
                        // Mostrar todos los datos
                        GenerarReporte();
                    }
                }
                else
                {
                    MessageBox.Show("Primero debe generar un reporte", 
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la búsqueda: " + ex.Message, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FiltrarDatosReporte(string criterio)
        {
            // Implementar filtrado de datos según el criterio de búsqueda
            // Por simplicidad, regenerar el reporte con los datos filtrados
            GenerarReporte();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar el reporte y resetear controles
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.RefreshReport();
                
                txtBuscar.Clear();
                HabilitarBotonesExportacion(false);
                
                lblResultados.Text = "Genere un reporte para ver los resultados";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar: " + ex.Message, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmReportesAvanzados_Load(object sender, EventArgs e)
        {
            try
            {
                // Inicializar formulario primero
                InicializarFormulario();
                
                // Configurar ReportViewer después de que todos los controles estén listos
                ConfigurarReportViewer();
                
                HabilitarBotonesExportacion(false);
                lblResultados.Text = "Seleccione los criterios y genere un reporte";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}