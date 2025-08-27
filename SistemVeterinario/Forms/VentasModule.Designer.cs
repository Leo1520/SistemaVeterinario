using System.Drawing;
using System.Windows.Forms;

namespace SistemVeterinario.Forms
{
    partial class VentasModule
    {
        private System.ComponentModel.IContainer components = null;

        // Controles específicos de ventas
        private Label lblBuscarPersona;
        private TextBox txtBuscarPersonaId;
        private Button btnRefrescar;
        private Label lblTotalRegistros;
        private GroupBox grpDatosFactura;
        private Label lblNumeroFactura;
        private TextBox txtNumeroFactura;
        private Label lblPersonaId;
        private TextBox txtPersonaId;
        private Label lblFechaEmision;
        private DateTimePicker dtpFechaEmision;
        private Label lblFechaVencimiento;
        private DateTimePicker dtpFechaVencimiento;
        private CheckBox chkTieneFechaVencimiento;
        private Label lblEstado;
        private ComboBox cmbEstado;
        private GroupBox grpMontos;
        private Label lblImpuestos;
        private NumericUpDown nudImpuestos;
        private Label lblDescuentos;
        private NumericUpDown nudDescuentos;
        private CheckBox chkFinalizar;
        private GroupBox grpDetalles;
        private Label lblNotas;
        private TextBox txtNotas;
        private Label lblProductos;
        private TextBox txtProductosJson;
        private Label lblServicios;
        private TextBox txtServiciosJson;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private new void InitializeComponent()
        {
            lblBuscarPersona = new Label();
            txtBuscarPersonaId = new TextBox();
            btnRefrescar = new Button();
            lblTotalRegistros = new Label();
            grpDatosFactura = new GroupBox();
            lblNumeroFactura = new Label();
            txtNumeroFactura = new TextBox();
            lblPersonaId = new Label();
            txtPersonaId = new TextBox();
            lblFechaEmision = new Label();
            dtpFechaEmision = new DateTimePicker();
            chkTieneFechaVencimiento = new CheckBox();
            dtpFechaVencimiento = new DateTimePicker();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            lblFechaVencimiento = new Label();
            grpMontos = new GroupBox();
            lblImpuestos = new Label();
            nudImpuestos = new NumericUpDown();
            lblDescuentos = new Label();
            nudDescuentos = new NumericUpDown();
            chkFinalizar = new CheckBox();
            grpDetalles = new GroupBox();
            lblNotas = new Label();
            txtNotas = new TextBox();
            lblProductos = new Label();
            txtProductosJson = new TextBox();
            lblServicios = new Label();
            txtServiciosJson = new TextBox();
            tabControlPrincipal.SuspendLayout();
            tabInicio.SuspendLayout();
            tabConfiguraciones.SuspendLayout();
            panelBusqueda.SuspendLayout();
            panelFormulario.SuspendLayout();
            panelSuperior.SuspendLayout();
            panelBotones.SuspendLayout();
            grpDatosFactura.SuspendLayout();
            grpMontos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudImpuestos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDescuentos).BeginInit();
            grpDetalles.SuspendLayout();
            SuspendLayout();
            // 
            // tabInicio
            // 
            tabInicio.Text = "Gestión de Ventas";
            // 
            // tabConfiguraciones
            // 
            tabConfiguraciones.Text = "Configuración de Ventas";
            // 
            // panelBusqueda
            // 
            panelBusqueda.Controls.Add(lblBuscarPersona);
            panelBusqueda.Controls.Add(txtBuscarPersonaId);
            panelBusqueda.Controls.Add(btnRefrescar);
            panelBusqueda.Controls.Add(lblTotalRegistros);
            panelBusqueda.Controls.SetChildIndex(lblTotalRegistros, 0);
            panelBusqueda.Controls.SetChildIndex(btnRefrescar, 0);
            panelBusqueda.Controls.SetChildIndex(txtBuscarPersonaId, 0);
            panelBusqueda.Controls.SetChildIndex(lblBuscarPersona, 0);
            panelBusqueda.Controls.SetChildIndex(chkMostrarTodo, 0);
            panelBusqueda.Controls.SetChildIndex(btnNuevo, 0);
            panelBusqueda.Controls.SetChildIndex(btnBuscar, 0);
            panelBusqueda.Controls.SetChildIndex(txtBuscar, 0);
            // 
            // panelFormulario
            // 
            panelFormulario.Controls.Add(grpDatosFactura);
            panelFormulario.Controls.Add(grpMontos);
            panelFormulario.Controls.Add(grpDetalles);
            panelFormulario.Controls.SetChildIndex(grpDetalles, 0);
            panelFormulario.Controls.SetChildIndex(grpMontos, 0);
            panelFormulario.Controls.SetChildIndex(grpDatosFactura, 0);
            panelFormulario.Controls.SetChildIndex(panelBotones, 0);
            panelFormulario.Controls.SetChildIndex(panelSuperior, 0);
            // 
            // lblBuscarPersona
            // 
            lblBuscarPersona.Location = new Point(10, 15);
            lblBuscarPersona.Name = "lblBuscarPersona";
            lblBuscarPersona.Size = new Size(100, 20);
            lblBuscarPersona.TabIndex = 4;
            lblBuscarPersona.Text = "Buscar Persona ID:";
            // 
            // txtBuscarPersonaId
            // 
            txtBuscarPersonaId.Location = new Point(160, 85);
            txtBuscarPersonaId.Name = "txtBuscarPersonaId";
            txtBuscarPersonaId.Size = new Size(150, 23);
            txtBuscarPersonaId.TabIndex = 5;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(320, 85);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(80, 25);
            btnRefrescar.TabIndex = 6;
            btnRefrescar.Text = "Refrescar";
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.Location = new Point(420, 60);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(100, 20);
            lblTotalRegistros.TabIndex = 7;
            lblTotalRegistros.Text = "Total: 0";
            // 
            // grpDatosFactura
            // 
            grpDatosFactura.Controls.Add(lblNumeroFactura);
            grpDatosFactura.Controls.Add(txtNumeroFactura);
            grpDatosFactura.Controls.Add(lblPersonaId);
            grpDatosFactura.Controls.Add(txtPersonaId);
            grpDatosFactura.Controls.Add(lblFechaEmision);
            grpDatosFactura.Controls.Add(dtpFechaEmision);
            grpDatosFactura.Controls.Add(chkTieneFechaVencimiento);
            grpDatosFactura.Controls.Add(dtpFechaVencimiento);
            grpDatosFactura.Controls.Add(lblEstado);
            grpDatosFactura.Controls.Add(cmbEstado);
            grpDatosFactura.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpDatosFactura.ForeColor = Color.DarkBlue;
            grpDatosFactura.Location = new Point(15, 100);
            grpDatosFactura.Name = "grpDatosFactura";
            grpDatosFactura.Size = new Size(560, 180);
            grpDatosFactura.TabIndex = 2;
            grpDatosFactura.TabStop = false;
            grpDatosFactura.Text = "Datos de la Factura";
            // 
            // lblNumeroFactura
            // 
            lblNumeroFactura.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNumeroFactura.ForeColor = Color.DarkRed;
            lblNumeroFactura.Location = new Point(15, 30);
            lblNumeroFactura.Name = "lblNumeroFactura";
            lblNumeroFactura.Size = new Size(130, 20);
            lblNumeroFactura.TabIndex = 0;
            lblNumeroFactura.Text = "Número de Factura *:";
            // 
            // txtNumeroFactura
            // 
            txtNumeroFactura.Location = new Point(150, 28);
            txtNumeroFactura.MaxLength = 50;
            txtNumeroFactura.Name = "txtNumeroFactura";
            txtNumeroFactura.Size = new Size(150, 23);
            txtNumeroFactura.TabIndex = 1;
            // 
            // lblPersonaId
            // 
            lblPersonaId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPersonaId.ForeColor = Color.DarkRed;
            lblPersonaId.Location = new Point(315, 30);
            lblPersonaId.Name = "lblPersonaId";
            lblPersonaId.Size = new Size(80, 20);
            lblPersonaId.TabIndex = 2;
            lblPersonaId.Text = "ID Persona *:";
            // 
            // txtPersonaId
            // 
            txtPersonaId.Location = new Point(405, 28);
            txtPersonaId.Name = "txtPersonaId";
            txtPersonaId.Size = new Size(100, 23);
            txtPersonaId.TabIndex = 3;
            // 
            // lblFechaEmision
            // 
            lblFechaEmision.AutoSize = true;
            lblFechaEmision.Location = new Point(15, 65);
            lblFechaEmision.Name = "lblFechaEmision";
            lblFechaEmision.Size = new Size(87, 15);
            lblFechaEmision.TabIndex = 4;
            lblFechaEmision.Text = "Fecha Emisión:";
            // 
            // dtpFechaEmision
            // 
            dtpFechaEmision.Format = DateTimePickerFormat.Short;
            dtpFechaEmision.Location = new Point(150, 63);
            dtpFechaEmision.Name = "dtpFechaEmision";
            dtpFechaEmision.Size = new Size(150, 23);
            dtpFechaEmision.TabIndex = 5;
            // 
            // chkTieneFechaVencimiento
            // 
            chkTieneFechaVencimiento.Checked = true;
            chkTieneFechaVencimiento.CheckState = CheckState.Checked;
            chkTieneFechaVencimiento.Location = new Point(315, 65);
            chkTieneFechaVencimiento.Name = "chkTieneFechaVencimiento";
            chkTieneFechaVencimiento.Size = new Size(130, 20);
            chkTieneFechaVencimiento.TabIndex = 6;
            chkTieneFechaVencimiento.Text = "Fecha Vencimiento:";
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Format = DateTimePickerFormat.Short;
            dtpFechaVencimiento.Location = new Point(315, 88);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(150, 23);
            dtpFechaVencimiento.TabIndex = 7;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(15, 100);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(46, 15);
            lblEstado.TabIndex = 8;
            lblEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Location = new Point(150, 98);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(150, 23);
            cmbEstado.TabIndex = 9;
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.Location = new Point(0, 0);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(100, 23);
            lblFechaVencimiento.TabIndex = 0;
            // 
            // grpMontos
            // 
            grpMontos.Controls.Add(lblImpuestos);
            grpMontos.Controls.Add(nudImpuestos);
            grpMontos.Controls.Add(lblDescuentos);
            grpMontos.Controls.Add(nudDescuentos);
            grpMontos.Controls.Add(chkFinalizar);
            grpMontos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpMontos.ForeColor = Color.DarkGreen;
            grpMontos.Location = new Point(580, 100);
            grpMontos.Name = "grpMontos";
            grpMontos.Size = new Size(280, 120);
            grpMontos.TabIndex = 3;
            grpMontos.TabStop = false;
            grpMontos.Text = "Montos";
            // 
            // lblImpuestos
            // 
            lblImpuestos.AutoSize = true;
            lblImpuestos.Location = new Point(15, 30);
            lblImpuestos.Name = "lblImpuestos";
            lblImpuestos.Size = new Size(68, 15);
            lblImpuestos.TabIndex = 0;
            lblImpuestos.Text = "Impuestos:";
            // 
            // nudImpuestos
            // 
            nudImpuestos.DecimalPlaces = 2;
            nudImpuestos.Location = new Point(95, 28);
            nudImpuestos.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudImpuestos.Name = "nudImpuestos";
            nudImpuestos.Size = new Size(120, 23);
            nudImpuestos.TabIndex = 1;
            // 
            // lblDescuentos
            // 
            lblDescuentos.AutoSize = true;
            lblDescuentos.Location = new Point(15, 65);
            lblDescuentos.Name = "lblDescuentos";
            lblDescuentos.Size = new Size(75, 15);
            lblDescuentos.TabIndex = 2;
            lblDescuentos.Text = "Descuentos:";
            // 
            // nudDescuentos
            // 
            nudDescuentos.DecimalPlaces = 2;
            nudDescuentos.Location = new Point(95, 63);
            nudDescuentos.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudDescuentos.Name = "nudDescuentos";
            nudDescuentos.Size = new Size(120, 23);
            nudDescuentos.TabIndex = 3;
            // 
            // chkFinalizar
            // 
            chkFinalizar.Location = new Point(15, 90);
            chkFinalizar.Name = "chkFinalizar";
            chkFinalizar.Size = new Size(120, 20);
            chkFinalizar.TabIndex = 4;
            chkFinalizar.Text = "Finalizar Factura";
            // 
            // grpDetalles
            // 
            grpDetalles.Controls.Add(lblNotas);
            grpDetalles.Controls.Add(txtNotas);
            grpDetalles.Controls.Add(lblProductos);
            grpDetalles.Controls.Add(txtProductosJson);
            grpDetalles.Controls.Add(lblServicios);
            grpDetalles.Controls.Add(txtServiciosJson);
            grpDetalles.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpDetalles.ForeColor = Color.DarkSlateGray;
            grpDetalles.Location = new Point(15, 290);
            grpDetalles.Name = "grpDetalles";
            grpDetalles.Size = new Size(845, 180);
            grpDetalles.TabIndex = 4;
            grpDetalles.TabStop = false;
            grpDetalles.Text = "Detalles";
            // 
            // lblNotas
            // 
            lblNotas.AutoSize = true;
            lblNotas.Location = new Point(15, 30);
            lblNotas.Name = "lblNotas";
            lblNotas.Size = new Size(42, 15);
            lblNotas.TabIndex = 0;
            lblNotas.Text = "Notas:";
            // 
            // txtNotas
            // 
            txtNotas.Location = new Point(15, 53);
            txtNotas.Multiline = true;
            txtNotas.Name = "txtNotas";
            txtNotas.ScrollBars = ScrollBars.Vertical;
            txtNotas.Size = new Size(820, 40);
            txtNotas.TabIndex = 1;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Location = new Point(15, 105);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(107, 15);
            lblProductos.TabIndex = 2;
            lblProductos.Text = "Productos (JSON):";
            // 
            // txtProductosJson
            // 
            txtProductosJson.Font = new Font("Consolas", 9F);
            txtProductosJson.Location = new Point(15, 128);
            txtProductosJson.Multiline = true;
            txtProductosJson.Name = "txtProductosJson";
            txtProductosJson.ScrollBars = ScrollBars.Vertical;
            txtProductosJson.Size = new Size(400, 40);
            txtProductosJson.TabIndex = 3;
            // 
            // lblServicios
            // 
            lblServicios.AutoSize = true;
            lblServicios.Location = new Point(435, 105);
            lblServicios.Name = "lblServicios";
            lblServicios.Size = new Size(101, 15);
            lblServicios.TabIndex = 4;
            lblServicios.Text = "Servicios (JSON):";
            // 
            // txtServiciosJson
            // 
            txtServiciosJson.Font = new Font("Consolas", 9F);
            txtServiciosJson.Location = new Point(435, 128);
            txtServiciosJson.Multiline = true;
            txtServiciosJson.Name = "txtServiciosJson";
            txtServiciosJson.ScrollBars = ScrollBars.Vertical;
            txtServiciosJson.Size = new Size(400, 40);
            txtServiciosJson.TabIndex = 5;
            // 
            // VentasModule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            Name = "VentasModule";
            tabControlPrincipal.ResumeLayout(false);
            tabInicio.ResumeLayout(false);
            tabConfiguraciones.ResumeLayout(false);
            panelBusqueda.ResumeLayout(false);
            panelBusqueda.PerformLayout();
            panelFormulario.ResumeLayout(false);
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelBotones.ResumeLayout(false);
            grpDatosFactura.ResumeLayout(false);
            grpDatosFactura.PerformLayout();
            grpMontos.ResumeLayout(false);
            grpMontos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudImpuestos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDescuentos).EndInit();
            grpDetalles.ResumeLayout(false);
            grpDetalles.PerformLayout();
            ResumeLayout(false);
        }
    }
}