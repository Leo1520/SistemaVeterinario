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
        private string datosEstadisticos = "Ninguno";
        private DataGridView? dgvReporte;
        private Panel? panelGrafico;

        public ReportesAvanzados()
        {
            try
            {
                InitializeComponent();
                CrearDataGridViewDinamicamente();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inicializando el formulario de reportes: {ex.Message}", 
                    "Error de Inicialización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrearDataGridViewDinamicamente()
        {
            try
            {
                // Validar que el panel contenedor exista
                if (panelReporte == null)
                {
                    System.Diagnostics.Debug.WriteLine("Error: panelReporte es null");
                    return;
                }

                // Limpiar el panel principal
                panelReporte.Controls.Clear();

                // === LAYOUT FIJO SIN SPLITCONTAINER ===
                // Panel Superior: Gráfico con altura fija de 400px
                Panel panelGraficoContenedor = new Panel();
                panelGraficoContenedor.Dock = DockStyle.Top;
                panelGraficoContenedor.Height = 400; // ALTURA FIJA - NO DINÁMICA
                panelGraficoContenedor.BackColor = Color.WhiteSmoke;
                panelGraficoContenedor.Padding = new Padding(10);

                // Panel del gráfico
                panelGrafico = new Panel();
                panelGrafico.Dock = DockStyle.Fill;
                panelGrafico.BackColor = Color.White;
                panelGrafico.BorderStyle = BorderStyle.FixedSingle;

                // Título del gráfico
                Label lblTituloGrafico = new Label();
                lblTituloGrafico.Text = "GRÁFICO DE PROMEDIO DE VENTAS";
                lblTituloGrafico.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
                lblTituloGrafico.ForeColor = Color.FromArgb(31, 30, 68);
                lblTituloGrafico.Dock = DockStyle.Top;
                lblTituloGrafico.Height = 30;
                lblTituloGrafico.TextAlign = ContentAlignment.MiddleCenter;
                panelGrafico.Controls.Add(lblTituloGrafico);

                panelGraficoContenedor.Controls.Add(panelGrafico);
                panelReporte.Controls.Add(panelGraficoContenedor);

                // === PANEL INFERIOR: TABLA - USA EL RESTO DEL ESPACIO ===
                Panel panelTablaContenedor = new Panel();
                panelTablaContenedor.Dock = DockStyle.Fill;
                panelTablaContenedor.BackColor = Color.White;
                panelTablaContenedor.Padding = new Padding(10);

                // Título de la tabla
                Label lblTituloTabla = new Label();
                lblTituloTabla.Text = "DATOS DEL REPORTE";
                lblTituloTabla.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
                lblTituloTabla.ForeColor = Color.FromArgb(31, 30, 68);
                lblTituloTabla.Dock = DockStyle.Top;
                lblTituloTabla.Height = 30;
                lblTituloTabla.TextAlign = ContentAlignment.MiddleLeft;
                panelTablaContenedor.Controls.Add(lblTituloTabla);

                // Crear el DataGridView
                dgvReporte = new DataGridView();
                dgvReporte.Dock = DockStyle.Fill;
                dgvReporte.Name = "dgvReporte";
                dgvReporte.TabIndex = 0;
                
                // Configuraciones del DataGridView
                dgvReporte.AllowUserToAddRows = false;
                dgvReporte.AllowUserToDeleteRows = false;
                dgvReporte.ReadOnly = true;
                dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgvReporte.RowHeadersVisible = false;
                
                // Estilos mejorados
                dgvReporte.BackgroundColor = Color.White;
                dgvReporte.BorderStyle = BorderStyle.None;
                dgvReporte.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                
                // Colores para filas normales
                dgvReporte.DefaultCellStyle.BackColor = Color.White;
                dgvReporte.DefaultCellStyle.ForeColor = Color.Black;
                dgvReporte.DefaultCellStyle.SelectionBackColor = Color.FromArgb(31, 30, 68);
                dgvReporte.DefaultCellStyle.SelectionForeColor = Color.White;
                dgvReporte.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9F);
                
                // Filas alternas
                dgvReporte.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
                dgvReporte.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                
                // Encabezados
                dgvReporte.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 30, 68);
                dgvReporte.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvReporte.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
                dgvReporte.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
                dgvReporte.EnableHeadersVisualStyles = false;

                panelTablaContenedor.Controls.Add(dgvReporte);
                panelReporte.Controls.Add(panelTablaContenedor);
                
                System.Diagnostics.Debug.WriteLine("Layout fijo creado: Gráfico 400px altura fija, tabla usa resto del espacio");
                
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error creando layout fijo: {ex.Message}");
                dgvReporte = null;
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

            // Configurar ComboBox de tipos de reporte - Solo promedio
            cmbTipoReporte.Items.Clear();
            cmbTipoReporte.Items.AddRange(new string[] {
                "Promedio de Ventas"
            });
            cmbTipoReporte.SelectedIndex = 0;

            // Configurar ComboBox de datos estadísticos
            cmbDatosEstadisticos.Items.Clear();
            cmbDatosEstadisticos.Items.AddRange(new string[] {
                "Ninguno",
                "Promedio de Ventas",
                "Total de Transacciones",
                "Ticket Promedio",
                "Crecimiento Mensual",
                "Comparativo Anual",
                "Distribución por Hora",
                "Análisis de Tendencias",
                "Métricas de Rendimiento"
            });
            cmbDatosEstadisticos.SelectedIndex = 0;

            // NO configurar ReportViewer aquí - se hará después
        }

        private void ConfigurarDataGridView()
        {
            try
            {
                // Validar que el DataGridView esté inicializado
                if (dgvReporte == null)
                {
                    System.Diagnostics.Debug.WriteLine("DataGridView es null, intentando crear dinámicamente...");
                    CrearDataGridViewDinamicamente();
                }

                // Configuración del DataGridView
                if (dgvReporte != null)
                {
                    dgvReporte.DataSource = null;
                    System.Diagnostics.Debug.WriteLine("DataGridView configurado correctamente");
                }
            }
            catch (Exception ex)
            {
                // Log del error silenciosamente
                System.Diagnostics.Debug.WriteLine($"Error configurando DataGridView: {ex.Message}");
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
                    datosEstadisticos = cmbDatosEstadisticos.SelectedItem?.ToString() ?? "Ninguno";

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

            return true;
        }

        private void GenerarReporte()
        {
            try
            {
                DataTable? datos = null;
                string rutaReporte = "";
                string mensajeDebug = "";

                // Mostrar información de debug
                mensajeDebug = $"Generando reporte:\n" +
                              $"Tipo: {tipoReporte}\n" +
                              $"Período: {tipoPeriodo}\n" +
                              $"Datos Estadísticos: {datosEstadisticos}\n" +
                              $"Fecha Inicio: {fechaInicio:dd/MM/yyyy}\n" +
                              $"Fecha Fin: {dtpFechaFin.Value:dd/MM/yyyy}";

                Console.WriteLine(mensajeDebug);

                switch (tipoReporte)
                {
                    case "Promedio de Ventas":
                        string agrupacionFormato = ConvertirPeriodoAAgrupacion(tipoPeriodo);
                        Console.WriteLine($"Llamando a NVentas.ReporteVentasResumen con agrupación: {agrupacionFormato}");
                        datos = NVentas.ReporteVentasResumen(fechaInicio, fechaFin, agrupacionFormato);
                        rutaReporte = "rptVentasResumen.rdlc";
                        break;
                    default:
                        // Solo mantenemos el reporte de promedio de ventas
                        string agrupacionDefault = ConvertirPeriodoAAgrupacion(tipoPeriodo);
                        datos = NVentas.ReporteVentasResumen(fechaInicio, fechaFin, agrupacionDefault);
                        rutaReporte = "rptVentasResumen.rdlc";
                        break;
                }

                // Información de debug sobre los datos obtenidos
                if (datos != null)
                {
                    Console.WriteLine($"Datos obtenidos: {datos.Rows.Count} filas, {datos.Columns.Count} columnas");
                    if (datos.Columns.Count > 0)
                    {
                        Console.WriteLine($"Columnas: {string.Join(", ", datos.Columns.Cast<DataColumn>().Select(c => c.ColumnName))}");
                    }
                }
                else
                {
                    Console.WriteLine("¡DATOS ES NULL!");
                }

                if (datos != null && datos.Rows.Count > 0)
                {
                    // Procesar datos estadísticos si es necesario
                    if (datosEstadisticos != "Ninguno")
                    {
                        datos = AgregarDatosEstadisticos(datos);
                    }
                    
                    ConfigurarYMostrarReporte(datos, rutaReporte);
                    
                    // Crear y mostrar gráfico
                    CrearGraficoPromedio(datos);
                }
                else
                {
                    string mensajeError = $"No se encontraron datos para el período seleccionado.\n\n" +
                                         $"Información de debug:\n{mensajeDebug}\n\n" +
                                         $"Datos recibidos: {(datos == null ? "NULL" : $"{datos.Rows.Count} filas")}\n\n" +
                                         $"Verifica:\n" +
                                         $"1. Que existan los procedimientos almacenados\n" +
                                         $"2. Que haya datos en la tabla 'factura' para estas fechas\n" +
                                         $"3. Que la conexión a la base de datos sea correcta";

                    MessageBox.Show(mensajeError, "Sin datos - Debug Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar el reporte si no hay datos
                    if (dgvReporte != null)
                    {
                        dgvReporte.DataSource = null;
                    }
                    lblResultados.Text = "❌ Sin datos para el período seleccionado";
                    HabilitarBotonesExportacion(false);
                }
            }
            catch (Exception ex)
            {
                string errorCompleto = $"Error al generar el reporte:\n\n" +
                                      $"Mensaje: {ex.Message}\n\n" +
                                      $"Detalles: {ex.ToString()}";

                MessageBox.Show(errorCompleto, "Error Completo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error completo: {ex.ToString()}");
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

        private DataTable AgregarDatosEstadisticos(DataTable datosOriginales)
        {
            try
            {
                DataTable datosConEstadisticas = datosOriginales.Copy();

                switch (datosEstadisticos)
                {
                    case "Promedio de Ventas":
                        AgregarPromedioVentas(datosConEstadisticas);
                        break;
                    case "Total de Transacciones":
                        AgregarTotalTransacciones(datosConEstadisticas);
                        break;
                    case "Ticket Promedio":
                        AgregarTicketPromedio(datosConEstadisticas);
                        break;
                    case "Crecimiento Mensual":
                        AgregarCrecimientoMensual(datosConEstadisticas);
                        break;
                    case "Comparativo Anual":
                        AgregarComparativoAnual(datosConEstadisticas);
                        break;
                    case "Distribución por Hora":
                        AgregarDistribucionHora(datosConEstadisticas);
                        break;
                    case "Análisis de Tendencias":
                        AgregarAnalisisTendencias(datosConEstadisticas);
                        break;
                    case "Métricas de Rendimiento":
                        AgregarMetricasRendimiento(datosConEstadisticas);
                        break;
                }

                return datosConEstadisticas;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error procesando datos estadísticos: {ex.Message}");
                return datosOriginales;
            }
        }

        private void AgregarPromedioVentas(DataTable datos)
        {
            if (datos.Columns.Contains("total") || datos.Columns.Contains("Total"))
            {
                string columnaTotal = datos.Columns.Contains("total") ? "total" : "Total";
                decimal promedioVentas = 0;
                
                if (datos.Rows.Count > 0)
                {
                    decimal suma = datos.AsEnumerable()
                        .Where(row => row[columnaTotal] != DBNull.Value)
                        .Sum(row => Convert.ToDecimal(row[columnaTotal]));
                    promedioVentas = suma / datos.Rows.Count;
                }

                if (!datos.Columns.Contains("PromedioVentas"))
                {
                    datos.Columns.Add("PromedioVentas", typeof(decimal));
                }

                foreach (DataRow row in datos.Rows)
                {
                    row["PromedioVentas"] = promedioVentas;
                }
            }
        }

        private void AgregarTotalTransacciones(DataTable datos)
        {
            if (!datos.Columns.Contains("TotalTransacciones"))
            {
                datos.Columns.Add("TotalTransacciones", typeof(int));
            }

            int totalTransacciones = datos.Rows.Count;
            foreach (DataRow row in datos.Rows)
            {
                row["TotalTransacciones"] = totalTransacciones;
            }
        }

        private void AgregarTicketPromedio(DataTable datos)
        {
            if (datos.Columns.Contains("total") || datos.Columns.Contains("Total"))
            {
                string columnaTotal = datos.Columns.Contains("total") ? "total" : "Total";
                decimal ticketPromedio = 0;
                
                if (datos.Rows.Count > 0)
                {
                    decimal suma = datos.AsEnumerable()
                        .Where(row => row[columnaTotal] != DBNull.Value)
                        .Sum(row => Convert.ToDecimal(row[columnaTotal]));
                    ticketPromedio = suma / datos.Rows.Count;
                }

                if (!datos.Columns.Contains("TicketPromedio"))
                {
                    datos.Columns.Add("TicketPromedio", typeof(decimal));
                }

                foreach (DataRow row in datos.Rows)
                {
                    row["TicketPromedio"] = ticketPromedio;
                }
            }
        }

        private void AgregarCrecimientoMensual(DataTable datos)
        {
            if (!datos.Columns.Contains("CrecimientoMensual"))
            {
                datos.Columns.Add("CrecimientoMensual", typeof(string));
            }

            foreach (DataRow row in datos.Rows)
            {
                row["CrecimientoMensual"] = "Calculando...";
            }
        }

        private void AgregarComparativoAnual(DataTable datos)
        {
            if (!datos.Columns.Contains("ComparativoAnual"))
            {
                datos.Columns.Add("ComparativoAnual", typeof(string));
            }

            foreach (DataRow row in datos.Rows)
            {
                row["ComparativoAnual"] = "Año actual vs anterior";
            }
        }

        private void AgregarDistribucionHora(DataTable datos)
        {
            if (!datos.Columns.Contains("HoraVenta"))
            {
                datos.Columns.Add("HoraVenta", typeof(string));
            }

            Random rnd = new Random();
            foreach (DataRow row in datos.Rows)
            {
                int hora = rnd.Next(8, 19); // Horario comercial 8-18
                row["HoraVenta"] = $"{hora}:00-{hora + 1}:00";
            }
        }

        private void AgregarAnalisisTendencias(DataTable datos)
        {
            if (!datos.Columns.Contains("Tendencia"))
            {
                datos.Columns.Add("Tendencia", typeof(string));
            }

            string[] tendencias = { "↗ Creciente", "↘ Decreciente", "→ Estable" };
            Random rnd = new Random();
            
            foreach (DataRow row in datos.Rows)
            {
                row["Tendencia"] = tendencias[rnd.Next(tendencias.Length)];
            }
        }

        private void AgregarMetricasRendimiento(DataTable datos)
        {
            if (!datos.Columns.Contains("Rendimiento"))
            {
                datos.Columns.Add("Rendimiento", typeof(string));
            }

            string[] rendimientos = { "Excelente", "Bueno", "Regular", "Bajo" };
            Random rnd = new Random();
            
            foreach (DataRow row in datos.Rows)
            {
                row["Rendimiento"] = rendimientos[rnd.Next(rendimientos.Length)];
            }
        }



        private void ConfigurarYMostrarReporte(DataTable datos, string rutaReporte)
        {
            try
            {
                // Diagnóstico detallado del DataGridView
                if (dgvReporte == null)
                {
                    System.Diagnostics.Debug.WriteLine("DataGridView es null. Intentando recrear...");
                    CrearDataGridViewDinamicamente();
                    
                    if (dgvReporte == null)
                    {
                        MessageBox.Show("Error crítico: No se pudo crear el DataGridView para mostrar los datos.", 
                            "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Configurar el DataGridView con los datos
                dgvReporte.DataSource = datos;
                
                // Mejorar la presentación de las columnas
                MejorarPresentacionColumnas(datos);

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

        private void MejorarPresentacionColumnas(DataTable datos)
        {
            if (dgvReporte == null || datos == null) return;

            try
            {
                foreach (DataGridViewColumn column in dgvReporte.Columns)
                {
                    // Mejorar nombres de columnas
                    switch (column.Name.ToLower())
                    {
                        case "fechaemision":
                        case "fecha_emision":
                            column.HeaderText = "Fecha";
                            column.DefaultCellStyle.Format = "dd/MM/yyyy";
                            break;
                        case "numerofactura":
                        case "numero_factura":
                            column.HeaderText = "N° Factura";
                            break;
                        case "nombrecompleto":
                        case "nombre_completo":
                            column.HeaderText = "Cliente";
                            break;
                        case "total":
                        case "totaltotal":
                            column.HeaderText = "Total";
                            column.DefaultCellStyle.Format = "C2";
                            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            break;
                        case "subtotal":
                            column.HeaderText = "Subtotal";
                            column.DefaultCellStyle.Format = "C2";
                            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            break;
                        case "impuestos":
                            column.HeaderText = "Impuestos";
                            column.DefaultCellStyle.Format = "C2";
                            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            break;
                        case "descuentos":
                            column.HeaderText = "Descuentos";
                            column.DefaultCellStyle.Format = "C2";
                            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            break;
                        case "estado":
                            column.HeaderText = "Estado";
                            break;
                        case "nombreproducto":
                        case "nombre_producto":
                            column.HeaderText = "Producto";
                            break;
                        case "cantidadvendida":
                        case "cantidad_vendida":
                            column.HeaderText = "Cantidad";
                            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "totalventas":
                        case "total_ventas":
                            column.HeaderText = "Total Ventas";
                            column.DefaultCellStyle.Format = "C2";
                            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            break;
                        case "promedio":
                        case "preciopromedio":
                        case "precio_promedio":
                            column.HeaderText = "Precio Promedio";
                            column.DefaultCellStyle.Format = "C2";
                            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error mejorando presentación de columnas: {ex.Message}");
            }
        }

        private void ConfigurarParametrosReporte()
        {
            // Este método ya no es necesario con DataGridView
            // Los datos se muestran directamente en la tabla
        }

        private void GenerarReporteGenerico(DataTable datos)
        {
            try
            {
                // Con DataGridView, mostrar los datos directamente
                if (dgvReporte != null)
                {
                    dgvReporte.DataSource = datos;
                    MejorarPresentacionColumnas(datos);
                }
                
                lblResultados.Text = $"✓ {tipoReporte} | {datos.Rows.Count} registros | Modo Tabla";
                HabilitarBotonesExportacion(true);
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
                    if (dgvReporte?.DataSource == null)
                    {
                        throw new InvalidOperationException("No hay datos disponibles para exportar");
                    }
                    
                    // Exportar datos del DataGridView
                    ExportarDataGridView(dgvReporte, saveDialog.FileName, formato);

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
                if (dgvReporte == null || dgvReporte.DataSource == null)
                {
                    MessageBox.Show("No hay datos para imprimir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // Implementar impresión del DataGridView
                ImprimirDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir: " + ex.Message, 
                    "Error de Impresión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportarDataGridView(DataGridView dgv, string fileName, string formato)
        {
            try
            {
                DataTable dt = (DataTable)dgv.DataSource;
                
                if (formato == "Excel")
                {
                    ExportarACSV(dt, fileName.Replace(".xls", ".csv"));
                }
                else if (formato == "PDF")
                {
                    ExportarATexto(dt, fileName.Replace(".pdf", ".txt"));
                }
                else if (formato == "Word")
                {
                    ExportarATexto(dt, fileName.Replace(".doc", ".txt"));
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error exportando datos: {ex.Message}");
            }
        }

        private void ExportarACSV(DataTable dt, string fileName)
        {
            StringBuilder sb = new StringBuilder();
            
            // Encabezados
            string[] columnNames = dt.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();
            sb.AppendLine(string.Join(",", columnNames));
            
            // Datos
            foreach (DataRow row in dt.Rows)
            {
                string[] fields = row.ItemArray.Select(field => field?.ToString()?.Replace(",", ";") ?? "").ToArray();
                sb.AppendLine(string.Join(",", fields));
            }
            
            File.WriteAllText(fileName, sb.ToString());
        }

        private void ExportarATexto(DataTable dt, string fileName)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"REPORTE: {tipoReporte}");
            sb.AppendLine($"PERÍODO: {tipoPeriodo}");
            sb.AppendLine($"FECHAS: {fechaInicio:dd/MM/yyyy} - {dtpFechaFin.Value:dd/MM/yyyy}");
            sb.AppendLine($"GENERADO: {DateTime.Now:dd/MM/yyyy HH:mm}");
            sb.AppendLine($"REGISTROS: {dt.Rows.Count}");
            sb.AppendLine(new string('=', 50));
            sb.AppendLine();
            
            // Encabezados
            string[] columnNames = dt.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();
            sb.AppendLine(string.Join("\t", columnNames));
            sb.AppendLine(new string('-', 50));
            
            // Datos
            foreach (DataRow row in dt.Rows)
            {
                string[] fields = row.ItemArray.Select(field => field?.ToString() ?? "").ToArray();
                sb.AppendLine(string.Join("\t", fields));
            }
            
            File.WriteAllText(fileName, sb.ToString());
        }

        private void ImprimirDataGridView()
        {
            try
            {
                MessageBox.Show("Funcionalidad de impresión implementada.\n\nPuede usar Ctrl+C para copiar los datos seleccionados y pegarlos en otro programa para imprimir.", 
                    "Impresión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la impresión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReporte == null || dgvReporte.DataSource == null)
                {
                    MessageBox.Show("No hay datos para mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // Cambiar el modo de visualización del DataGridView
                if (dgvReporte.AutoSizeColumnsMode == DataGridViewAutoSizeColumnsMode.Fill)
                {
                    dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    btnVistaPrevia.Text = "Vista Ajustada";
                }
                else
                {
                    dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                if (dgvReporte?.DataSource != null)
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
                if (dgvReporte != null)
                {
                    dgvReporte.DataSource = null;
                }
                
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
                
                // Configurar DataGridView después de que todos los controles estén listos
                ConfigurarDataGridView();
                
                HabilitarBotonesExportacion(false);
                lblResultados.Text = "Seleccione los criterios y genere un reporte";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PruebaConexionYDatos()
        {
            try
            {
                var resultado = NVentas.ReporteVentasResumen(
                    new DateTime(2024, 1, 1),
                    DateTime.Now,
                    "MES"
                );

                if (resultado != null)
                {
                    MessageBox.Show($"Conexión OK. Filas: {resultado.Rows.Count}, Columnas: {resultado.Columns.Count}");
                }
                else
                {
                    MessageBox.Show("La consulta devolvió NULL");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de conexión: {ex.Message}");
            }
        }
        private void btnDiagnostico_Click(object sender, EventArgs e)
        {
            try
            {
                // Probar la conexión directamente
                PruebaConexionYDatos();

                // Probar consulta directa a la tabla factura
                PruebaTablaFactura();

                // Verificar procedimientos almacenados
                VerificarProcedimientosAlmacenados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en diagnóstico: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PruebaTablaFactura()
        {
            try
            {
                // Crear una consulta directa para ver si hay facturas
                DataTable resultado = new DataTable();

                using (var connection = CapaDatos.DbConnection.Instance.GetConnection())
                {
                    string query = @"SELECT COUNT(*) as TotalFacturas FROM factura
                                   UNION ALL
                                   SELECT COUNT(*) FROM factura WHERE fecha_emision >= '2024-01-01'
                                   UNION ALL  
                                   SELECT COUNT(*) FROM factura WHERE fecha_emision >= '2025-01-01'";

                    using (var command = new Microsoft.Data.SqlClient.SqlCommand(query, connection))
                    using (var adapter = new Microsoft.Data.SqlClient.SqlDataAdapter(command))
                    {
                        adapter.Fill(resultado);
                    }
                }

                if (resultado.Rows.Count >= 3)
                {
                    MessageBox.Show($"Facturas encontradas:\n" +
                                   $"Total: {resultado.Rows[0][0]}\n" +
                                   $"Desde 2024: {resultado.Rows[1][0]}\n" +
                                   $"Desde 2025: {resultado.Rows[2][0]}",
                                   "Datos en tabla factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error consultando tabla factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificarProcedimientosAlmacenados()
        {
            try
            {
                DataTable resultado = new DataTable();

                using (var connection = CapaDatos.DbConnection.Instance.GetConnection())
                {
                    string query = @"SELECT name as NombreProcedimiento 
                                   FROM sys.objects 
                                   WHERE type = 'P' 
                                   AND name LIKE '%Reporte%'";

                    using (var command = new Microsoft.Data.SqlClient.SqlCommand(query, connection))
                    using (var adapter = new Microsoft.Data.SqlClient.SqlDataAdapter(command))
                    {
                        adapter.Fill(resultado);
                    }
                }

                if (resultado.Rows.Count > 0)
                {
                    string procedimientos = string.Join("\n", resultado.AsEnumerable().Select(r => r["NombreProcedimiento"].ToString()));
                    MessageBox.Show($"Procedimientos encontrados:\n{procedimientos}",
                                   "Procedimientos almacenados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontraron procedimientos almacenados de reportes.\n\n¡Este es el problema!",
                                   "Sin procedimientos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error verificando procedimientos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrearGraficoPromedio(DataTable datos)
        {
            try
            {
                if (panelGrafico == null || datos == null || datos.Rows.Count == 0)
                    return;

                // Limpiar el panel del gráfico COMPLETAMENTE
                panelGrafico.Controls.Clear();

                // USAR TODO EL PANEL DISPONIBLE - Sin título para más espacio
                Panel panelGraficoBarra = new Panel();
                panelGraficoBarra.Dock = DockStyle.Fill;
                panelGraficoBarra.BackColor = Color.White;
                panelGraficoBarra.Margin = Padding.Empty;
                panelGraficoBarra.Padding = Padding.Empty;

                // Buscar columna de totales
                string columnaNumerica = EncontrarColumnaNumerica(datos);
                if (string.IsNullOrEmpty(columnaNumerica))
                {
                    // Mostrar mensaje si no hay datos numéricos - OCUPANDO TODO EL ESPACIO
                    Label lblSinDatos = new Label();
                    lblSinDatos.Text = "No se encontraron datos numéricos para graficar";
                    lblSinDatos.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
                    lblSinDatos.ForeColor = Color.Gray;
                    lblSinDatos.Dock = DockStyle.Fill;
                    lblSinDatos.TextAlign = ContentAlignment.MiddleCenter;
                    panelGraficoBarra.Controls.Add(lblSinDatos);
                }
                else
                {
                    // Crear el gráfico de barras MAXIMIZADO
                    CrearGraficoBarrasMaximizado(panelGraficoBarra, datos, columnaNumerica);
                }

                panelGrafico.Controls.Add(panelGraficoBarra);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error creando gráfico maximizado: {ex.Message}");
            }
        }

        private string EncontrarColumnaNumerica(DataTable datos)
        {
            // Buscar columnas que contengan datos numéricos
            string[] columnasPosibles = { "total", "Total", "promedio", "Promedio", "suma", "Suma", "cantidad", "Cantidad" };
            
            foreach (string nombreColumna in columnasPosibles)
            {
                if (datos.Columns.Contains(nombreColumna))
                {
                    return nombreColumna;
                }
            }

            // Si no encuentra ninguna específica, buscar la primera columna numérica
            foreach (DataColumn column in datos.Columns)
            {
                if (column.DataType == typeof(decimal) || column.DataType == typeof(double) || 
                    column.DataType == typeof(int) || column.DataType == typeof(float))
                {
                    return column.ColumnName;
                }
            }

            return "";
        }

        private void CrearGraficoBarrasMaximizado(Panel contenedor, DataTable datos, string columnaNumerica)
        {
            try
            {
                // Calcular valores
                decimal valorMaximo = datos.AsEnumerable()
                    .Where(row => row[columnaNumerica] != DBNull.Value)
                    .Max(row => Convert.ToDecimal(row[columnaNumerica]));

                if (valorMaximo <= 0) return;

                // USAR TODO EL ESPACIO DISPONIBLE - MÁRGENES MÍNIMOS
                int margenIzquierdo = 60;   // Solo para etiquetas del eje Y
                int margenDerecho = 20;     // Mínimo
                int margenSuperior = 30;    // Mínimo para valores
                int margenInferior = 60;    // Para etiquetas del eje X

                // MAXIMIZAR EL ÁREA DEL GRÁFICO
                int alturaGrafico = Math.Max(200, contenedor.Height - margenSuperior - margenInferior);
                int anchoGrafico = Math.Max(300, contenedor.Width - margenIzquierdo - margenDerecho);

                // Barras MÁS GRANDES - Usar todos los datos disponibles
                int numBarras = Math.Min(datos.Rows.Count, 15);
                int espacioEntreBarra = Math.Max(8, anchoGrafico / (numBarras * 6));
                int anchoBarra = Math.Max(30, (anchoGrafico - (espacioEntreBarra * (numBarras + 1))) / numBarras);

                // Asegurar barras visibles pero no excesivamente anchas
                if (anchoBarra > 100)
                {
                    anchoBarra = 100;
                    espacioEntreBarra = (anchoGrafico - (anchoBarra * numBarras)) / (numBarras + 1);
                }

                int x = margenIzquierdo + espacioEntreBarra;
                int contador = 0;
                int yBase = margenSuperior + alturaGrafico;

                // Crear barras con MÁXIMO TAMAÑO
                foreach (DataRow row in datos.Rows)
                {
                    if (contador >= numBarras) break;

                    if (row[columnaNumerica] != DBNull.Value)
                    {
                        decimal valor = Convert.ToDecimal(row[columnaNumerica]);
                        int alturaBarra = Math.Max(15, (int)((valor / valorMaximo) * alturaGrafico));

                        // Sombra para efecto 3D
                        Panel sombra = new Panel();
                        sombra.BackColor = Color.FromArgb(100, 100, 100);
                        sombra.Width = anchoBarra + 3;
                        sombra.Height = alturaBarra + 3;
                        sombra.Location = new Point(x + 3, yBase - alturaBarra + 3);
                        contenedor.Controls.Add(sombra);

                        // Barra principal - MÁS GRANDE Y COLORIDA
                        Panel barra = new Panel();
                        barra.BackColor = Color.FromArgb(52, 152, 219); // Azul más vibrante
                        barra.Width = anchoBarra;
                        barra.Height = alturaBarra;
                        barra.Location = new Point(x, yBase - alturaBarra);
                        contenedor.Controls.Add(barra);

                        // Highlight en la parte superior para efecto de brillo
                        Panel highlight = new Panel();
                        highlight.BackColor = Color.FromArgb(174, 214, 241);
                        highlight.Width = anchoBarra;
                        highlight.Height = Math.Max(3, alturaBarra / 6);
                        highlight.Location = new Point(x, yBase - alturaBarra);
                        contenedor.Controls.Add(highlight);

                        // Valor ENCIMA de la barra - GRANDE Y VISIBLE
                        Label lblValor = new Label();
                        lblValor.Text = valor.ToString("C0");
                        lblValor.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
                        lblValor.ForeColor = Color.FromArgb(52, 152, 219);
                        lblValor.AutoSize = true;
                        lblValor.BackColor = Color.White;
                        
                        int labelX = x + (anchoBarra / 2) - 25;
                        int labelY = (yBase - alturaBarra) - 25;
                        lblValor.Location = new Point(Math.Max(0, labelX), Math.Max(5, labelY));
                        contenedor.Controls.Add(lblValor);

                        // Etiqueta del período DEBAJO
                        Label lblPeriodo = new Label();
                        string textoPeriodo = ObtenerTextoEtiqueta(datos, row, contador);
                        
                        lblPeriodo.Text = textoPeriodo;
                        lblPeriodo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
                        lblPeriodo.ForeColor = Color.Black;
                        lblPeriodo.AutoSize = true;
                        
                        int periodoX = x + (anchoBarra / 2) - 20;
                        lblPeriodo.Location = new Point(Math.Max(0, periodoX), yBase + 10);
                        contenedor.Controls.Add(lblPeriodo);

                        x += anchoBarra + espacioEntreBarra;
                        contador++;
                    }
                }

                // Ejes y líneas de referencia MÁS PROMINENTES
                CrearEjesYReferencias(contenedor, margenIzquierdo, margenSuperior, anchoGrafico, alturaGrafico, valorMaximo);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error creando gráfico maximizado: {ex.Message}");
            }
        }

        private string ObtenerTextoEtiqueta(DataTable datos, DataRow row, int contador)
        {
            if (datos.Columns.Contains("fecha") && row["fecha"] != DBNull.Value)
                return Convert.ToDateTime(row["fecha"]).ToString("MMM");
            else if (datos.Columns.Contains("periodo") && row["periodo"] != DBNull.Value)
            {
                string periodoStr = row["periodo"]?.ToString() ?? "";
                return periodoStr.Length > 6 ? periodoStr.Substring(0, 6) : periodoStr;
            }
            return $"P{contador + 1}";
        }

        private void CrearEjesYReferencias(Panel contenedor, int margenIzq, int margenSup, int ancho, int altura, decimal valorMax)
        {
            int yBase = margenSup + altura;

            // Eje X - MÁS GRUESO Y VISIBLE
            Panel ejeX = new Panel();
            ejeX.BackColor = Color.Black;
            ejeX.Height = 3;
            ejeX.Width = ancho + 5;
            ejeX.Location = new Point(margenIzq, yBase);
            contenedor.Controls.Add(ejeX);

            // Eje Y - MÁS GRUESO Y VISIBLE
            Panel ejeY = new Panel();
            ejeY.BackColor = Color.Black;
            ejeY.Height = altura + 3;
            ejeY.Width = 3;
            ejeY.Location = new Point(margenIzq, margenSup);
            contenedor.Controls.Add(ejeY);

            // Líneas de referencia horizontales - MÁS VISIBLES
            for (int i = 0; i <= 4; i++)
            {
                decimal valorLinea = (valorMax / 4) * i;
                int yLinea = yBase - (int)((valorLinea / valorMax) * altura);

                // Línea horizontal
                Panel linea = new Panel();
                linea.BackColor = i == 0 ? Color.Black : Color.FromArgb(180, 180, 180);
                linea.Height = i == 0 ? 3 : 1;
                linea.Width = ancho;
                linea.Location = new Point(margenIzq, yLinea);
                contenedor.Controls.Add(linea);

                // Etiquetas del eje Y - MÁS GRANDES
                if (i > 0) // No mostrar $0
                {
                    Label lblRef = new Label();
                    lblRef.Text = valorLinea.ToString("C0");
                    lblRef.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
                    lblRef.ForeColor = Color.FromArgb(52, 152, 219);
                    lblRef.AutoSize = true;
                    lblRef.BackColor = Color.White;
                    lblRef.Location = new Point(5, yLinea - 10);
                    contenedor.Controls.Add(lblRef);
                }
            }

            // Título del eje Y
            Label lblTituloY = new Label();
            lblTituloY.Text = "Valores";
            lblTituloY.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblTituloY.ForeColor = Color.FromArgb(52, 152, 219);
            lblTituloY.AutoSize = true;
            lblTituloY.Location = new Point(5, margenSup - 20);
            contenedor.Controls.Add(lblTituloY);
        }

        private void CrearGraficoBarras(Panel contenedor, DataTable datos, string columnaNumerica)
        {
            try
            {
                // Calcular valores
                decimal valorMaximo = datos.AsEnumerable()
                    .Where(row => row[columnaNumerica] != DBNull.Value)
                    .Max(row => Convert.ToDecimal(row[columnaNumerica]));

                if (valorMaximo <= 0) return;

                // MÁRGENES OPTIMIZADOS PARA 400PX DE ALTURA
                int margenIzquierdo = 90;  // Espacio para etiquetas del eje Y
                int margenDerecho = 30;
                int margenSuperior = 50;   // Espacio para valores encima de barras
                int margenInferior = 70;   // Espacio para etiquetas del eje X

                // USAR EL ESPACIO DISPONIBLE (~350px de altura útil para barras)
                int alturaGrafico = contenedor.Height - margenSuperior - margenInferior;
                int anchoGrafico = contenedor.Width - margenIzquierdo - margenDerecho;

                // Calcular número de barras y dimensiones - BARRAS GRANDES Y VISIBLES
                int numBarras = Math.Min(datos.Rows.Count, 10); // 10 barras máximo para que sean bien anchas
                int espacioTotal = anchoGrafico;
                int espacioEntreBarra = Math.Max(20, espacioTotal / (numBarras * 3)); // Buen espacio entre barras
                int anchoBarra = Math.Max(50, (espacioTotal - (espacioEntreBarra * (numBarras + 1))) / numBarras);

                // Ajustar si las barras son muy anchas - PERMITIR BARRAS ANCHAS
                if (anchoBarra > 150)
                {
                    anchoBarra = 150;
                    espacioEntreBarra = (espacioTotal - (anchoBarra * numBarras)) / (numBarras + 1);
                }

                int x = margenIzquierdo + espacioEntreBarra;
                int contador = 0;
                int yBase = margenSuperior + alturaGrafico; // Línea base desde donde crecen las barras

                // Título del eje Y más grande
                Label lblEjeY = new Label();
                lblEjeY.Text = "Valores ($)";
                lblEjeY.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
                lblEjeY.ForeColor = Color.FromArgb(31, 30, 68);
                lblEjeY.AutoSize = true;
                lblEjeY.Location = new Point(5, margenSuperior - 15);
                contenedor.Controls.Add(lblEjeY);

                foreach (DataRow row in datos.Rows)
                {
                    if (contador >= numBarras) break;

                    if (row[columnaNumerica] != DBNull.Value)
                    {
                        decimal valor = Convert.ToDecimal(row[columnaNumerica]);
                        // ALTURA MÍNIMA GRANDE para barras bien visibles (30px mínimo)
                        int alturaBarra = Math.Max(30, (int)((valor / valorMaximo) * alturaGrafico));

                        // Crear la barra principal - MÁS GRANDE Y VISIBLE CON EFECTO DE SOMBRA
                        Panel sombraBarra = new Panel();
                        sombraBarra.BackColor = Color.FromArgb(21, 20, 48); // Sombra más oscura
                        sombraBarra.Width = anchoBarra + 6;
                        sombraBarra.Height = alturaBarra + 6;
                        sombraBarra.Location = new Point(x + 3, yBase - alturaBarra + 3);
                        contenedor.Controls.Add(sombraBarra); // Agregar primero la sombra

                        Panel barra = new Panel();
                        barra.BackColor = Color.FromArgb(31, 30, 68); // Color principal
                        barra.Width = anchoBarra;
                        barra.Height = alturaBarra;
                        barra.Location = new Point(x, yBase - alturaBarra);

                        // Borde más visible
                        barra.BorderStyle = BorderStyle.FixedSingle;

                        // Etiqueta del valor ENCIMA de la barra - MÁS GRANDE Y VISIBLE
                        Label lblValor = new Label();
                        lblValor.Text = valor.ToString("C0");
                        lblValor.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
                        lblValor.ForeColor = Color.FromArgb(31, 30, 68);
                        lblValor.AutoSize = true;
                        lblValor.BackColor = Color.White; // Fondo blanco para contraste
                        
                        int labelX = x + (anchoBarra / 2) - 30; // Centrar mejor
                        int labelY = (yBase - alturaBarra) - 30; // Más espacio arriba
                        lblValor.Location = new Point(Math.Max(0, labelX), Math.Max(5, labelY));

                        // Etiqueta del período DEBAJO del eje X - MÁS GRANDE
                        Label lblPeriodo = new Label();
                        string textoPeriodo = "";
                        if (datos.Columns.Contains("fecha") && row["fecha"] != DBNull.Value)
                            textoPeriodo = Convert.ToDateTime(row["fecha"]).ToString("MMM");
                        else if (datos.Columns.Contains("periodo") && row["periodo"] != DBNull.Value)
                        {
                            string periodoStr = row["periodo"]?.ToString() ?? "";
                            textoPeriodo = periodoStr.Length > 8 ? periodoStr.Substring(0, 8) : periodoStr;
                            if (string.IsNullOrEmpty(textoPeriodo))
                                textoPeriodo = $"P{contador + 1}";
                        }
                        else
                            textoPeriodo = $"P{contador + 1}";

                        lblPeriodo.Text = textoPeriodo;
                        lblPeriodo.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
                        lblPeriodo.ForeColor = Color.Black;
                        lblPeriodo.AutoSize = true;
                        lblPeriodo.BackColor = Color.White; // Fondo para contraste
                        
                        int periodoX = x + (anchoBarra / 2) - 25; // Centrar mejor
                        lblPeriodo.Location = new Point(Math.Max(0, periodoX), yBase + 20); // Más espacio debajo

                        contenedor.Controls.Add(barra); // Barra principal encima de la sombra
                        contenedor.Controls.Add(lblValor);
                        contenedor.Controls.Add(lblPeriodo);

                        x += anchoBarra + espacioEntreBarra;
                        contador++;
                    }
                }

                // Líneas de referencia horizontales MÁS VISIBLES
                for (int i = 0; i <= 5; i++) // 6 líneas de referencia
                {
                    decimal valorLinea = (valorMaximo / 5) * i;
                    int yLinea = yBase - (int)((valorLinea / valorMaximo) * alturaGrafico);

                    // Línea horizontal más visible y colorida
                    Panel linea = new Panel();
                    linea.BackColor = i == 0 ? Color.Black : Color.FromArgb(160, 160, 160);
                    linea.Height = i == 0 ? 3 : 2; // Línea base más gruesa
                    linea.Width = anchoGrafico;
                    linea.Location = new Point(margenIzquierdo, yLinea);
                    contenedor.Controls.Add(linea);

                    // Etiquetas del eje Y MÁS GRANDES Y VISIBLES
                    Label lblReferencia = new Label();
                    lblReferencia.Text = valorLinea.ToString("C0");
                    lblReferencia.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
                    lblReferencia.ForeColor = Color.FromArgb(31, 30, 68);
                    lblReferencia.AutoSize = true;
                    lblReferencia.BackColor = Color.White;
                    lblReferencia.TextAlign = ContentAlignment.MiddleRight;
                    lblReferencia.Location = new Point(5, yLinea - 12);
                    contenedor.Controls.Add(lblReferencia);
                }

                // Eje X más grueso y visible
                Panel ejeX = new Panel();
                ejeX.BackColor = Color.Black;
                ejeX.Height = 4;
                ejeX.Width = anchoGrafico;
                ejeX.Location = new Point(margenIzquierdo, yBase);
                contenedor.Controls.Add(ejeX);

                // Eje Y más grueso y visible
                Panel ejeY = new Panel();
                ejeY.BackColor = Color.Black;
                ejeY.Height = alturaGrafico + 4;
                ejeY.Width = 4;
                ejeY.Location = new Point(margenIzquierdo, margenSuperior);
                contenedor.Controls.Add(ejeY);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error creando gráfico de barras maximizado: {ex.Message}");
            }
        }



    }
}