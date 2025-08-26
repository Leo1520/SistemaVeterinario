namespace SistemVeterinario.Forms
{
    partial class ClientesModule
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
            cmbTipoPersona = new ComboBox();
            lblTipoPersona = new Label();
            lblContador = new Label();
            lblTipoPersonaForm = new Label();
            cmbTipoPersonaForm = new ComboBox();
            grpPersonaFisica = new GroupBox();
            cmbGenero = new ComboBox();
            lblGenero = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblFechaNacimiento = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtCi = new TextBox();
            lblCi = new Label();
            grpPersonaJuridica = new GroupBox();
            txtEncargadoCargo = new TextBox();
            lblEncargadoCargo = new Label();
            txtEncargadoNombre = new TextBox();
            lblEncargadoNombre = new Label();
            txtNit = new TextBox();
            lblNit = new Label();
            txtRazonSocial = new TextBox();
            lblRazonSocial = new Label();
            grpDatosComunes = new GroupBox();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Margin = new Padding(3, 5, 3, 5);
            tabControlPrincipal.Size = new Size(1306, 1067);
            // 
            // tabInicio
            // 
            tabInicio.Margin = new Padding(3, 5, 3, 5);
            tabInicio.Padding = new Padding(3, 5, 3, 5);
            tabInicio.Size = new Size(1298, 1034);
            tabInicio.Text = "Gestión de Personas";
            // 
            // tabConfiguraciones
            // 
            tabConfiguraciones.Margin = new Padding(3, 5, 3, 5);
            tabConfiguraciones.Padding = new Padding(3, 5, 3, 5);
            tabConfiguraciones.Size = new Size(1298, 1034);
            tabConfiguraciones.Text = "Configuración de Persona";
            // 
            // panelBusqueda
            // 
            panelBusqueda.Controls.Add(lblContador);
            panelBusqueda.Controls.Add(lblTipoPersona);
            panelBusqueda.Controls.Add(cmbTipoPersona);
            panelBusqueda.Location = new Point(13, 17);
            panelBusqueda.Margin = new Padding(3, 5, 3, 5);
            panelBusqueda.Size = new Size(1254, 106);
            panelBusqueda.Controls.SetChildIndex(cmbTipoPersona, 0);
            panelBusqueda.Controls.SetChildIndex(lblTipoPersona, 0);
            panelBusqueda.Controls.SetChildIndex(lblContador, 0);
            panelBusqueda.Controls.SetChildIndex(chkMostrarTodo, 0);
            panelBusqueda.Controls.SetChildIndex(btnNuevo, 0);
            panelBusqueda.Controls.SetChildIndex(btnBuscar, 0);
            panelBusqueda.Controls.SetChildIndex(txtBuscar, 0);
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(231, 34);
            txtBuscar.Margin = new Padding(3, 5, 3, 5);
            txtBuscar.PlaceholderText = "Buscar por nombre, CI, NIT, email, razón social...";
            txtBuscar.Size = new Size(398, 27);
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(670, 17);
            btnBuscar.Margin = new Padding(3, 5, 3, 5);
            btnBuscar.Size = new Size(104, 44);
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(1107, 23);
            btnNuevo.Margin = new Padding(3, 5, 3, 5);
            btnNuevo.Size = new Size(104, 44);
            // 
            // chkMostrarTodo
            // 
            chkMostrarTodo.Location = new Point(623, 67);
            chkMostrarTodo.Margin = new Padding(3, 5, 3, 5);
            // 
            // panelFormulario
            // 
            panelFormulario.Controls.Add(grpDatosComunes);
            panelFormulario.Controls.Add(grpPersonaJuridica);
            panelFormulario.Controls.Add(grpPersonaFisica);
            panelFormulario.Controls.Add(cmbTipoPersonaForm);
            panelFormulario.Controls.Add(lblTipoPersonaForm);
            panelFormulario.Location = new Point(3, 5);
            panelFormulario.Margin = new Padding(3, 5, 3, 5);
            panelFormulario.Size = new Size(1292, 1024);
            panelFormulario.Controls.SetChildIndex(lblTipoPersonaForm, 0);
            panelFormulario.Controls.SetChildIndex(cmbTipoPersonaForm, 0);
            panelFormulario.Controls.SetChildIndex(grpPersonaFisica, 0);
            panelFormulario.Controls.SetChildIndex(grpPersonaJuridica, 0);
            panelFormulario.Controls.SetChildIndex(grpDatosComunes, 0);
            panelFormulario.Controls.SetChildIndex(panelBotones, 0);
            panelFormulario.Controls.SetChildIndex(panelSuperior, 0);
            // 
            // panelSuperior
            // 
            panelSuperior.Location = new Point(13, 17);
            panelSuperior.Margin = new Padding(3, 5, 3, 5);
            panelSuperior.Size = new Size(1135, 66);
            // 
            // lblModo
            // 
            lblModo.Location = new Point(13, 27);
            // 
            // cmbModo
            // 
            cmbModo.Location = new Point(91, 21);
            cmbModo.Margin = new Padding(3, 5, 3, 5);
            cmbModo.Size = new Size(156, 28);
            // 
            // lblId
            // 
            lblId.Location = new Point(274, 27);
            // 
            // txtId
            // 
            txtId.Location = new Point(327, 21);
            txtId.Margin = new Padding(3, 5, 3, 5);
            txtId.Size = new Size(103, 27);
            // 
            // panelBotones
            // 
            panelBotones.Location = new Point(0, 665);
            panelBotones.Margin = new Padding(3, 5, 3, 5);
            panelBotones.Size = new Size(1258, 87);
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(957, 17);
            btnGuardar.Margin = new Padding(3, 5, 3, 5);
            btnGuardar.Size = new Size(130, 53);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1101, 17);
            btnCancelar.Margin = new Padding(3, 5, 3, 5);
            btnCancelar.Size = new Size(130, 53);
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(26, 17);
            btnEliminar.Margin = new Padding(3, 5, 3, 5);
            btnEliminar.Size = new Size(130, 53);
            // 
            // cmbTipoPersona
            // 
            cmbTipoPersona.BackColor = Color.White;
            cmbTipoPersona.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPersona.Font = new Font("Segoe UI", 9F);
            cmbTipoPersona.ForeColor = Color.Black;
            cmbTipoPersona.Location = new Point(17, 47);
            cmbTipoPersona.Margin = new Padding(3, 4, 3, 4);
            cmbTipoPersona.Name = "cmbTipoPersona";
            cmbTipoPersona.Size = new Size(171, 28);
            cmbTipoPersona.TabIndex = 4;
            // 
            // lblTipoPersona
            // 
            lblTipoPersona.AutoSize = true;
            lblTipoPersona.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTipoPersona.ForeColor = Color.Black;
            lblTipoPersona.Location = new Point(34, 23);
            lblTipoPersona.Name = "lblTipoPersona";
            lblTipoPersona.Size = new Size(125, 20);
            lblTipoPersona.TabIndex = 5;
            lblTipoPersona.Text = "Tipo de Persona:";
            // 
            // lblContador
            // 
            lblContador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblContador.AutoSize = true;
            lblContador.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblContador.Location = new Point(921, 35);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(148, 20);
            lblContador.TabIndex = 6;
            lblContador.Text = "Total de registros: 0";
            // 
            // lblTipoPersonaForm
            // 
            lblTipoPersonaForm.AutoSize = true;
            lblTipoPersonaForm.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTipoPersonaForm.ForeColor = Color.DarkBlue;
            lblTipoPersonaForm.Location = new Point(17, 87);
            lblTipoPersonaForm.Name = "lblTipoPersonaForm";
            lblTipoPersonaForm.Size = new Size(132, 20);
            lblTipoPersonaForm.TabIndex = 0;
            lblTipoPersonaForm.Text = "Tipo de Persona *";
            // 
            // cmbTipoPersonaForm
            // 
            cmbTipoPersonaForm.BackColor = Color.White;
            cmbTipoPersonaForm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPersonaForm.Font = new Font("Segoe UI", 9F);
            cmbTipoPersonaForm.ForeColor = Color.Black;
            cmbTipoPersonaForm.Location = new Point(149, 83);
            cmbTipoPersonaForm.Margin = new Padding(3, 4, 3, 4);
            cmbTipoPersonaForm.Name = "cmbTipoPersonaForm";
            cmbTipoPersonaForm.Size = new Size(171, 28);
            cmbTipoPersonaForm.TabIndex = 1;
            // 
            // grpPersonaFisica
            // 
            grpPersonaFisica.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpPersonaFisica.Controls.Add(cmbGenero);
            grpPersonaFisica.Controls.Add(lblGenero);
            grpPersonaFisica.Controls.Add(dtpFechaNacimiento);
            grpPersonaFisica.Controls.Add(lblFechaNacimiento);
            grpPersonaFisica.Controls.Add(txtApellido);
            grpPersonaFisica.Controls.Add(lblApellido);
            grpPersonaFisica.Controls.Add(txtNombre);
            grpPersonaFisica.Controls.Add(lblNombre);
            grpPersonaFisica.Controls.Add(txtCi);
            grpPersonaFisica.Controls.Add(lblCi);
            grpPersonaFisica.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpPersonaFisica.ForeColor = Color.DarkBlue;
            grpPersonaFisica.Location = new Point(17, 133);
            grpPersonaFisica.Margin = new Padding(3, 4, 3, 4);
            grpPersonaFisica.Name = "grpPersonaFisica";
            grpPersonaFisica.Padding = new Padding(3, 4, 3, 4);
            grpPersonaFisica.Size = new Size(1099, 160);
            grpPersonaFisica.TabIndex = 2;
            grpPersonaFisica.TabStop = false;
            grpPersonaFisica.Text = "Datos de Persona Física";
            // 
            // cmbGenero
            // 
            cmbGenero.BackColor = Color.White;
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.Font = new Font("Segoe UI", 9F);
            cmbGenero.ForeColor = Color.Black;
            cmbGenero.Location = new Point(383, 103);
            cmbGenero.Margin = new Padding(3, 4, 3, 4);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(91, 28);
            cmbGenero.TabIndex = 9;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Segoe UI", 9F);
            lblGenero.ForeColor = Color.Black;
            lblGenero.Location = new Point(320, 107);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(60, 20);
            lblGenero.TabIndex = 8;
            lblGenero.Text = "Género:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Font = new Font("Segoe UI", 9F);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(160, 103);
            dtpFechaNacimiento.Margin = new Padding(3, 4, 3, 4);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(137, 27);
            dtpFechaNacimiento.TabIndex = 7;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 9F);
            lblFechaNacimiento.ForeColor = Color.Black;
            lblFechaNacimiento.Location = new Point(17, 107);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(152, 20);
            lblFechaNacimiento.TabIndex = 6;
            lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtApellido.BackColor = Color.White;
            txtApellido.Font = new Font("Segoe UI", 9F);
            txtApellido.ForeColor = Color.Black;
            txtApellido.Location = new Point(451, 60);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.MaxLength = 100;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(230, 27);
            txtApellido.TabIndex = 5;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblApellido.ForeColor = Color.DarkRed;
            lblApellido.Location = new Point(451, 33);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(78, 20);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido *";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(206, 60);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 27);
            txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.ForeColor = Color.DarkRed;
            lblNombre.Location = new Point(206, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre *";
            // 
            // txtCi
            // 
            txtCi.BackColor = Color.White;
            txtCi.Font = new Font("Segoe UI", 9F);
            txtCi.ForeColor = Color.Black;
            txtCi.Location = new Point(17, 60);
            txtCi.Margin = new Padding(3, 4, 3, 4);
            txtCi.MaxLength = 15;
            txtCi.Name = "txtCi";
            txtCi.Size = new Size(171, 27);
            txtCi.TabIndex = 1;
            // 
            // lblCi
            // 
            lblCi.AutoSize = true;
            lblCi.Font = new Font("Segoe UI", 9F);
            lblCi.ForeColor = Color.Black;
            lblCi.Location = new Point(17, 33);
            lblCi.Name = "lblCi";
            lblCi.Size = new Size(25, 20);
            lblCi.TabIndex = 0;
            lblCi.Text = "CI:";
            // 
            // grpPersonaJuridica
            // 
            grpPersonaJuridica.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpPersonaJuridica.Controls.Add(txtEncargadoCargo);
            grpPersonaJuridica.Controls.Add(lblEncargadoCargo);
            grpPersonaJuridica.Controls.Add(txtEncargadoNombre);
            grpPersonaJuridica.Controls.Add(lblEncargadoNombre);
            grpPersonaJuridica.Controls.Add(txtNit);
            grpPersonaJuridica.Controls.Add(lblNit);
            grpPersonaJuridica.Controls.Add(txtRazonSocial);
            grpPersonaJuridica.Controls.Add(lblRazonSocial);
            grpPersonaJuridica.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpPersonaJuridica.ForeColor = Color.DarkGreen;
            grpPersonaJuridica.Location = new Point(17, 133);
            grpPersonaJuridica.Margin = new Padding(3, 4, 3, 4);
            grpPersonaJuridica.Name = "grpPersonaJuridica";
            grpPersonaJuridica.Padding = new Padding(3, 4, 3, 4);
            grpPersonaJuridica.Size = new Size(1099, 160);
            grpPersonaJuridica.TabIndex = 3;
            grpPersonaJuridica.TabStop = false;
            grpPersonaJuridica.Text = "Datos de Persona Jurídica";
            grpPersonaJuridica.Visible = false;
            // 
            // txtEncargadoCargo
            // 
            txtEncargadoCargo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEncargadoCargo.Font = new Font("Segoe UI", 9F);
            txtEncargadoCargo.Location = new Point(560, 103);
            txtEncargadoCargo.Margin = new Padding(3, 4, 3, 4);
            txtEncargadoCargo.MaxLength = 100;
            txtEncargadoCargo.Name = "txtEncargadoCargo";
            txtEncargadoCargo.Size = new Size(230, 27);
            txtEncargadoCargo.TabIndex = 7;
            // 
            // lblEncargadoCargo
            // 
            lblEncargadoCargo.AutoSize = true;
            lblEncargadoCargo.Font = new Font("Segoe UI", 9F);
            lblEncargadoCargo.ForeColor = Color.Black;
            lblEncargadoCargo.Location = new Point(423, 107);
            lblEncargadoCargo.Name = "lblEncargadoCargo";
            lblEncargadoCargo.Size = new Size(152, 20);
            lblEncargadoCargo.TabIndex = 6;
            lblEncargadoCargo.Text = "Cargo del Encargado:";
            // 
            // txtEncargadoNombre
            // 
            txtEncargadoNombre.Font = new Font("Segoe UI", 9F);
            txtEncargadoNombre.Location = new Point(171, 103);
            txtEncargadoNombre.Margin = new Padding(3, 4, 3, 4);
            txtEncargadoNombre.MaxLength = 100;
            txtEncargadoNombre.Name = "txtEncargadoNombre";
            txtEncargadoNombre.Size = new Size(228, 27);
            txtEncargadoNombre.TabIndex = 5;
            // 
            // lblEncargadoNombre
            // 
            lblEncargadoNombre.AutoSize = true;
            lblEncargadoNombre.Font = new Font("Segoe UI", 9F);
            lblEncargadoNombre.ForeColor = Color.Black;
            lblEncargadoNombre.Location = new Point(17, 107);
            lblEncargadoNombre.Name = "lblEncargadoNombre";
            lblEncargadoNombre.Size = new Size(167, 20);
            lblEncargadoNombre.TabIndex = 4;
            lblEncargadoNombre.Text = "Nombre del Encargado:";
            // 
            // txtNit
            // 
            txtNit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNit.Font = new Font("Segoe UI", 9F);
            txtNit.Location = new Point(499, 60);
            txtNit.Margin = new Padding(3, 4, 3, 4);
            txtNit.MaxLength = 15;
            txtNit.Name = "txtNit";
            txtNit.Size = new Size(171, 27);
            txtNit.TabIndex = 3;
            // 
            // lblNit
            // 
            lblNit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNit.AutoSize = true;
            lblNit.Font = new Font("Segoe UI", 9F);
            lblNit.ForeColor = Color.Black;
            lblNit.Location = new Point(499, 33);
            lblNit.Name = "lblNit";
            lblNit.Size = new Size(35, 20);
            lblNit.TabIndex = 2;
            lblNit.Text = "NIT:";
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRazonSocial.Font = new Font("Segoe UI", 9F);
            txtRazonSocial.Location = new Point(17, 60);
            txtRazonSocial.Margin = new Padding(3, 4, 3, 4);
            txtRazonSocial.MaxLength = 255;
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(459, 27);
            txtRazonSocial.TabIndex = 1;
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.AutoSize = true;
            lblRazonSocial.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRazonSocial.ForeColor = Color.DarkRed;
            lblRazonSocial.Location = new Point(17, 33);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(107, 20);
            lblRazonSocial.TabIndex = 0;
            lblRazonSocial.Text = "Razón Social *";
            // 
            // grpDatosComunes
            // 
            grpDatosComunes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDatosComunes.Controls.Add(txtTelefono);
            grpDatosComunes.Controls.Add(lblTelefono);
            grpDatosComunes.Controls.Add(txtDireccion);
            grpDatosComunes.Controls.Add(lblDireccion);
            grpDatosComunes.Controls.Add(txtEmail);
            grpDatosComunes.Controls.Add(lblEmail);
            grpDatosComunes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpDatosComunes.ForeColor = Color.DarkSlateGray;
            grpDatosComunes.Location = new Point(17, 313);
            grpDatosComunes.Margin = new Padding(3, 4, 3, 4);
            grpDatosComunes.Name = "grpDatosComunes";
            grpDatosComunes.Padding = new Padding(3, 4, 3, 4);
            grpDatosComunes.Size = new Size(1099, 212);
            grpDatosComunes.TabIndex = 4;
            grpDatosComunes.TabStop = false;
            grpDatosComunes.Text = "Datos de Contacto";
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTelefono.BackColor = Color.White;
            txtTelefono.Font = new Font("Segoe UI", 9F);
            txtTelefono.ForeColor = Color.Black;
            txtTelefono.Location = new Point(745, 133);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.MaxLength = 15;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(171, 27);
            txtTelefono.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 9F);
            lblTelefono.ForeColor = Color.Black;
            lblTelefono.Location = new Point(745, 107);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDireccion.BackColor = Color.White;
            txtDireccion.Font = new Font("Segoe UI", 9F);
            txtDireccion.ForeColor = Color.Black;
            txtDireccion.Location = new Point(17, 133);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.MaxLength = 255;
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.ScrollBars = ScrollBars.Vertical;
            txtDireccion.Size = new Size(687, 52);
            txtDireccion.TabIndex = 3;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 9F);
            lblDireccion.ForeColor = Color.Black;
            lblDireccion.Location = new Point(17, 107);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 20);
            lblDireccion.TabIndex = 2;
            lblDireccion.Text = "Dirección:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(17, 60);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(459, 27);
            txtEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(17, 33);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // PersonasModule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Margin = new Padding(3, 5, 3, 5);
            Name = "PersonasModule";
            Size = new Size(1306, 1067);
        }

        #endregion

        private ComboBox cmbTipoPersona;
        private Label lblTipoPersona;
        private Label lblContador;
        private Label lblTipoPersonaForm;
        private ComboBox cmbTipoPersonaForm;
        private GroupBox grpPersonaFisica;
        private Label lblCi;
        private TextBox txtCi;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblGenero;
        private ComboBox cmbGenero;
        private GroupBox grpPersonaJuridica;
        private Label lblRazonSocial;
        private TextBox txtRazonSocial;
        private Label lblNit;
        private TextBox txtNit;
        private Label lblEncargadoNombre;
        private TextBox txtEncargadoNombre;
        private Label lblEncargadoCargo;
        private TextBox txtEncargadoCargo;
        private GroupBox grpDatosComunes;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblTelefono;
        private TextBox txtTelefono;
    }
}
