using FontAwesome.Sharp;
using SistemVeterinario.Forms;

namespace SistemVeterinario
{
    /// <summary>
    /// Dashboard principal del sistema - Pantalla principal después del login
    /// </summary>
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
            ConfigurarDashboard();
            InicializarNavegacion();
            // Inicia el Timer al cargar el formulario
            timer1.Start();
        }

        private void ConfigurarDashboard()
        {
            // Configurar información del usuario


            lblUsuario.Text = $"Bienvenido, Falta obtener su nombre";
            lblEmail.Text = "Falta obtener su email";

            // Configurar eventos de botones
            BtnClientes.Click += BtnClientes_Click;
            BtnMascotas.Click += BtnMascotas_Click;
            BtnVentas.Click += BtnVentas_Click;
            BtnProductos.Click += BtnProductos_Click;
            BtnReportes.Click += BtnReportes_Click;
            BtnPersonal.Click += BtnConfiguracion_Click;
        }

        /// <summary>
        /// Inicializa el sistema de navegación modular
        /// </summary>
        private void InicializarNavegacion()
        {
            try
            {
                // La pantalla de bienvenida ya está diseñada en el Visual Studio Designer
                // Solo asegurarse de que esté visible
                MostrarPantallaInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inicializando navegación: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Muestra la pantalla inicial (diseñada en Visual Studio Designer)
        /// </summary>
        private void MostrarPantallaInicial()
        {
            // Remover cualquier UserControl que pueda estar activo
            var userControls = panelContent.Controls.OfType<UserControl>().ToList();
            foreach (var control in userControls)
            {
                panelContent.Controls.Remove(control);
                control.Dispose();
            }

            // Hacer visibles todos los elementos del diseñador
            foreach (Control control in panelContent.Controls)
            {
                control.Visible = true;
            }

            // Refrescar el panel para asegurar que se vea todo correctamente
            panelContent.Refresh();
        }

        /// <summary>
        /// Oculta los elementos del diseñador cuando se navega a un módulo
        /// </summary>
        private void OcultarElementosDisenador()
        {
            foreach (Control control in panelContent.Controls)
            {
                if (!(control is UserControl))
                {
                    control.Visible = false;
                }
            }
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Solo preguntar si el usuario está cerrando manualmente (no cuando se hace logout)
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show("¿Está seguro que desea salir del sistema?",
                    "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }

            base.OnFormClosing(e);
        }



        // Método para cambiar el icono y título superior
        private void CambiarIconoSuperior(IconChar nuevoIcono, string nuevoTitulo)
        {
            if (iconoSuperior != null)
            {
                iconoSuperior.IconChar = nuevoIcono;
            }
            if (tituloSuperior != null)
            {
                tituloSuperior.Text = nuevoTitulo;
            }
        }

        private void BtnClientes_Click(object? sender, EventArgs e)
        {
            CambiarIconoSuperior(IconChar.Users, "Clientes");

            try
            {
                OcultarElementosDisenador();
                var userControls = panelContent.Controls.OfType<UserControl>().ToList();
                foreach (var control in userControls)
                {
                    panelContent.Controls.Remove(control);
                    control.Dispose();
                }

                PersonasModule personasModule = new PersonasModule
                {
                    Dock = DockStyle.Fill
                };

                panelContent.Controls.Add(personasModule);
                personasModule.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el módulo de Clientes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnMascotas_Click(object? sender, EventArgs e)
        {
            CambiarIconoSuperior(IconChar.Paw, "Mascotas");

            try
            {
                OcultarElementosDisenador();
                var userControls = panelContent.Controls.OfType<UserControl>().ToList();
                foreach (var control in userControls)
                {
                    panelContent.Controls.Remove(control);
                    control.Dispose();
                }

                Forms.MascotasModule mascotasModule = new Forms.MascotasModule
                {
                    Dock = DockStyle.Fill
                };

                panelContent.Controls.Add(mascotasModule);
                mascotasModule.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el módulo de mascotas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPersonal_Click(object sender, EventArgs e)
        {
            CambiarIconoSuperior(IconChar.UserTie, "Personal");

        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            CambiarIconoSuperior(IconChar.BoxesStacked, "Inventario");

        }



        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            CambiarIconoSuperior(IconChar.FileMedical, "Historial Médico");

        }

        private void BtnConsultas_Click(object sender, EventArgs e)
        {
            // Cambiar icono antes de abrir el formulario
            CambiarIconoSuperior(IconChar.UserMd, "Consulta");
        }


        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            CambiarIconoSuperior(IconChar.TachometerAltFast, "Reportes");

        }

        private void BtnVentas_Click(object? sender, EventArgs e)
        {
            CambiarIconoSuperior(IconChar.ShoppingBag, "Ventas");

            try
            {
                using (Venta frmVenta = new Venta())
                {
                    frmVenta.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el módulo de ventas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReportes_Click(object? sender, EventArgs e)
        {
            CambiarIconoSuperior(IconChar.ChartLine, "Reportes");

            try
            {
                foreach (Control control in panelContent.Controls.Cast<Control>().ToList())
                {
                    panelContent.Controls.Remove(control);
                    control.Dispose();
                }

                Forms.ProductosModule productosModule = new Forms.ProductosModule
                {
                    Dock = DockStyle.Fill
                };
                panelContent.Controls.Add(productosModule);

                using (Reportes frmReportes = new Reportes())
                {
                    frmReportes.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el módulo de reportes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnConfiguracion_Click(object? sender, EventArgs e)
        {
            CambiarIconoSuperior(IconChar.Toolbox, "Reportes");

            MessageBox.Show("Módulo de Configuración - Próximamente", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnLogout_Click(object? sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro que desea cerrar sesión?",
                "Confirmar Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Cerrar el dashboard - esto hará que se regrese al login automáticamente
                this.Close();
            }
        }

        private void BtnProductos_Click(object? sender, EventArgs e)
        {
            CambiarIconoSuperior(IconChar.BoxOpen, "Productos");

            try
            {
                using (Producto frmProducto = new Producto())
                {
                    frmProducto.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el módulo de productos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Muestra la hora y fecha actualizadas cada segundo
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            CambiarIconoSuperior(IconChar.Home, "Home");

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
