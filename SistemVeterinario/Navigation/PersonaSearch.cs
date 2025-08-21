using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace SistemVeterinario.Navigation
{
    public partial class PersonaSearch : SearchBase
    {
        #region Controles Específicos de Persona

        private ComboBox cmbTipoPersona = null!;
        private GroupBox gbPersonaFisica = null!;
        private GroupBox gbPersonaJuridica = null!;
        
        // Controles Persona Física
        private TextBox txtCI = null!;
        private TextBox txtNombre = null!;
        private TextBox txtApellido = null!;
        private DateTimePicker dtpFechaNacimiento = null!;
        private ComboBox cmbGenero = null!;
        
        // Controles Persona Jurídica
        private TextBox txtRazonSocial = null!;
        private TextBox txtNIT = null!;
        private TextBox txtEncargadoNombre = null!;
        private TextBox txtEncargadoCargo = null!;
        
        // Controles Comunes
        private TextBox txtEmail = null!;
        private TextBox txtDireccion = null!;
        private TextBox txtTelefono = null!;

        #endregion

        #region Constructor

        public PersonaSearch()
        {
            InitializeComponent();
            CrearControlesPersona();
            ConfigurarEventosPersona();
            CargarDatosIniciales();
        }

        #endregion

        #region Métodos de Inicialización

        private void CrearControlesPersona()
        {
            // Panel contenedor para los controles del formulario
            Panel panelContenido = new Panel();
            panelContenido.Size = new Size(920, 400);
            panelContenido.Location = new Point(10, 70);
            panelContenido.AutoScroll = true;
            panelContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            
            // ComboBox Tipo de Persona
            Label lblTipo = new Label();
            lblTipo.Text = "Tipo de Persona:";
            lblTipo.Location = new Point(20, 20);
            lblTipo.Size = new Size(120, 20);
            
            cmbTipoPersona = new ComboBox();
            cmbTipoPersona.Size = new Size(150, 23);
            cmbTipoPersona.Location = new Point(150, 18);
            cmbTipoPersona.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPersona.Items.AddRange(new string[] { "Física", "Jurídica" });
            cmbTipoPersona.SelectedIndex = 0;
            
            // GroupBox Persona Física
            gbPersonaFisica = new GroupBox();
            gbPersonaFisica.Text = "Datos de Persona Física";
            gbPersonaFisica.Size = new Size(420, 240);
            gbPersonaFisica.Location = new Point(20, 60);
            
            CrearControlesPersonaFisica();
            
            // GroupBox Persona Jurídica
            gbPersonaJuridica = new GroupBox();
            gbPersonaJuridica.Text = "Datos de Persona Jurídica";
            gbPersonaJuridica.Size = new Size(420, 240);
            gbPersonaJuridica.Location = new Point(460, 60);
            gbPersonaJuridica.Visible = false;
            
            CrearControlesPersonaJuridica();
            
            // GroupBox Datos Comunes
            GroupBox gbComunes = new GroupBox();
            gbComunes.Text = "Datos de Contacto";
            gbComunes.Size = new Size(860, 80);
            gbComunes.Location = new Point(20, 320);
            
            CrearControlesComunes(gbComunes);
            
            panelContenido.Controls.AddRange(new Control[] { 
                lblTipo, cmbTipoPersona, gbPersonaFisica, gbPersonaJuridica, gbComunes 
            });
            
            panelFormulario.Controls.Add(panelContenido);
        }

        private void CrearControlesPersonaFisica()
        {
            // CI
            Label lblCI = new Label();
            lblCI.Text = "CI:";
            lblCI.Location = new Point(20, 30);
            lblCI.Size = new Size(30, 20);
            
            txtCI = new TextBox();
            txtCI.Size = new Size(150, 23);
            txtCI.Location = new Point(80, 28);
            
            // Nombre
            Label lblNombre = new Label();
            lblNombre.Text = "Nombre:*";
            lblNombre.Location = new Point(20, 65);
            lblNombre.Size = new Size(60, 20);
            
            txtNombre = new TextBox();
            txtNombre.Size = new Size(150, 23);
            txtNombre.Location = new Point(80, 63);
            
            // Apellido
            Label lblApellido = new Label();
            lblApellido.Text = "Apellido:*";
            lblApellido.Location = new Point(20, 100);
            lblApellido.Size = new Size(60, 20);
            
            txtApellido = new TextBox();
            txtApellido.Size = new Size(150, 23);
            txtApellido.Location = new Point(80, 98);
            
            // Fecha Nacimiento
            Label lblFecha = new Label();
            lblFecha.Text = "F. Nac.:";
            lblFecha.Location = new Point(20, 135);
            lblFecha.Size = new Size(60, 20);
            
            dtpFechaNacimiento = new DateTimePicker();
            dtpFechaNacimiento.Size = new Size(150, 23);
            dtpFechaNacimiento.Location = new Point(80, 133);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.ShowCheckBox = true;
            dtpFechaNacimiento.Checked = false;
            
            // Género
            Label lblGenero = new Label();
            lblGenero.Text = "Género:";
            lblGenero.Location = new Point(20, 170);
            lblGenero.Size = new Size(60, 20);
            
            cmbGenero = new ComboBox();
            cmbGenero.Size = new Size(80, 23);
            cmbGenero.Location = new Point(80, 168);
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.Items.AddRange(new string[] { "", "M", "F" });
            cmbGenero.SelectedIndex = 0;
            
            gbPersonaFisica.Controls.AddRange(new Control[] {
                lblCI, txtCI, lblNombre, txtNombre, lblApellido, txtApellido,
                lblFecha, dtpFechaNacimiento, lblGenero, cmbGenero
            });
        }

        private void CrearControlesPersonaJuridica()
        {
            // Razón Social
            Label lblRazonSocial = new Label();
            lblRazonSocial.Text = "Razón Social:*";
            lblRazonSocial.Location = new Point(20, 30);
            lblRazonSocial.Size = new Size(90, 20);
            
            txtRazonSocial = new TextBox();
            txtRazonSocial.Size = new Size(300, 23);
            txtRazonSocial.Location = new Point(20, 53);
            
            // NIT
            Label lblNIT = new Label();
            lblNIT.Text = "NIT:";
            lblNIT.Location = new Point(20, 90);
            lblNIT.Size = new Size(40, 20);
            
            txtNIT = new TextBox();
            txtNIT.Size = new Size(150, 23);
            txtNIT.Location = new Point(70, 88);
            
            // Encargado Nombre
            Label lblEncargadoNombre = new Label();
            lblEncargadoNombre.Text = "Encargado:";
            lblEncargadoNombre.Location = new Point(20, 125);
            lblEncargadoNombre.Size = new Size(80, 20);
            
            txtEncargadoNombre = new TextBox();
            txtEncargadoNombre.Size = new Size(200, 23);
            txtEncargadoNombre.Location = new Point(110, 123);
            
            // Encargado Cargo
            Label lblEncargadoCargo = new Label();
            lblEncargadoCargo.Text = "Cargo:";
            lblEncargadoCargo.Location = new Point(20, 160);
            lblEncargadoCargo.Size = new Size(50, 20);
            
            txtEncargadoCargo = new TextBox();
            txtEncargadoCargo.Size = new Size(150, 23);
            txtEncargadoCargo.Location = new Point(80, 158);
            
            gbPersonaJuridica.Controls.AddRange(new Control[] {
                lblRazonSocial, txtRazonSocial, lblNIT, txtNIT,
                lblEncargadoNombre, txtEncargadoNombre, lblEncargadoCargo, txtEncargadoCargo
            });
        }

        private void CrearControlesComunes(GroupBox contenedor)
        {
            // Email
            Label lblEmail = new Label();
            lblEmail.Text = "Email:";
            lblEmail.Location = new Point(20, 30);
            lblEmail.Size = new Size(50, 20);
            
            txtEmail = new TextBox();
            txtEmail.Size = new Size(200, 23);
            txtEmail.Location = new Point(80, 28);
            
            // Dirección
            Label lblDireccion = new Label();
            lblDireccion.Text = "Dirección:";
            lblDireccion.Location = new Point(300, 30);
            lblDireccion.Size = new Size(70, 20);
            
            txtDireccion = new TextBox();
            txtDireccion.Size = new Size(250, 23);
            txtDireccion.Location = new Point(380, 28);
            
            // Teléfono
            Label lblTelefono = new Label();
            lblTelefono.Text = "Teléfono:";
            lblTelefono.Location = new Point(650, 30);
            lblTelefono.Size = new Size(70, 20);
            
            txtTelefono = new TextBox();
            txtTelefono.Size = new Size(150, 23);
            txtTelefono.Location = new Point(720, 28);
            
            contenedor.Controls.AddRange(new Control[] {
                lblEmail, txtEmail, lblDireccion, txtDireccion, lblTelefono, txtTelefono
            });
        }

        private void ConfigurarEventosPersona()
        {
            cmbTipoPersona.SelectedIndexChanged += CmbTipoPersona_SelectedIndexChanged;
        }

        private void CargarDatosIniciales()
        {
            OnBuscar(); // Cargar todos los datos al inicio
        }

        #endregion

        #region Eventos

        private void PersonaSearch_Load(object? sender, EventArgs e)
        {
            // Configurar ComboBox de filtro
            if (cmbFiltroTipo != null)
            {
                cmbFiltroTipo.SelectedIndex = 0; // Por defecto "Todas las personas"
            }
        }

        private void CmbTipoPersona_SelectedIndexChanged(object? sender, EventArgs e)
        {
            bool esPersonaFisica = cmbTipoPersona.SelectedIndex == 0;
            
            gbPersonaFisica.Visible = esPersonaFisica;
            gbPersonaJuridica.Visible = !esPersonaFisica;
            
            LimpiarFormulario();
        }

        private void CmbFiltroTipo_SelectedIndexChanged(object? sender, EventArgs e)
        {
            FiltrarColumnasPorTipo();
        }

        #endregion

        #region Implementación de Métodos Base

        protected override void OnBuscar()
        {
            try
            {
                DataTable datos;
                string textoBuscar = txtBuscar.Text.Trim();
                
                if (string.IsNullOrEmpty(textoBuscar))
                {
                    datos = NPersona.Mostrar();
                }
                else
                {
                    datos = NPersona.BuscarTexto(textoBuscar);
                }
                
                CargarDatos(datos);
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error al buscar: {ex.Message}", "Error", MessageBoxIcon.Error);
            }
        }

        protected override void OnGuardar()
        {
            try
            {
                if (!ValidarFormulario())
                    return;
                
                string resultado;
                bool esPersonaFisica = cmbTipoPersona.SelectedIndex == 0;
                
                if (ModoEdicion && IdSeleccionado > 0)
                {
                    // Editar
                    if (esPersonaFisica)
                    {
                        resultado = NPersona.EditarPersonaFisica(
                            IdSeleccionado,
                            txtCI.Text.Trim(),
                            txtNombre.Text.Trim(),
                            txtApellido.Text.Trim(),
                            string.IsNullOrEmpty(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                            string.IsNullOrEmpty(txtDireccion.Text) ? null : txtDireccion.Text.Trim(),
                            string.IsNullOrEmpty(txtTelefono.Text) ? null : txtTelefono.Text.Trim(),
                            dtpFechaNacimiento.Checked ? dtpFechaNacimiento.Value : null,
                            cmbGenero.SelectedIndex == 0 ? null : Convert.ToChar(cmbGenero.Text)
                        );
                    }
                    else
                    {
                        resultado = NPersona.EditarPersonaJuridica(
                            IdSeleccionado,
                            txtRazonSocial.Text.Trim(),
                            string.IsNullOrEmpty(txtNIT.Text) ? null : txtNIT.Text.Trim(),
                            string.IsNullOrEmpty(txtEncargadoNombre.Text) ? null : txtEncargadoNombre.Text.Trim(),
                            string.IsNullOrEmpty(txtEncargadoCargo.Text) ? null : txtEncargadoCargo.Text.Trim(),
                            string.IsNullOrEmpty(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                            string.IsNullOrEmpty(txtDireccion.Text) ? null : txtDireccion.Text.Trim(),
                            string.IsNullOrEmpty(txtTelefono.Text) ? null : txtTelefono.Text.Trim()
                        );
                    }
                }
                else
                {
                    // Insertar
                    if (esPersonaFisica)
                    {
                        resultado = NPersona.InsertarPersonaFisica(
                            string.IsNullOrEmpty(txtCI.Text) ? null : txtCI.Text.Trim(),
                            txtNombre.Text.Trim(),
                            txtApellido.Text.Trim(),
                            string.IsNullOrEmpty(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                            string.IsNullOrEmpty(txtDireccion.Text) ? null : txtDireccion.Text.Trim(),
                            string.IsNullOrEmpty(txtTelefono.Text) ? null : txtTelefono.Text.Trim(),
                            dtpFechaNacimiento.Checked ? dtpFechaNacimiento.Value : null,
                            cmbGenero.SelectedIndex == 0 ? null : Convert.ToChar(cmbGenero.Text)
                        );
                    }
                    else
                    {
                        resultado = NPersona.InsertarPersonaJuridica(
                            txtRazonSocial.Text.Trim(),
                            string.IsNullOrEmpty(txtNIT.Text) ? null : txtNIT.Text.Trim(),
                            string.IsNullOrEmpty(txtEncargadoNombre.Text) ? null : txtEncargadoNombre.Text.Trim(),
                            string.IsNullOrEmpty(txtEncargadoCargo.Text) ? null : txtEncargadoCargo.Text.Trim(),
                            string.IsNullOrEmpty(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                            string.IsNullOrEmpty(txtDireccion.Text) ? null : txtDireccion.Text.Trim(),
                            string.IsNullOrEmpty(txtTelefono.Text) ? null : txtTelefono.Text.Trim()
                        );
                    }
                }
                
                if (resultado == "OK")
                {
                    MostrarMensaje("Operación realizada exitosamente", "Éxito", MessageBoxIcon.Information);
                    OnCancelar(); // Volver a la lista
                    OnBuscar(); // Actualizar la lista
                }
                else
                {
                    MostrarMensaje($"Error: {resultado}", "Error", MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error al guardar: {ex.Message}", "Error", MessageBoxIcon.Error);
            }
        }

        protected override void OnEliminar()
        {
            try
            {
                if (IdSeleccionado <= 0)
                {
                    MostrarMensaje("Debe seleccionar una persona para eliminar", "Advertencia", MessageBoxIcon.Warning);
                    return;
                }
                
                if (MostrarConfirmacion("¿Está seguro de que desea eliminar esta persona?") == DialogResult.Yes)
                {
                    string resultado = NPersona.Eliminar(IdSeleccionado);
                    
                    if (resultado == "OK")
                    {
                        MostrarMensaje("Persona eliminada exitosamente", "Éxito", MessageBoxIcon.Information);
                        OnCancelar(); // Volver a la lista
                        OnBuscar(); // Actualizar la lista
                    }
                    else
                    {
                        MostrarMensaje($"Error al eliminar: {resultado}", "Error", MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error al eliminar: {ex.Message}", "Error", MessageBoxIcon.Error);
            }
        }

        protected override void LimpiarFormulario()
        {
            // Limpiar controles de persona física
            txtCI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            dtpFechaNacimiento.Checked = false;
            cmbGenero.SelectedIndex = 0;
            
            // Limpiar controles de persona jurídica
            txtRazonSocial.Clear();
            txtNIT.Clear();
            txtEncargadoNombre.Clear();
            txtEncargadoCargo.Clear();
            
            // Limpiar controles comunes
            txtEmail.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            
            // Reset modo
            cmbModo.SelectedIndex = 0;
            txtId.Clear();
            IdSeleccionado = 0;
        }

        protected override void CargarDatosParaEdicion(int id)
        {
            try
            {
                DataTable datos = NPersona.ObtenerPorId(id);
                
                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.Rows[0];
                    string tipo = fila["tipo"].ToString() ?? "";
                    
                    // Seleccionar tipo de persona
                    cmbTipoPersona.SelectedItem = tipo;
                    
                    // Cargar datos comunes
                    txtEmail.Text = fila["email"]?.ToString() ?? "";
                    txtDireccion.Text = fila["direccion"]?.ToString() ?? "";
                    txtTelefono.Text = fila["telefono"]?.ToString() ?? "";
                    
                    if (tipo == "Física")
                    {
                        // Cargar datos de persona física
                        txtCI.Text = fila["ci"]?.ToString() ?? "";
                        txtNombre.Text = fila["nombre"]?.ToString() ?? "";
                        txtApellido.Text = fila["apellido"]?.ToString() ?? "";
                        
                        if (fila["fecha_nacimiento"] != DBNull.Value)
                        {
                            dtpFechaNacimiento.Value = Convert.ToDateTime(fila["fecha_nacimiento"]);
                            dtpFechaNacimiento.Checked = true;
                        }
                        
                        string? genero = fila["genero"]?.ToString();
                        if (!string.IsNullOrEmpty(genero))
                        {
                            cmbGenero.SelectedItem = genero;
                        }
                    }
                    else
                    {
                        // Cargar datos de persona jurídica
                        txtRazonSocial.Text = fila["razon_social"]?.ToString() ?? "";
                        txtNIT.Text = fila["nit"]?.ToString() ?? "";
                        txtEncargadoNombre.Text = fila["encargado_nombre"]?.ToString() ?? "";
                        txtEncargadoCargo.Text = fila["encargado_cargo"]?.ToString() ?? "";
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error al cargar datos: {ex.Message}", "Error", MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Validaciones

        private bool ValidarFormulario()
        {
            bool esPersonaFisica = cmbTipoPersona.SelectedIndex == 0;
            
            if (esPersonaFisica)
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MostrarMensaje("El nombre es obligatorio", "Validación", MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    return false;
                }
                
                if (string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    MostrarMensaje("El apellido es obligatorio", "Validación", MessageBoxIcon.Warning);
                    txtApellido.Focus();
                    return false;
                }
                
                // Validaciones adicionales
                if (!string.IsNullOrEmpty(txtCI.Text) && !NPersona.ValidarCi(txtCI.Text))
                {
                    MostrarMensaje("El formato de la CI no es válido", "Validación", MessageBoxIcon.Warning);
                    txtCI.Focus();
                    return false;
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtRazonSocial.Text))
                {
                    MostrarMensaje("La razón social es obligatoria", "Validación", MessageBoxIcon.Warning);
                    txtRazonSocial.Focus();
                    return false;
                }
                
                // Validaciones adicionales
                if (!string.IsNullOrEmpty(txtNIT.Text) && !NPersona.ValidarNit(txtNIT.Text))
                {
                    MostrarMensaje("El formato del NIT no es válido", "Validación", MessageBoxIcon.Warning);
                    txtNIT.Focus();
                    return false;
                }
            }
            
            // Validaciones comunes
            if (!string.IsNullOrEmpty(txtEmail.Text) && !NPersona.ValidarEmail(txtEmail.Text))
            {
                MostrarMensaje("El formato del email no es válido", "Validación", MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            
            if (!string.IsNullOrEmpty(txtTelefono.Text) && !NPersona.ValidarTelefono(txtTelefono.Text))
            {
                MostrarMensaje("El formato del teléfono no es válido", "Validación", MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }
            
            return true;
        }

        protected override void EliminarRegistro(int id)
        {
            try
            {
                string resultado = NPersona.Eliminar(id);
                
                if (resultado == "OK")
                {
                    MostrarMensaje("Registro eliminado correctamente", "Éxito", MessageBoxIcon.Information);
                }
                else
                {
                    MostrarMensaje($"No se pudo eliminar el registro: {resultado}", "Error", MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error al eliminar el registro: {ex.Message}", "Error", MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Métodos auxiliares para filtrado de columnas

        private void FiltrarColumnasPorTipo()
        {
            if (dgvDatos.Columns.Count == 0 || cmbFiltroTipo == null)
                return;

            int tipoSeleccionado = cmbFiltroTipo.SelectedIndex;
            
            // Definir columnas específicas de cada tipo
            var columnasFisica = new HashSet<string> { "ci", "nombre", "apellido", "fecha_nacimiento", "genero", "nombre_completo" };
            var columnasJuridica = new HashSet<string> { "razon_social", "nit", "encargado_nombre", "encargado_cargo" };
            var columnasComunes = new HashSet<string> { "id", "tipo", "email", "direccion", "telefono", "activo", "btneditar", "btneliminar" };

            foreach (DataGridViewColumn columna in dgvDatos.Columns)
            {
                string nombreColumna = columna.Name.ToLower();
                
                // Siempre mostrar columnas comunes y botones de acción
                if (columnasComunes.Contains(nombreColumna))
                {
                    columna.Visible = true;
                    continue;
                }

                switch (tipoSeleccionado)
                {
                    case 0: // Todas las personas
                        columna.Visible = true;
                        break;
                    case 1: // Solo Físicas
                        columna.Visible = columnasFisica.Contains(nombreColumna);
                        break;
                    case 2: // Solo Jurídicas
                        columna.Visible = columnasJuridica.Contains(nombreColumna);
                        break;
                }
            }
        }

        #endregion
    }
}
