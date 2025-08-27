using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.IO;

namespace SistemVeterinario.Reportes
{
    public partial class FrmReportesAvanzadosNuevo : UserControl
    {
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private string tipoPeriodo = "MENSUAL";
        private string tipoReporte = "Resumen de Ventas";
        private DataGridView? dgvReporte;

        // Controles de la interfaz mejorada
        private Panel panelFiltros;
        private Panel panelFechas;
        private Panel panelPeriodos;
        private Panel panelTipoReporte;
        private Panel panelAcciones;
        private Panel panelReporte;
        private Panel panelStatus;

        // Controles de fechas
        private Label lblFechaInicio;
        private Label lblFechaFin;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;

        // Botones de períodos predefinidos
        private RadioButton rbHoy;
        private RadioButton rbUltimos7Dias;
        private RadioButton rbUltimos30Dias;
        private RadioButton rbMesActual;
        private RadioButton rbAnoActual;
        private RadioButton rbPersonalizado;

        // Controles de filtros
        private Label lblTipoReporte;
        private ComboBox cmbTipoReporte;
        private Label lblCategoria;
        private ComboBox cmbCategoria;

        // Botones de acción
        private Button btnGenerar;
        private Button btnExportarPDF;
        private Button btnExportarExcel;
        private Button btnExportarWord;
        private Button btnImprimir;
        private Button btnLimpiar;

        // Status
        private Label lblResultados;
        private ProgressBar progressBar;

