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
            lblContador = new Label();
            cmbCategoriaFiltro = new ComboBox();
            lblCategoriaFiltro = new Label();
            grpDatosProducto = new GroupBox();
            tableLayoutProducto = new TableLayoutPanel();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            btnGenerarCodigo = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            btnNuevaCategoria = new Button();
            lblPrecio = new Label();
            nudPrecio = new NumericUpDown();
            lblStockMinimo = new Label();
            nudStockMinimo = new NumericUpDown();
            lblStockActual = new Label();
            nudStockActual = new NumericUpDown();
            chkRequiereReceta = new CheckBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            btnStockBajo = new Button();
            tabControlPrincipal.SuspendLayout();
            tabInicio.SuspendLayout();
            tabConfiguraciones.SuspendLayout();
            panelBusqueda.SuspendLayout();
            panelFormulario.SuspendLayout();
            panelSuperior.SuspendLayout();
            panelBotones.SuspendLayout();
            grpDatosProducto.SuspendLayout();
            tableLayoutProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStockMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStockActual).BeginInit();
            SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Margin = new Padding(3, 4, 3, 4);
            tabControlPrincipal.Size = new Size(1306, 853);
            // 
            // tabInicio
            // 
            tabInicio.Location = new Point(4, 39);
            tabInicio.Margin = new Padding(3, 4, 3, 4);
            tabInicio.Padding = new Padding(3, 4, 3, 4);
            tabInicio.Size = new Size(1298, 810);
            tabInicio.Text = "Gestión de Productos";
            // 
            // tabConfiguraciones
            // 
            tabConfiguraciones.Location = new Point(4, 39);
            tabConfiguraciones.Margin = new Padding(3, 4, 3, 4);
            tabConfiguraciones.Padding = new Padding(3, 4, 3, 4);
            tabConfiguraciones.Size = new Size(1298, 810);
            tabConfiguraciones.Text = "Configuración de Producto";
            // 
            // panelBusqueda
            // 
            panelBusqueda.Controls.Add(lblContador);
            panelBusqueda.Controls.Add(lblCategoriaFiltro);
            panelBusqueda.Controls.Add(cmbCategoriaFiltro);
            panelBusqueda.Controls.Add(btnStockBajo);
            panelBusqueda.Location = new Point(13, 14);
            panelBusqueda.Margin = new Padding(10);
            panelBusqueda.Size = new Size(1272, 120);
            panelBusqueda.Controls.SetChildIndex(btnStockBajo, 0);
            panelBusqueda.Controls.SetChildIndex(cmbCategoriaFiltro, 0);
            panelBusqueda.Controls.SetChildIndex(lblCategoriaFiltro, 0);
            panelBusqueda.Controls.SetChildIndex(lblContador, 0);
            panelBusqueda.Controls.SetChildIndex(chkMostrarTodo, 0);
            panelBusqueda.Controls.SetChildIndex(btnNuevo, 0);
            panelBusqueda.Controls.SetChildIndex(btnBuscar, 0);
            panelBusqueda.Controls.SetChildIndex(txtBuscar, 0);
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(25, 30);
            txtBuscar.Margin = new Padding(5);
            txtBuscar.Size = new Size(444, 32);
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.Location = new Point(510, 26);
            btnBuscar.Margin = new Padding(5);
            btnBuscar.Size = new Size(120, 36);
            // 
            // btnNuevo
            // 
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.Location = new Point(1039, 27);
            btnNuevo.Margin = new Padding(5);
            btnNuevo.Size = new Size(140, 36);
            btnNuevo.Text = "➕ Nuevo Producto";
            // 
            // chkMostrarTodo
            // 
            chkMostrarTodo.Location = new Point(100, 72);
            chkMostrarTodo.Margin = new Padding(5);
            // 
            // panelFormulario
            // 
            panelFormulario.Controls.Add(grpDatosProducto);
            panelFormulario.Location = new Point(3, 4);
            panelFormulario.Margin = new Padding(3, 4, 3, 4);
            panelFormulario.Size = new Size(1292, 802);
            panelFormulario.Controls.SetChildIndex(grpDatosProducto, 0);
            panelFormulario.Controls.SetChildIndex(panelBotones, 0);
            panelFormulario.Controls.SetChildIndex(panelSuperior, 0);
            // 
            // panelSuperior
            // 
            panelSuperior.Location = new Point(13, 14);
            panelSuperior.Margin = new Padding(3, 4, 3, 4);
            panelSuperior.Size = new Size(2093, 79);
            // 
            // lblModo
            // 
            lblModo.Location = new Point(35, 27);
            // 
            // cmbModo
            // 
            cmbModo.Location = new Point(145, 21);
            cmbModo.Margin = new Padding(3, 4, 3, 4);
            cmbModo.Size = new Size(156, 31);
            // 
            // lblId
            // 
            lblId.Location = new Point(392, 21);
            // 
            // txtId
            // 
            txtId.Location = new Point(452, 17);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Size = new Size(129, 30);
            // 
            // panelBotones
            // 
            panelBotones.Location = new Point(100, 921);
            panelBotones.Size = new Size(1399, 65);
            // 
            // btnGuardar
            // 
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.Location = new Point(1262, 15);
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Location = new Point(1079, 15);
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.Location = new Point(18, 15);
            // 
            // lblContador
            // 
            lblContador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblContador.AutoSize = true;
            lblContador.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblContador.ForeColor = Color.FromArgb(52, 73, 94);
            lblContador.Location = new Point(1080, 75);
            lblContador.Margin = new Padding(5);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(168, 23);
            lblContador.TabIndex = 0;
            lblContador.Text = "Total de registros: 0";
            // 
            // grpDatosProducto
            // 
            grpDatosProducto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpDatosProducto.Controls.Add(tableLayoutProducto);
            grpDatosProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpDatosProducto.ForeColor = Color.FromArgb(52, 73, 94);
            grpDatosProducto.Location = new Point(50, 115);
            grpDatosProducto.Margin = new Padding(20);
            grpDatosProducto.Name = "grpDatosProducto";
            grpDatosProducto.Padding = new Padding(20);
            grpDatosProducto.Size = new Size(1200, 550);
            grpDatosProducto.TabIndex = 0;
            grpDatosProducto.TabStop = false;
            grpDatosProducto.Text = "📦 Datos del Producto";
            // 
            // tableLayoutProducto
            // 
            tableLayoutProducto.ColumnCount = 6;
            tableLayoutProducto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutProducto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutProducto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutProducto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutProducto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutProducto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutProducto.Controls.Add(lblCodigo, 0, 0);
            tableLayoutProducto.Controls.Add(txtCodigo, 1, 0);
            tableLayoutProducto.Controls.Add(btnGenerarCodigo, 2, 0);
            tableLayoutProducto.Controls.Add(lblNombre, 3, 0);
            tableLayoutProducto.Controls.Add(txtNombre, 4, 0);
            tableLayoutProducto.Controls.Add(chkRequiereReceta, 5, 0);
            tableLayoutProducto.Controls.Add(lblCategoria, 0, 1);
            tableLayoutProducto.Controls.Add(cmbCategoria, 1, 1);
            tableLayoutProducto.Controls.Add(btnNuevaCategoria, 2, 1);
            tableLayoutProducto.Controls.Add(lblPrecio, 3, 1);
            tableLayoutProducto.Controls.Add(nudPrecio, 4, 1);
            tableLayoutProducto.Controls.Add(lblStockMinimo, 0, 2);
            tableLayoutProducto.Controls.Add(nudStockMinimo, 1, 2);
            tableLayoutProducto.Controls.Add(lblStockActual, 3, 2);
            tableLayoutProducto.Controls.Add(nudStockActual, 4, 2);
            tableLayoutProducto.Controls.Add(lblDescripcion, 0, 3);
            tableLayoutProducto.Controls.Add(txtDescripcion, 0, 4);
            tableLayoutProducto.Dock = DockStyle.Fill;
            tableLayoutProducto.Location = new Point(20, 47);
            tableLayoutProducto.Name = "tableLayoutProducto";
            tableLayoutProducto.RowCount = 5;
            tableLayoutProducto.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutProducto.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutProducto.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutProducto.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutProducto.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutProducto.Size = new Size(1160, 483);
            tableLayoutProducto.TabIndex = 0;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Dock = DockStyle.Fill;
            lblCodigo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCodigo.ForeColor = Color.FromArgb(52, 73, 94);
            lblCodigo.Location = new Point(3, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(168, 60);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "🏷️ Código:";
            lblCodigo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCodigo
            // 
            txtCodigo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCodigo.BackColor = Color.White;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Segoe UI", 11F);
            txtCodigo.ForeColor = Color.FromArgb(44, 62, 80);
            txtCodigo.Location = new Point(177, 18);
            txtCodigo.Margin = new Padding(3, 3, 10, 3);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(219, 32);
            txtCodigo.TabIndex = 1;
            // 
            // btnGenerarCodigo
            // 
            btnGenerarCodigo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnGenerarCodigo.BackColor = Color.FromArgb(52, 152, 219);
            btnGenerarCodigo.FlatAppearance.BorderSize = 0;
            btnGenerarCodigo.FlatStyle = FlatStyle.Flat;
            btnGenerarCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGenerarCodigo.ForeColor = Color.White;
            btnGenerarCodigo.Location = new Point(409, 15);
            btnGenerarCodigo.Name = "btnGenerarCodigo";
            btnGenerarCodigo.Size = new Size(110, 30);
            btnGenerarCodigo.TabIndex = 2;
            btnGenerarCodigo.Text = "🎲 Generar";
            btnGenerarCodigo.UseVisualStyleBackColor = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(231, 76, 60);
            lblNombre.Location = new Point(525, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(168, 60);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "📝 Nombre *:";
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 11F);
            txtNombre.ForeColor = Color.FromArgb(44, 62, 80);
            txtNombre.Location = new Point(699, 18);
            txtNombre.Margin = new Padding(3, 3, 10, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(277, 32);
            txtNombre.TabIndex = 4;
            // 
            // chkRequiereReceta
            // 
            chkRequiereReceta.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chkRequiereReceta.AutoSize = true;
            chkRequiereReceta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkRequiereReceta.ForeColor = Color.FromArgb(155, 89, 182);
            chkRequiereReceta.Location = new Point(989, 18);
            chkRequiereReceta.Name = "chkRequiereReceta";
            chkRequiereReceta.Size = new Size(168, 27);
            chkRequiereReceta.TabIndex = 5;
            chkRequiereReceta.Text = "💊 Requiere Receta";
            chkRequiereReceta.UseVisualStyleBackColor = true;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Dock = DockStyle.Fill;
            lblCategoria.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCategoria.ForeColor = Color.FromArgb(231, 76, 60);
            lblCategoria.Location = new Point(3, 60);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(168, 60);
            lblCategoria.TabIndex = 6;
            lblCategoria.Text = "🏷️ Categoría *:";
            lblCategoria.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbCategoria
            // 
            cmbCategoria.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbCategoria.BackColor = Color.White;
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FlatStyle = FlatStyle.Flat;
            cmbCategoria.Font = new Font("Segoe UI", 11F);
            cmbCategoria.ForeColor = Color.FromArgb(44, 62, 80);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(177, 78);
            cmbCategoria.Margin = new Padding(3, 3, 10, 3);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(219, 33);
            cmbCategoria.TabIndex = 7;
            // 
            // btnNuevaCategoria
            // 
            btnNuevaCategoria.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnNuevaCategoria.BackColor = Color.FromArgb(46, 204, 113);
            btnNuevaCategoria.FlatAppearance.BorderSize = 0;
            btnNuevaCategoria.FlatStyle = FlatStyle.Flat;
            btnNuevaCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNuevaCategoria.ForeColor = Color.White;
            btnNuevaCategoria.Location = new Point(409, 75);
            btnNuevaCategoria.Name = "btnNuevaCategoria";
            btnNuevaCategoria.Size = new Size(110, 30);
            btnNuevaCategoria.TabIndex = 8;
            btnNuevaCategoria.Text = "➕ Nueva";
            btnNuevaCategoria.UseVisualStyleBackColor = false;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Dock = DockStyle.Fill;
            lblPrecio.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPrecio.ForeColor = Color.FromArgb(231, 76, 60);
            lblPrecio.Location = new Point(525, 60);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(168, 60);
            lblPrecio.TabIndex = 9;
            lblPrecio.Text = "💰 Precio *:";
            lblPrecio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudPrecio
            // 
            nudPrecio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudPrecio.BackColor = Color.White;
            nudPrecio.BorderStyle = BorderStyle.FixedSingle;
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Font = new Font("Segoe UI", 11F);
            nudPrecio.ForeColor = Color.FromArgb(44, 62, 80);
            nudPrecio.Location = new Point(699, 78);
            nudPrecio.Margin = new Padding(3, 3, 10, 3);
            nudPrecio.Maximum = new decimal(new int[] { 999999, 0, 0, 131072 });
            nudPrecio.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(277, 32);
            nudPrecio.TabIndex = 10;
            nudPrecio.TextAlign = HorizontalAlignment.Right;
            nudPrecio.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // lblStockMinimo
            // 
            lblStockMinimo.AutoSize = true;
            lblStockMinimo.Dock = DockStyle.Fill;
            lblStockMinimo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStockMinimo.ForeColor = Color.FromArgb(52, 73, 94);
            lblStockMinimo.Location = new Point(3, 120);
            lblStockMinimo.Name = "lblStockMinimo";
            lblStockMinimo.Size = new Size(168, 60);
            lblStockMinimo.TabIndex = 11;
            lblStockMinimo.Text = "📉 Stock Mínimo:";
            lblStockMinimo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudStockMinimo
            // 
            nudStockMinimo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudStockMinimo.BackColor = Color.White;
            nudStockMinimo.BorderStyle = BorderStyle.FixedSingle;
            nudStockMinimo.Font = new Font("Segoe UI", 11F);
            nudStockMinimo.ForeColor = Color.FromArgb(44, 62, 80);
            nudStockMinimo.Location = new Point(177, 138);
            nudStockMinimo.Margin = new Padding(3, 3, 10, 3);
            nudStockMinimo.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudStockMinimo.Name = "nudStockMinimo";
            nudStockMinimo.Size = new Size(219, 32);
            nudStockMinimo.TabIndex = 12;
            nudStockMinimo.TextAlign = HorizontalAlignment.Right;
            nudStockMinimo.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblStockActual
            // 
            lblStockActual.AutoSize = true;
            lblStockActual.Dock = DockStyle.Fill;
            lblStockActual.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStockActual.ForeColor = Color.FromArgb(52, 73, 94);
            lblStockActual.Location = new Point(525, 120);
            lblStockActual.Name = "lblStockActual";
            lblStockActual.Size = new Size(168, 60);
            lblStockActual.TabIndex = 13;
            lblStockActual.Text = "📊 Stock Actual:";
            lblStockActual.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudStockActual
            // 
            nudStockActual.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudStockActual.BackColor = Color.White;
            nudStockActual.BorderStyle = BorderStyle.FixedSingle;
            nudStockActual.Font = new Font("Segoe UI", 11F);
            nudStockActual.ForeColor = Color.FromArgb(44, 62, 80);
            nudStockActual.Location = new Point(699, 138);
            nudStockActual.Margin = new Padding(3, 3, 10, 3);
            nudStockActual.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudStockActual.Name = "nudStockActual";
            nudStockActual.Size = new Size(277, 32);
            nudStockActual.TabIndex = 14;
            nudStockActual.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Dock = DockStyle.Fill;
            lblDescripcion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDescripcion.ForeColor = Color.FromArgb(52, 73, 94);
            lblDescripcion.Location = new Point(3, 180);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(168, 40);
            lblDescripcion.TabIndex = 15;
            lblDescripcion.Text = "📝 Descripción:";
            lblDescripcion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDescripcion
            // 
            tableLayoutProducto.SetColumnSpan(txtDescripcion, 6);
            txtDescripcion.Dock = DockStyle.Fill;
            txtDescripcion.Font = new Font("Segoe UI", 11F);
            txtDescripcion.ForeColor = Color.FromArgb(44, 62, 80);
            txtDescripcion.Location = new Point(3, 223);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(1154, 257);
            txtDescripcion.TabIndex = 16;
            // 
            // cmbCategoriaFiltro
            // 
            cmbCategoriaFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbCategoriaFiltro.BackColor = Color.White;
            cmbCategoriaFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoriaFiltro.FlatStyle = FlatStyle.Flat;
            cmbCategoriaFiltro.Font = new Font("Segoe UI", 10F);
            cmbCategoriaFiltro.ForeColor = Color.FromArgb(44, 62, 80);
            cmbCategoriaFiltro.Location = new Point(676, 57);
            cmbCategoriaFiltro.Margin = new Padding(5);
            cmbCategoriaFiltro.Name = "cmbCategoriaFiltro";
            cmbCategoriaFiltro.Size = new Size(180, 31);
            cmbCategoriaFiltro.TabIndex = 4;
            // 
            // lblCategoriaFiltro
            // 
            lblCategoriaFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCategoriaFiltro.AutoSize = true;
            lblCategoriaFiltro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCategoriaFiltro.ForeColor = Color.FromArgb(52, 73, 94);
            lblCategoriaFiltro.Location = new Point(672, 23);
            lblCategoriaFiltro.Margin = new Padding(5);
            lblCategoriaFiltro.Name = "lblCategoriaFiltro";
            lblCategoriaFiltro.Size = new Size(108, 23);
            lblCategoriaFiltro.TabIndex = 5;
            lblCategoriaFiltro.Text = "🏷️ Categoría";
            // 
            // btnStockBajo
            // 
            btnStockBajo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStockBajo.BackColor = Color.FromArgb(231, 76, 60);
            btnStockBajo.FlatAppearance.BorderSize = 0;
            btnStockBajo.FlatStyle = FlatStyle.Flat;
            btnStockBajo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnStockBajo.ForeColor = Color.White;
            btnStockBajo.Location = new Point(896, 42);
            btnStockBajo.Margin = new Padding(5);
            btnStockBajo.Name = "btnStockBajo";
            btnStockBajo.Size = new Size(140, 40);
            btnStockBajo.TabIndex = 6;
            btnStockBajo.Text = "⚠️ Stock Bajo";
            btnStockBajo.UseVisualStyleBackColor = false;
            // 
            // ProductosModule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductosModule";
            Size = new Size(1306, 853);
            tabControlPrincipal.ResumeLayout(false);
            tabInicio.ResumeLayout(false);
            tabConfiguraciones.ResumeLayout(false);
            panelBusqueda.ResumeLayout(false);
            panelBusqueda.PerformLayout();
            panelFormulario.ResumeLayout(false);
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelBotones.ResumeLayout(false);
            grpDatosProducto.ResumeLayout(false);
            tableLayoutProducto.ResumeLayout(false);
            tableLayoutProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStockMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStockActual).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}