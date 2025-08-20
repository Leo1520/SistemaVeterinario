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
        }

        private void ConfigurarDashboard()
        {
            // Configurar información del usuario básica
            lblUsuario.Text = "Bienvenido al Sistema Veterinario";
            
            // Configurar eventos de botones
            btnClientes.Click += BtnClientes_Click;
            btnMascotas.Click += BtnMascotas_Click;
            btnVentas.Click += BtnVentas_Click;
            btnProductos.Click += BtnProductos_Click;
            btnReportes.Click += BtnReportes_Click;
            btnPersonal.Click += BtnPersonal_Click;
            btnLogout.Click += BtnLogout_Click;
        }

        private void BtnClientes_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Módulo 'Cliente' no implementado", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnMascotas_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Módulo 'Mascota' no implementado", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnVentas_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Módulo 'Ventas' no implementado", "Información", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnProductos_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Módulo 'Productos' no implementado", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnReportes_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Módulo 'Reportes' no implementado", "Información", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnPersonal_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Módulo 'Personal' no implementado", "Información", 
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Solo preguntar si el usuario está cerrando manualmente
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
    }
}