        public FrmReportesAvanzadosNuevo()
        {
            try
            {
                InitializeComponent();
                CrearDataGridViewDinamicamente();
                ConfigurarEventos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inicializando el formulario de reportes: {ex.Message}", 
                    "Error de Inicialización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // Configuración del UserControl principal
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Name = "FrmReportesAvanzados";
            this.Size = new Size(1400, 800);

            CrearPaneles();
            CrearControlesFechas();
            CrearBotonesPeriodos();
            CrearControlesFiltros();
            CrearBotonesAcciones();
            CrearPanelStatus();

            this.ResumeLayout(false);
        }

        private void CrearPaneles()
        {
            // Panel superior de filtros
            panelFiltros = new Panel();
            panelFiltros.Dock = DockStyle.Top;
            panelFiltros.Height = 200;
            panelFiltros.BackColor = Color.White;
            panelFiltros.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(panelFiltros);

            // Panel de fechas (lado izquierdo)
            panelFechas = new Panel();
            panelFechas.Location = new Point(10, 10);
            panelFechas.Size = new Size(300, 180);
            panelFechas.BackColor = Color.FromArgb(249, 249, 249);
            panelFechas.BorderStyle = BorderStyle.FixedSingle;
            panelFiltros.Controls.Add(panelFechas);

            // Panel de períodos predefinidos (centro)
            panelPeriodos = new Panel();
            panelPeriodos.Location = new Point(320, 10);
            panelPeriodos.Size = new Size(400, 180);
            panelPeriodos.BackColor = Color.FromArgb(249, 249, 249);
            panelPeriodos.BorderStyle = BorderStyle.FixedSingle;
            panelFiltros.Controls.Add(panelPeriodos);

            // Panel de tipo de reporte (lado derecho)
            panelTipoReporte = new Panel();
            panelTipoReporte.Location = new Point(730, 10);
            panelTipoReporte.Size = new Size(250, 180);
            panelTipoReporte.BackColor = Color.FromArgb(249, 249, 249);
            panelTipoReporte.BorderStyle = BorderStyle.FixedSingle;
            panelFiltros.Controls.Add(panelTipoReporte);

            // Panel de acciones (extremo derecho)
            panelAcciones = new Panel();
            panelAcciones.Location = new Point(990, 10);
            panelAcciones.Size = new Size(180, 180);
            panelAcciones.BackColor = Color.FromArgb(249, 249, 249);
            panelAcciones.BorderStyle = BorderStyle.FixedSingle;
            panelFiltros.Controls.Add(panelAcciones);

            // Panel del reporte (centro)
            panelReporte = new Panel();
            panelReporte.Dock = DockStyle.Fill;
            panelReporte.BackColor = Color.White;
            panelReporte.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(panelReporte);

            // Panel de status (inferior)
            panelStatus = new Panel();
            panelStatus.Dock = DockStyle.Bottom;
            panelStatus.Height = 40;
            panelStatus.BackColor = Color.FromArgb(64, 64, 64);
            this.Controls.Add(panelStatus);
        }

        private void CrearControlesFechas()
        {
            // Título del panel
            Label lblTituloFechas = new Label();
            lblTituloFechas.Text = "RANGO DE FECHAS";
            lblTituloFechas.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblTituloFechas.ForeColor = Color.FromArgb(31, 30, 68);
            lblTituloFechas.Location = new Point(10, 10);
            lblTituloFechas.Size = new Size(200, 20);
            panelFechas.Controls.Add(lblTituloFechas);

            // Fecha inicio
            lblFechaInicio = new Label();
            lblFechaInicio.Text = "Fecha Inicio:";
            lblFechaInicio.Location = new Point(10, 40);
            lblFechaInicio.Size = new Size(100, 20);
            panelFechas.Controls.Add(lblFechaInicio);

            dtpFechaInicio = new DateTimePicker();
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(10, 65);
            dtpFechaInicio.Size = new Size(120, 27);
            dtpFechaInicio.Value = DateTime.Now.AddDays(-30);
            panelFechas.Controls.Add(dtpFechaInicio);

            // Fecha fin
            lblFechaFin = new Label();
            lblFechaFin.Text = "Fecha Fin:";
            lblFechaFin.Location = new Point(150, 40);
            lblFechaFin.Size = new Size(100, 20);
            panelFechas.Controls.Add(lblFechaFin);

            dtpFechaFin = new DateTimePicker();
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(150, 65);
            dtpFechaFin.Size = new Size(120, 27);
            dtpFechaFin.Value = DateTime.Now;
            panelFechas.Controls.Add(dtpFechaFin);

            // Botón aplicar fechas
            Button btnAplicarFechas = new Button();
            btnAplicarFechas.Text = "Aplicar";
            btnAplicarFechas.BackColor = Color.FromArgb(31, 30, 68);
            btnAplicarFechas.ForeColor = Color.White;
            btnAplicarFechas.FlatStyle = FlatStyle.Flat;
            btnAplicarFechas.Location = new Point(10, 105);
            btnAplicarFechas.Size = new Size(80, 30);
            btnAplicarFechas.Click += BtnAplicarFechas_Click;
            panelFechas.Controls.Add(btnAplicarFechas);
        }

        private void CrearBotonesPeriodos()
        {
            // Título del panel
            Label lblTituloPeriodos = new Label();
            lblTituloPeriodos.Text = "PERÍODOS PREDEFINIDOS";
            lblTituloPeriodos.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblTituloPeriodos.ForeColor = Color.FromArgb(31, 30, 68);
            lblTituloPeriodos.Location = new Point(10, 10);
            lblTituloPeriodos.Size = new Size(200, 20);
            panelPeriodos.Controls.Add(lblTituloPeriodos);

            // Primera fila de botones
            rbHoy = new RadioButton();
            rbHoy.Text = "Hoy";
            rbHoy.Location = new Point(10, 40);
            rbHoy.Size = new Size(80, 24);
            rbHoy.CheckedChanged += RbPeriodo_CheckedChanged;
            panelPeriodos.Controls.Add(rbHoy);

            rbUltimos7Dias = new RadioButton();
            rbUltimos7Dias.Text = "Últimos 7 días";
            rbUltimos7Dias.Location = new Point(100, 40);
            rbUltimos7Dias.Size = new Size(120, 24);
            rbUltimos7Dias.CheckedChanged += RbPeriodo_CheckedChanged;
            panelPeriodos.Controls.Add(rbUltimos7Dias);

            rbUltimos30Dias = new RadioButton();
            rbUltimos30Dias.Text = "Últimos 30 días";
            rbUltimos30Dias.Location = new Point(230, 40);
            rbUltimos30Dias.Size = new Size(130, 24);
            rbUltimos30Dias.Checked = true;
            rbUltimos30Dias.CheckedChanged += RbPeriodo_CheckedChanged;
            panelPeriodos.Controls.Add(rbUltimos30Dias);

            // Segunda fila de botones
            rbMesActual = new RadioButton();
            rbMesActual.Text = "Mes actual";
            rbMesActual.Location = new Point(10, 75);
            rbMesActual.Size = new Size(100, 24);
            rbMesActual.CheckedChanged += RbPeriodo_CheckedChanged;
            panelPeriodos.Controls.Add(rbMesActual);

            rbAnoActual = new RadioButton();
            rbAnoActual.Text = "Año actual";
            rbAnoActual.Location = new Point(120, 75);
            rbAnoActual.Size = new Size(100, 24);
            rbAnoActual.CheckedChanged += RbPeriodo_CheckedChanged;
            panelPeriodos.Controls.Add(rbAnoActual);

            rbPersonalizado = new RadioButton();
            rbPersonalizado.Text = "Personalizado";
            rbPersonalizado.Location = new Point(230, 75);
            rbPersonalizado.Size = new Size(120, 24);
            rbPersonalizado.CheckedChanged += RbPeriodo_CheckedChanged;
            panelPeriodos.Controls.Add(rbPersonalizado);
        }

        private void CrearControlesFiltros()
        {
            // Título del panel
            Label lblTituloTipo = new Label();
            lblTituloTipo.Text = "TIPO DE REPORTE";
            lblTituloTipo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblTituloTipo.ForeColor = Color.FromArgb(31, 30, 68);
            lblTituloTipo.Location = new Point(10, 10);
            lblTituloTipo.Size = new Size(150, 20);
            panelTipoReporte.Controls.Add(lblTituloTipo);

            // Tipo de reporte
            lblTipoReporte = new Label();
            lblTipoReporte.Text = "Reporte:";
            lblTipoReporte.Location = new Point(10, 40);
            lblTipoReporte.Size = new Size(80, 20);
            panelTipoReporte.Controls.Add(lblTipoReporte);

            cmbTipoReporte = new ComboBox();
            cmbTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoReporte.Location = new Point(10, 65);
            cmbTipoReporte.Size = new Size(200, 28);
            cmbTipoReporte.Items.AddRange(new string[] {
                "Resumen de Ventas",
                "Ventas Detalladas", 
                "Productos Más Vendidos",
                "Clientes Top",
                "Ventas por Categoría"
            });
            cmbTipoReporte.SelectedIndex = 0;
            panelTipoReporte.Controls.Add(cmbTipoReporte);

            // Categoría
            lblCategoria = new Label();
            lblCategoria.Text = "Agrupación:";
            lblCategoria.Location = new Point(10, 105);
            lblCategoria.Size = new Size(80, 20);
            panelTipoReporte.Controls.Add(lblCategoria);

            cmbCategoria = new ComboBox();
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Location = new Point(10, 130);
            cmbCategoria.Size = new Size(200, 28);
            cmbCategoria.Items.AddRange(new string[] {
                "Diario", "Semanal", "Mensual", "Anual"
            });
            cmbCategoria.SelectedIndex = 2; // Mensual por defecto
            panelTipoReporte.Controls.Add(cmbCategoria);
        }

        private void CrearBotonesAcciones()
        {
            // Título del panel
            Label lblTituloAcciones = new Label();
            lblTituloAcciones.Text = "ACCIONES";
            lblTituloAcciones.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblTituloAcciones.ForeColor = Color.FromArgb(31, 30, 68);
            lblTituloAcciones.Location = new Point(10, 10);
            lblTituloAcciones.Size = new Size(100, 20);
            panelAcciones.Controls.Add(lblTituloAcciones);

            // Botón generar (más prominente)
            btnGenerar = new Button();
            btnGenerar.Text = "GENERAR";
            btnGenerar.BackColor = Color.FromArgb(46, 125, 50);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnGenerar.Location = new Point(10, 40);
            btnGenerar.Size = new Size(150, 35);
            btnGenerar.Click += BtnGenerar_Click;
            panelAcciones.Controls.Add(btnGenerar);

            // Botón limpiar
            btnLimpiar = new Button();
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.BackColor = Color.FromArgb(158, 158, 158);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Location = new Point(10, 85);
            btnLimpiar.Size = new Size(70, 30);
            btnLimpiar.Click += BtnLimpiar_Click;
            panelAcciones.Controls.Add(btnLimpiar);

            // Progress bar
            progressBar = new ProgressBar();
            progressBar.Location = new Point(10, 125);
            progressBar.Size = new Size(150, 20);
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.Visible = false;
            panelAcciones.Controls.Add(progressBar);
        }

        private void CrearPanelStatus()
        {
            lblResultados = new Label();
            lblResultados.Text = "Seleccione los criterios y genere un reporte";
            lblResultados.ForeColor = Color.White;
            lblResultados.Location = new Point(10, 10);
            lblResultados.Size = new Size(800, 20);
            panelStatus.Controls.Add(lblResultados);

            // Botones de exportación en el status
            btnExportarPDF = new Button();
            btnExportarPDF.Text = "📄 PDF";
            btnExportarPDF.BackColor = Color.FromArgb(211, 47, 47);
            btnExportarPDF.ForeColor = Color.White;
            btnExportarPDF.FlatStyle = FlatStyle.Flat;
            btnExportarPDF.Size = new Size(70, 25);
            btnExportarPDF.Location = new Point(850, 7);
            btnExportarPDF.Enabled = false;
            btnExportarPDF.Click += BtnExportarPDF_Click;
            panelStatus.Controls.Add(btnExportarPDF);

            btnExportarExcel = new Button();
            btnExportarExcel.Text = "📊 CSV";
            btnExportarExcel.BackColor = Color.FromArgb(46, 125, 50);
            btnExportarExcel.ForeColor = Color.White;
            btnExportarExcel.FlatStyle = FlatStyle.Flat;
            btnExportarExcel.Size = new Size(70, 25);
            btnExportarExcel.Location = new Point(930, 7);
            btnExportarExcel.Enabled = false;
            btnExportarExcel.Click += BtnExportarExcel_Click;
            panelStatus.Controls.Add(btnExportarExcel);

            btnExportarWord = new Button();
            btnExportarWord.Text = "📝 TXT";
            btnExportarWord.BackColor = Color.FromArgb(25, 118, 210);
            btnExportarWord.ForeColor = Color.White;
            btnExportarWord.FlatStyle = FlatStyle.Flat;
            btnExportarWord.Size = new Size(70, 25);
            btnExportarWord.Location = new Point(1010, 7);
            btnExportarWord.Enabled = false;
            btnExportarWord.Click += BtnExportarWord_Click;
            panelStatus.Controls.Add(btnExportarWord);

            btnImprimir = new Button();
            btnImprimir.Text = "🖨️ Print";
            btnImprimir.BackColor = Color.FromArgb(69, 90, 100);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Size = new Size(70, 25);
            btnImprimir.Location = new Point(1090, 7);
            btnImprimir.Enabled = false;
            btnImprimir.Click += BtnImprimir_Click;
            panelStatus.Controls.Add(btnImprimir);
        }

        private void CrearDataGridViewDinamicamente()
        {
            try
            {
                // Crear el DataGridView dinámicamente
                dgvReporte = new DataGridView();
                
                // Configurar propiedades básicas
                dgvReporte.Dock = DockStyle.Fill;
                dgvReporte.Location = new Point(0, 0);
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
                dgvReporte.DefaultCellStyle.SelectionBackColor = Color.FromArgb(31, 30, 68);
                dgvReporte.DefaultCellStyle.SelectionForeColor = Color.White;
                dgvReporte.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 30, 68);
                dgvReporte.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvReporte.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
                dgvReporte.EnableHeadersVisualStyles = false;
                dgvReporte.GridColor = Color.FromArgb(230, 230, 230);
                
                // Agregar al panel contenedor
                if (panelReporte != null)
                {
                    panelReporte.Controls.Add(dgvReporte);
                }
                
                System.Diagnostics.Debug.WriteLine("DataGridView creado exitosamente");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error creando DataGridView: {ex.Message}");
                dgvReporte = null;
            }
        }

