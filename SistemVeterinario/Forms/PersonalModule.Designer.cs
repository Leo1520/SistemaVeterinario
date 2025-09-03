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
            this.tabControlPrincipal.SuspendLayout();
            this.tabInicio.SuspendLayout();
            this.tabConfiguraciones.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.panelFormulario.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panelBotones.SuspendLayout();
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
            this.btnNuevo.Location = new System.Drawing.Point(944, 25);
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
            // PersonalModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Name = "PersonalModule";
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabInicio.ResumeLayout(false);
            this.tabConfiguraciones.ResumeLayout(false);
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.panelFormulario.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cmbTipoPersonal;
        private Label lblTipoPersonal;
        private Label lblContador;
        private Label lblTipoPersonalForm;
        private ComboBox cmbTipoPersonalForm;
        private GroupBox grpDatosPersonales;
        private TableLayoutPanel tableLayoutPersonales;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private GroupBox grpDatosLaborales;
        private TableLayoutPanel tableLayoutLaborales;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblContrasena;
        private TextBox txtContrasena;
        private Label lblSalario;
        private TextBox txtSalario;
        private Label lblRol;
        private ComboBox cmbRol;
        private Label lblFechaContratacion;
        private DateTimePicker dtpFechaContratacion;
        private GroupBox grpDatosEspecificos;
        private TableLayoutPanel tableLayoutEspecificos;
        private Label lblLicencia;
        private TextBox txtLicencia;
        private Label lblEspecialidad;
        private TextBox txtEspecialidad;
        private Label lblUniversidad;
        private TextBox txtUniversidad;
        private Label lblExperiencia;
        private NumericUpDown numExperiencia;
        private Label lblArea;
        private TextBox txtArea;
        private Label lblTurno;
        private ComboBox cmbTurno;
        private Label lblNivel;
        private ComboBox cmbNivel;
    }
}