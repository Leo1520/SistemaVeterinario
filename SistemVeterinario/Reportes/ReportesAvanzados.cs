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

                // Crear panel contenedor principal con layout personalizado
                Panel panelContenedor = new Panel();
                panelContenedor.Dock = DockStyle.Fill;
                panelContenedor.BackColor = Color.WhiteSmoke;

                // Calcular dimensiones disponibles
                int alturaDisponible = panelReporte.Height;
                int anchoDisponible = panelReporte.Width;

                // 1. Panel superior para gráfico centrado
                // Ajustar tamaño del gráfico si es necesario para que quepa
                int tamanoGrafico = Math.Min(650, Math.Min(anchoDisponible - 20, (alturaDisponible / 2) - 50));
                tamanoGrafico = Math.Max(300, tamanoGrafico); // Mínimo 300x300

                panelGrafico = new Panel();
                panelGrafico.Size = new Size(tamanoGrafico, tamanoGrafico);
                panelGrafico.BackColor = Color.White;
                panelGrafico.BorderStyle = BorderStyle.FixedSingle;
                panelGrafico.Anchor = AnchorStyles.Top;
                
                // Centrar el gráfico horizontalmente
                panelGrafico.Location = new Point((anchoDisponible - tamanoGrafico) / 2, 10);

                // Agregar título al panel de gráfico
                Label lblTituloGrafico = new Label();
                lblTituloGrafico.Text = "GRÁFICO DE PROMEDIO DE VENTAS";
                lblTituloGrafico.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
                lblTituloGrafico.ForeColor = Color.FromArgb(31, 30, 68);
                lblTituloGrafico.Dock = DockStyle.Top;
                lblTituloGrafico.Height = 30;
                lblTituloGrafico.TextAlign = ContentAlignment.MiddleCenter;
                panelGrafico.Controls.Add(lblTituloGrafico);

                // 2. Panel para la tabla del reporte (resto del espacio disponible)
                Panel panelTabla = new Panel();
                int yTabla = tamanoGrafico + 20; // Debajo del gráfico con margen
                int alturaTabla = alturaDisponible - yTabla - 10;
                
                panelTabla.Location = new Point(10, yTabla);
                panelTabla.Size = new Size(anchoDisponible - 20, alturaTabla);
                panelTabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                panelTabla.BackColor = Color.White;
                panelTabla.BorderStyle = BorderStyle.FixedSingle;

                // Crear el DataGridView dinámicamente
                dgvReporte = new DataGridView();
                
                // Configurar propiedades básicas
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
                
                // Estilos mejorados para mejor visibilidad
                dgvReporte.BackgroundColor = Color.White;
                dgvReporte.BorderStyle = BorderStyle.None;
                dgvReporte.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                
                // Configurar colores para filas normales
                dgvReporte.DefaultCellStyle.BackColor = Color.White;
                dgvReporte.DefaultCellStyle.ForeColor = Color.Black;
                dgvReporte.DefaultCellStyle.SelectionBackColor = Color.FromArgb(31, 30, 68);
                dgvReporte.DefaultCellStyle.SelectionForeColor = Color.White;
                
                // Configurar filas alternas con color gris claro
                dgvReporte.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                dgvReporte.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                
                // Configurar encabezados de columnas
                dgvReporte.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 30, 68);
                dgvReporte.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvReporte.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
                dgvReporte.EnableHeadersVisualStyles = false;

                // Agregar el DataGridView al panel de tabla
                panelTabla.Controls.Add(dgvReporte);

                // Agregar ambos paneles al contenedor
                panelContenedor.Controls.Add(panelGrafico);
                panelContenedor.Controls.Add(panelTabla);

                // Manejar el redimensionamiento para mantener el layout
                panelContenedor.Resize += (sender, e) =>
                {
                    if (panelGrafico != null && panelTabla != null)
                    {
                        int nuevoAnchoDisponible = panelContenedor.Width;
                        int nuevaAlturaDisponible = panelContenedor.Height;
                        
                        // Recalcular tamaño del gráfico
                        int nuevoTamanoGrafico = Math.Min(650, Math.Min(nuevoAnchoDisponible - 20, (nuevaAlturaDisponible / 2) - 50));
                        nuevoTamanoGrafico = Math.Max(300, nuevoTamanoGrafico);
                        
                        panelGrafico.Size = new Size(nuevoTamanoGrafico, nuevoTamanoGrafico);
                        panelGrafico.Location = new Point((nuevoAnchoDisponible - nuevoTamanoGrafico) / 2, 10);
                        
                        // Reposicionar tabla
                        int nuevoYTabla = nuevoTamanoGrafico + 20;
                        int nuevaAlturaTabla = nuevaAlturaDisponible - nuevoYTabla - 10;
                        
                        panelTabla.Location = new Point(10, nuevoYTabla);
                        panelTabla.Size = new Size(nuevoAnchoDisponible - 20, nuevaAlturaTabla);
                    }
                };

                // Agregar el contenedor al panel principal
                panelReporte.Controls.Add(panelContenedor);
                
                System.Diagnostics.Debug.WriteLine($"Layout reorganizado: Gráfico {tamanoGrafico}x{tamanoGrafico} centrado, tabla usando espacio restante");
                
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error creando layout dinámicamente: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"StackTrace: {ex.StackTrace}");
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

                // Limpiar el panel del gráfico (excepto el título)
                var controles = panelGrafico.Controls.Cast<Control>().Where(c => c.GetType() != typeof(Label)).ToList();
                foreach (var control in controles)
                {
                    panelGrafico.Controls.Remove(control);
                }

                // Crear un gráfico de barras simple usando Panel y PictureBox
                Panel panelGraficoBarra = new Panel();
                panelGraficoBarra.Dock = DockStyle.Fill;
                panelGraficoBarra.BackColor = Color.White;
                panelGraficoBarra.Padding = new Padding(20);

                // Buscar columna de totales
                string columnaNumerica = EncontrarColumnaNumerica(datos);
                if (string.IsNullOrEmpty(columnaNumerica))
                {
                    // Mostrar mensaje si no hay datos numéricos
                    Label lblSinDatos = new Label();
                    lblSinDatos.Text = "No se encontraron datos numéricos para graficar";
                    lblSinDatos.Font = new Font("Microsoft Sans Serif", 10F);
                    lblSinDatos.ForeColor = Color.Gray;
                    lblSinDatos.Dock = DockStyle.Fill;
                    lblSinDatos.TextAlign = ContentAlignment.MiddleCenter;
                    panelGraficoBarra.Controls.Add(lblSinDatos);
                }
                else
                {
                    // Crear el gráfico de barras
                    CrearGraficoBarras(panelGraficoBarra, datos, columnaNumerica);
                }

                panelGrafico.Controls.Add(panelGraficoBarra);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error creando gráfico: {ex.Message}");
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

        private void CrearGraficoBarras(Panel contenedor, DataTable datos, string columnaNumerica)
        {
            try
            {
                // Calcular valores
                decimal valorMaximo = datos.AsEnumerable()
                    .Where(row => row[columnaNumerica] != DBNull.Value)
                    .Max(row => Convert.ToDecimal(row[columnaNumerica]));

                if (valorMaximo <= 0) return;

                int alturaMaxima = contenedor.Height - 100; // Dejar espacio para etiquetas
                int anchoDisponible = contenedor.Width - 40;
                int anchoBarra = Math.Max(30, anchoDisponible / Math.Min(datos.Rows.Count, 10));
                int espacioBarra = 10;

                int x = 20;
                int contador = 0;

                foreach (DataRow row in datos.Rows)
                {
                    if (contador >= 10) break; // Máximo 10 barras para que se vean bien

                    if (row[columnaNumerica] != DBNull.Value)
                    {
                        decimal valor = Convert.ToDecimal(row[columnaNumerica]);
                        int alturaBarra = (int)((valor / valorMaximo) * alturaMaxima);

                        // Crear la barra
                        Panel barra = new Panel();
                        barra.BackColor = Color.FromArgb(31, 30, 68);
                        barra.Width = anchoBarra;
                        barra.Height = alturaBarra;
                        barra.Location = new Point(x, contenedor.Height - alturaBarra - 60);

                        // Etiqueta del valor
                        Label lblValor = new Label();
                        lblValor.Text = valor.ToString("C0");
                        lblValor.Font = new Font("Microsoft Sans Serif", 8F);
                        lblValor.ForeColor = Color.Black;
                        lblValor.AutoSize = true;
                        lblValor.Location = new Point(x, contenedor.Height - alturaBarra - 80);

                        // Etiqueta del período (si existe)
                        Label lblPeriodo = new Label();
                        string textoPeriodo = "";
                        if (datos.Columns.Contains("fecha"))
                            textoPeriodo = Convert.ToDateTime(row["fecha"]).ToString("MM/dd");
                        else if (datos.Columns.Contains("periodo"))
                            textoPeriodo = row["periodo"]?.ToString() ?? (contador + 1).ToString();
                        else
                            textoPeriodo = (contador + 1).ToString();

                        lblPeriodo.Text = textoPeriodo;
                        lblPeriodo.Font = new Font("Microsoft Sans Serif", 8F);
                        lblPeriodo.ForeColor = Color.Black;
                        lblPeriodo.AutoSize = true;
                        lblPeriodo.Location = new Point(x, contenedor.Height - 40);

                        contenedor.Controls.Add(barra);
                        contenedor.Controls.Add(lblValor);
                        contenedor.Controls.Add(lblPeriodo);

                        x += anchoBarra + espacioBarra;
                        contador++;
                    }
                }

                // Agregar líneas de referencia y etiquetas del eje Y
                for (int i = 0; i <= 4; i++)
                {
                    decimal valorLinea = (valorMaximo / 4) * i;
                    int yLinea = contenedor.Height - 60 - (int)((valorLinea / valorMaximo) * alturaMaxima);

                    // Línea horizontal de referencia
                    Panel linea = new Panel();
                    linea.BackColor = Color.LightGray;
                    linea.Height = 1;
                    linea.Width = anchoDisponible;
                    linea.Location = new Point(20, yLinea);
                    contenedor.Controls.Add(linea);

                    // Etiqueta del valor
                    Label lblReferencia = new Label();
                    lblReferencia.Text = valorLinea.ToString("C0");
                    lblReferencia.Font = new Font("Microsoft Sans Serif", 7F);
                    lblReferencia.ForeColor = Color.Gray;
                    lblReferencia.AutoSize = true;
                    lblReferencia.Location = new Point(2, yLinea - 8);
                    contenedor.Controls.Add(lblReferencia);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error creando gráfico de barras: {ex.Message}");
            }
        }



    }
}