        private void ConfigurarEventos()
        {
            // No hay eventos adicionales que configurar por ahora
        }

        // Event Handlers
        private void RbPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                DateTime hoy = DateTime.Now;
                
                if (rb == rbHoy)
                {
                    dtpFechaInicio.Value = hoy.Date;
                    dtpFechaFin.Value = hoy.Date;
                    tipoPeriodo = "DIARIO";
                }
                else if (rb == rbUltimos7Dias)
                {
                    dtpFechaInicio.Value = hoy.AddDays(-6).Date;
                    dtpFechaFin.Value = hoy.Date;
                    tipoPeriodo = "DIARIO";
                }
                else if (rb == rbUltimos30Dias)
                {
                    dtpFechaInicio.Value = hoy.AddDays(-29).Date;
                    dtpFechaFin.Value = hoy.Date;
                    tipoPeriodo = "MENSUAL";
                }
                else if (rb == rbMesActual)
                {
                    dtpFechaInicio.Value = new DateTime(hoy.Year, hoy.Month, 1);
                    dtpFechaFin.Value = hoy.Date;
                    tipoPeriodo = "DIARIO";
                }
                else if (rb == rbAnoActual)
                {
                    dtpFechaInicio.Value = new DateTime(hoy.Year, 1, 1);
                    dtpFechaFin.Value = hoy.Date;
                    tipoPeriodo = "MENSUAL";
                }
                else if (rb == rbPersonalizado)
                {
                    // Las fechas se mantienen como están
                    tipoPeriodo = cmbCategoria.SelectedItem?.ToString()?.ToUpper() ?? "MENSUAL";
                }

