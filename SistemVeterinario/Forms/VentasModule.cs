using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaNegocio;
using SistemVeterinario.Navigation;
using System.Collections.Generic;

namespace SistemVeterinario.Forms
{
    /// <summary>
    /// Módulo para gestión de ventas/facturas
    /// Incluye listado y mantenimiento (CRUD)
    /// Hereda de BaseModulos para funcionalidad estándar
    /// </summary>
    public partial class VentasModule : BaseModulos
    {
        private bool IsEditing = false;
        private int CurrentFacturaId = 0;

        public VentasModule()
        {
            InitializeComponent();
            ValidarControlesInicializados();
            ConfigurarModulo();
            
            // Configurar validación y estilos modernos después de la inicialización
            this.Load += (s, e) => {
                ConfigurarValidacionEnTiempoReal();
                ConfigurarEstilosModernos();
                ConfigurarEventosPersonalizados();
                ConfigurarBotonesEditables();
            };
            
            // También configurar cuando se cambia a la pestaña de configuración
            if (this.tabControlPrincipal != null)
            {
                this.tabControlPrincipal.SelectedIndexChanged += (s, e) =>
                {
                    if (this.tabControlPrincipal.SelectedTab == this.tabConfiguraciones)
                    {
                        // Pequeño delay para que el tab se renderice completamente
                        var timer = new System.Windows.Forms.Timer();
                        timer.Interval = 50;
                        timer.Tick += (ts, te) =>
                        {
                            timer.Stop();
                            ConfigurarBotonesEditables();
                        };
                        timer.Start();
                    }
                };
            }
        }

        protected override void OnLoad()
        {
            CargarDatosVentas();
        }

        protected override void OnBuscar()
        {
            if (!string.IsNullOrWhiteSpace(txtBuscar?.Text))
            {
                BuscarVentas(txtBuscar.Text);
            }
            else
            {
                CargarDatosVentas();
            }
        }

        protected override void OnNuevo()
        {
            LimpiarFormulario();
            IsEditing = false;
            CurrentFacturaId = 0;
            ConfigurarEstadoBotones(true);
            if (tabControlPrincipal != null)
                tabControlPrincipal.SelectedTab = tabConfiguraciones;
            txtNumeroFactura?.Focus();
        }

        protected override void OnEditar(DataGridViewRow fila)
        {
            if (fila != null)
            {
                CargarDatosParaEdicion(fila);
                IsEditing = true;
                ConfigurarEstadoBotones(true);
                if (tabControlPrincipal != null)
                    tabControlPrincipal.SelectedTab = tabConfiguraciones;
                txtNumeroFactura?.Focus();
            }
        }

