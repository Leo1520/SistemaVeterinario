using System;
using System.Windows.Forms;
using CapaNegocio;

namespace SistemVeterinario
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool loginExitoso = NUsuario.ValidarLogin(usuario, contrasena);

            if (loginExitoso)
            {
                MessageBox.Show("Login exitoso", "Bienvenido", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Ocultar el login y mostrar el dashboard
                this.Hide();
                
                Dashboard dashboard = new Dashboard();
                dashboard.FormClosed += (s, args) => this.Close(); // Cerrar la aplicación cuando se cierre el dashboard
                dashboard.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de Login", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContrasena.Clear();
                txtUsuario.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtContrasena.Focus();
            }
        }
    }
}
