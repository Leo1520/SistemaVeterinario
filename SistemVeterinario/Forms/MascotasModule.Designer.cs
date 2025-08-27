namespace SistemVeterinario.Forms
{
    partial class MascotasModule
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
        private new void InitializeComponent()
        {
            lblContador = new Label();
            grpDatosMascota = new GroupBox();
            dtpFechaNacimiento = new DateTimePicker();
            chkTieneFechaNacimiento = new CheckBox();
            txtMicrochip = new TextBox();
            lblMicrochip = new Label();
            btnBuscarPropietario = new Button();
            txtPropietario = new TextBox();
            lblPropietario = new Label();
            chkEsterilizado = new CheckBox();
            txtColor = new TextBox();
            lblColor = new Label();
            nudPeso = new NumericUpDown();
            lblPeso = new Label();
            cmbGenero = new ComboBox();
            lblGenero = new Label();
            txtRaza = new TextBox();
            cmbRaza = new ComboBox();
            lblRaza = new Label();
            cmbEspecie = new ComboBox();
            lblEspecie = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            tabControlPrincipal.SuspendLayout();
            tabInicio.SuspendLayout();
            tabConfiguraciones.SuspendLayout();
            panelBusqueda.SuspendLayout();
            panelFormulario.SuspendLayout();
            panelSuperior.SuspendLayout();
            panelBotones.SuspendLayout();
            grpDatosMascota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPeso).BeginInit();
            SuspendLayout();
            // 
            // tabInicio
            // 
            tabInicio.Text = "Gestión de Mascotas";
            // 
            // tabConfiguraciones
            // 
            tabConfiguraciones.Text = "Configuración de Mascota";
            // 
            // panelBusqueda
            // 
            panelBusqueda.Controls.Add(lblContador);
            panelBusqueda.Size = new Size(960, 80);
            panelBusqueda.Controls.SetChildIndex(lblContador, 0);
            panelBusqueda.Controls.SetChildIndex(chkMostrarTodo, 0);
            panelBusqueda.Controls.SetChildIndex(btnNuevo, 0);
            panelBusqueda.Controls.SetChildIndex(btnBuscar, 0);
            panelBusqueda.Controls.SetChildIndex(txtBuscar, 0);
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(17, 3);
            txtBuscar.PlaceholderText = "Buscar por nombre, especie, raza, propietario...";
            txtBuscar.Size = new Size(350, 23);
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(287, 40);
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(860, 17);
            // 
            // chkMostrarTodo
            // 
            chkMostrarTodo.Location = new Point(110, 46);
            // 
            // panelFormulario
            // 
            panelFormulario.Controls.Add(grpDatosMascota);
            panelFormulario.Controls.SetChildIndex(grpDatosMascota, 0);
            panelFormulario.Controls.SetChildIndex(panelBotones, 0);
            panelFormulario.Controls.SetChildIndex(panelSuperior, 0);
            // 
            // panelSuperior
            // 
            panelSuperior.Size = new Size(992, 50);
            // 
            // panelBotones
            // 
            panelBotones.Location = new Point(0, 490);
            // 
            // lblContador
            // 
            lblContador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblContador.AutoSize = true;
            lblContador.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblContador.Location = new Point(824, 45);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(116, 15);
            lblContador.TabIndex = 6;
            lblContador.Text = "Total de registros: 0";
            // 
            // grpDatosMascota
            // 
            grpDatosMascota.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDatosMascota.Controls.Add(dtpFechaNacimiento);
            grpDatosMascota.Controls.Add(chkTieneFechaNacimiento);
            grpDatosMascota.Controls.Add(txtMicrochip);
            grpDatosMascota.Controls.Add(lblMicrochip);
            grpDatosMascota.Controls.Add(btnBuscarPropietario);
            grpDatosMascota.Controls.Add(txtPropietario);
            grpDatosMascota.Controls.Add(lblPropietario);
            grpDatosMascota.Controls.Add(chkEsterilizado);
            grpDatosMascota.Controls.Add(txtColor);
            grpDatosMascota.Controls.Add(lblColor);
            grpDatosMascota.Controls.Add(nudPeso);
            grpDatosMascota.Controls.Add(lblPeso);
            grpDatosMascota.Controls.Add(cmbGenero);
            grpDatosMascota.Controls.Add(lblGenero);
            grpDatosMascota.Controls.Add(txtRaza);
            grpDatosMascota.Controls.Add(cmbRaza);
            grpDatosMascota.Controls.Add(lblRaza);
            grpDatosMascota.Controls.Add(cmbEspecie);
            grpDatosMascota.Controls.Add(lblEspecie);
            grpDatosMascota.Controls.Add(txtNombre);
            grpDatosMascota.Controls.Add(lblNombre);
            grpDatosMascota.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpDatosMascota.ForeColor = Color.DarkBlue;
            grpDatosMascota.Location = new Point(15, 65);
            grpDatosMascota.Name = "grpDatosMascota";
            grpDatosMascota.Size = new Size(960, 320);
            grpDatosMascota.TabIndex = 1;
            grpDatosMascota.TabStop = false;
            grpDatosMascota.Text = "Datos de la Mascota";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Enabled = false;
            dtpFechaNacimiento.Font = new Font("Segoe UI", 9F);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(180, 198);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(120, 23);
            dtpFechaNacimiento.TabIndex = 20;
            // 
            // chkTieneFechaNacimiento
            // 
            chkTieneFechaNacimiento.AutoSize = true;
            chkTieneFechaNacimiento.Font = new Font("Segoe UI", 9F);
            chkTieneFechaNacimiento.ForeColor = Color.Black;
            chkTieneFechaNacimiento.Location = new Point(15, 200);
            chkTieneFechaNacimiento.Name = "chkTieneFechaNacimiento";
            chkTieneFechaNacimiento.Size = new Size(141, 19);
            chkTieneFechaNacimiento.TabIndex = 19;
            chkTieneFechaNacimiento.Text = "Fecha de Nacimiento:";
            chkTieneFechaNacimiento.UseVisualStyleBackColor = false;
            // 
            // txtMicrochip
            // 
            txtMicrochip.BackColor = Color.White;
            txtMicrochip.Font = new Font("Segoe UI", 9F);
            txtMicrochip.ForeColor = Color.Black;
            txtMicrochip.Location = new Point(430, 160);
            txtMicrochip.MaxLength = 50;
            txtMicrochip.Name = "txtMicrochip";
            txtMicrochip.Size = new Size(180, 23);
            txtMicrochip.TabIndex = 18;
            // 
            // lblMicrochip
            // 
            lblMicrochip.AutoSize = true;
            lblMicrochip.Font = new Font("Segoe UI", 9F);
            lblMicrochip.ForeColor = Color.Black;
            lblMicrochip.Location = new Point(430, 140);
            lblMicrochip.Name = "lblMicrochip";
            lblMicrochip.Size = new Size(64, 15);
            lblMicrochip.TabIndex = 17;
            lblMicrochip.Text = "Microchip:";
            // 
            // btnBuscarPropietario
            // 
            btnBuscarPropietario.BackColor = Color.LightBlue;
            btnBuscarPropietario.Font = new Font("Segoe UI", 9F);
            btnBuscarPropietario.Location = new Point(330, 160);
            btnBuscarPropietario.Name = "btnBuscarPropietario";
            btnBuscarPropietario.Size = new Size(80, 23);
            btnBuscarPropietario.TabIndex = 16;
            btnBuscarPropietario.Text = "Buscar";
            btnBuscarPropietario.UseVisualStyleBackColor = false;
            btnBuscarPropietario.Click += BtnBuscarPropietario_Click;
            // 
            // txtPropietario
            // 
            txtPropietario.BackColor = Color.LightGray;
            txtPropietario.Font = new Font("Segoe UI", 9F);
            txtPropietario.ForeColor = Color.Black;
            txtPropietario.Location = new Point(15, 160);
            txtPropietario.Name = "txtPropietario";
            txtPropietario.ReadOnly = true;
            txtPropietario.Size = new Size(300, 23);
            txtPropietario.TabIndex = 15;
            // 
            // lblPropietario
            // 
            lblPropietario.AutoSize = true;
            lblPropietario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPropietario.ForeColor = Color.DarkRed;
            lblPropietario.Location = new Point(15, 140);
            lblPropietario.Name = "lblPropietario";
            lblPropietario.Size = new Size(77, 15);
            lblPropietario.TabIndex = 14;
            lblPropietario.Text = "Propietario *";
            // 
            // chkEsterilizado
            // 
            chkEsterilizado.AutoSize = true;
            chkEsterilizado.Font = new Font("Segoe UI", 9F);
            chkEsterilizado.ForeColor = Color.Black;
            chkEsterilizado.Location = new Point(620, 30);
            chkEsterilizado.Name = "chkEsterilizado";
            chkEsterilizado.Size = new Size(85, 19);
            chkEsterilizado.TabIndex = 13;
            chkEsterilizado.Text = "Esterilizado";
            chkEsterilizado.UseVisualStyleBackColor = false;
            // 
            // txtColor
            // 
            txtColor.BackColor = Color.White;
            txtColor.Font = new Font("Segoe UI", 9F);
            txtColor.ForeColor = Color.Black;
            txtColor.Location = new Point(350, 105);
            txtColor.MaxLength = 100;
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(150, 23);
            txtColor.TabIndex = 12;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI", 9F);
            lblColor.ForeColor = Color.Black;
            lblColor.Location = new Point(350, 85);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(39, 15);
            lblColor.TabIndex = 11;
            lblColor.Text = "Color:";
            // 
            // nudPeso
            // 
            nudPeso.DecimalPlaces = 2;
            nudPeso.Font = new Font("Segoe UI", 9F);
            nudPeso.Location = new Point(500, 50);
            nudPeso.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudPeso.Name = "nudPeso";
            nudPeso.Size = new Size(100, 23);
            nudPeso.TabIndex = 10;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Segoe UI", 9F);
            lblPeso.ForeColor = Color.Black;
            lblPeso.Location = new Point(500, 30);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(59, 15);
            lblPeso.TabIndex = 9;
            lblPeso.Text = "Peso (kg):";
            // 
            // cmbGenero
            // 
            cmbGenero.BackColor = Color.White;
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.Font = new Font("Segoe UI", 9F);
            cmbGenero.ForeColor = Color.Black;
            cmbGenero.Location = new Point(400, 50);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(80, 23);
            cmbGenero.TabIndex = 8;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Segoe UI", 9F);
            lblGenero.ForeColor = Color.Black;
            lblGenero.Location = new Point(400, 30);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(35, 15);
            lblGenero.TabIndex = 7;
            lblGenero.Text = "Sexo:";
            // 
            // txtRaza
            // 
            txtRaza.BackColor = Color.White;
            txtRaza.Font = new Font("Segoe UI", 9F);
            txtRaza.ForeColor = Color.Black;
            txtRaza.Location = new Point(180, 105);
            txtRaza.MaxLength = 100;
            txtRaza.Name = "txtRaza";
            txtRaza.PlaceholderText = "o escriba otra raza";
            txtRaza.Size = new Size(150, 23);
            txtRaza.TabIndex = 6;
            // 
            // cmbRaza
            // 
            cmbRaza.BackColor = Color.White;
            cmbRaza.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRaza.Font = new Font("Segoe UI", 9F);
            cmbRaza.ForeColor = Color.Black;
            cmbRaza.Location = new Point(15, 105);
            cmbRaza.Name = "cmbRaza";
            cmbRaza.Size = new Size(150, 23);
            cmbRaza.TabIndex = 5;
            // 
            // lblRaza
            // 
            lblRaza.AutoSize = true;
            lblRaza.Font = new Font("Segoe UI", 9F);
            lblRaza.ForeColor = Color.Black;
            lblRaza.Location = new Point(15, 85);
            lblRaza.Name = "lblRaza";
            lblRaza.Size = new Size(34, 15);
            lblRaza.TabIndex = 4;
            lblRaza.Text = "Raza:";
            // 
            // cmbEspecie
            // 
            cmbEspecie.BackColor = Color.White;
            cmbEspecie.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecie.Font = new Font("Segoe UI", 9F);
            cmbEspecie.ForeColor = Color.Black;
            cmbEspecie.Location = new Point(230, 50);
            cmbEspecie.Name = "cmbEspecie";
            cmbEspecie.Size = new Size(150, 23);
            cmbEspecie.TabIndex = 3;
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEspecie.ForeColor = Color.DarkRed;
            lblEspecie.Location = new Point(230, 30);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(56, 15);
            lblEspecie.TabIndex = 2;
            lblEspecie.Text = "Especie *";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(15, 50);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.ForeColor = Color.DarkRed;
            lblNombre.Location = new Point(15, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(61, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre *";
            // 
            // MascotasModule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "MascotasModule";
            tabControlPrincipal.ResumeLayout(false);
            tabInicio.ResumeLayout(false);
            tabConfiguraciones.ResumeLayout(false);
            panelBusqueda.ResumeLayout(false);
            panelBusqueda.PerformLayout();
            panelFormulario.ResumeLayout(false);
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelBotones.ResumeLayout(false);
            grpDatosMascota.ResumeLayout(false);
            grpDatosMascota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPeso).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Label lblContador;
        private GroupBox grpDatosMascota;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblEspecie;
        private ComboBox cmbEspecie;
        private Label lblRaza;
        private ComboBox cmbRaza;
        private TextBox txtRaza;
        private Label lblGenero;
        private ComboBox cmbGenero;
        private Label lblPeso;
        private NumericUpDown nudPeso;
        private Label lblColor;
        private TextBox txtColor;
        private CheckBox chkEsterilizado;
        private Label lblPropietario;
        private TextBox txtPropietario;
        private Button btnBuscarPropietario;
        private Label lblMicrochip;
        private TextBox txtMicrochip;
        private CheckBox chkTieneFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
    }
}