        protected override void OnEliminarFila(DataGridViewRow fila)
        {
            if (fila != null)
            {
                if (MessageBox.Show("¿Está seguro de eliminar esta factura?", "Confirmar Eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        MessageBox.Show("Funcionalidad de eliminación - Próximamente", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CargarDatosVentas()
        {
            try
            {
                if (dgvDatos == null)
                {
                    System.Diagnostics.Debug.WriteLine("dgvDatos es null en CargarDatos");
                    return;
                }

                DataTable dt = NVentas.Mostrar();

                if (dt != null && dt.Rows.Count >= 0)
                {
                    dgvDatos.DataSource = dt;
                    PersonalizarColumnasVentas();
                }
                else
                {
                    dgvDatos.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dgvDatos != null)
                    dgvDatos.DataSource = null;
            }
        }

        private void PersonalizarColumnasVentas()
        {
            if (dgvDatos?.DataSource == null) return;

            try
            {
                foreach (DataGridViewColumn column in dgvDatos.Columns)
                {
                    if (column == null || string.IsNullOrEmpty(column.Name))
                        continue;

                    switch (column.Name.ToLower())
                    {
                        case "id":
                            column.HeaderText = "ID";
                            column.Width = 50;
                            break;
                        case "numero_factura":
                            column.HeaderText = "Nº Factura";
                            column.Width = 100;
                            break;
                        case "fecha_emision":
                            column.HeaderText = "Fecha Emisión";
                            column.Width = 100;
                            break;
                        case "fecha_vencimiento":
                            column.HeaderText = "Fecha Vencimiento";
                            column.Width = 120;
                            break;
                        case "cliente":
                            column.HeaderText = "Cliente";
                            column.Width = 200;
                            break;
                        case "subtotal":
                            column.HeaderText = "Subtotal";
                            column.Width = 80;
                            column.DefaultCellStyle.Format = "C2";
                            break;
                        case "impuestos":
                            column.HeaderText = "Impuestos";
                            column.Width = 80;
                            column.DefaultCellStyle.Format = "C2";
                            break;
                        case "descuentos":
                            column.HeaderText = "Descuentos";
                            column.Width = 80;
                            column.DefaultCellStyle.Format = "C2";
                            break;
                        case "total":
                            column.HeaderText = "Total";
                            column.Width = 80;
                            column.DefaultCellStyle.Format = "C2";
                            break;
                        case "estado":
                            column.HeaderText = "Estado";
                            column.Width = 80;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error en PersonalizarColumnas: {ex.Message}");
            }
        }

        private void BuscarVentas(string textoBuscar)
        {
            try
            {
                if (int.TryParse(textoBuscar, out int personaId))
                {
                    DataTable dt = NVentas.BuscarPorPersona(personaId);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        dgvDatos.DataSource = dt;
                        PersonalizarColumnasVentas();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron facturas para esta persona", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDatos.DataSource = null;
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un ID de persona válido para buscar", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarControlesInicializados()
        {
            var controlesRequeridos = new Dictionary<string, Control>
            {
                { "tabControlPrincipal", tabControlPrincipal },
                { "dgvDatos", dgvDatos },
                { "btnNuevo", btnNuevo },
                { "btnGuardar", btnGuardar },
                { "btnCancelar", btnCancelar },
                { "cmbEstado", cmbEstado }
            };

            var controlesNulos = controlesRequeridos.Where(c => c.Value == null).Select(c => c.Key).ToList();

            if (controlesNulos.Any())
            {
                string mensaje = $"Error de Inicialización:\n\nLos siguientes controles no se inicializaron:\n• {string.Join("\n• ", controlesNulos)}\n\nEl formulario puede no funcionar correctamente.";
                MessageBox.Show(mensaje, "Error de Inicialización", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                System.Diagnostics.Debug.WriteLine($"Controles no inicializados: {string.Join(", ", controlesNulos)}");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Todos los controles críticos se inicializaron correctamente");
            }
        }

        private void ConfigurarModulo()
        {
            try
            {
                // Configurar eventos - con validación null
                if (btnNuevo != null) btnNuevo.Click += BtnNuevo_Click;
                if (btnGuardar != null) btnGuardar.Click += BtnGuardar_Click;
                // btnEditar se maneja desde BaseModulos
                if (btnCancelar != null) btnCancelar.Click += BtnCancelar_Click;
                if (btnEliminar != null) btnEliminar.Click += BtnEliminar_Click;
                if (btnBuscar != null) btnBuscar.Click += BtnBuscar_Click;
                if (btnRefrescar != null) btnRefrescar.Click += BtnRefrescar_Click;

                // Eventos del DataGridView - usar dgvDatos del BaseModulos
                if (dgvDatos != null)
                {
                    dgvDatos.SelectionChanged += DgvDatos_SelectionChanged;
                    dgvDatos.CellDoubleClick += DgvDatos_CellDoubleClick;
                }

                // Configurar ComboBox de Estado
                if (cmbEstado != null)
                {
                    cmbEstado.Items.AddRange(new string[] { "Pendiente", "Pagada", "Cancelada", "Anulada" });
                    cmbEstado.SelectedIndex = 0;
                }

                // Configurar fechas
                if (dtpFechaEmision != null) dtpFechaEmision.Value = DateTime.Now;
                if (dtpFechaVencimiento != null) dtpFechaVencimiento.Value = DateTime.Now.AddDays(30);

                // Estado inicial
                LimpiarFormulario();
                ConfigurarEstadoBotones(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al configurar módulo: {ex.Message}\n\nDetalle: {ex.StackTrace}",
                    "Error de Inicialización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Eventos de Botones

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            OnNuevo();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                try
                {
                    string resultado;

                    if (IsEditing)
                    {
                        resultado = NVentas.Editar(
                            CurrentFacturaId,
                            Convert.ToInt32(txtPersonaId.Text),
                            txtNumeroFactura.Text,
                            chkTieneFechaVencimiento.Checked ? dtpFechaVencimiento.Value : (DateTime?)null,
                            txtNotas.Text,
                            txtProductosJson.Text,
                            txtServiciosJson.Text,
                            nudImpuestos.Value,
                            nudDescuentos.Value,
                            cmbEstado.Text,
                            chkFinalizar.Checked
                        );
                    }
                    else
                    {
                        resultado = NVentas.CrearFacturaCompleta(
                            Convert.ToInt32(txtPersonaId.Text),
                            txtNumeroFactura.Text,
                            chkTieneFechaVencimiento.Checked ? dtpFechaVencimiento.Value : (DateTime?)null,
                            txtNotas.Text,
                            txtProductosJson.Text,
                            txtServiciosJson.Text,
                            nudImpuestos.Value,
                            nudDescuentos.Value,
                            chkFinalizar.Checked
                        );
                    }

                    if (resultado == "OK")
                    {
                        MessageBox.Show(IsEditing ? "Factura actualizada exitosamente" : "Factura creada exitosamente",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatosVentas();
                        LimpiarFormulario();
                        ConfigurarEstadoBotones(false);
                        tabControlPrincipal.SelectedTab = tabInicio;
                    }
                    else
                    {
                        MessageBox.Show($"Error: {resultado}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error inesperado: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos?.CurrentRow != null)
            {
                OnEditar(dgvDatos.CurrentRow);
            }
            else
            {
                MessageBox.Show("Seleccione una factura para editar", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cancelar? Se perderán los cambios no guardados.",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpiarFormulario();
                ConfigurarEstadoBotones(false);
                IsEditing = false;
                CurrentFacturaId = 0;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos?.CurrentRow != null)
            {
                OnEliminarFila(dgvDatos.CurrentRow);
            }
            else
            {
                MessageBox.Show("Seleccione una factura para eliminar", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            OnBuscar();
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            CargarDatosVentas();
            if (txtBuscarPersonaId != null) txtBuscarPersonaId.Clear();
        }

        #endregion

        #region Eventos del DataGridView

        private void DgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            bool haySeleccion = dgvDatos?.CurrentRow != null;
            // btnEditar se maneja desde BaseModulos
            if (btnEliminar != null) btnEliminar.Enabled = haySeleccion;
        }

        private void DgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDatos?.Rows[e.RowIndex] != null)
            {
                OnEditar(dgvDatos.Rows[e.RowIndex]);
            }
        }

        #endregion

        #region Métodos Auxiliares


        private void ConfigurarColumnasGrid()
        {
            try
            {
                if (dgvDatos?.DataSource == null || dgvDatos.Columns.Count == 0)
                    return;

                // SOLO configurar encabezados de texto - NADA más
                foreach (DataGridViewColumn column in dgvDatos.Columns)
                {
                    if (column == null || string.IsNullOrEmpty(column.Name))
                        continue;

                    try
                    {
                        // Solo cambiar el texto del header - operación más básica posible
                        switch (column.Name.ToLower())
                        {
                            case "id":
                                column.HeaderText = "ID";
                                break;
                            case "numero_factura":
                                column.HeaderText = "Nº Factura";
                                break;
                            case "fecha_emision":
                                column.HeaderText = "Fecha Emisión";
                                break;
                            case "fecha_vencimiento":
                                column.HeaderText = "Fecha Vencimiento";
                                break;
                            case "cliente":
                                column.HeaderText = "Cliente";
                                break;
                            case "subtotal":
                                column.HeaderText = "Subtotal";
                                break;
                            case "impuestos":
                                column.HeaderText = "Impuestos";
                                break;
                            case "descuentos":
                                column.HeaderText = "Descuentos";
                                break;
                            case "total":
                                column.HeaderText = "Total";
                                break;
                            case "estado":
                                column.HeaderText = "Estado";
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Si falla hasta cambiar el header, solo loggear y continuar
                        System.Diagnostics.Debug.WriteLine($"Error configurando header de columna {column.Name}: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error en ConfigurarColumnasGrid: {ex.Message}");
            }
        }

        private void CargarDatosParaEdicion(DataGridViewRow fila)
        {
            if (fila != null)
            {
                CurrentFacturaId = Convert.ToInt32(fila.Cells["id"].Value);

                // Cargar datos básicos desde el grid
                if (txtNumeroFactura != null)
                    txtNumeroFactura.Text = fila.Cells["numero_factura"].Value?.ToString() ?? "";

                if (dtpFechaEmision != null)
                    dtpFechaEmision.Value = Convert.ToDateTime(fila.Cells["fecha_emision"].Value);

                if (fila.Cells["fecha_vencimiento"].Value != DBNull.Value)
                {
                    if (chkTieneFechaVencimiento != null) chkTieneFechaVencimiento.Checked = true;
                    if (dtpFechaVencimiento != null)
                        dtpFechaVencimiento.Value = Convert.ToDateTime(fila.Cells["fecha_vencimiento"].Value);
                }
                else
                {
                    if (chkTieneFechaVencimiento != null) chkTieneFechaVencimiento.Checked = false;
                }

                if (nudImpuestos != null)
                    nudImpuestos.Value = Convert.ToDecimal(fila.Cells["impuestos"].Value ?? 0);
                if (nudDescuentos != null)
                    nudDescuentos.Value = Convert.ToDecimal(fila.Cells["descuentos"].Value ?? 0);
                if (cmbEstado != null)
                    cmbEstado.Text = fila.Cells["estado"].Value?.ToString() ?? "Pendiente";
                if (txtNotas != null)
                    txtNotas.Text = fila.Cells["notas"].Value?.ToString() ?? "";

                // Para obtener más detalles, deberías hacer una consulta adicional
                // Por ahora asignamos valores por defecto
                if (txtPersonaId != null) txtPersonaId.Text = "1"; // Esto debería venir de la consulta detallada
                if (txtProductosJson != null) txtProductosJson.Text = "";
                if (txtServiciosJson != null) txtServiciosJson.Text = "";
            }
        }

        private new void LimpiarFormulario()
        {
            try
            {
                txtNumeroFactura?.Clear();
                txtPersonaId?.Clear();
                if (dtpFechaEmision != null) dtpFechaEmision.Value = DateTime.Now;
                if (dtpFechaVencimiento != null) dtpFechaVencimiento.Value = DateTime.Now.AddDays(30);
                if (chkTieneFechaVencimiento != null) chkTieneFechaVencimiento.Checked = true;
                if (nudImpuestos != null) nudImpuestos.Value = 0;
                if (nudDescuentos != null) nudDescuentos.Value = 0;
                if (cmbEstado != null) cmbEstado.SelectedIndex = 0;
                txtNotas?.Clear();
                txtProductosJson?.Clear();
                txtServiciosJson?.Clear();
                if (chkFinalizar != null) chkFinalizar.Checked = false;
            }
            catch (Exception ex)
            {
                // Log error but don't show to user - this is cleanup
                System.Diagnostics.Debug.WriteLine($"Error in LimpiarFormulario: {ex.Message}");
            }
        }

        private void ConfigurarEstadoBotones(bool editando)
        {
            try
            {
                if (btnNuevo != null) btnNuevo.Enabled = !editando;
                if (btnGuardar != null) btnGuardar.Enabled = editando;
                if (btnCancelar != null) btnCancelar.Enabled = editando;
                // btnEditar se maneja desde BaseModulos
                if (btnEliminar != null) btnEliminar.Enabled = !editando && dgvDatos?.CurrentRow != null;

                // Habilitar/deshabilitar controles de edición
                if (txtNumeroFactura != null) txtNumeroFactura.Enabled = editando;
                if (txtPersonaId != null) txtPersonaId.Enabled = editando;
                if (dtpFechaEmision != null) dtpFechaEmision.Enabled = editando;
                if (dtpFechaVencimiento != null) dtpFechaVencimiento.Enabled = editando;
                if (chkTieneFechaVencimiento != null) chkTieneFechaVencimiento.Enabled = editando;
                if (nudImpuestos != null) nudImpuestos.Enabled = editando;
                if (nudDescuentos != null) nudDescuentos.Enabled = editando;
                if (cmbEstado != null) cmbEstado.Enabled = editando;
                if (txtNotas != null) txtNotas.Enabled = editando;
                if (txtProductosJson != null) txtProductosJson.Enabled = editando;
                if (txtServiciosJson != null) txtServiciosJson.Enabled = editando;
                if (chkFinalizar != null) chkFinalizar.Enabled = editando;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in ConfigurarEstadoBotones: {ex.Message}");
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNumeroFactura.Text))
            {
                MessageBox.Show("El número de factura es requerido", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroFactura.Focus();
                return false;
            }

            if (!NVentas.ValidarFactura(txtNumeroFactura.Text))
            {
                MessageBox.Show("El número de factura no tiene un formato válido", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroFactura.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtClienteSeleccionado.Text))
            {
                MessageBox.Show("Debe seleccionar un cliente para la factura", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSeleccionarCliente.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Configura eventos personalizados para los controles específicos de ventas
        /// </summary>
        private void ConfigurarEventosPersonalizados()
        {
            // Configurar eventos del botón limpiar filtros
            if (btnLimpiarFiltros != null)
            {
                btnLimpiarFiltros.Click += btnLimpiarFiltros_Click;
            }

            // Configurar eventos del botón generar número
            if (btnGenerarNumero != null)
            {
                btnGenerarNumero.Click += (s, e) => GenerarNumeroFactura();
            }

            // Configurar eventos del botón seleccionar cliente
            if (btnSeleccionarCliente != null)
            {
                btnSeleccionarCliente.Click += (s, e) => SeleccionarCliente();
            }

            // Configurar eventos de los botones agregar productos y servicios
            if (btnAgregarProductos != null)
            {
                btnAgregarProductos.Click += (s, e) => AgregarProductos();
            }

            if (btnAgregarServicios != null)
            {
                btnAgregarServicios.Click += (s, e) => AgregarServicios();
            }

            // Configurar filtrado por estado
            if (cmbEstadoFiltro != null)
            {
                cmbEstadoFiltro.SelectedIndexChanged += (s, e) => FiltrarPorEstado();
            }

            // Configurar búsqueda en tiempo real
            if (txtBuscarCliente != null)
            {
                txtBuscarCliente.TextChanged += (s, e) => {
                    if (txtBuscarCliente.Text.Length >= 3)
                    {
                        BuscarClientesEnTiempoReal();
                    }
                };
            }
        }

        /// <summary>
        /// Genera un número de factura automáticamente
        /// </summary>
        private void GenerarNumeroFactura()
        {
            if (txtNumeroFactura != null)
            {
                string numeroGenerado = "F" + DateTime.Now.ToString("yyyyMMddHHmmss");
                txtNumeroFactura.Text = numeroGenerado;
            }
        }

        /// <summary>
        /// Abre el diálogo para seleccionar un cliente
        /// </summary>
        private void SeleccionarCliente()
        {
            try
            {
                // Aquí se abriría el diálogo de selección de cliente
                MessageBox.Show("Funcionalidad de selección de cliente en desarrollo", 
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar cliente: {ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Abre el diálogo para agregar productos
        /// </summary>
        private void AgregarProductos()
        {
            try
            {
                // Aquí se abriría el diálogo de selección de productos
                MessageBox.Show("Funcionalidad de agregar productos en desarrollo", 
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar productos: {ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Abre el diálogo para agregar servicios
        /// </summary>
        private void AgregarServicios()
        {
            try
            {
                // Aquí se abriría el diálogo de selección de servicios
                MessageBox.Show("Funcionalidad de agregar servicios en desarrollo", 
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar servicios: {ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Realiza búsqueda de clientes en tiempo real
        /// </summary>
        private void BuscarClientesEnTiempoReal()
        {
            if (txtBuscarCliente == null) return;

            try
            {
                string terminoBusqueda = txtBuscarCliente.Text;
                // Aquí se implementaría la búsqueda en tiempo real
                // Por ahora solo actualiza el contador
                if (lblTotalRegistros != null)
                {
                    lblTotalRegistros.Text = $"Buscando: {terminoBusqueda}...";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en búsqueda en tiempo real: {ex.Message}");
            }
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }

        #endregion

        #region Configuración de Botones

        private void ConfigurarBotonesEditables()
        {
            // Asegurar que tenemos acceso a los botones a través de la base
            if (this.btnEliminar == null || this.btnCancelar == null || this.btnGuardar == null)
                return;

            // Usar un Timer para configurar después de que la UI se haya cargado completamente
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // 100ms delay
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                
                try
                {
                    // Configurar propiedades básicas primero
                    var buttonWidth = 100;
                    var buttonHeight = 35;
                    var spacing = 15;
                    
                    // Asegurar que los botones estén en el tab correcto
                    if (this.tabConfiguraciones != null)
                    {
                        // Remover de cualquier contenedor anterior
                        if (this.btnEliminar.Parent != this.tabConfiguraciones)
                            this.tabConfiguraciones.Controls.Add(this.btnEliminar);
                        if (this.btnCancelar.Parent != this.tabConfiguraciones)
                            this.tabConfiguraciones.Controls.Add(this.btnCancelar);
                        if (this.btnGuardar.Parent != this.tabConfiguraciones)
                            this.tabConfiguraciones.Controls.Add(this.btnGuardar);
                        
                        var tabWidth = this.tabConfiguraciones.ClientSize.Width;
                        var tabHeight = this.tabConfiguraciones.ClientSize.Height;
                        
                        // Calcular posición centrada más robusta
                        var totalWidth = (buttonWidth * 3) + (spacing * 2);
                        var startX = Math.Max(10, (tabWidth - totalWidth) / 2);
                        var buttonY = Math.Max(10, tabHeight - 60); // 60px desde el bottom
                        
                        // Configurar btnEliminar
                        this.btnEliminar.Size = new Size(buttonWidth, buttonHeight);
                        this.btnEliminar.Location = new Point(startX, buttonY);
                        this.btnEliminar.Visible = true;
                        this.btnEliminar.Enabled = true;
                        this.btnEliminar.BringToFront();
                        this.btnEliminar.TabIndex = 0;
                        
                        // Configurar btnCancelar
                        this.btnCancelar.Size = new Size(buttonWidth, buttonHeight);
                        this.btnCancelar.Location = new Point(startX + buttonWidth + spacing, buttonY);
                        this.btnCancelar.Visible = true;
                        this.btnCancelar.Enabled = true;
                        this.btnCancelar.BringToFront();
                        this.btnCancelar.TabIndex = 1;
                        
                        // Configurar btnGuardar
                        this.btnGuardar.Size = new Size(buttonWidth, buttonHeight);
                        this.btnGuardar.Location = new Point(startX + (buttonWidth + spacing) * 2, buttonY);
                        this.btnGuardar.Visible = true;
                        this.btnGuardar.Enabled = true;
                        this.btnGuardar.BringToFront();
                        this.btnGuardar.TabIndex = 2;
                        
                        // Forzar actualización
                        this.tabConfiguraciones.Refresh();
                    }
                }
                catch (Exception)
                {
                    // Si hay algún error, al menos hacer los botones visibles
                    this.btnEliminar.Visible = true;
                    this.btnCancelar.Visible = true;
                    this.btnGuardar.Visible = true;
                }
            };
            timer.Start();
        }

        #endregion

        #region Validación y Estilos Modernos

        /// <summary>
        /// Configura la validación en tiempo real para los controles del formulario
        /// </summary>
        private void ConfigurarValidacionEnTiempoReal()
        {
            // Validación para número de factura
            if (txtNumeroFactura != null)
            {
                txtNumeroFactura.Leave += (s, e) => ValidarNumeroFactura();
                txtNumeroFactura.TextChanged += (s, e) => {
                    if (txtNumeroFactura.Text.Length > 20)
                    {
                        txtNumeroFactura.BackColor = Color.FromArgb(255, 235, 235);
                    }
                    else
                    {
                        txtNumeroFactura.BackColor = Color.White;
                    }
                };
            }

            // Validación para cliente seleccionado
            if (txtClienteSeleccionado != null)
            {
                txtClienteSeleccionado.Leave += (s, e) => ValidarClienteSeleccionado();
            }

            // Validación para fechas
            if (dtpFechaEmision != null && dtpFechaVencimiento != null)
            {
                dtpFechaEmision.ValueChanged += (s, e) => ValidarFechas();
                dtpFechaVencimiento.ValueChanged += (s, e) => ValidarFechas();
            }

            // Validación para montos
            if (nudImpuestos != null)
            {
                nudImpuestos.ValueChanged += (s, e) => CalcularTotal();
            }

            if (nudDescuentos != null)
            {
                nudDescuentos.ValueChanged += (s, e) => CalcularTotal();
            }
        }

        /// <summary>
        /// Configura los estilos modernos para todos los controles
        /// </summary>
        private void ConfigurarEstilosModernos()
        {
            // Aplicar estilos a los controles de búsqueda
            AplicarEstiloModerno(txtBuscarCliente, "Buscar por nombre, cédula, teléfono...");
            AplicarEstiloCombo(cmbEstadoFiltro);

            // Aplicar estilos a los controles del formulario principal
            AplicarEstiloModerno(txtNumeroFactura, "Número de factura");
            AplicarEstiloModerno(txtClienteSeleccionado, "Cliente seleccionado");
            AplicarEstiloModerno(txtNotas, "Observaciones adicionales...");
            
            AplicarEstiloCombo(cmbEstado);
            AplicarEstiloNumerico(nudSubtotal);
            AplicarEstiloNumerico(nudImpuestos);
            AplicarEstiloNumerico(nudDescuentos);
            AplicarEstiloNumerico(nudTotal);

            // Configurar DataGridView
            ConfigurarDataGridViewModerno(dgvItems);
        }

        /// <summary>
        /// Aplica estilo moderno a un TextBox
        /// </summary>
        private void AplicarEstiloModerno(TextBox textBox, string placeholder = "")
        {
            if (textBox == null) return;

            textBox.Font = new Font("Segoe UI", 10F);
            textBox.ForeColor = Color.FromArgb(44, 62, 80);
            textBox.BackColor = Color.White;
            textBox.BorderStyle = BorderStyle.FixedSingle;

            if (!string.IsNullOrEmpty(placeholder))
            {
                // Placeholder personalizado para .NET Framework
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
                
                textBox.Enter += (s, e) => {
                    if (textBox.Text == placeholder)
                    {
                        textBox.Text = "";
                        textBox.ForeColor = Color.FromArgb(44, 62, 80);
                    }
                    textBox.BackColor = Color.FromArgb(240, 248, 255);
                };

                textBox.Leave += (s, e) => {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        textBox.Text = placeholder;
                        textBox.ForeColor = Color.Gray;
                    }
                    textBox.BackColor = Color.White;
                };
            }
            else
            {
                // Efectos de hover y focus sin placeholder
                textBox.Enter += (s, e) => {
                    textBox.BackColor = Color.FromArgb(240, 248, 255);
                };

                textBox.Leave += (s, e) => {
                    textBox.BackColor = Color.White;
                };
            }
        }

        /// <summary>
        /// Aplica estilo moderno a un ComboBox
        /// </summary>
        private void AplicarEstiloCombo(ComboBox comboBox)
        {
            if (comboBox == null) return;

            comboBox.Font = new Font("Segoe UI", 10F);
            comboBox.ForeColor = Color.FromArgb(44, 62, 80);
            comboBox.BackColor = Color.White;
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Aplica estilo moderno a un NumericUpDown
        /// </summary>
        private void AplicarEstiloNumerico(NumericUpDown numericUpDown)
        {
            if (numericUpDown == null) return;

            numericUpDown.Font = new Font("Segoe UI", 10F);
            numericUpDown.ForeColor = Color.FromArgb(44, 62, 80);
            numericUpDown.BackColor = Color.White;
            numericUpDown.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown.TextAlign = HorizontalAlignment.Right;
            numericUpDown.DecimalPlaces = 2;
        }

        /// <summary>
        /// Configura el DataGridView con estilo moderno
        /// </summary>
        private void ConfigurarDataGridViewModerno(DataGridView dataGridView)
        {
            if (dataGridView == null) return;

            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.FixedSingle;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.EnableHeadersVisualStyles = false;

            // Estilo de las cabeceras
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 73, 94);

            // Estilo de las filas
            dataGridView.DefaultCellStyle.BackColor = Color.White;
            dataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80);
            dataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;

            // Configuración general
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Valida el número de factura
        /// </summary>
        private bool ValidarNumeroFactura()
        {
            if (txtNumeroFactura == null) return true;

            if (string.IsNullOrWhiteSpace(txtNumeroFactura.Text))
            {
                MostrarValidacion(txtNumeroFactura, "El número de factura es requerido", false);
                return false;
            }

            if (txtNumeroFactura.Text.Length > 20)
            {
                MostrarValidacion(txtNumeroFactura, "El número de factura no puede exceder 20 caracteres", false);
                return false;
            }

            MostrarValidacion(txtNumeroFactura, "", true);
            return true;
        }

        /// <summary>
        /// Valida que se haya seleccionado un cliente
        /// </summary>
        private bool ValidarClienteSeleccionado()
        {
            if (txtClienteSeleccionado == null) return true;

            if (string.IsNullOrWhiteSpace(txtClienteSeleccionado.Text))
            {
                MostrarValidacion(txtClienteSeleccionado, "Debe seleccionar un cliente", false);
                return false;
            }

            MostrarValidacion(txtClienteSeleccionado, "", true);
            return true;
        }

        /// <summary>
        /// Valida las fechas de emisión y vencimiento
        /// </summary>
        private bool ValidarFechas()
        {
            if (dtpFechaEmision == null || dtpFechaVencimiento == null) return true;

            if (dtpFechaVencimiento.Value < dtpFechaEmision.Value)
            {
                MessageBox.Show("La fecha de vencimiento no puede ser anterior a la fecha de emisión",
                    "Validación de Fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Calcula el total basado en subtotal, impuestos y descuentos
        /// </summary>
        private void CalcularTotal()
        {
            if (nudSubtotal == null || nudImpuestos == null || nudDescuentos == null || nudTotal == null) return;

            decimal subtotal = nudSubtotal.Value;
            decimal impuestos = nudImpuestos.Value;
            decimal descuentos = nudDescuentos.Value;

            decimal total = subtotal + impuestos - descuentos;
            nudTotal.Value = Math.Max(0, total);
        }

        /// <summary>
        /// Muestra indicadores visuales de validación
        /// </summary>
        private void MostrarValidacion(Control control, string mensaje, bool esValido)
        {
            if (control == null) return;

            if (esValido)
            {
                control.BackColor = Color.White;
                // Remover tooltip si existe
            }
            else
            {
                control.BackColor = Color.FromArgb(255, 235, 235);
                // Mostrar tooltip con el mensaje si se implementa
            }
        }

        /// <summary>
        /// Limpia todos los filtros aplicados
        /// </summary>
        private void LimpiarFiltros()
        {
            if (txtBuscarCliente != null) txtBuscarCliente.Clear();
            if (cmbEstadoFiltro != null) cmbEstadoFiltro.SelectedIndex = -1;

            // Recargar datos sin filtros
            CargarDatosVentas();
        }

        /// <summary>
        /// Filtra las ventas por estado
        /// </summary>
        private void FiltrarPorEstado()
        {
            if (cmbEstadoFiltro == null || cmbEstadoFiltro.SelectedIndex == -1) return;

            string estadoSeleccionado = cmbEstadoFiltro.SelectedItem.ToString();
            // Implementar filtrado por estado
        }

        #endregion

        // UserControls no manejan FormClosing, se puede implementar en eventos del Dashboard si es necesario
    }
}