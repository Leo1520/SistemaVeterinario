namespace SistemVeterinario.Forms
{
    partial class ProductosModule
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controles específicos de productos
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.ComboBox cmbCategoriaFiltro;
        private System.Windows.Forms.Label lblCategoriaFiltro;
        private System.Windows.Forms.GroupBox grpDatosProducto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutProducto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnGenerarCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnNuevaCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.NumericUpDown nudStockMinimo;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.NumericUpDown nudStockActual;
        private System.Windows.Forms.CheckBox chkRequiereReceta;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnStockBajo;

        // Controles para gestión de categorías
        private System.Windows.Forms.GroupBox grpGestionCategorias;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.GroupBox grpFormCategoria;
        private System.Windows.Forms.Label lblNombreCategoria;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Label lblDescripcionCategoria;
        private System.Windows.Forms.TextBox txtDescripcionCategoria;
        private System.Windows.Forms.Button btnNuevaConfigCat;
        private System.Windows.Forms.Button btnGuardarCategoria;
        private System.Windows.Forms.Button btnEditarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnCancelarCategoria;
        private System.Windows.Forms.Button btnInicializarCategorias;

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
            this.components = new System.ComponentModel.Container();
            
            
            // Inicializar controles específicos de productos
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
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnNuevaCategoria = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.nudStockMinimo = new System.Windows.Forms.NumericUpDown();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.nudStockActual = new System.Windows.Forms.NumericUpDown();
            this.chkRequiereReceta = new System.Windows.Forms.CheckBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnStockBajo = new System.Windows.Forms.Button();
            
            // Controles de gestión de categorías
            this.grpGestionCategorias = new System.Windows.Forms.GroupBox();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.grpFormCategoria = new System.Windows.Forms.GroupBox();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.lblDescripcionCategoria = new System.Windows.Forms.Label();
            this.txtDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.btnNuevaConfigCat = new System.Windows.Forms.Button();
            this.btnGuardarCategoria = new System.Windows.Forms.Button();
            this.btnEditarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnCancelarCategoria = new System.Windows.Forms.Button();
            this.btnInicializarCategorias = new System.Windows.Forms.Button();
            
            // Suspender el layout durante la configuración
            this.grpDatosProducto.SuspendLayout();
            this.tableLayoutProducto.SuspendLayout();
            this.grpGestionCategorias.SuspendLayout();
            this.grpFormCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(12, 15);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(125, 15);
            this.lblContador.TabIndex = 0;
            this.lblContador.Text = "Total de registros: 0";
            
            // 
            // lblCategoriaFiltro
            // 
            this.lblCategoriaFiltro.AutoSize = true;
            this.lblCategoriaFiltro.Location = new System.Drawing.Point(250, 15);
            this.lblCategoriaFiltro.Name = "lblCategoriaFiltro";
            this.lblCategoriaFiltro.Size = new System.Drawing.Size(66, 15);
            this.lblCategoriaFiltro.TabIndex = 1;
            this.lblCategoriaFiltro.Text = "Categoría:";
            
            // 
            // cmbCategoriaFiltro
            // 
            this.cmbCategoriaFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaFiltro.FormattingEnabled = true;
            this.cmbCategoriaFiltro.Location = new System.Drawing.Point(322, 12);
            this.cmbCategoriaFiltro.Name = "cmbCategoriaFiltro";
            this.cmbCategoriaFiltro.Size = new System.Drawing.Size(200, 23);
            this.cmbCategoriaFiltro.TabIndex = 2;
            
            // 
            // btnStockBajo
            // 
            this.btnStockBajo.Location = new System.Drawing.Point(550, 12);
            this.btnStockBajo.Name = "btnStockBajo";
            this.btnStockBajo.Size = new System.Drawing.Size(150, 23);
            this.btnStockBajo.TabIndex = 3;
            this.btnStockBajo.Text = "Productos con Stock Bajo";
            this.btnStockBajo.UseVisualStyleBackColor = true;
            
            // 
            // grpDatosProducto
            // 
            this.grpDatosProducto.Controls.Add(this.tableLayoutProducto);
            this.grpDatosProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDatosProducto.Location = new System.Drawing.Point(3, 3);
            this.grpDatosProducto.Name = "grpDatosProducto";
            this.grpDatosProducto.Size = new System.Drawing.Size(800, 400);
            this.grpDatosProducto.TabIndex = 0;
            this.grpDatosProducto.TabStop = false;
            this.grpDatosProducto.Text = "Datos del Producto";
            
            // 
            // tableLayoutProducto
            // 
            this.tableLayoutProducto.ColumnCount = 4;
            this.tableLayoutProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutProducto.Controls.Add(this.lblCodigo, 0, 0);
            this.tableLayoutProducto.Controls.Add(this.txtCodigo, 1, 0);
            this.tableLayoutProducto.Controls.Add(this.btnGenerarCodigo, 2, 0);
            this.tableLayoutProducto.Controls.Add(this.lblNombre, 0, 1);
            this.tableLayoutProducto.Controls.Add(this.txtNombre, 1, 1);
            this.tableLayoutProducto.Controls.Add(this.lblCategoria, 0, 2);
            this.tableLayoutProducto.Controls.Add(this.cmbCategoria, 1, 2);
            this.tableLayoutProducto.Controls.Add(this.btnNuevaCategoria, 2, 2);
            this.tableLayoutProducto.Controls.Add(this.lblPrecio, 0, 3);
            this.tableLayoutProducto.Controls.Add(this.nudPrecio, 1, 3);
            this.tableLayoutProducto.Controls.Add(this.lblStockMinimo, 0, 4);
            this.tableLayoutProducto.Controls.Add(this.nudStockMinimo, 1, 4);
            this.tableLayoutProducto.Controls.Add(this.lblStockActual, 2, 4);
            this.tableLayoutProducto.Controls.Add(this.nudStockActual, 3, 4);
            this.tableLayoutProducto.Controls.Add(this.chkRequiereReceta, 1, 5);
            this.tableLayoutProducto.Controls.Add(this.lblDescripcion, 0, 6);
            this.tableLayoutProducto.Controls.Add(this.txtDescripcion, 1, 6);
            this.tableLayoutProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutProducto.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutProducto.Name = "tableLayoutProducto";
            this.tableLayoutProducto.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutProducto.RowCount = 7;
            this.tableLayoutProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutProducto.Size = new System.Drawing.Size(794, 378);
            this.tableLayoutProducto.TabIndex = 0;
            
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 20);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.Location = new System.Drawing.Point(113, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(301, 23);
            this.txtCodigo.TabIndex = 1;
            
            // 
            // btnGenerarCodigo
            // 
            this.btnGenerarCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGenerarCodigo.Location = new System.Drawing.Point(420, 16);
            this.btnGenerarCodigo.Name = "btnGenerarCodigo";
            this.btnGenerarCodigo.Size = new System.Drawing.Size(74, 23);
            this.btnGenerarCodigo.TabIndex = 2;
            this.btnGenerarCodigo.Text = "Generar";
            this.btnGenerarCodigo.UseVisualStyleBackColor = true;
            
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutProducto.SetColumnSpan(this.txtNombre, 3);
            this.txtNombre.Location = new System.Drawing.Point(113, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(668, 23);
            this.txtNombre.TabIndex = 4;
            
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(13, 90);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(66, 15);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoría:";
            
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(113, 86);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(301, 23);
            this.cmbCategoria.TabIndex = 6;
            
            // 
            // btnNuevaCategoria
            // 
            this.btnNuevaCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNuevaCategoria.Location = new System.Drawing.Point(420, 86);
            this.btnNuevaCategoria.Name = "btnNuevaCategoria";
            this.btnNuevaCategoria.Size = new System.Drawing.Size(74, 23);
            this.btnNuevaCategoria.TabIndex = 7;
            this.btnNuevaCategoria.Text = "Nueva";
            this.btnNuevaCategoria.UseVisualStyleBackColor = true;
            
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(13, 125);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(43, 15);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio:";
            
            // 
            // nudPrecio
            // 
            this.nudPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(113, 121);
            this.nudPrecio.Maximum = new decimal(new int[] { 999999, 0, 0, 131072 });
            this.nudPrecio.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(301, 23);
            this.nudPrecio.TabIndex = 9;
            this.nudPrecio.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Location = new System.Drawing.Point(13, 160);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(84, 15);
            this.lblStockMinimo.TabIndex = 10;
            this.lblStockMinimo.Text = "Stock Mínimo:";
            
            // 
            // nudStockMinimo
            // 
            this.nudStockMinimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudStockMinimo.Location = new System.Drawing.Point(113, 156);
            this.nudStockMinimo.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            this.nudStockMinimo.Name = "nudStockMinimo";
            this.nudStockMinimo.Size = new System.Drawing.Size(301, 23);
            this.nudStockMinimo.TabIndex = 11;
            this.nudStockMinimo.Value = new decimal(new int[] { 5, 0, 0, 0 });
            
            // 
            // lblStockActual
            // 
            this.lblStockActual.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Location = new System.Drawing.Point(420, 160);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(74, 15);
            this.lblStockActual.TabIndex = 12;
            this.lblStockActual.Text = "Stock Actual:";
            
            // 
            // nudStockActual
            // 
            this.nudStockActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudStockActual.Location = new System.Drawing.Point(500, 156);
            this.nudStockActual.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            this.nudStockActual.Name = "nudStockActual";
            this.nudStockActual.Size = new System.Drawing.Size(281, 23);
            this.nudStockActual.TabIndex = 13;
            
            // 
            // chkRequiereReceta
            // 
            this.chkRequiereReceta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkRequiereReceta.AutoSize = true;
            this.tableLayoutProducto.SetColumnSpan(this.chkRequiereReceta, 3);
            this.chkRequiereReceta.Location = new System.Drawing.Point(113, 195);
            this.chkRequiereReceta.Name = "chkRequiereReceta";
            this.chkRequiereReceta.Size = new System.Drawing.Size(107, 19);
            this.chkRequiereReceta.TabIndex = 14;
            this.chkRequiereReceta.Text = "Requiere Receta";
            this.chkRequiereReceta.UseVisualStyleBackColor = true;
            
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(13, 230);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(72, 15);
            this.lblDescripcion.TabIndex = 15;
            this.lblDescripcion.Text = "Descripción:";
            
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutProducto.SetColumnSpan(this.txtDescripcion, 3);
            this.txtDescripcion.Location = new System.Drawing.Point(113, 233);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(668, 132);
            this.txtDescripcion.TabIndex = 16;
            
            // 
            // grpGestionCategorias
            // 
            this.grpGestionCategorias.Controls.Add(this.dgvCategorias);
            this.grpGestionCategorias.Controls.Add(this.grpFormCategoria);
            this.grpGestionCategorias.Controls.Add(this.btnNuevaConfigCat);
            this.grpGestionCategorias.Controls.Add(this.btnEditarCategoria);
            this.grpGestionCategorias.Controls.Add(this.btnEliminarCategoria);
            this.grpGestionCategorias.Controls.Add(this.btnInicializarCategorias);
            this.grpGestionCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGestionCategorias.Location = new System.Drawing.Point(3, 3);
            this.grpGestionCategorias.Name = "grpGestionCategorias";
            this.grpGestionCategorias.Size = new System.Drawing.Size(800, 400);
            this.grpGestionCategorias.TabIndex = 0;
            this.grpGestionCategorias.TabStop = false;
            this.grpGestionCategorias.Text = "Gestión de Categorías";
            
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(10, 25);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(450, 200);
            this.dgvCategorias.TabIndex = 0;
            
            // 
            // grpFormCategoria
            // 
            this.grpFormCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFormCategoria.Controls.Add(this.lblNombreCategoria);
            this.grpFormCategoria.Controls.Add(this.txtNombreCategoria);
            this.grpFormCategoria.Controls.Add(this.lblDescripcionCategoria);
            this.grpFormCategoria.Controls.Add(this.txtDescripcionCategoria);
            this.grpFormCategoria.Controls.Add(this.btnGuardarCategoria);
            this.grpFormCategoria.Controls.Add(this.btnCancelarCategoria);
            this.grpFormCategoria.Location = new System.Drawing.Point(470, 25);
            this.grpFormCategoria.Name = "grpFormCategoria";
            this.grpFormCategoria.Size = new System.Drawing.Size(320, 320);
            this.grpFormCategoria.TabIndex = 1;
            this.grpFormCategoria.TabStop = false;
            this.grpFormCategoria.Text = "Datos de Categoría";
            
            // 
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.AutoSize = true;
            this.lblNombreCategoria.Location = new System.Drawing.Point(15, 30);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(54, 15);
            this.lblNombreCategoria.TabIndex = 0;
            this.lblNombreCategoria.Text = "Nombre:";
            
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreCategoria.Location = new System.Drawing.Point(15, 50);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(290, 23);
            this.txtNombreCategoria.TabIndex = 1;
            
            // 
            // lblDescripcionCategoria
            // 
            this.lblDescripcionCategoria.AutoSize = true;
            this.lblDescripcionCategoria.Location = new System.Drawing.Point(15, 85);
            this.lblDescripcionCategoria.Name = "lblDescripcionCategoria";
            this.lblDescripcionCategoria.Size = new System.Drawing.Size(72, 15);
            this.lblDescripcionCategoria.TabIndex = 2;
            this.lblDescripcionCategoria.Text = "Descripción:";
            
            // 
            // txtDescripcionCategoria
            // 
            this.txtDescripcionCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcionCategoria.Location = new System.Drawing.Point(15, 105);
            this.txtDescripcionCategoria.Multiline = true;
            this.txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            this.txtDescripcionCategoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcionCategoria.Size = new System.Drawing.Size(290, 150);
            this.txtDescripcionCategoria.TabIndex = 3;
            
            // 
            // btnGuardarCategoria
            // 
            this.btnGuardarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarCategoria.Location = new System.Drawing.Point(135, 280);
            this.btnGuardarCategoria.Name = "btnGuardarCategoria";
            this.btnGuardarCategoria.Size = new System.Drawing.Size(80, 30);
            this.btnGuardarCategoria.TabIndex = 4;
            this.btnGuardarCategoria.Text = "Guardar";
            this.btnGuardarCategoria.UseVisualStyleBackColor = true;
            
            // 
            // btnCancelarCategoria
            // 
            this.btnCancelarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarCategoria.Location = new System.Drawing.Point(225, 280);
            this.btnCancelarCategoria.Name = "btnCancelarCategoria";
            this.btnCancelarCategoria.Size = new System.Drawing.Size(80, 30);
            this.btnCancelarCategoria.TabIndex = 5;
            this.btnCancelarCategoria.Text = "Cancelar";
            this.btnCancelarCategoria.UseVisualStyleBackColor = true;
            
            // 
            // btnNuevaConfigCat
            // 
            this.btnNuevaConfigCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevaConfigCat.Location = new System.Drawing.Point(10, 355);
            this.btnNuevaConfigCat.Name = "btnNuevaConfigCat";
            this.btnNuevaConfigCat.Size = new System.Drawing.Size(80, 30);
            this.btnNuevaConfigCat.TabIndex = 2;
            this.btnNuevaConfigCat.Text = "Nueva";
            this.btnNuevaConfigCat.UseVisualStyleBackColor = true;
            
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditarCategoria.Location = new System.Drawing.Point(100, 355);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(80, 30);
            this.btnEditarCategoria.TabIndex = 3;
            this.btnEditarCategoria.Text = "Editar";
            this.btnEditarCategoria.UseVisualStyleBackColor = true;
            
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarCategoria.Location = new System.Drawing.Point(190, 355);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(80, 30);
            this.btnEliminarCategoria.TabIndex = 4;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            
            // 
            // btnInicializarCategorias
            // 
            this.btnInicializarCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInicializarCategorias.Location = new System.Drawing.Point(650, 355);
            this.btnInicializarCategorias.Name = "btnInicializarCategorias";
            this.btnInicializarCategorias.Size = new System.Drawing.Size(140, 30);
            this.btnInicializarCategorias.TabIndex = 5;
            this.btnInicializarCategorias.Text = "Inicializar Categorías";
            this.btnInicializarCategorias.UseVisualStyleBackColor = true;
            
            // Reanudar el layout
            this.grpDatosProducto.ResumeLayout(false);
            this.tableLayoutProducto.ResumeLayout(false);
            this.tableLayoutProducto.PerformLayout();
            this.grpGestionCategorias.ResumeLayout(false);
            this.grpFormCategoria.ResumeLayout(false);
            this.grpFormCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
