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
            tabControlPrincipal.SuspendLayout();
            tabInicio.SuspendLayout();
            tabConfiguraciones.SuspendLayout();
            panelBusqueda.SuspendLayout();
            panelFormulario.SuspendLayout();
            panelSuperior.SuspendLayout();
            panelBotones.SuspendLayout();
            grpDatosProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStockMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStockActual).BeginInit();
            SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Margin = new Padding(3, 2, 3, 2);
            tabControlPrincipal.Size = new Size(875, 450);
            // 
            // tabInicio
            // 
            tabInicio.Margin = new Padding(3, 2, 3, 2);
            tabInicio.Padding = new Padding(3, 2, 3, 2);
            tabInicio.Size = new Size(867, 422);
            tabInicio.Text = "Gestión de Productos";
            // 
            // tabConfiguraciones
            // 
            tabConfiguraciones.Margin = new Padding(3, 2, 3, 2);
            tabConfiguraciones.Padding = new Padding(3, 2, 3, 2);
            tabConfiguraciones.Size = new Size(867, 422);
            tabConfiguraciones.Text = "Configuración de Producto";
            // 
            // panelBusqueda
            // 
            panelBusqueda.Controls.Add(lblContador);
            panelBusqueda.Controls.Add(btnStockBajo);
            panelBusqueda.Location = new Point(5, 8);
            panelBusqueda.Margin = new Padding(3, 2, 3, 2);
            panelBusqueda.Size = new Size(960, 100);
            panelBusqueda.Controls.SetChildIndex(btnStockBajo, 0);
            panelBusqueda.Controls.SetChildIndex(lblContador, 0);
            panelBusqueda.Controls.SetChildIndex(chkMostrarTodo, 0);
            panelBusqueda.Controls.SetChildIndex(btnNuevo, 0);
            panelBusqueda.Controls.SetChildIndex(btnBuscar, 0);
            panelBusqueda.Controls.SetChildIndex(txtBuscar, 0);
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(15, 9);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Size = new Size(307, 23);
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(252, 44);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Size = new Size(70, 26);
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(724, 2);
            btnNuevo.Margin = new Padding(3, 2, 3, 2);
            btnNuevo.Size = new Size(70, 30);
            // 
            // chkMostrarTodo
            // 
            chkMostrarTodo.Location = new Point(75, 51);
            chkMostrarTodo.Margin = new Padding(3, 2, 3, 2);
            // 
            // panelFormulario
            // 
            panelFormulario.Controls.Add(grpDatosProducto);
            panelFormulario.Location = new Point(3, 2);
            panelFormulario.Margin = new Padding(3, 2, 3, 2);
            panelFormulario.Size = new Size(861, 418);
            panelFormulario.Controls.SetChildIndex(grpDatosProducto, 0);
            panelFormulario.Controls.SetChildIndex(panelBotones, 0);
            panelFormulario.Controls.SetChildIndex(panelSuperior, 0);
            // 
            // panelSuperior
            // 
            panelSuperior.Location = new Point(9, 8);
            panelSuperior.Margin = new Padding(3, 2, 3, 2);
            panelSuperior.Size = new Size(741, 38);
            // 
            // lblModo
            // 
            lblModo.Location = new Point(40, 8);
            // 
            // cmbModo
            // 
            cmbModo.Location = new Point(93, 6);
            cmbModo.Margin = new Padding(3, 2, 3, 2);
            cmbModo.Size = new Size(106, 23);
            // 
            // lblId
            // 
            lblId.Location = new Point(276, 12);
            // 
            // txtId
            // 
            txtId.Location = new Point(327, 10);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Size = new Size(70, 23);
            // 
            // panelBotones
            // 
            panelBotones.Location = new Point(9, 568);
            panelBotones.Margin = new Padding(3, 2, 3, 2);
            panelBotones.Size = new Size(1401, 38);
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(1863, 8);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Size = new Size(88, 22);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1959, 8);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Size = new Size(88, 22);
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(18, 8);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Size = new Size(88, 22);
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblContador.ForeColor = Color.DarkBlue;
            lblContador.Location = new Point(678, 66);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(116, 15);
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
            grpDatosProducto.Location = new Point(39, 68);
            grpDatosProducto.Margin = new Padding(3, 2, 3, 2);
            grpDatosProducto.Name = "grpDatosProducto";
            grpDatosProducto.Padding = new Padding(3, 2, 3, 2);
            grpDatosProducto.Size = new Size(786, 403);
            grpDatosProducto.TabIndex = 0;
            grpDatosProducto.TabStop = false;
            grpDatosProducto.Text = "📦 Datos del Producto";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 9F);
            lblCodigo.Location = new Point(18, 47);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 9F);
            txtCodigo.Location = new Point(88, 42);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(123, 23);
            txtCodigo.TabIndex = 1;
            // 
            // btnGenerarCodigo
            // 
            btnGenerarCodigo.BackColor = Color.LightCyan;
            btnGenerarCodigo.Font = new Font("Segoe UI", 8F);
            btnGenerarCodigo.Location = new Point(226, 44);
            btnGenerarCodigo.Margin = new Padding(3, 2, 3, 2);
            btnGenerarCodigo.Name = "btnGenerarCodigo";
            btnGenerarCodigo.Size = new Size(70, 19);
            btnGenerarCodigo.TabIndex = 2;
            btnGenerarCodigo.Text = "🎲 Generar";
            btnGenerarCodigo.UseVisualStyleBackColor = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F);
            lblNombre.Location = new Point(355, 28);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre *:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.Location = new Point(433, 26);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(263, 23);
            txtNombre.TabIndex = 4;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F);
            lblCategoria.Location = new Point(26, 96);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(69, 15);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoría *:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Font = new Font("Segoe UI", 9F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(108, 96);
            cmbCategoria.Margin = new Padding(3, 2, 3, 2);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(158, 23);
            cmbCategoria.TabIndex = 6;
            // 
            // btnNuevaCategoria
            // 
            btnNuevaCategoria.BackColor = Color.LightGreen;
            btnNuevaCategoria.Font = new Font("Segoe UI", 8F);
            btnNuevaCategoria.Location = new Point(286, 80);
            btnNuevaCategoria.Margin = new Padding(3, 2, 3, 2);
            btnNuevaCategoria.Name = "btnNuevaCategoria";
            btnNuevaCategoria.Size = new Size(70, 19);
            btnNuevaCategoria.TabIndex = 7;
            btnNuevaCategoria.Text = "➕ Nueva";
            btnNuevaCategoria.UseVisualStyleBackColor = false;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9F);
            lblPrecio.Location = new Point(407, 81);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(51, 15);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio *:";
            // 
            // nudPrecio
            // 
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Font = new Font("Segoe UI", 9F);
            nudPrecio.Location = new Point(472, 80);
            nudPrecio.Margin = new Padding(3, 2, 3, 2);
            nudPrecio.Maximum = new decimal(new int[] { 999999, 0, 0, 131072 });
            nudPrecio.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(105, 23);
            nudPrecio.TabIndex = 9;
            nudPrecio.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // lblStockMinimo
            // 
            lblStockMinimo.AutoSize = true;
            lblStockMinimo.Font = new Font("Segoe UI", 9F);
            lblStockMinimo.Location = new Point(26, 157);
            lblStockMinimo.Name = "lblStockMinimo";
            lblStockMinimo.Size = new Size(84, 15);
            lblStockMinimo.TabIndex = 11;
            lblStockMinimo.Text = "Stock Mínimo:";
            // 
            // nudStockMinimo
            // 
            nudStockMinimo.Font = new Font("Segoe UI", 9F);
            nudStockMinimo.Location = new Point(122, 152);
            nudStockMinimo.Margin = new Padding(3, 2, 3, 2);
            nudStockMinimo.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudStockMinimo.Name = "nudStockMinimo";
            nudStockMinimo.Size = new Size(88, 23);
            nudStockMinimo.TabIndex = 12;
            nudStockMinimo.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblStockActual
            // 
            lblStockActual.AutoSize = true;
            lblStockActual.Font = new Font("Segoe UI", 9F);
            lblStockActual.Location = new Point(274, 142);
            lblStockActual.Name = "lblStockActual";
            lblStockActual.Size = new Size(76, 15);
            lblStockActual.TabIndex = 13;
            lblStockActual.Text = "Stock Actual:";
            // 
            // nudStockActual
            // 
            nudStockActual.Font = new Font("Segoe UI", 9F);
            nudStockActual.Location = new Point(374, 142);
            nudStockActual.Margin = new Padding(3, 2, 3, 2);
            nudStockActual.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudStockActual.Name = "nudStockActual";
            nudStockActual.Size = new Size(88, 23);
            nudStockActual.TabIndex = 14;
            // 
            // chkRequiereReceta
            // 
            chkRequiereReceta.AutoSize = true;
            chkRequiereReceta.Font = new Font("Segoe UI", 9F);
            chkRequiereReceta.Location = new Point(624, 78);
            chkRequiereReceta.Margin = new Padding(3, 2, 3, 2);
            chkRequiereReceta.Name = "chkRequiereReceta";
            chkRequiereReceta.Size = new Size(125, 19);
            chkRequiereReceta.TabIndex = 10;
            chkRequiereReceta.Text = "💊 Requiere Receta";
            chkRequiereReceta.UseVisualStyleBackColor = false;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9F);
            lblDescripcion.Location = new Point(26, 245);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 15);
            lblDescripcion.TabIndex = 15;
            lblDescripcion.Text = "📝 Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 9F);
            txtDescripcion.Location = new Point(26, 275);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(718, 91);
            txtDescripcion.TabIndex = 16;
            // 
            // btnStockBajo
            // 
            btnStockBajo.BackColor = Color.LightSalmon;
            btnStockBajo.Font = new Font("Segoe UI", 9F);
            btnStockBajo.Location = new Point(700, 36);
            btnStockBajo.Margin = new Padding(3, 2, 3, 2);
            btnStockBajo.Name = "btnStockBajo";
            btnStockBajo.Size = new Size(94, 28);
            btnStockBajo.TabIndex = 1;
            btnStockBajo.Text = "Stock Bajo";
            btnStockBajo.UseVisualStyleBackColor = false;
            // 
            // ProductosModule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductosModule";
            Size = new Size(875, 450);
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
            grpDatosProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStockMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStockActual).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}