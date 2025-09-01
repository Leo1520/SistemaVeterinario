namespace SistemVeterinario.Forms
{
    partial class VentasModule
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private new void InitializeComponent()
        {
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.txtPersonaId = new System.Windows.Forms.TextBox();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.txtProductosJson = new System.Windows.Forms.TextBox();
            this.txtServiciosJson = new System.Windows.Forms.TextBox();
            this.txtBuscarPersonaId = new System.Windows.Forms.TextBox();
            this.txtClienteSeleccionado = new System.Windows.Forms.TextBox();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbEstadoFiltro = new System.Windows.Forms.ComboBox();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.chkTieneFechaVencimiento = new System.Windows.Forms.CheckBox();
            this.chkFinalizar = new System.Windows.Forms.CheckBox();
            this.nudImpuestos = new System.Windows.Forms.NumericUpDown();
            this.nudDescuentos = new System.Windows.Forms.NumericUpDown();
            this.nudSubtotal = new System.Windows.Forms.NumericUpDown();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.btnGenerarNumero = new System.Windows.Forms.Button();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.btnAgregarServicios = new System.Windows.Forms.Button();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.tabControlPrincipal.SuspendLayout();
            this.tabInicio.SuspendLayout();
            this.tabConfiguraciones.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.panelFormulario.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImpuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubtotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // tabInicio
            // 
            this.tabInicio.Location = new System.Drawing.Point(4, 39);
            this.tabInicio.Size = new System.Drawing.Size(1135, 597);
            // 
            // tabConfiguraciones
            // 
            this.tabConfiguraciones.Location = new System.Drawing.Point(4, 39);
            this.tabConfiguraciones.Size = new System.Drawing.Size(1135, 597);
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Size = new System.Drawing.Size(1112, 128);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Size = new System.Drawing.Size(515, 32);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Location = new System.Drawing.Point(555, 25);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.Location = new System.Drawing.Point(894, 23);
            // 
            // chkMostrarTodo
            // 
            this.chkMostrarTodo.Location = new System.Drawing.Point(119, 80);
            // 
            // panelFormulario
            // 
            this.panelFormulario.Size = new System.Drawing.Size(1113, 575);
            // 
            // panelSuperior
            // 
            this.panelSuperior.Size = new System.Drawing.Size(1078, 64);
            // 
            // panelBotones
            // 
            this.panelBotones.Location = new System.Drawing.Point(17, 495);
            this.panelBotones.Size = new System.Drawing.Size(1078, 64);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Location = new System.Drawing.Point(918, 16);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Location = new System.Drawing.Point(763, 16);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(120, 50);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(150, 22);
            this.txtNumeroFactura.TabIndex = 0;
            // 
            // txtPersonaId
            // 
            this.txtPersonaId.Location = new System.Drawing.Point(120, 80);
            this.txtPersonaId.Name = "txtPersonaId";
            this.txtPersonaId.Size = new System.Drawing.Size(100, 22);
            this.txtPersonaId.TabIndex = 1;
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(120, 110);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(300, 60);
            this.txtNotas.TabIndex = 2;
            // 
            // txtProductosJson
            // 
            this.txtProductosJson.Location = new System.Drawing.Point(120, 180);
            this.txtProductosJson.Multiline = true;
            this.txtProductosJson.Name = "txtProductosJson";
            this.txtProductosJson.Size = new System.Drawing.Size(300, 40);
            this.txtProductosJson.TabIndex = 3;
            this.txtProductosJson.Visible = false;
            // 
            // txtServiciosJson
            // 
            this.txtServiciosJson.Location = new System.Drawing.Point(120, 230);
            this.txtServiciosJson.Multiline = true;
            this.txtServiciosJson.Name = "txtServiciosJson";
            this.txtServiciosJson.Size = new System.Drawing.Size(300, 40);
            this.txtServiciosJson.TabIndex = 4;
            this.txtServiciosJson.Visible = false;
            // 
            // txtBuscarPersonaId
            // 
            this.txtBuscarPersonaId.Location = new System.Drawing.Point(450, 50);
            this.txtBuscarPersonaId.Name = "txtBuscarPersonaId";
            this.txtBuscarPersonaId.Size = new System.Drawing.Size(100, 22);
            this.txtBuscarPersonaId.TabIndex = 5;
            // 
            // txtClienteSeleccionado
            // 
            this.txtClienteSeleccionado.Location = new System.Drawing.Point(450, 80);
            this.txtClienteSeleccionado.Name = "txtClienteSeleccionado";
            this.txtClienteSeleccionado.ReadOnly = true;
            this.txtClienteSeleccionado.Size = new System.Drawing.Size(200, 22);
            this.txtClienteSeleccionado.TabIndex = 6;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(450, 110);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(200, 22);
            this.txtBuscarCliente.TabIndex = 7;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(120, 280);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(150, 24);
            this.cmbEstado.TabIndex = 8;
            // 
            // cmbEstadoFiltro
            // 
            this.cmbEstadoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoFiltro.FormattingEnabled = true;
            this.cmbEstadoFiltro.Location = new System.Drawing.Point(450, 140);
            this.cmbEstadoFiltro.Name = "cmbEstadoFiltro";
            this.cmbEstadoFiltro.Size = new System.Drawing.Size(150, 24);
            this.cmbEstadoFiltro.TabIndex = 9;
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEmision.Location = new System.Drawing.Point(120, 310);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(100, 22);
            this.dtpFechaEmision.TabIndex = 10;
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(250, 310);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(100, 22);
            this.dtpFechaVencimiento.TabIndex = 11;
            // 
            // chkTieneFechaVencimiento
            // 
            this.chkTieneFechaVencimiento.AutoSize = true;
            this.chkTieneFechaVencimiento.Location = new System.Drawing.Point(120, 340);
            this.chkTieneFechaVencimiento.Name = "chkTieneFechaVencimiento";
            this.chkTieneFechaVencimiento.Size = new System.Drawing.Size(130, 17);
            this.chkTieneFechaVencimiento.TabIndex = 12;
            this.chkTieneFechaVencimiento.Text = "Tiene fecha vencimiento";
            this.chkTieneFechaVencimiento.UseVisualStyleBackColor = true;
            // 
            // chkFinalizar
            // 
            this.chkFinalizar.AutoSize = true;
            this.chkFinalizar.Location = new System.Drawing.Point(280, 340);
            this.chkFinalizar.Name = "chkFinalizar";
            this.chkFinalizar.Size = new System.Drawing.Size(65, 17);
            this.chkFinalizar.TabIndex = 13;
            this.chkFinalizar.Text = "Finalizar";
            this.chkFinalizar.UseVisualStyleBackColor = true;
            // 
            // nudImpuestos
            // 
            this.nudImpuestos.DecimalPlaces = 2;
            this.nudImpuestos.Location = new System.Drawing.Point(120, 370);
            this.nudImpuestos.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudImpuestos.Name = "nudImpuestos";
            this.nudImpuestos.Size = new System.Drawing.Size(80, 22);
            this.nudImpuestos.TabIndex = 14;
            // 
            // nudDescuentos
            // 
            this.nudDescuentos.DecimalPlaces = 2;
            this.nudDescuentos.Location = new System.Drawing.Point(220, 370);
            this.nudDescuentos.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudDescuentos.Name = "nudDescuentos";
            this.nudDescuentos.Size = new System.Drawing.Size(80, 22);
            this.nudDescuentos.TabIndex = 15;
            // 
            // nudSubtotal
            // 
            this.nudSubtotal.DecimalPlaces = 2;
            this.nudSubtotal.Location = new System.Drawing.Point(320, 370);
            this.nudSubtotal.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudSubtotal.Name = "nudSubtotal";
            this.nudSubtotal.ReadOnly = true;
            this.nudSubtotal.Size = new System.Drawing.Size(80, 22);
            this.nudSubtotal.TabIndex = 16;
            // 
            // nudTotal
            // 
            this.nudTotal.DecimalPlaces = 2;
            this.nudTotal.Location = new System.Drawing.Point(420, 370);
            this.nudTotal.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudTotal.Name = "nudTotal";
            this.nudTotal.ReadOnly = true;
            this.nudTotal.Size = new System.Drawing.Size(80, 22);
            this.nudTotal.TabIndex = 17;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(680, 50);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 18;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(680, 80);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(100, 23);
            this.btnSeleccionarCliente.TabIndex = 19;
            this.btnSeleccionarCliente.Text = "Seleccionar Cliente";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(680, 110);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(100, 23);
            this.btnLimpiarFiltros.TabIndex = 20;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            // 
            // btnGenerarNumero
            // 
            this.btnGenerarNumero.Location = new System.Drawing.Point(280, 50);
            this.btnGenerarNumero.Name = "btnGenerarNumero";
            this.btnGenerarNumero.Size = new System.Drawing.Size(100, 23);
            this.btnGenerarNumero.TabIndex = 21;
            this.btnGenerarNumero.Text = "Generar Número";
            this.btnGenerarNumero.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.Location = new System.Drawing.Point(450, 180);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(120, 23);
            this.btnAgregarProductos.TabIndex = 22;
            this.btnAgregarProductos.Text = "Agregar Productos";
            this.btnAgregarProductos.UseVisualStyleBackColor = true;
            // 
            // btnAgregarServicios
            // 
            this.btnAgregarServicios.Location = new System.Drawing.Point(450, 210);
            this.btnAgregarServicios.Name = "btnAgregarServicios";
            this.btnAgregarServicios.Size = new System.Drawing.Size(120, 23);
            this.btnAgregarServicios.TabIndex = 23;
            this.btnAgregarServicios.Text = "Agregar Servicios";
            this.btnAgregarServicios.UseVisualStyleBackColor = true;
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(450, 250);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(85, 13);
            this.lblTotalRegistros.TabIndex = 24;
            this.lblTotalRegistros.Text = "Total registros: 0";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(450, 280);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(350, 150);
            this.dgvItems.TabIndex = 25;
            // 
            // VentasModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Name = "VentasModule";
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabInicio.ResumeLayout(false);
            this.tabConfiguraciones.ResumeLayout(false);
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.panelFormulario.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudImpuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubtotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // Controles básicos
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.TextBox txtPersonaId;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.TextBox txtProductosJson;
        private System.Windows.Forms.TextBox txtServiciosJson;
        private System.Windows.Forms.TextBox txtBuscarPersonaId;
        private System.Windows.Forms.TextBox txtClienteSeleccionado;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbEstadoFiltro;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.CheckBox chkTieneFechaVencimiento;
        private System.Windows.Forms.CheckBox chkFinalizar;
        private System.Windows.Forms.NumericUpDown nudImpuestos;
        private System.Windows.Forms.NumericUpDown nudDescuentos;
        private System.Windows.Forms.NumericUpDown nudSubtotal;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnSeleccionarCliente;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Button btnGenerarNumero;
        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.Button btnAgregarServicios;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.DataGridView dgvItems;
    }
}
