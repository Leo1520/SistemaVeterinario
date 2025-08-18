namespace SistemVeterinario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Sistema Veterinario - Panel Principal";
            this.WindowState = FormWindowState.Maximized;
            MessageBox.Show("Bienvenido al Sistema Veterinario", "Bienvenido", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
