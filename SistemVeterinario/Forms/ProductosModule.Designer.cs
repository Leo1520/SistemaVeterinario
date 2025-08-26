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
        private GroupBox grpDatosProducto;
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
            grpDatosProducto = new GroupBox();
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
            // 
            // tabInicio
            // 
            tabInicio.Text = "Gestión de Productos";
            // 
            // tabConfiguraciones
            // 
            tabConfiguraciones.Text = "Configuración de Producto";
            // 
            // panelBusqueda
            // 
            panelBusqueda.Controls.Add(lblContador);
            panelBusqueda.Controls.Add(btnStockBajo);
            panelBusqueda.Size = new Size(1097, 80);
            panelBusqueda.Controls.SetChildIndex(btnStockBajo, 0);
            panelBusqueda.Controls.SetChildIndex(lblContador, 0);
            panelBusqueda.Controls.SetChildIndex(chkMostrarTodo, 0);
            panelBusqueda.Controls.SetChildIndex(btnNuevo, 0);
            panelBusqueda.Controls.SetChildIndex(btnBuscar, 0);
            panelBusqueda.Controls.SetChildIndex(txtBuscar, 0);
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(17, 23);
            txtBuscar.PlaceholderText = "Buscar por código, nombre, categoría...";
            txtBuscar.Size = new Size(350, 27);
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(385, 20);
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(997, 17);
            // 
            // chkMostrarTodo
            // 
            chkMostrarTodo.Location = new Point(496, 20);
            // 
            // panelFormulario
            // 
            panelFormulario.Controls.Add(grpDatosProducto);
            panelFormulario.Controls.SetChildIndex(grpDatosProducto, 0);
            panelFormulario.Controls.SetChildIndex(panelBotones, 0);
            panelFormulario.Controls.SetChildIndex(panelSuperior, 0);
            // 
            // panelSuperior
            // 
            panelSuperior.Size = new Size(992, 50);
            // 
            // lblModo
            // 
            lblModo.Location = new Point(46, 11);
            // 
            // cmbModo
            // 
            cmbModo.Items.AddRange(new object[] { "Nuevo", "Edición" });
            cmbModo.Location = new Point(106, 8);
            // 
            // lblId
            // 
            lblId.Location = new Point(316, 16);
            // 
            // txtId
            // 
            txtId.Location = new Point(374, 13);
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblContador.ForeColor = Color.DarkBlue;
            lblContador.Location = new Point(523, 45);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(148, 20);
            lblContador.TabIndex = 0;
            lblContador.Text = "Total de registros: 0";
            // 
            // grpDatosProducto
            // 
            grpDatosProducto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpDatosProducto.Controls.Add(lblCodigo);
            grpDatosProducto.Controls.Add(txtCodigo);
            grpDatosProducto.Controls.Add(btnGenerarCodigo);
            grpDatosProducto.Controls.Add(lblNombre);
            grpDatosProducto.Controls.Add(txtNombre);
            grpDatosProducto.Controls.Add(lblCategoria);
            grpDatosProducto.Controls.Add(cmbCategoria);
            grpDatosProducto.Controls.Add(btnNuevaCategoria);
            grpDatosProducto.Controls.Add(lblPrecio);
            grpDatosProducto.Controls.Add(nudPrecio);
            grpDatosProducto.Controls.Add(lblStockMinimo);
            grpDatosProducto.Controls.Add(nudStockMinimo);
            grpDatosProducto.Controls.Add(lblStockActual);
            grpDatosProducto.Controls.Add(nudStockActual);
            grpDatosProducto.Controls.Add(chkRequiereReceta);
            grpDatosProducto.Controls.Add(lblDescripcion);
            grpDatosProducto.Controls.Add(txtDescripcion);
            grpDatosProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpDatosProducto.Location = new Point(45, 91);
            grpDatosProducto.Name = "grpDatosProducto";
            grpDatosProducto.Size = new Size(900, 537);
            grpDatosProducto.TabIndex = 0;
            grpDatosProducto.TabStop = false;
            grpDatosProducto.Text = "📦 Datos del Producto";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 9F);
            lblCodigo.Location = new Point(20, 63);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(61, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 9F);
            txtCodigo.Location = new Point(100, 56);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(140, 27);
            txtCodigo.TabIndex = 1;
            // 
            // btnGenerarCodigo
            // 
            btnGenerarCodigo.BackColor = Color.LightCyan;
            btnGenerarCodigo.Font = new Font("Segoe UI", 8F);
            btnGenerarCodigo.Location = new Point(258, 58);
            btnGenerarCodigo.Name = "btnGenerarCodigo";
            btnGenerarCodigo.Size = new Size(80, 25);
            btnGenerarCodigo.TabIndex = 2;
            btnGenerarCodigo.Text = "🎲 Generar";
            btnGenerarCodigo.UseVisualStyleBackColor = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F);
            lblNombre.Location = new Point(406, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre *:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.Location = new Point(495, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 27);
            txtNombre.TabIndex = 4;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F);
            lblCategoria.Location = new Point(30, 128);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(87, 20);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoría *:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Font = new Font("Segoe UI", 9F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(123, 128);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(180, 28);
            cmbCategoria.TabIndex = 6;
            // 
            // btnNuevaCategoria
            // 
            btnNuevaCategoria.BackColor = Color.LightGreen;
            btnNuevaCategoria.Font = new Font("Segoe UI", 8F);
            btnNuevaCategoria.Location = new Point(327, 106);
            btnNuevaCategoria.Name = "btnNuevaCategoria";
            btnNuevaCategoria.Size = new Size(80, 25);
            btnNuevaCategoria.TabIndex = 7;
            btnNuevaCategoria.Text = "➕ Nueva";
            btnNuevaCategoria.UseVisualStyleBackColor = false;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9F);
            lblPrecio.Location = new Point(465, 108);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(63, 20);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio *:";
            // 
            // nudPrecio
            // 
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Font = new Font("Segoe UI", 9F);
            nudPrecio.Location = new Point(540, 106);
            nudPrecio.Maximum = new decimal(new int[] { 999999, 0, 0, 131072 });
            nudPrecio.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(120, 27);
            nudPrecio.TabIndex = 9;
            nudPrecio.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // lblStockMinimo
            // 
            lblStockMinimo.AutoSize = true;
            lblStockMinimo.Font = new Font("Segoe UI", 9F);
            lblStockMinimo.Location = new Point(30, 209);
            lblStockMinimo.Name = "lblStockMinimo";
            lblStockMinimo.Size = new Size(103, 20);
            lblStockMinimo.TabIndex = 11;
            lblStockMinimo.Text = "Stock Mínimo:";
            // 
            // nudStockMinimo
            // 
            nudStockMinimo.Font = new Font("Segoe UI", 9F);
            nudStockMinimo.Location = new Point(140, 202);
            nudStockMinimo.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudStockMinimo.Name = "nudStockMinimo";
            nudStockMinimo.Size = new Size(100, 27);
            nudStockMinimo.TabIndex = 12;
            nudStockMinimo.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblStockActual
            // 
            lblStockActual.AutoSize = true;
            lblStockActual.Font = new Font("Segoe UI", 9F);
            lblStockActual.Location = new Point(313, 190);
            lblStockActual.Name = "lblStockActual";
            lblStockActual.Size = new Size(94, 20);
            lblStockActual.TabIndex = 13;
            lblStockActual.Text = "Stock Actual:";
            // 
            // nudStockActual
            // 
            nudStockActual.Font = new Font("Segoe UI", 9F);
            nudStockActual.Location = new Point(428, 190);
            nudStockActual.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudStockActual.Name = "nudStockActual";
            nudStockActual.Size = new Size(100, 27);
            nudStockActual.TabIndex = 14;
            // 
            // chkRequiereReceta
            // 
            chkRequiereReceta.AutoSize = true;
            chkRequiereReceta.Font = new Font("Segoe UI", 9F);
            chkRequiereReceta.Location = new Point(713, 104);
            chkRequiereReceta.Name = "chkRequiereReceta";
            chkRequiereReceta.Size = new Size(164, 24);
            chkRequiereReceta.TabIndex = 10;
            chkRequiereReceta.Text = "💊 Requiere Receta";
            chkRequiereReceta.UseVisualStyleBackColor = false;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9F);
            lblDescripcion.Location = new Point(30, 327);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(115, 20);
            lblDescripcion.TabIndex = 15;
            lblDescripcion.Text = "📝 Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 9F);
            txtDescripcion.Location = new Point(30, 367);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Ingrese una descripción detallada del producto...";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(820, 120);
            txtDescripcion.TabIndex = 16;
            // 
            // btnStockBajo
            // 
            btnStockBajo.BackColor = Color.LightSalmon;
            btnStockBajo.Font = new Font("Segoe UI", 9F);
            btnStockBajo.Location = new Point(800, 18);
            btnStockBajo.Name = "btnStockBajo";
            btnStockBajo.Size = new Size(108, 37);
            btnStockBajo.TabIndex = 1;
            btnStockBajo.Text = "Stock Bajo";
            btnStockBajo.UseVisualStyleBackColor = false;
            // 
            // ProductosModule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            Name = "ProductosModule";
        }

        #endregion
    }
}