                // Habilitar/deshabilitar controles de fecha
                bool esPersonalizado = rb == rbPersonalizado;
                dtpFechaInicio.Enabled = esPersonalizado;
                dtpFechaFin.Enabled = esPersonalizado;
                cmbCategoria.Enabled = esPersonalizado;
            }
        }

        private void BtnAplicarFechas_Click(object sender, EventArgs e)
        {
            rbPersonalizado.Checked = true;
            tipoPeriodo = cmbCategoria.SelectedItem?.ToString()?.ToUpper() ?? "MENSUAL";
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                // Mostrar progreso
                progressBar.Visible = true;
                btnGenerar.Enabled = false;

                if (ValidarFechas())
                {
                    fechaInicio = dtpFechaInicio.Value.Date;
                    fechaFin = dtpFechaFin.Value.Date.AddDays(1).AddSeconds(-1);
                    tipoPeriodo = cmbCategoria.SelectedItem?.ToString()?.ToUpper() ?? "MENSUAL";
                    tipoReporte = cmbTipoReporte.SelectedItem?.ToString() ?? "Resumen de Ventas";

                    GenerarReporte();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Visible = false;
                btnGenerar.Enabled = true;
            }
        }

        // Mantener toda la lógica existente de generación de reportes
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
                    MessageBox.Show($"No se encontraron datos para el período seleccionado.\n\nTipo: {tipoReporte}\nFechas: {fechaInicio:dd/MM/yyyy} - {dtpFechaFin.Value:dd/MM/yyyy}", 
                        "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (dgvReporte == null)
                {
                    CrearDataGridViewDinamicamente();
                    if (dgvReporte == null)
                    {
                        MessageBox.Show("Error crítico: No se pudo crear el visor de datos.", 
                            "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Configurar el DataGridView con los datos
                dgvReporte.DataSource = datos;
                MejorarPresentacionColumnas(datos);

                // Actualizar label de resultados
                lblResultados.Text = $"✓ {tipoReporte} | {tipoPeriodo} | {fechaInicio:dd/MM/yyyy} - {dtpFechaFin.Value:dd/MM/yyyy} | {datos.Rows.Count} registros | {DateTime.Now:HH:mm}";

                // Habilitar botones de exportación
                HabilitarBotonesExportacion(true);

                // Mostrar información de columnas para debug
                if (datos.Rows.Count > 0)
                {
                    string columnas = string.Join(", ", datos.Columns.Cast<DataColumn>().Select(c => c.ColumnName));
                    System.Diagnostics.Debug.WriteLine($"Columnas disponibles: {columnas}");
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
                    // Mejorar nombres de columnas y formato
                    switch (column.Name.ToLower())
                    {
                        case "fechaemision":
                        case "fecha_emision":
                            column.HeaderText = "Fecha";
                            column.DefaultCellStyle.Format = "dd/MM/yyyy";
                            column.Width = 100;
                            break;
                        case "numerofactura":
                        case "numero_factura":
                            column.HeaderText = "N° Factura";
                            column.Width = 120;
                            break;
                        case "nombrecompleto":
                        case "nombre_completo":
                            column.HeaderText = "Cliente";
                            column.Width = 200;
                            break;
                        case "total":
                        case "totaltotal":
                            column.HeaderText = "Total";
                            column.DefaultCellStyle.Format = "C2";
                            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            column.Width = 100;
                            break;
                        case "subtotal":
                            column.HeaderText = "Subtotal";
                            column.DefaultCellStyle.Format = "C2";
                            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            column.Width = 100;
                            break;
                        case "impuestos":
                            column.HeaderText = "Impuestos";
                            column.DefaultCellStyle.Format = "C2";
                            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            column.Width = 100;
                            break;
                        case "descuentos":
                            column.HeaderText = "Descuentos";
                            column.DefaultCellStyle.Format = "C2";
                            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            column.Width = 100;
                            break;
                        case "estado":
                            column.HeaderText = "Estado";
                            column.Width = 100;
                            break;
                        case "nombreproducto":
                        case "nombre_producto":
                            column.HeaderText = "Producto";
                            column.Width = 200;
                            break;
                        case "cantidadvendida":
                        case "cantidad_vendida":
                            column.HeaderText = "Cantidad";
                            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            column.Width = 80;
                            break;
                        case "totalventas":
                        case "total_ventas":
                            column.HeaderText = "Total Ventas";
                            column.DefaultCellStyle.Format = "C2";
                            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            column.Width = 120;
                            break;
                        case "promedio":
                        case "preciopromedio":
                        case "precio_promedio":
                            column.HeaderText = "Precio Promedio";
                            column.DefaultCellStyle.Format = "C2";
                            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            column.Width = 120;
                            break;
                        case "periodo":
                            column.HeaderText = "Período";
                            column.Width = 150;
                            break;
                        case "cantidadfacturas":
                            column.HeaderText = "N° Facturas";
                            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            column.Width = 100;
                            break;
                    }
                }

                // Alternar colores de filas
                dgvReporte.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error mejorando presentación de columnas: {ex.Message}");
            }
        }

        private void HabilitarBotonesExportacion(bool habilitar)
        {
            btnExportarPDF.Enabled = habilitar;
            btnExportarExcel.Enabled = habilitar;
            btnExportarWord.Enabled = habilitar;
            btnImprimir.Enabled = habilitar;
        }

        // Event handlers de exportación (mantener la lógica existente)
        private void BtnExportarPDF_Click(object sender, EventArgs e)
        {
            ExportarReporte("PDF", "Archivos PDF|*.pdf");
        }

        private void BtnExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarReporte("Excel", "Archivos CSV|*.csv");
        }

        private void BtnExportarWord_Click(object sender, EventArgs e)
        {
            ExportarReporte("Word", "Archivos TXT|*.txt");
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
                    
                    ExportarDataGridView(dgvReporte, saveDialog.FileName, formato);

                    MessageBox.Show($"Reporte exportado exitosamente a:\n{saveDialog.FileName}", 
                        "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MessageBox.Show("¿Desea abrir el archivo exportado?", "Abrir Archivo", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("notepad.exe", saveDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar a {formato}: " + ex.Message, 
                    "Error de Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportarDataGridView(DataGridView dgv, string fileName, string formato)
        {
            try
            {
                DataTable dt = (DataTable)dgv.DataSource;
                
                if (formato == "Excel")
                {
                    ExportarACSV(dt, fileName.Replace(".csv", ".csv"));
                }
                else if (formato == "PDF")
                {
                    ExportarATexto(dt, fileName.Replace(".pdf", ".txt"));
                }
                else if (formato == "Word")
                {
                    ExportarATexto(dt, fileName.Replace(".txt", ".txt"));
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
            sb.AppendLine("SISTEMA VETERINARIO - REPORTE DE VENTAS");
            sb.AppendLine(new string('=', 60));
            sb.AppendLine($"REPORTE: {tipoReporte}");
            sb.AppendLine($"PERÍODO: {tipoPeriodo}");
            sb.AppendLine($"FECHAS: {fechaInicio:dd/MM/yyyy} - {dtpFechaFin.Value:dd/MM/yyyy}");
            sb.AppendLine($"GENERADO: {DateTime.Now:dd/MM/yyyy HH:mm}");
            sb.AppendLine($"REGISTROS: {dt.Rows.Count}");
            sb.AppendLine(new string('=', 60));
            sb.AppendLine();
            
            // Encabezados
            string[] columnNames = dt.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();
            sb.AppendLine(string.Join("\t", columnNames));
            sb.AppendLine(new string('-', 60));
            
            // Datos
            foreach (DataRow row in dt.Rows)
            {
                string[] fields = row.ItemArray.Select(field => field?.ToString() ?? "").ToArray();
                sb.AppendLine(string.Join("\t", fields));
            }
            
            File.WriteAllText(fileName, sb.ToString());
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReporte == null || dgvReporte.DataSource == null)
                {
                    MessageBox.Show("No hay datos para imprimir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                MessageBox.Show("Funcionalidad de impresión disponible.\n\nPuede:\n1. Seleccionar datos y usar Ctrl+C para copiar\n2. Exportar a PDF/TXT para imprimir desde otro programa", 
                    "Impresión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir: " + ex.Message, 
                    "Error de Impresión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReporte != null)
                {
                    dgvReporte.DataSource = null;
                }
                
                HabilitarBotonesExportacion(false);
                lblResultados.Text = "Seleccione los criterios y genere un reporte";

                // Resetear a valores por defecto
                rbUltimos30Dias.Checked = true;
                cmbTipoReporte.SelectedIndex = 0;
                cmbCategoria.SelectedIndex = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar: " + ex.Message, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}