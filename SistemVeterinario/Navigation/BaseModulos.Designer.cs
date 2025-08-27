namespace SistemVeterinario.Navigation
{
    partial class BaseModulos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        protected void InitializeComponent()
        {
            tabControlPrincipal = new TabControl();
            tabInicio = new TabPage();
            panelBusqueda = new Panel();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnNuevo = new Button();
            chkMostrarTodo = new CheckBox();
            dgvDatos = new DataGridView();
            tabConfiguraciones = new TabPage();
            panelFormulario = new Panel();
            panelSuperior = new Panel();
            lblModo = new Label();
            cmbModo = new ComboBox();
            lblId = new Label();
            txtId = new TextBox();
            panelBotones = new Panel();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            tabControlPrincipal.SuspendLayout();
            tabInicio.SuspendLayout();
            panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            tabConfiguraciones.SuspendLayout();
            panelFormulario.SuspendLayout();
            panelSuperior.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Controls.Add(tabInicio);
            tabControlPrincipal.Controls.Add(tabConfiguraciones);
            tabControlPrincipal.Dock = DockStyle.Fill;
            tabControlPrincipal.Location = new Point(0, 0);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(1000, 600);
            tabControlPrincipal.TabIndex = 0;
            // 
            // tabInicio
            // 
            tabInicio.BackColor = Color.White;
            tabInicio.Controls.Add(panelBusqueda);
            tabInicio.Controls.Add(dgvDatos);
            tabInicio.Location = new Point(4, 24);
            tabInicio.Name = "tabInicio";
            tabInicio.Padding = new Padding(3);
            tabInicio.Size = new Size(992, 572);
            tabInicio.TabIndex = 0;
            tabInicio.Text = "Inicio";
            // 
            // panelBusqueda
            // 
            panelBusqueda.BackColor = Color.FromArgb(240, 240, 240);
            panelBusqueda.BorderStyle = BorderStyle.FixedSingle;
            panelBusqueda.Controls.Add(txtBuscar);
            panelBusqueda.Controls.Add(btnBuscar);
            panelBusqueda.Controls.Add(btnNuevo);
            panelBusqueda.Controls.Add(chkMostrarTodo);
            panelBusqueda.Location = new Point(6, 10);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Size = new Size(980, 133);
            panelBusqueda.TabIndex = 0;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(10, 18);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar...";
            txtBuscar.Size = new Size(300, 23);
            txtBuscar.TabIndex = 0;
            txtBuscar.KeyPress += TxtBuscar_KeyPress;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 120, 215);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(320, 17);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(80, 25);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += BtnBuscar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(16, 137, 62);
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(640, 32);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(80, 25);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += BtnNuevo_Click;
            // 
            // chkMostrarTodo
            // 
            chkMostrarTodo.AutoSize = true;
            chkMostrarTodo.BackColor = Color.FromArgb(240, 240, 240);
            chkMostrarTodo.Checked = true;
            chkMostrarTodo.CheckState = CheckState.Checked;
            chkMostrarTodo.ForeColor = Color.Black;
            chkMostrarTodo.Location = new Point(420, 20);
            chkMostrarTodo.Name = "chkMostrarTodo";
            chkMostrarTodo.Size = new Size(171, 19);
            chkMostrarTodo.TabIndex = 3;
            chkMostrarTodo.Text = "Mostrar todas las columnas";
            chkMostrarTodo.UseVisualStyleBackColor = false;
            chkMostrarTodo.CheckedChanged += ChkMostrarTodo_CheckedChanged;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDatos.BackgroundColor = Color.White;
            dgvDatos.BorderStyle = BorderStyle.FixedSingle;
            dgvDatos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDatos.ColumnHeadersHeight = 35;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDatos.EnableHeadersVisualStyles = false;
            dgvDatos.GridColor = Color.FromArgb(240, 240, 240);
            dgvDatos.Location = new Point(6, 149);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDatos.RowHeadersWidth = 25;
            dgvDatos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvDatos.RowTemplate.Height = 28;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(980, 417);
            dgvDatos.TabIndex = 1;
            dgvDatos.DataSourceChanged += DgvDatos_DataSourceChanged;
            dgvDatos.CellClick += DgvDatos_CellClick;

            // Estilos para las celdas
            dgvDatos.DefaultCellStyle.BackColor = Color.White;
            dgvDatos.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvDatos.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgvDatos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvDatos.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvDatos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDatos.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            // Estilos para los encabezados de columna
            dgvDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dgvDatos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvDatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDatos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Estilos para los encabezados de fila
            dgvDatos.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvDatos.RowHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8F);
            dgvDatos.RowHeadersDefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgvDatos.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 220, 220);
            // 
            // tabConfiguraciones
            // 
            tabConfiguraciones.BackColor = Color.White;
            tabConfiguraciones.Controls.Add(panelFormulario);
            tabConfiguraciones.Location = new Point(4, 24);
            tabConfiguraciones.Name = "tabConfiguraciones";
            tabConfiguraciones.Padding = new Padding(3);
            tabConfiguraciones.Size = new Size(992, 572);
            tabConfiguraciones.TabIndex = 1;
            tabConfiguraciones.Text = "Configuraciones";
            // 
            // panelFormulario
            // 
            panelFormulario.Controls.Add(panelSuperior);
            panelFormulario.Controls.Add(panelBotones);
            panelFormulario.Dock = DockStyle.Fill;
            panelFormulario.Location = new Point(3, 3);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(986, 566);
            panelFormulario.TabIndex = 0;
            // 
            // panelSuperior
            // 
            panelSuperior.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSuperior.BackColor = Color.FromArgb(240, 240, 240);
            panelSuperior.BorderStyle = BorderStyle.FixedSingle;
            panelSuperior.Controls.Add(lblModo);
            panelSuperior.Controls.Add(cmbModo);
            panelSuperior.Controls.Add(lblId);
            panelSuperior.Controls.Add(txtId);
            panelSuperior.Location = new Point(10, 10);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(900, 50);
            panelSuperior.TabIndex = 0;
            // 
            // lblModo
            // 
            lblModo.AutoSize = true;
            lblModo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblModo.ForeColor = Color.Black;
            lblModo.Location = new Point(10, 15);
            lblModo.Name = "lblModo";
            lblModo.Size = new Size(42, 15);
            lblModo.TabIndex = 0;
            lblModo.Text = "Modo:";
            // 
            // cmbModo
            // 
            cmbModo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModo.FormattingEnabled = true;
            cmbModo.Items.AddRange(new object[] { "Nuevo", "Edición" });
            cmbModo.Location = new Point(70, 12);
            cmbModo.Name = "cmbModo";
            cmbModo.Size = new Size(120, 23);
            cmbModo.TabIndex = 1;
            cmbModo.SelectedIndexChanged += CmbModo_SelectedIndexChanged;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.ForeColor = Color.Black;
            lblId.Location = new Point(210, 15);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 15);
            lblId.TabIndex = 2;
            lblId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.Control;
            txtId.Enabled = false;
            txtId.Location = new Point(250, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(80, 23);
            txtId.TabIndex = 3;
            // 
            // panelBotones
            // 
            panelBotones.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBotones.BackColor = Color.FromArgb(240, 240, 240);
            panelBotones.BorderStyle = BorderStyle.FixedSingle;
            panelBotones.Controls.Add(btnGuardar);
            panelBotones.Controls.Add(btnCancelar);
            panelBotones.Controls.Add(btnEliminar);
            panelBotones.Location = new Point(10, 500);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(900,50);
            panelBotones.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(40, 167, 69);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(500, 10);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += BtnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(108, 117, 125);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(250, 500);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += BtnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(220, 53, 69);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(20, 10);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Visible = false;
            btnEliminar.Click += BtnEliminar_Click;
            // 
            // BaseModulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlPrincipal);
            Name = "BaseModulos";
            Size = new Size(1000, 600);
            Load += SearchBase_Load;
            tabControlPrincipal.ResumeLayout(false);
            tabInicio.ResumeLayout(false);
            panelBusqueda.ResumeLayout(false);
            panelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            tabConfiguraciones.ResumeLayout(false);
            panelFormulario.ResumeLayout(false);
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        protected System.Windows.Forms.TabControl tabControlPrincipal;
        protected System.Windows.Forms.TabPage tabInicio;
        protected System.Windows.Forms.TabPage tabConfiguraciones;
        protected System.Windows.Forms.Panel panelBusqueda;
        protected System.Windows.Forms.TextBox txtBuscar;
        protected System.Windows.Forms.Button btnBuscar;
        protected System.Windows.Forms.Button btnNuevo;
        protected System.Windows.Forms.CheckBox chkMostrarTodo;
        public System.Windows.Forms.DataGridView dgvDatos;
        protected System.Windows.Forms.Panel panelFormulario;
        protected System.Windows.Forms.Panel panelSuperior;
        protected System.Windows.Forms.Label lblModo;
        protected System.Windows.Forms.ComboBox cmbModo;
        protected System.Windows.Forms.Label lblId;
        protected System.Windows.Forms.TextBox txtId;
        protected System.Windows.Forms.Panel panelBotones;
        protected System.Windows.Forms.Button btnGuardar;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnEliminar;
    }
}
