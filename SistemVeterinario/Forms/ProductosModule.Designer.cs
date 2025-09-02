using System.Windows.Forms;
using System.Drawing;
namespace SistemVeterinario.Forms
{
    partial class ProductosModule
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controles específicos de productos
        private Label lblContador;
        private ComboBox cmbCategoriaFiltro;
        private Label lblCategoriaFiltro;
        private GroupBox grpDatosProducto;
        private TableLayoutPanel tableLayoutProducto;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Button btnGenerarCodigo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private Button btnNuevaCategoria;
        private Label lblPrecio;
        private NumericUpDown nudPrecio;
        private Label lblStockMinimo;
        private NumericUpDown nudStockMinimo;
        private Label lblStockActual;
        private NumericUpDown nudStockActual;
        private CheckBox chkRequiereReceta;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Button btnStockBajo;
        
        // Controls for Category Configuration
        private GroupBox grpGestionCategorias;
        private DataGridView dgvCategorias;
        private GroupBox grpFormCategoria;
        private Label lblNombreCategoria;
        private TextBox txtNombreCategoria;
        private Label lblDescripcionCategoria;
        private TextBox txtDescripcionCategoria;
        private Button btnNuevaConfigCat;
        private Button btnGuardarCategoria;
        private Button btnEditarCategoria;
        private Button btnEliminarCategoria;
        private Button btnCancelarCategoria;
        private Button btnInicializarCategorias;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private new void InitializeComponent()
        {
            this.lblContador = new System.Windows.Forms.Label();
            this.cmbCategoriaFiltro = new System.Windows.Forms.ComboBox();
            this.lblCategoriaFiltro = new System.Windows.Forms.Label();
            this.grpDatosProducto = new System.Windows.Forms.GroupBox();
            this.tableLayoutProducto = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnGenerarCodigo = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.chkRequiereReceta = new System.Windows.Forms.CheckBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnNuevaCategoria = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.nudStockMinimo = new System.Windows.Forms.NumericUpDown();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.nudStockActual = new System.Windows.Forms.NumericUpDown();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnStockBajo = new System.Windows.Forms.Button();
            this.tabControlPrincipal.SuspendLayout();
            this.tabInicio.SuspendLayout();
            this.tabConfiguraciones.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.panelFormulario.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.grpDatosProducto.SuspendLayout();
            this.tableLayoutProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockActual)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Size = new System.Drawing.Size(1306, 682);
            // 
            // tabInicio
            // 
            this.tabInicio.Location = new System.Drawing.Point(4, 39);
            this.tabInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicio.Size = new System.Drawing.Size(1298, 639);
            this.tabInicio.Text = "Gestión de Productos";
            // 
            // tabConfiguraciones
            // 
            this.tabConfiguraciones.Location = new System.Drawing.Point(4, 39);
            this.tabConfiguraciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfiguraciones.Size = new System.Drawing.Size(1298, 639);
            this.tabConfiguraciones.Text = "Configuración de Producto";
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Controls.Add(this.lblContador);
            this.panelBusqueda.Controls.Add(this.lblCategoriaFiltro);
            this.panelBusqueda.Controls.Add(this.cmbCategoriaFiltro);
            this.panelBusqueda.Controls.Add(this.btnStockBajo);
            this.panelBusqueda.Location = new System.Drawing.Point(18, 11);
            this.panelBusqueda.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.panelBusqueda.Padding = new System.Windows.Forms.Padding(17, 13, 17, 13);
            this.panelBusqueda.Size = new System.Drawing.Size(1280, 113);
            this.panelBusqueda.Controls.SetChildIndex(this.btnStockBajo, 0);
            this.panelBusqueda.Controls.SetChildIndex(this.cmbCategoriaFiltro, 0);
            this.panelBusqueda.Controls.SetChildIndex(this.lblCategoriaFiltro, 0);
            this.panelBusqueda.Controls.SetChildIndex(this.lblContador, 0);
            this.panelBusqueda.Controls.SetChildIndex(this.chkMostrarTodo, 0);
            this.panelBusqueda.Controls.SetChildIndex(this.btnNuevo, 0);
            this.panelBusqueda.Controls.SetChildIndex(this.btnBuscar, 0);
            this.panelBusqueda.Controls.SetChildIndex(this.txtBuscar, 0);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(22, 9);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBuscar.Size = new System.Drawing.Size(308, 32);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Location = new System.Drawing.Point(372, 8);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBuscar.Size = new System.Drawing.Size(120, 41);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.Location = new System.Drawing.Point(1074, 9);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNuevo.Size = new System.Drawing.Size(140, 40);
            this.btnNuevo.Text = "➕ Nuevo Producto";
            // 
            // chkMostrarTodo
            // 
            this.chkMostrarTodo.Location = new System.Drawing.Point(49, 49);
            this.chkMostrarTodo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            // 
            // panelFormulario
            // 
            this.panelFormulario.Controls.Add(this.grpDatosProducto);
            this.panelFormulario.Location = new System.Drawing.Point(3, 3);
            this.panelFormulario.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.panelFormulario.Size = new System.Drawing.Size(1292, 633);
            this.panelFormulario.Controls.SetChildIndex(this.grpDatosProducto, 0);
            this.panelFormulario.Controls.SetChildIndex(this.panelBotones, 0);
            this.panelFormulario.Controls.SetChildIndex(this.panelSuperior, 0);
            // 
            // panelSuperior
            // 
            this.panelSuperior.Location = new System.Drawing.Point(13, 11);
            this.panelSuperior.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.panelSuperior.Size = new System.Drawing.Size(2745, 64);
            // 
            // lblModo
            // 
            this.lblModo.Location = new System.Drawing.Point(35, 22);
            // 
            // cmbModo
            // 
            this.cmbModo.Location = new System.Drawing.Point(145, 17);
            this.cmbModo.Size = new System.Drawing.Size(156, 31);
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(392, 17);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(452, 14);
            this.txtId.Size = new System.Drawing.Size(129, 30);
            // 
            // panelBotones
            // 
            this.panelBotones.Location = new System.Drawing.Point(100, 1025);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBotones.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.panelBotones.Size = new System.Drawing.Size(2051, 52);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Location = new System.Drawing.Point(1914, 12);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Location = new System.Drawing.Point(1731, 12);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Location = new System.Drawing.Point(18, 12);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // lblContador
            // 
            this.lblContador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblContador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblContador.Location = new System.Drawing.Point(1046, 53);
            this.lblContador.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(169, 23);
            this.lblContador.TabIndex = 0;
            this.lblContador.Text = "Total de registros: 0";
            // 
            // cmbCategoriaFiltro
            // 
            this.cmbCategoriaFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategoriaFiltro.BackColor = System.Drawing.Color.White;
            this.cmbCategoriaFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoriaFiltro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategoriaFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cmbCategoriaFiltro.Location = new System.Drawing.Point(763, 39);
            this.cmbCategoriaFiltro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbCategoriaFiltro.Name = "cmbCategoriaFiltro";
            this.cmbCategoriaFiltro.Size = new System.Drawing.Size(180, 31);
            this.cmbCategoriaFiltro.TabIndex = 4;
            // 
            // lblCategoriaFiltro
            // 
            this.lblCategoriaFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoriaFiltro.AutoSize = true;
            this.lblCategoriaFiltro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategoriaFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblCategoriaFiltro.Location = new System.Drawing.Point(794, 6);
            this.lblCategoriaFiltro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblCategoriaFiltro.Name = "lblCategoriaFiltro";
            this.lblCategoriaFiltro.Size = new System.Drawing.Size(117, 23);
            this.lblCategoriaFiltro.TabIndex = 5;
            this.lblCategoriaFiltro.Text = "🏷️ Categoría";
            // 
            // grpDatosProducto
            // 
            this.grpDatosProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDatosProducto.Controls.Add(this.tableLayoutProducto);
            this.grpDatosProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpDatosProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpDatosProducto.Location = new System.Drawing.Point(50, 92);
            this.grpDatosProducto.Margin = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.grpDatosProducto.Name = "grpDatosProducto";
            this.grpDatosProducto.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.grpDatosProducto.Size = new System.Drawing.Size(1200, 440);
            this.grpDatosProducto.TabIndex = 0;
            this.grpDatosProducto.TabStop = false;
            this.grpDatosProducto.Text = "📦 Datos del Producto";
            // 
            // tableLayoutProducto
            // 
            this.tableLayoutProducto.ColumnCount = 6;
            this.tableLayoutProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutProducto.Controls.Add(this.lblCodigo, 0, 0);
            this.tableLayoutProducto.Controls.Add(this.txtCodigo, 1, 0);
            this.tableLayoutProducto.Controls.Add(this.btnGenerarCodigo, 2, 0);
            this.tableLayoutProducto.Controls.Add(this.lblNombre, 3, 0);
            this.tableLayoutProducto.Controls.Add(this.txtNombre, 4, 0);
            this.tableLayoutProducto.Controls.Add(this.chkRequiereReceta, 5, 0);
            this.tableLayoutProducto.Controls.Add(this.lblCategoria, 0, 1);
            this.tableLayoutProducto.Controls.Add(this.cmbCategoria, 1, 1);
            this.tableLayoutProducto.Controls.Add(this.btnNuevaCategoria, 2, 1);
            this.tableLayoutProducto.Controls.Add(this.lblPrecio, 3, 1);
            this.tableLayoutProducto.Controls.Add(this.nudPrecio, 4, 1);
            this.tableLayoutProducto.Controls.Add(this.lblStockMinimo, 0, 2);
            this.tableLayoutProducto.Controls.Add(this.nudStockMinimo, 1, 2);
            this.tableLayoutProducto.Controls.Add(this.lblStockActual, 3, 2);
            this.tableLayoutProducto.Controls.Add(this.nudStockActual, 4, 2);
            this.tableLayoutProducto.Controls.Add(this.lblDescripcion, 0, 3);
            this.tableLayoutProducto.Controls.Add(this.txtDescripcion, 0, 4);
            this.tableLayoutProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutProducto.Location = new System.Drawing.Point(20, 43);
            this.tableLayoutProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutProducto.Name = "tableLayoutProducto";
            this.tableLayoutProducto.RowCount = 5;
            this.tableLayoutProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutProducto.Size = new System.Drawing.Size(1160, 381);
            this.tableLayoutProducto.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblCodigo.Location = new System.Drawing.Point(3, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(168, 48);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "🏷️ Código:";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtCodigo.Location = new System.Drawing.Point(177, 8);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 10, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(219, 32);
            this.txtCodigo.TabIndex = 1;
            // 
            // btnGenerarCodigo
            // 
            this.btnGenerarCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnGenerarCodigo.FlatAppearance.BorderSize = 0;
            this.btnGenerarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerarCodigo.ForeColor = System.Drawing.Color.White;
            this.btnGenerarCodigo.Location = new System.Drawing.Point(409, 6);
            this.btnGenerarCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarCodigo.Name = "btnGenerarCodigo";
            this.btnGenerarCodigo.Size = new System.Drawing.Size(110, 36);
            this.btnGenerarCodigo.TabIndex = 2;
            this.btnGenerarCodigo.Text = "🎲 Generar";
            this.btnGenerarCodigo.UseVisualStyleBackColor = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblNombre.Location = new System.Drawing.Point(525, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(168, 48);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "📝 Nombre *:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtNombre.Location = new System.Drawing.Point(699, 8);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 10, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(277, 32);
            this.txtNombre.TabIndex = 4;
            // 
            // chkRequiereReceta
            // 
            this.chkRequiereReceta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRequiereReceta.AutoSize = true;
            this.chkRequiereReceta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.chkRequiereReceta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.chkRequiereReceta.Location = new System.Drawing.Point(989, 10);
            this.chkRequiereReceta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkRequiereReceta.Name = "chkRequiereReceta";
            this.chkRequiereReceta.Size = new System.Drawing.Size(168, 27);
            this.chkRequiereReceta.TabIndex = 5;
            this.chkRequiereReceta.Text = "💊 Requiere Receta";
            this.chkRequiereReceta.UseVisualStyleBackColor = true;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblCategoria.Location = new System.Drawing.Point(3, 48);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(168, 48);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "🏷️ Categoría *:";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategoria.BackColor = System.Drawing.Color.White;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(177, 55);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 10, 2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(219, 33);
            this.cmbCategoria.TabIndex = 7;
            // 
            // btnNuevaCategoria
            // 
            this.btnNuevaCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnNuevaCategoria.FlatAppearance.BorderSize = 0;
            this.btnNuevaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevaCategoria.ForeColor = System.Drawing.Color.White;
            this.btnNuevaCategoria.Location = new System.Drawing.Point(409, 54);
            this.btnNuevaCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevaCategoria.Name = "btnNuevaCategoria";
            this.btnNuevaCategoria.Size = new System.Drawing.Size(110, 36);
            this.btnNuevaCategoria.TabIndex = 8;
            this.btnNuevaCategoria.Text = "➕ Nueva";
            this.btnNuevaCategoria.UseVisualStyleBackColor = false;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblPrecio.Location = new System.Drawing.Point(525, 48);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(168, 48);
            this.lblPrecio.TabIndex = 9;
            this.lblPrecio.Text = "💰 Precio *:";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudPrecio
            // 
            this.nudPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPrecio.BackColor = System.Drawing.Color.White;
            this.nudPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nudPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.nudPrecio.Location = new System.Drawing.Point(699, 56);
            this.nudPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 10, 2);
            this.nudPrecio.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
            this.nudPrecio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(277, 32);
            this.nudPrecio.TabIndex = 10;
            this.nudPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStockMinimo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStockMinimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblStockMinimo.Location = new System.Drawing.Point(3, 96);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(168, 48);
            this.lblStockMinimo.TabIndex = 11;
            this.lblStockMinimo.Text = "📉 Stock Mínimo:";
            this.lblStockMinimo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudStockMinimo
            // 
            this.nudStockMinimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudStockMinimo.BackColor = System.Drawing.Color.White;
            this.nudStockMinimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudStockMinimo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nudStockMinimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.nudStockMinimo.Location = new System.Drawing.Point(177, 104);
            this.nudStockMinimo.Margin = new System.Windows.Forms.Padding(3, 2, 10, 2);
            this.nudStockMinimo.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudStockMinimo.Name = "nudStockMinimo";
            this.nudStockMinimo.Size = new System.Drawing.Size(219, 32);
            this.nudStockMinimo.TabIndex = 12;
            this.nudStockMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudStockMinimo.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblStockActual
            // 
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStockActual.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStockActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblStockActual.Location = new System.Drawing.Point(525, 96);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(168, 48);
            this.lblStockActual.TabIndex = 13;
            this.lblStockActual.Text = "📊 Stock Actual:";
            this.lblStockActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudStockActual
            // 
            this.nudStockActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudStockActual.BackColor = System.Drawing.Color.White;
            this.nudStockActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudStockActual.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nudStockActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.nudStockActual.Location = new System.Drawing.Point(699, 104);
            this.nudStockActual.Margin = new System.Windows.Forms.Padding(3, 2, 10, 2);
            this.nudStockActual.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudStockActual.Name = "nudStockActual";
            this.nudStockActual.Size = new System.Drawing.Size(277, 32);
            this.nudStockActual.TabIndex = 14;
            this.nudStockActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblDescripcion.Location = new System.Drawing.Point(3, 144);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(168, 32);
            this.lblDescripcion.TabIndex = 15;
            this.lblDescripcion.Text = "📝 Descripción:";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescripcion
            // 
            this.tableLayoutProducto.SetColumnSpan(this.txtDescripcion, 6);
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtDescripcion.Location = new System.Drawing.Point(3, 178);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(1154, 201);
            this.txtDescripcion.TabIndex = 16;
            // 
            // btnStockBajo
            // 
            this.btnStockBajo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStockBajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnStockBajo.FlatAppearance.BorderSize = 0;
            this.btnStockBajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockBajo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStockBajo.ForeColor = System.Drawing.Color.White;
            this.btnStockBajo.Location = new System.Drawing.Point(538, 8);
            this.btnStockBajo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnStockBajo.Name = "btnStockBajo";
            this.btnStockBajo.Size = new System.Drawing.Size(140, 41);
            this.btnStockBajo.TabIndex = 6;
            this.btnStockBajo.Text = "⚠️ Stock Bajo";
            this.btnStockBajo.UseVisualStyleBackColor = false;
            // 
            // grpGestionCategorias
            // 
            grpGestionCategorias.Controls.Add(dgvCategorias);
            grpGestionCategorias.Controls.Add(grpFormCategoria);
            grpGestionCategorias.Controls.Add(btnNuevaConfigCat);
            grpGestionCategorias.Controls.Add(btnEditarCategoria);
            grpGestionCategorias.Controls.Add(btnEliminarCategoria);
            grpGestionCategorias.Controls.Add(btnInicializarCategorias);
            grpGestionCategorias.Dock = DockStyle.Fill;
            grpGestionCategorias.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpGestionCategorias.ForeColor = Color.DarkBlue;
            grpGestionCategorias.Location = new Point(3, 2);
            grpGestionCategorias.Name = "grpGestionCategorias";
            grpGestionCategorias.Size = new Size(861, 418);
            grpGestionCategorias.TabIndex = 0;
            grpGestionCategorias.TabStop = false;
            grpGestionCategorias.Text = "Gestión de Categorías de Productos";
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(15, 60);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(500, 300);
            dgvCategorias.TabIndex = 0;
            // 
            // grpFormCategoria
            // 
            grpFormCategoria.Controls.Add(lblNombreCategoria);
            grpFormCategoria.Controls.Add(txtNombreCategoria);
            grpFormCategoria.Controls.Add(lblDescripcionCategoria);
            grpFormCategoria.Controls.Add(txtDescripcionCategoria);
            grpFormCategoria.Controls.Add(btnGuardarCategoria);
            grpFormCategoria.Controls.Add(btnCancelarCategoria);
            grpFormCategoria.Font = new Font("Segoe UI", 9F);
            grpFormCategoria.ForeColor = Color.DarkGreen;
            grpFormCategoria.Location = new Point(530, 60);
            grpFormCategoria.Name = "grpFormCategoria";
            grpFormCategoria.Size = new Size(320, 220);
            grpFormCategoria.TabIndex = 1;
            grpFormCategoria.TabStop = false;
            grpFormCategoria.Text = "Datos de Categoría";
            // 
            // lblNombreCategoria
            // 
            lblNombreCategoria.AutoSize = true;
            lblNombreCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombreCategoria.ForeColor = Color.DarkRed;
            lblNombreCategoria.Location = new Point(15, 30);
            lblNombreCategoria.Name = "lblNombreCategoria";
            lblNombreCategoria.Size = new Size(62, 15);
            lblNombreCategoria.TabIndex = 0;
            lblNombreCategoria.Text = "Nombre *:";
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(15, 48);
            txtNombreCategoria.MaxLength = 100;
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(290, 23);
            txtNombreCategoria.TabIndex = 1;
            // 
            // lblDescripcionCategoria
            // 
            lblDescripcionCategoria.AutoSize = true;
            lblDescripcionCategoria.Location = new Point(15, 85);
            lblDescripcionCategoria.Name = "lblDescripcionCategoria";
            lblDescripcionCategoria.Size = new Size(72, 15);
            lblDescripcionCategoria.TabIndex = 2;
            lblDescripcionCategoria.Text = "Descripción:";
            // 
            // txtDescripcionCategoria
            // 
            txtDescripcionCategoria.Location = new Point(15, 103);
            txtDescripcionCategoria.MaxLength = 500;
            txtDescripcionCategoria.Multiline = true;
            txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            txtDescripcionCategoria.ScrollBars = ScrollBars.Vertical;
            txtDescripcionCategoria.Size = new Size(290, 80);
            txtDescripcionCategoria.TabIndex = 3;
            // 
            // btnGuardarCategoria
            // 
            btnGuardarCategoria.BackColor = Color.Green;
            btnGuardarCategoria.ForeColor = Color.White;
            btnGuardarCategoria.Location = new Point(130, 190);
            btnGuardarCategoria.Name = "btnGuardarCategoria";
            btnGuardarCategoria.Size = new Size(80, 25);
            btnGuardarCategoria.TabIndex = 4;
            btnGuardarCategoria.Text = "Guardar";
            btnGuardarCategoria.UseVisualStyleBackColor = false;
            // 
            // btnCancelarCategoria
            // 
            btnCancelarCategoria.BackColor = Color.Gray;
            btnCancelarCategoria.ForeColor = Color.White;
            btnCancelarCategoria.Location = new Point(220, 190);
            btnCancelarCategoria.Name = "btnCancelarCategoria";
            btnCancelarCategoria.Size = new Size(80, 25);
            btnCancelarCategoria.TabIndex = 5;
            btnCancelarCategoria.Text = "Cancelar";
            btnCancelarCategoria.UseVisualStyleBackColor = false;
            // 
            // btnNuevaConfigCat
            // 
            btnNuevaConfigCat.BackColor = Color.Blue;
            btnNuevaConfigCat.ForeColor = Color.White;
            btnNuevaConfigCat.Location = new Point(15, 25);
            btnNuevaConfigCat.Name = "btnNuevaConfigCat";
            btnNuevaConfigCat.Size = new Size(80, 30);
            btnNuevaConfigCat.TabIndex = 2;
            btnNuevaConfigCat.Text = "Nueva";
            btnNuevaConfigCat.UseVisualStyleBackColor = false;
            // 
            // btnEditarCategoria
            // 
            btnEditarCategoria.BackColor = Color.Orange;
            btnEditarCategoria.ForeColor = Color.White;
            btnEditarCategoria.Location = new Point(105, 25);
            btnEditarCategoria.Name = "btnEditarCategoria";
            btnEditarCategoria.Size = new Size(80, 30);
            btnEditarCategoria.TabIndex = 3;
            btnEditarCategoria.Text = "Editar";
            btnEditarCategoria.UseVisualStyleBackColor = false;
            // 
            // btnEliminarCategoria
            // 
            btnEliminarCategoria.BackColor = Color.Red;
            btnEliminarCategoria.ForeColor = Color.White;
            btnEliminarCategoria.Location = new Point(195, 25);
            btnEliminarCategoria.Name = "btnEliminarCategoria";
            btnEliminarCategoria.Size = new Size(80, 30);
            btnEliminarCategoria.TabIndex = 4;
            btnEliminarCategoria.Text = "Eliminar";
            btnEliminarCategoria.UseVisualStyleBackColor = false;
            // 
            // btnInicializarCategorias
            // 
            btnInicializarCategorias.BackColor = Color.Purple;
            btnInicializarCategorias.ForeColor = Color.White;
            btnInicializarCategorias.Location = new Point(285, 25);
            btnInicializarCategorias.Name = "btnInicializarCategorias";
            btnInicializarCategorias.Size = new Size(120, 30);
            btnInicializarCategorias.TabIndex = 5;
            btnInicializarCategorias.Text = "Categorías por defecto";
            btnInicializarCategorias.UseVisualStyleBackColor = false;
            // 
            // ProductosModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Name = "ProductosModule";
            this.Size = new System.Drawing.Size(1306, 682);
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabInicio.ResumeLayout(false);
            this.tabConfiguraciones.ResumeLayout(false);
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.panelFormulario.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.grpDatosProducto.ResumeLayout(false);
            this.tableLayoutProducto.ResumeLayout(false);
            this.tableLayoutProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockActual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}