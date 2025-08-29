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
    public partial class ReportesAvanzados : UserControl
    {
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private string tipoPeriodo = "MENSUAL";
        private string tipoReporte = "Resumen de Ventas";

        public ReportesAvanzados()
        {
            InitializeComponent();
        }

        private void InicializarReportViewer()
        {
            if (reportViewer1 == null)
            {
                try
                {
                    // Limpiar cualquier control existente en el panel
                    panelReporte.Controls.Clear();
                    
                    // Configuración específica para .NET 8
                    System.AppDomain.CurrentDomain.SetData("APP_CONTEXT_DEPS", "");
                    
                    reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
                    reportViewer1.Dock = DockStyle.Fill;
                    reportViewer1.Location = new Point(0, 0);
                    reportViewer1.Name = "reportViewer1";
                    reportViewer1.Size = new Size(1400, 569);
                    reportViewer1.TabIndex = 0;
                    
                    // Configuración adicional para compatibilidad
                    reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                    
                    panelReporte.Controls.Add(reportViewer1);
                }
                catch (Exception ex)
                {
                    // Si falla la inicialización, mostrar error específico
                    MostrarErrorCompatibilidad(ex);
                }
            }
        }

        private void MostrarErrorCompatibilidad(Exception ex)
        {
            panelReporte.Controls.Clear();
            
            Label lblError = new Label();
            lblError.Text = $"Error de compatibilidad con ReportViewer en .NET 8:\n\n{ex.Message}\n\nPor favor, ejecute los comandos de actualización.";
            lblError.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            lblError.ForeColor = Color.Red;
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            lblError.Dock = DockStyle.Fill;
            
            panelReporte.Controls.Add(lblError);
        }

        private void MostrarMensajeInicial()
        {
            panelReporte.Controls.Clear();
            
            Label lblMensaje = new Label();
            lblMensaje.Text = "Seleccione los criterios y haga clic en 'GENERAR REPORTE' para visualizar los resultados";
            lblMensaje.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            lblMensaje.ForeColor = Color.Gray;
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            lblMensaje.Dock = DockStyle.Fill;
            
            panelReporte.Controls.Add(lblMensaje);
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
                "Ventas Agrupadas"
            });
            cmbTipoReporte.SelectedIndex = 0;
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
                    fechaFin = dtpFechaFin.Value.Date.AddDays(1).AddSeconds(-1);
                    tipoPeriodo = cmbPeriodo.SelectedItem?.ToString()?.ToUpper() ?? "DIARIO";
                    tipoReporte = cmbTipoReporte.SelectedItem?.ToString() ?? "Ventas Agrupadas";

                    // Aquí sí se carga el reporte
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
            return true;
        }

        private void GenerarReporte()
        {
            try
            {
                // Primero inicializar el ReportViewer si no existe
                InicializarReportViewer();

                DataTable datos;

                // Llamar al procedimiento almacenado
                string agrupacionFormato = ConvertirPeriodoAAgrupacion(tipoPeriodo);
                datos = NVentas.ReporteVentasAgrupadas(fechaInicio, fechaFin, agrupacionFormato);

                if (datos != null && datos.Rows.Count > 0)
                {
                    CargarReporte(reportViewer1.LocalReport, datos, "DataSet1", new Dictionary<string, string>
                    {
                        { "FechaInicio", fechaInicio.ToString("dd/MM/yyyy") },
                        { "FechaFin", fechaFin.ToString("dd/MM/yyyy") },
                        { "TipoAgrupamiento", tipoPeriodo }
                    });

                    reportViewer1.RefreshReport();
                    lblResultados.Text = $"✓ Reporte generado | {datos.Rows.Count} registros | {DateTime.Now:HH:mm}";
                }
                else
                {
                    if (reportViewer1 != null)
                    {
                        reportViewer1.Reset();
                    }
                    MessageBox.Show("No se encontraron datos para el período seleccionado.",
                        "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblResultados.Text = "❌ Sin datos para el período seleccionado";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblResultados.Text = $"❌ Error: {ex.Message}";
            }
        }

        private void CargarReporte(LocalReport report, DataTable datos, string nombreDataSource, Dictionary<string, string> parametros)
        {
            try
            {
                report.ReportEmbeddedResource = "SistemVeterinario.Reportes.ReporteVentas.rdlc";

                report.DataSources.Clear();
                report.DataSources.Add(new ReportDataSource(nombreDataSource, datos));

                if (parametros != null && parametros.Count > 0)
                {
                    var reportParameters = parametros.Select(p => new ReportParameter(p.Key, p.Value)).ToArray();
                    report.SetParameters(reportParameters);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ConvertirPeriodoAAgrupacion(string periodo)
        {
            periodo= periodo.Trim().ToLower();
            switch(periodo)
            {
                case "diario":
                    return "DIA";
                case "semanal":
                    return "SEMANA";
                case "mensual":
                    return "MES";
                case "anual":
                    return "AÑO";
                default:
                    return "DIA";
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            lblResultados.Text = "Seleccione los criterios y genere un reporte";
        }

        private void FrmReportesAvanzados_Load(object sender, EventArgs e)
        {
            try
            {
                InicializarFormulario();
                MostrarMensajeInicial();
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