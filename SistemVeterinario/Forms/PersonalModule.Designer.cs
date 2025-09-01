using System.Windows.Forms;
using System.Drawing;
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
            // tabControlPrincipal
            // 
            tabControlPrincipal.Margin = new Padding(3, 2, 3, 2);
            tabControlPrincipal.Size = new Size(1000, 600);
            // 
            // tabInicio
            // 
            tabInicio.Margin = new Padding(3, 2, 3, 2);
            tabInicio.Padding = new Padding(3, 2, 3, 2);
            tabInicio.Size = new Size(992, 572);
            // 
            // tabConfiguraciones
            // 
            tabConfiguraciones.Margin = new Padding(3, 2, 3, 2);
            tabConfiguraciones.Padding = new Padding(3, 2, 3, 2);
            tabConfiguraciones.Size = new Size(992, 572);
            // 
            // panelBusqueda
            // 
            panelBusqueda.Controls.Add(cmbTipoPersonal);
            panelBusqueda.Controls.Add(lblTipoPersonal);
            panelBusqueda.Location = new Point(5, 8);
            panelBusqueda.Margin = new Padding(3, 2, 3, 2);
            panelBusqueda.Size = new Size(980, 133);
            panelBusqueda.Controls.SetChildIndex(lblTipoPersonal, 0);
            panelBusqueda.Controls.SetChildIndex(cmbTipoPersonal, 0);
            panelBusqueda.Controls.SetChildIndex(chkMostrarTodo, 0);
            panelBusqueda.Controls.SetChildIndex(btnNuevo, 0);
            panelBusqueda.Controls.SetChildIndex(btnBuscar, 0);
            panelBusqueda.Controls.SetChildIndex(txtBuscar, 0);
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(3, 2);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Size = new Size(263, 23);
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(196, 29);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Size = new Size(70, 25);
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(634, 35);
            btnNuevo.Margin = new Padding(3, 2, 3, 2);
            btnNuevo.Size = new Size(70, 25);
            // 
            // chkMostrarTodo
            // 
            chkMostrarTodo.Location = new Point(19, 35);
            chkMostrarTodo.Margin = new Padding(3, 2, 3, 2);
            // 
            // panelFormulario
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
            panelFormulario.Location = new Point(3, 2);
            panelFormulario.Margin = new Padding(3, 2, 3, 2);
            panelFormulario.Size = new Size(986, 566);
            panelFormulario.Controls.SetChildIndex(cmbNivel, 0);
            panelFormulario.Controls.SetChildIndex(lblNivel, 0);
            panelFormulario.Controls.SetChildIndex(cmbTurno, 0);
            panelFormulario.Controls.SetChildIndex(lblTurno, 0);
            panelFormulario.Controls.SetChildIndex(txtArea, 0);
            panelFormulario.Controls.SetChildIndex(lblArea, 0);
            panelFormulario.Controls.SetChildIndex(numExperiencia, 0);
            panelFormulario.Controls.SetChildIndex(lblExperiencia, 0);
            panelFormulario.Controls.SetChildIndex(txtUniversidad, 0);
            panelFormulario.Controls.SetChildIndex(lblUniversidad, 0);
            panelFormulario.Controls.SetChildIndex(txtEspecialidad, 0);
            panelFormulario.Controls.SetChildIndex(lblEspecialidad, 0);
            panelFormulario.Controls.SetChildIndex(txtLicencia, 0);
            panelFormulario.Controls.SetChildIndex(lblLicencia, 0);
            panelFormulario.Controls.SetChildIndex(cmbTipoPersonalForm, 0);
            panelFormulario.Controls.SetChildIndex(lblTipoPersonalForm, 0);
            panelFormulario.Controls.SetChildIndex(dtpFechaContratacion, 0);
            panelFormulario.Controls.SetChildIndex(lblFechaContratacion, 0);
            panelFormulario.Controls.SetChildIndex(cmbRolForm, 0);
            panelFormulario.Controls.SetChildIndex(lblRol, 0);
            panelFormulario.Controls.SetChildIndex(txtSalario, 0);
            panelFormulario.Controls.SetChildIndex(lblSalario, 0);
            panelFormulario.Controls.SetChildIndex(txtDireccion, 0);
            panelFormulario.Controls.SetChildIndex(lblDireccion, 0);
            panelFormulario.Controls.SetChildIndex(txtTelefono, 0);
            panelFormulario.Controls.SetChildIndex(lblTelefono, 0);
            panelFormulario.Controls.SetChildIndex(txtContrasena, 0);
            panelFormulario.Controls.SetChildIndex(lblContrasena, 0);
            panelFormulario.Controls.SetChildIndex(txtUsuario, 0);
            panelFormulario.Controls.SetChildIndex(lblUsuario, 0);
            panelFormulario.Controls.SetChildIndex(txtEmail, 0);
            panelFormulario.Controls.SetChildIndex(lblEmail, 0);
            panelFormulario.Controls.SetChildIndex(txtApellido, 0);
            panelFormulario.Controls.SetChildIndex(lblApellido, 0);
            panelFormulario.Controls.SetChildIndex(txtNombre, 0);
            panelFormulario.Controls.SetChildIndex(lblNombre, 0);
            panelFormulario.Controls.SetChildIndex(panelBotones, 0);
            panelFormulario.Controls.SetChildIndex(panelSuperior, 0);
            // 
            // panelSuperior
            // 
            panelSuperior.Location = new Point(9, 8);
            panelSuperior.Margin = new Padding(3, 2, 3, 2);
            panelSuperior.Size = new Size(961, 42);
            // 
            // lblModo
            // 
            lblModo.Location = new Point(9, 11);
            // 
            // cmbModo
            // 
            cmbModo.Location = new Point(74, 11);
            cmbModo.Margin = new Padding(3, 2, 3, 2);
            cmbModo.Size = new Size(106, 23);
            // 
            // lblId
            // 
            lblId.Location = new Point(271, 14);
            // 
            // txtId
            // 
            txtId.Location = new Point(302, 11);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Size = new Size(70, 23);
            // 
            // panelBotones
            // 
            panelBotones.Location = new Point(9, 500);
            panelBotones.Margin = new Padding(3, 2, 3, 2);
            panelBotones.Size = new Size(900, 50);
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(780, 10);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Size = new Size(100, 30);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(400, 10);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Size = new Size(100, 30);
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(10, 10);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Size = new Size(100, 30);
            // 
            // cmbTipoPersonal
            // 
            cmbTipoPersonal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPersonal.Font = new Font("Segoe UI", 9F);
            cmbTipoPersonal.Location = new Point(590, 2);
            cmbTipoPersonal.Margin = new Padding(3, 2, 3, 2);
            cmbTipoPersonal.Name = "cmbTipoPersonal";
            cmbTipoPersonal.Size = new Size(114, 23);
            cmbTipoPersonal.TabIndex = 21;
            // 
            // lblTipoPersonal
            // 
            lblTipoPersonal.AutoSize = true;
            lblTipoPersonal.Font = new Font("Segoe UI", 9F);
            lblTipoPersonal.Location = new Point(502, 4);
            lblTipoPersonal.Name = "lblTipoPersonal";
            lblTipoPersonal.Size = new Size(82, 15);
            lblTipoPersonal.TabIndex = 20;
            lblTipoPersonal.Text = "Tipo Personal:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.White;
            lblNombre.Font = new Font("Segoe UI", 9F);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(26, 60);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.Location = new Point(105, 58);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(176, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F);
            lblApellido.ForeColor = Color.Black;
            lblApellido.Location = new Point(324, 60);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 9F);
            txtApellido.Location = new Point(402, 58);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.MaxLength = 100;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(176, 23);
            txtApellido.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(26, 90);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.Location = new Point(105, 88);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F);
            lblUsuario.ForeColor = Color.Black;
            lblUsuario.Location = new Point(324, 90);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 9F);
            txtUsuario.Location = new Point(402, 88);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.MaxLength = 50;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(176, 23);
            txtUsuario.TabIndex = 7;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI", 9F);
            lblContrasena.ForeColor = Color.Black;
            lblContrasena.Location = new Point(26, 120);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(70, 15);
            lblContrasena.TabIndex = 8;
            lblContrasena.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 9F);
            txtContrasena.Location = new Point(105, 118);
            txtContrasena.Margin = new Padding(3, 2, 3, 2);
            txtContrasena.MaxLength = 255;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(176, 23);
            txtContrasena.TabIndex = 9;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 9F);
            lblTelefono.ForeColor = Color.Black;
            lblTelefono.Location = new Point(324, 120);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 10;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 9F);
            txtTelefono.Location = new Point(402, 118);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.MaxLength = 20;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(176, 23);
            txtTelefono.TabIndex = 11;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 9F);
            lblDireccion.ForeColor = Color.Black;
            lblDireccion.Location = new Point(26, 150);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 12;
            lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 9F);
            txtDireccion.Location = new Point(105, 148);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.MaxLength = 255;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(473, 23);
            txtDireccion.TabIndex = 13;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Font = new Font("Segoe UI", 9F);
            lblSalario.ForeColor = Color.Black;
            lblSalario.Location = new Point(26, 180);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(45, 15);
            lblSalario.TabIndex = 14;
            lblSalario.Text = "Salario:";
            // 
            // txtSalario
            // 
            txtSalario.Font = new Font("Segoe UI", 9F);
            txtSalario.Location = new Point(105, 178);
            txtSalario.Margin = new Padding(3, 2, 3, 2);
            txtSalario.MaxLength = 10;
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(106, 23);
            txtSalario.TabIndex = 15;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 9F);
            lblRol.ForeColor = Color.Black;
            lblRol.Location = new Point(236, 180);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(27, 15);
            lblRol.TabIndex = 16;
            lblRol.Text = "Rol:";
            // 
            // cmbRol
            // 
            cmbRol.Location = new Point(-200, -200);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(121, 23);
            cmbRol.TabIndex = 999;
            cmbRol.Visible = false;
            // 
            // lblFechaContratacion
            // 
            lblFechaContratacion.AutoSize = true;
            lblFechaContratacion.Font = new Font("Segoe UI", 9F);
            lblFechaContratacion.ForeColor = Color.Black;
            lblFechaContratacion.Location = new Point(411, 180);
            lblFechaContratacion.Name = "lblFechaContratacion";
            lblFechaContratacion.Size = new Size(91, 15);
            lblFechaContratacion.TabIndex = 18;
            lblFechaContratacion.Text = "F. Contratación:";
            // 
            // dtpFechaContratacion
            // 
            dtpFechaContratacion.Font = new Font("Segoe UI", 9F);
            dtpFechaContratacion.Format = DateTimePickerFormat.Short;
            dtpFechaContratacion.Location = new Point(516, 178);
            dtpFechaContratacion.Margin = new Padding(3, 2, 3, 2);
            dtpFechaContratacion.Name = "dtpFechaContratacion";
            dtpFechaContratacion.Size = new Size(106, 23);
            dtpFechaContratacion.TabIndex = 19;
            // 
            // lblTipoPersonalForm
            // 
            lblTipoPersonalForm.AutoSize = true;
            lblTipoPersonalForm.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTipoPersonalForm.ForeColor = Color.Black;
            lblTipoPersonalForm.Location = new Point(26, 218);
            lblTipoPersonalForm.Name = "lblTipoPersonalForm";
            lblTipoPersonalForm.Size = new Size(101, 15);
            lblTipoPersonalForm.TabIndex = 20;
            lblTipoPersonalForm.Text = "Tipo de Personal:";
            // 
            // cmbTipoPersonalForm
            // 
            cmbTipoPersonalForm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPersonalForm.Font = new Font("Segoe UI", 9F);
            cmbTipoPersonalForm.Location = new Point(149, 215);
            cmbTipoPersonalForm.Margin = new Padding(3, 2, 3, 2);
            cmbTipoPersonalForm.Name = "cmbTipoPersonalForm";
            cmbTipoPersonalForm.Size = new Size(132, 23);
            cmbTipoPersonalForm.TabIndex = 21;
            // 
            // cmbRolForm
            // 
            cmbRolForm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRolForm.Font = new Font("Segoe UI", 9F);
            cmbRolForm.Location = new Point(280, 178);
            cmbRolForm.Margin = new Padding(3, 2, 3, 2);
            cmbRolForm.Name = "cmbRolForm";
            cmbRolForm.Size = new Size(106, 23);
            cmbRolForm.TabIndex = 17;
            // 
            // lblLicencia
            // 
            lblLicencia.AutoSize = true;
            lblLicencia.Font = new Font("Segoe UI", 9F);
            lblLicencia.ForeColor = Color.Black;
            lblLicencia.Location = new Point(26, 248);
            lblLicencia.Name = "lblLicencia";
            lblLicencia.Size = new Size(86, 15);
            lblLicencia.TabIndex = 22;
            lblLicencia.Text = "Núm. Licencia:";
            // 
            // txtLicencia
            // 
            txtLicencia.Font = new Font("Segoe UI", 9F);
            txtLicencia.Location = new Point(122, 245);
            txtLicencia.Margin = new Padding(3, 2, 3, 2);
            txtLicencia.MaxLength = 50;
            txtLicencia.Name = "txtLicencia";
            txtLicencia.Size = new Size(158, 23);
            txtLicencia.TabIndex = 23;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Segoe UI", 9F);
            lblEspecialidad.ForeColor = Color.Black;
            lblEspecialidad.Location = new Point(324, 218);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(75, 15);
            lblEspecialidad.TabIndex = 24;
            lblEspecialidad.Text = "Especialidad:";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Font = new Font("Segoe UI", 9F);
            txtEspecialidad.Location = new Point(420, 215);
            txtEspecialidad.Margin = new Padding(3, 2, 3, 2);
            txtEspecialidad.MaxLength = 100;
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(176, 23);
            txtEspecialidad.TabIndex = 25;
            // 
            // lblUniversidad
            // 
            lblUniversidad.AutoSize = true;
            lblUniversidad.Font = new Font("Segoe UI", 9F);
            lblUniversidad.ForeColor = Color.Black;
            lblUniversidad.Location = new Point(26, 278);
            lblUniversidad.Name = "lblUniversidad";
            lblUniversidad.Size = new Size(72, 15);
            lblUniversidad.TabIndex = 26;
            lblUniversidad.Text = "Universidad:";
            // 
            // txtUniversidad
            // 
            txtUniversidad.Font = new Font("Segoe UI", 9F);
            txtUniversidad.Location = new Point(122, 275);
            txtUniversidad.Margin = new Padding(3, 2, 3, 2);
            txtUniversidad.MaxLength = 200;
            txtUniversidad.Name = "txtUniversidad";
            txtUniversidad.Size = new Size(263, 23);
            txtUniversidad.TabIndex = 27;
            // 
            // lblExperiencia
            // 
            lblExperiencia.AutoSize = true;
            lblExperiencia.Font = new Font("Segoe UI", 9F);
            lblExperiencia.ForeColor = Color.Black;
            lblExperiencia.Location = new Point(411, 278);
            lblExperiencia.Name = "lblExperiencia";
            lblExperiencia.Size = new Size(99, 15);
            lblExperiencia.TabIndex = 28;
            lblExperiencia.Text = "Años Experiencia:";
            // 
            // numExperiencia
            // 
            numExperiencia.Font = new Font("Segoe UI", 9F);
            numExperiencia.Location = new Point(534, 275);
            numExperiencia.Margin = new Padding(3, 2, 3, 2);
            numExperiencia.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numExperiencia.Name = "numExperiencia";
            numExperiencia.Size = new Size(70, 23);
            numExperiencia.TabIndex = 29;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Segoe UI", 9F);
            lblArea.ForeColor = Color.Black;
            lblArea.Location = new Point(26, 248);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(34, 15);
            lblArea.TabIndex = 30;
            lblArea.Text = "Área:";
            // 
            // txtArea
            // 
            txtArea.Font = new Font("Segoe UI", 9F);
            txtArea.Location = new Point(122, 245);
            txtArea.Margin = new Padding(3, 2, 3, 2);
            txtArea.MaxLength = 100;
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(176, 23);
            txtArea.TabIndex = 31;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Segoe UI", 9F);
            lblTurno.ForeColor = Color.Black;
            lblTurno.Location = new Point(324, 248);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(42, 15);
            lblTurno.TabIndex = 32;
            lblTurno.Text = "Turno:";
            // 
            // cmbTurno
            // 
            cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTurno.Font = new Font("Segoe UI", 9F);
            cmbTurno.Location = new Point(376, 245);
            cmbTurno.Margin = new Padding(3, 2, 3, 2);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(88, 23);
            cmbTurno.TabIndex = 33;
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Segoe UI", 9F);
            lblNivel.ForeColor = Color.Black;
            lblNivel.Location = new Point(490, 248);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(37, 15);
            lblNivel.TabIndex = 34;
            lblNivel.Text = "Nivel:";
            // 
            // cmbNivel
            // 
            cmbNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivel.Font = new Font("Segoe UI", 9F);
            cmbNivel.Location = new Point(542, 245);
            cmbNivel.Margin = new Padding(3, 2, 3, 2);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(79, 23);
            cmbNivel.TabIndex = 35;
            // 
            // PersonalModule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PersonalModule";
            Size = new Size(1000, 600);
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