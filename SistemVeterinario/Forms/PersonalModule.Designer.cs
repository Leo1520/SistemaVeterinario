namespace SistemVeterinario.Forms
{
    partial class PersonalModule
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
            cmbTipoPersonal = new ComboBox();
            lblTipoPersonal = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblSalario = new Label();
            txtSalario = new TextBox();
            lblRol = new Label();
            cmbRol = new ComboBox();
            lblFechaContratacion = new Label();
            dtpFechaContratacion = new DateTimePicker();
            lblTipoPersonalForm = new Label();
            cmbTipoPersonalForm = new ComboBox();
            cmbRolForm = new ComboBox();
            lblLicencia = new Label();
            txtLicencia = new TextBox();
            lblEspecialidad = new Label();
            txtEspecialidad = new TextBox();
            lblUniversidad = new Label();
            txtUniversidad = new TextBox();
            lblExperiencia = new Label();
            numExperiencia = new NumericUpDown();
            lblArea = new Label();
            txtArea = new TextBox();
            lblTurno = new Label();
            cmbTurno = new ComboBox();
            lblNivel = new Label();
            cmbNivel = new ComboBox();

            tabControlPrincipal.SuspendLayout();
            tabInicio.SuspendLayout();
            tabConfiguraciones.SuspendLayout();
            panelBusqueda.SuspendLayout();
            panelFormulario.SuspendLayout();
            panelSuperior.SuspendLayout();
            panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numExperiencia).BeginInit();
            SuspendLayout();

            // 
            // panelBusqueda - Agregar controles de filtro
            // 
            panelBusqueda.Controls.Add(lblTipoPersonal);
            panelBusqueda.Controls.Add(cmbTipoPersonal);
            panelBusqueda.Controls.SetChildIndex(lblTipoPersonal, 0);
            panelBusqueda.Controls.SetChildIndex(cmbTipoPersonal, 0);
            panelBusqueda.Controls.SetChildIndex(chkMostrarTodo, 0);
            panelBusqueda.Controls.SetChildIndex(btnNuevo, 0);
            panelBusqueda.Controls.SetChildIndex(btnBuscar, 0);
            panelBusqueda.Controls.SetChildIndex(txtBuscar, 0);

            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(970, 25);

            // 
            // chkMostrarTodo
            // 
            chkMostrarTodo.Location = new Point(480, 30);

            // 
            // panelFormulario - Reorganizar todos los controles
            // 
            panelFormulario.Controls.Add(lblNombre);
            panelFormulario.Controls.Add(txtNombre);
            panelFormulario.Controls.Add(lblApellido);
            panelFormulario.Controls.Add(txtApellido);
            panelFormulario.Controls.Add(lblEmail);
            panelFormulario.Controls.Add(txtEmail);
            panelFormulario.Controls.Add(lblUsuario);
            panelFormulario.Controls.Add(txtUsuario);
            panelFormulario.Controls.Add(lblContrasena);
            panelFormulario.Controls.Add(txtContrasena);
            panelFormulario.Controls.Add(lblTelefono);
            panelFormulario.Controls.Add(txtTelefono);
            panelFormulario.Controls.Add(lblDireccion);
            panelFormulario.Controls.Add(txtDireccion);
            panelFormulario.Controls.Add(lblSalario);
            panelFormulario.Controls.Add(txtSalario);
            panelFormulario.Controls.Add(lblRol);
            panelFormulario.Controls.Add(cmbRolForm);
            panelFormulario.Controls.Add(lblFechaContratacion);
            panelFormulario.Controls.Add(dtpFechaContratacion);
            panelFormulario.Controls.Add(lblTipoPersonalForm);
            panelFormulario.Controls.Add(cmbTipoPersonalForm);
            panelFormulario.Controls.Add(lblLicencia);
            panelFormulario.Controls.Add(txtLicencia);
            panelFormulario.Controls.Add(lblEspecialidad);
            panelFormulario.Controls.Add(txtEspecialidad);
            panelFormulario.Controls.Add(lblUniversidad);
            panelFormulario.Controls.Add(txtUniversidad);
            panelFormulario.Controls.Add(lblExperiencia);
            panelFormulario.Controls.Add(numExperiencia);
            panelFormulario.Controls.Add(lblArea);
            panelFormulario.Controls.Add(txtArea);
            panelFormulario.Controls.Add(lblTurno);
            panelFormulario.Controls.Add(cmbTurno);
            panelFormulario.Controls.Add(lblNivel);
            panelFormulario.Controls.Add(cmbNivel);

            // 
            // panelSuperior
            // 
            panelSuperior.Size = new Size(1100, 55);

            // 
            // cmbModo
            // 
            cmbModo.Location = new Point(85, 15);

            // 
            // lblId
            // 
            lblId.Location = new Point(310, 18);

            // 
            // txtId
            // 
            txtId.Location = new Point(345, 15);

            // ===== CONTROLES DE BÚSQUEDA =====

            // 
            // lblTipoPersonal
            // 
            lblTipoPersonal.AutoSize = true;
            lblTipoPersonal.Font = new Font("Segoe UI", 9F);
            lblTipoPersonal.Location = new Point(620, 30);
            lblTipoPersonal.Name = "lblTipoPersonal";
            lblTipoPersonal.Size = new Size(85, 20);
            lblTipoPersonal.TabIndex = 20;
            lblTipoPersonal.Text = "Tipo Personal:";

            // 
            // cmbTipoPersonal
            // 
            cmbTipoPersonal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPersonal.Font = new Font("Segoe UI", 9F);
            cmbTipoPersonal.Location = new Point(720, 27);
            cmbTipoPersonal.Name = "cmbTipoPersonal";
            cmbTipoPersonal.Size = new Size(130, 28);
            cmbTipoPersonal.TabIndex = 21;

            // ===== CONTROLES DEL FORMULARIO =====
            // Reorganización sistemática con espaciado consistente

            // FILA 1 - Información Personal Básica
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.White;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(30, 80);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";

            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.Location = new Point(120, 77);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 27);
            txtNombre.TabIndex = 1;

            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F);
            lblApellido.ForeColor = Color.Black;
            lblApellido.Location = new Point(370, 80);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";

            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 9F);
            txtApellido.Location = new Point(460, 77);
            txtApellido.MaxLength = 100;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(200, 27);
            txtApellido.TabIndex = 3;

            // FILA 2 - Email y Usuario
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(30, 120);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";

            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.Location = new Point(120, 117);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 5;

            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F);
            lblUsuario.ForeColor = Color.Black;
            lblUsuario.Location = new Point(370, 120);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario:";

            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 9F);
            txtUsuario.Location = new Point(460, 117);
            txtUsuario.MaxLength = 50;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(200, 27);
            txtUsuario.TabIndex = 7;

            // FILA 3 - Contraseña y Teléfono
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI", 9F);
            lblContrasena.ForeColor = Color.Black;
            lblContrasena.Location = new Point(30, 160);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(86, 20);
            lblContrasena.TabIndex = 8;
            lblContrasena.Text = "Contraseña:";

            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 9F);
            txtContrasena.Location = new Point(120, 157);
            txtContrasena.MaxLength = 255;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(200, 27);
            txtContrasena.TabIndex = 9;

            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 9F);
            lblTelefono.ForeColor = Color.Black;
            lblTelefono.Location = new Point(370, 160);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 10;
            lblTelefono.Text = "Teléfono:";

            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 9F);
            txtTelefono.Location = new Point(460, 157);
            txtTelefono.MaxLength = 20;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 27);
            txtTelefono.TabIndex = 11;

            // FILA 4 - Dirección (campo largo)
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 9F);
            lblDireccion.ForeColor = Color.Black;
            lblDireccion.Location = new Point(30, 200);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 20);
            lblDireccion.TabIndex = 12;
            lblDireccion.Text = "Dirección:";

            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 9F);
            txtDireccion.Location = new Point(120, 197);
            txtDireccion.MaxLength = 255;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(540, 27);
            txtDireccion.TabIndex = 13;

            // FILA 5 - Salario, Rol y Fecha
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Font = new Font("Segoe UI", 9F);
            lblSalario.ForeColor = Color.Black;
            lblSalario.Location = new Point(30, 240);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(58, 20);
            lblSalario.TabIndex = 14;
            lblSalario.Text = "Salario:";

            // 
            // txtSalario
            // 
            txtSalario.Font = new Font("Segoe UI", 9F);
            txtSalario.Location = new Point(120, 237);
            txtSalario.MaxLength = 10;
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(120, 27);
            txtSalario.TabIndex = 15;

            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 9F);
            lblRol.ForeColor = Color.Black;
            lblRol.Location = new Point(270, 240);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(34, 20);
            lblRol.TabIndex = 16;
            lblRol.Text = "Rol:";

            // 
            // cmbRolForm
            // 
            cmbRolForm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRolForm.Font = new Font("Segoe UI", 9F);
            cmbRolForm.Location = new Point(320, 237);
            cmbRolForm.Name = "cmbRolForm";
            cmbRolForm.Size = new Size(120, 28);
            cmbRolForm.TabIndex = 17;

            // 
            // lblFechaContratacion
            // 
            lblFechaContratacion.AutoSize = true;
            lblFechaContratacion.Font = new Font("Segoe UI", 9F);
            lblFechaContratacion.ForeColor = Color.Black;
            lblFechaContratacion.Location = new Point(470, 240);
            lblFechaContratacion.Name = "lblFechaContratacion";
            lblFechaContratacion.Size = new Size(111, 20);
            lblFechaContratacion.TabIndex = 18;
            lblFechaContratacion.Text = "F. Contratación:";

            // 
            // dtpFechaContratacion
            // 
            dtpFechaContratacion.Font = new Font("Segoe UI", 9F);
            dtpFechaContratacion.Format = DateTimePickerFormat.Short;
            dtpFechaContratacion.Location = new Point(590, 237);
            dtpFechaContratacion.Name = "dtpFechaContratacion";
            dtpFechaContratacion.Size = new Size(120, 27);
            dtpFechaContratacion.TabIndex = 19;

            // FILA 6 - Tipo de Personal
            // 
            // lblTipoPersonalForm
            // 
            lblTipoPersonalForm.AutoSize = true;
            lblTipoPersonalForm.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTipoPersonalForm.ForeColor = Color.Black;
            lblTipoPersonalForm.Location = new Point(30, 290);
            lblTipoPersonalForm.Name = "lblTipoPersonalForm";
            lblTipoPersonalForm.Size = new Size(129, 20);
            lblTipoPersonalForm.TabIndex = 20;
            lblTipoPersonalForm.Text = "Tipo de Personal:";

            // 
            // cmbTipoPersonalForm
            // 
            cmbTipoPersonalForm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPersonalForm.Font = new Font("Segoe UI", 9F);
            cmbTipoPersonalForm.Location = new Point(170, 287);
            cmbTipoPersonalForm.Name = "cmbTipoPersonalForm";
            cmbTipoPersonalForm.Size = new Size(150, 28);
            cmbTipoPersonalForm.TabIndex = 21;

            // ===== CAMPOS ESPECÍFICOS DE VETERINARIO =====

            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Segoe UI", 9F);
            lblEspecialidad.ForeColor = Color.Black;
            lblEspecialidad.Location = new Point(370, 290);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(96, 20);
            lblEspecialidad.TabIndex = 24;
            lblEspecialidad.Text = "Especialidad:";

            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Font = new Font("Segoe UI", 9F);
            txtEspecialidad.Location = new Point(480, 287);
            txtEspecialidad.MaxLength = 100;
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(200, 27);
            txtEspecialidad.TabIndex = 25;

            // 
            // lblLicencia
            // 
            lblLicencia.AutoSize = true;
            lblLicencia.Font = new Font("Segoe UI", 9F);
            lblLicencia.ForeColor = Color.Black;
            lblLicencia.Location = new Point(30, 330);
            lblLicencia.Name = "lblLicencia";
            lblLicencia.Size = new Size(104, 20);
            lblLicencia.TabIndex = 22;
            lblLicencia.Text = "Núm. Licencia:";

            // 
            // txtLicencia
            // 
            txtLicencia.Font = new Font("Segoe UI", 9F);
            txtLicencia.Location = new Point(140, 327);
            txtLicencia.MaxLength = 50;
            txtLicencia.Name = "txtLicencia";
            txtLicencia.Size = new Size(180, 27);
            txtLicencia.TabIndex = 23;

            // 
            // lblUniversidad
            // 
            lblUniversidad.AutoSize = true;
            lblUniversidad.Font = new Font("Segoe UI", 9F);
            lblUniversidad.ForeColor = Color.Black;
            lblUniversidad.Location = new Point(30, 370);
            lblUniversidad.Name = "lblUniversidad";
            lblUniversidad.Size = new Size(90, 20);
            lblUniversidad.TabIndex = 26;
            lblUniversidad.Text = "Universidad:";

            // 
            // txtUniversidad
            // 
            txtUniversidad.Font = new Font("Segoe UI", 9F);
            txtUniversidad.Location = new Point(140, 367);
            txtUniversidad.MaxLength = 200;
            txtUniversidad.Name = "txtUniversidad";
            txtUniversidad.Size = new Size(300, 27);
            txtUniversidad.TabIndex = 27;

            // 
            // lblExperiencia
            // 
            lblExperiencia.AutoSize = true;
            lblExperiencia.Font = new Font("Segoe UI", 9F);
            lblExperiencia.ForeColor = Color.Black;
            lblExperiencia.Location = new Point(470, 370);
            lblExperiencia.Name = "lblExperiencia";
            lblExperiencia.Size = new Size(125, 20);
            lblExperiencia.TabIndex = 28;
            lblExperiencia.Text = "Años Experiencia:";

            // 
            // numExperiencia
            // 
            numExperiencia.Font = new Font("Segoe UI", 9F);
            numExperiencia.Location = new Point(610, 367);
            numExperiencia.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numExperiencia.Name = "numExperiencia";
            numExperiencia.Size = new Size(80, 27);
            numExperiencia.TabIndex = 29;

            // ===== CAMPOS ESPECÍFICOS DE AUXILIAR =====

            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Segoe UI", 9F);
            lblArea.ForeColor = Color.Black;
            lblArea.Location = new Point(30, 330);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(43, 20);
            lblArea.TabIndex = 30;
            lblArea.Text = "Área:";

            // 
            // txtArea
            // 
            txtArea.Font = new Font("Segoe UI", 9F);
            txtArea.Location = new Point(140, 327);
            txtArea.MaxLength = 100;
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(200, 27);
            txtArea.TabIndex = 31;

            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Segoe UI", 9F);
            lblTurno.ForeColor = Color.Black;
            lblTurno.Location = new Point(370, 330);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(50, 20);
            lblTurno.TabIndex = 32;
            lblTurno.Text = "Turno:";

            // 
            // cmbTurno
            // 
            cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTurno.Font = new Font("Segoe UI", 9F);
            cmbTurno.Location = new Point(430, 327);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(100, 28);
            cmbTurno.TabIndex = 33;

            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Segoe UI", 9F);
            lblNivel.ForeColor = Color.Black;
            lblNivel.Location = new Point(560, 330);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(46, 20);
            lblNivel.TabIndex = 34;
            lblNivel.Text = "Nivel:";

            // 
            // cmbNivel
            // 
            cmbNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivel.Font = new Font("Segoe UI", 9F);
            cmbNivel.Location = new Point(620, 327);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(90, 28);
            cmbNivel.TabIndex = 35;

            // 
            // cmbRol (control no utilizado - mantener para compatibilidad)
            // 
            cmbRol.Location = new Point(-200, -200); // Oculto fuera de vista
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(121, 28);
            cmbRol.TabIndex = 999;
            cmbRol.Visible = false;

            // 
            // PersonalModule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            Name = "PersonalModule";
            tabControlPrincipal.ResumeLayout(false);
            tabInicio.ResumeLayout(false);
            tabConfiguraciones.ResumeLayout(false);
            panelBusqueda.ResumeLayout(false);
            panelBusqueda.PerformLayout();
            panelFormulario.ResumeLayout(false);
            panelFormulario.PerformLayout();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numExperiencia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // Controles específicos de PersonalModule
        private ComboBox cmbTipoPersonal;
        private Label lblTipoPersonal;

        // Controles del formulario
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblContrasena;
        private TextBox txtContrasena;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblSalario;
        private TextBox txtSalario;
        private Label lblRol;
        private ComboBox cmbRol;
        private ComboBox cmbRolForm;
        private Label lblFechaContratacion;
        private DateTimePicker dtpFechaContratacion;

        // Tipo de Personal
        private Label lblTipoPersonalForm;
        private ComboBox cmbTipoPersonalForm;

        // Campos específicos de Veterinario
        private Label lblLicencia;
        private TextBox txtLicencia;
        private Label lblEspecialidad;
        private TextBox txtEspecialidad;
        private Label lblUniversidad;
        private TextBox txtUniversidad;
        private Label lblExperiencia;
        private NumericUpDown numExperiencia;

        // Campos específicos de Auxiliar
        private Label lblArea;
        private TextBox txtArea;
        private Label lblTurno;
        private ComboBox cmbTurno;
        private Label lblNivel;
        private ComboBox cmbNivel;
    }
}