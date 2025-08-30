using System.Drawing;
using System.Windows.Forms;
namespace SistemVeterinario
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnConfiguracion = new FontAwesome.Sharp.IconButton();
            this.BtnDashboard = new FontAwesome.Sharp.IconButton();
            this.BtnReportes = new FontAwesome.Sharp.IconButton();
            this.BtnConsultas = new FontAwesome.Sharp.IconButton();
            this.BtnHistorial = new FontAwesome.Sharp.IconButton();
            this.BtnMascotas = new FontAwesome.Sharp.IconButton();
            this.BtnProductos = new FontAwesome.Sharp.IconButton();
            this.BtnVentas = new FontAwesome.Sharp.IconButton();
            this.BtnPersonal = new FontAwesome.Sharp.IconButton();
            this.BtnClientes = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tituloSuperior = new System.Windows.Forms.Label();
            this.iconoSuperior = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.MediumOrchid;
            this.panelSidebar.Controls.Add(this.pictureBox2);
            this.panelSidebar.Controls.Add(this.BtnConfiguracion);
            this.panelSidebar.Controls.Add(this.BtnDashboard);
            this.panelSidebar.Controls.Add(this.BtnReportes);
            this.panelSidebar.Controls.Add(this.BtnConsultas);
            this.panelSidebar.Controls.Add(this.BtnHistorial);
            this.panelSidebar.Controls.Add(this.BtnMascotas);
            this.panelSidebar.Controls.Add(this.BtnProductos);
            this.panelSidebar.Controls.Add(this.BtnVentas);
            this.panelSidebar.Controls.Add(this.BtnPersonal);
            this.panelSidebar.Controls.Add(this.BtnClientes);
            this.panelSidebar.Controls.Add(this.pictureBox1);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(178, 607);
            this.panelSidebar.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SistemVeterinario.Properties.Resources.UPDS;
            this.pictureBox2.Location = new System.Drawing.Point(9, 559);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // BtnConfiguracion
            // 
            this.BtnConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConfiguracion.FlatAppearance.BorderSize = 0;
            this.BtnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfiguracion.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfiguracion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.BtnConfiguracion.IconColor = System.Drawing.Color.White;
            this.BtnConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConfiguracion.IconSize = 50;
            this.BtnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfiguracion.Location = new System.Drawing.Point(0, 468);
            this.BtnConfiguracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnConfiguracion.Name = "BtnConfiguracion";
            this.BtnConfiguracion.Size = new System.Drawing.Size(178, 41);
            this.BtnConfiguracion.TabIndex = 11;
            this.BtnConfiguracion.Text = "Configuracion";
            this.BtnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfiguracion.UseVisualStyleBackColor = false;
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDashboard.IconChar = FontAwesome.Sharp.IconChar.TachometerFast;
            this.BtnDashboard.IconColor = System.Drawing.Color.White;
            this.BtnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDashboard.IconSize = 50;
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.Location = new System.Drawing.Point(0, 427);
            this.BtnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(178, 41);
            this.BtnDashboard.TabIndex = 10;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDashboard.UseVisualStyleBackColor = false;
            // 
            // BtnReportes
            // 
            this.BtnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReportes.FlatAppearance.BorderSize = 0;
            this.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReportes.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnReportes.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.BtnReportes.IconColor = System.Drawing.Color.White;
            this.BtnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnReportes.IconSize = 50;
            this.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportes.Location = new System.Drawing.Point(0, 386);
            this.BtnReportes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(178, 41);
            this.BtnReportes.TabIndex = 9;
            this.BtnReportes.Text = "Reportes";
            this.BtnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReportes.UseVisualStyleBackColor = false;
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // BtnConsultas
            // 
            this.BtnConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConsultas.FlatAppearance.BorderSize = 0;
            this.BtnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultas.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnConsultas.IconChar = FontAwesome.Sharp.IconChar.UserNurse;
            this.BtnConsultas.IconColor = System.Drawing.Color.White;
            this.BtnConsultas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConsultas.IconSize = 50;
            this.BtnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultas.Location = new System.Drawing.Point(0, 345);
            this.BtnConsultas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnConsultas.Name = "BtnConsultas";
            this.BtnConsultas.Size = new System.Drawing.Size(178, 41);
            this.BtnConsultas.TabIndex = 8;
            this.BtnConsultas.Text = "Consultas";
            this.BtnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConsultas.UseVisualStyleBackColor = false;
            this.BtnConsultas.Click += new System.EventHandler(this.BtnConsultas_Click);
            // 
            // BtnHistorial
            // 
            this.BtnHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHistorial.FlatAppearance.BorderSize = 0;
            this.BtnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistorial.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHistorial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnHistorial.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            this.BtnHistorial.IconColor = System.Drawing.Color.White;
            this.BtnHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnHistorial.IconSize = 50;
            this.BtnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHistorial.Location = new System.Drawing.Point(0, 304);
            this.BtnHistorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnHistorial.Name = "BtnHistorial";
            this.BtnHistorial.Size = new System.Drawing.Size(178, 41);
            this.BtnHistorial.TabIndex = 7;
            this.BtnHistorial.Text = "Historial Medico";
            this.BtnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHistorial.UseVisualStyleBackColor = false;
            // 
            // BtnMascotas
            // 
            this.BtnMascotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMascotas.FlatAppearance.BorderSize = 0;
            this.BtnMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMascotas.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMascotas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMascotas.IconChar = FontAwesome.Sharp.IconChar.Paw;
            this.BtnMascotas.IconColor = System.Drawing.Color.White;
            this.BtnMascotas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMascotas.IconSize = 50;
            this.BtnMascotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMascotas.Location = new System.Drawing.Point(0, 263);
            this.BtnMascotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMascotas.Name = "BtnMascotas";
            this.BtnMascotas.Size = new System.Drawing.Size(178, 41);
            this.BtnMascotas.TabIndex = 6;
            this.BtnMascotas.Text = "Mascotas";
            this.BtnMascotas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMascotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMascotas.UseVisualStyleBackColor = false;
            this.BtnMascotas.Click += new System.EventHandler(this.BtnMascotas_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProductos.FlatAppearance.BorderSize = 0;
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnProductos.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.BtnProductos.IconColor = System.Drawing.Color.White;
            this.BtnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnProductos.IconSize = 50;
            this.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductos.Location = new System.Drawing.Point(0, 222);
            this.BtnProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(178, 41);
            this.BtnProductos.TabIndex = 5;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProductos.UseVisualStyleBackColor = false;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnVentas
            // 
            this.BtnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVentas.FlatAppearance.BorderSize = 0;
            this.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentas.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnVentas.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.BtnVentas.IconColor = System.Drawing.Color.White;
            this.BtnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnVentas.IconSize = 50;
            this.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.Location = new System.Drawing.Point(0, 181);
            this.BtnVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(178, 41);
            this.BtnVentas.TabIndex = 4;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVentas.UseVisualStyleBackColor = false;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // BtnPersonal
            // 
            this.BtnPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPersonal.FlatAppearance.BorderSize = 0;
            this.BtnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonal.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPersonal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnPersonal.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.BtnPersonal.IconColor = System.Drawing.Color.White;
            this.BtnPersonal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPersonal.IconSize = 50;
            this.BtnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPersonal.Location = new System.Drawing.Point(0, 140);
            this.BtnPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPersonal.Name = "BtnPersonal";
            this.BtnPersonal.Size = new System.Drawing.Size(178, 41);
            this.BtnPersonal.TabIndex = 2;
            this.BtnPersonal.Text = "Personal";
            this.BtnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPersonal.UseVisualStyleBackColor = false;
            this.BtnPersonal.Click += new System.EventHandler(this.BtnPersonal_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BtnClientes.IconColor = System.Drawing.Color.White;
            this.BtnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClientes.IconSize = 50;
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(0, 92);
            this.BtnClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(178, 48);
            this.BtnClientes.TabIndex = 1;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClientes.UseVisualStyleBackColor = false;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelContent.Controls.Add(this.panel1);
            this.panelContent.Controls.Add(this.panel2);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.ForeColor = System.Drawing.Color.Cornsilk;
            this.panelContent.Location = new System.Drawing.Point(178, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(851, 607);
            this.panelContent.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.tituloSuperior);
            this.panel1.Controls.Add(this.iconoSuperior);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 92);
            this.panel1.TabIndex = 2;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(163, 38);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(51, 23);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "00:00";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(1246, 45);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(130, 20);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Correo Electronico:";
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconButton2.BackColor = System.Drawing.Color.MediumOrchid;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(1421, 21);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(55, 48);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconButton1.BackColor = System.Drawing.Color.MediumOrchid;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(1487, 21);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(55, 48);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(1300, 27);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(74, 23);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // tituloSuperior
            // 
            this.tituloSuperior.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tituloSuperior.AutoSize = true;
            this.tituloSuperior.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloSuperior.Location = new System.Drawing.Point(71, 36);
            this.tituloSuperior.Name = "tituloSuperior";
            this.tituloSuperior.Size = new System.Drawing.Size(62, 26);
            this.tituloSuperior.TabIndex = 1;
            this.tituloSuperior.Text = "Home";
            // 
            // iconoSuperior
            // 
            this.iconoSuperior.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iconoSuperior.BackColor = System.Drawing.Color.MediumOrchid;
            this.iconoSuperior.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.iconoSuperior.IconColor = System.Drawing.Color.White;
            this.iconoSuperior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconoSuperior.Location = new System.Drawing.Point(12, 21);
            this.iconoSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconoSuperior.Name = "iconoSuperior";
            this.iconoSuperior.Size = new System.Drawing.Size(55, 48);
            this.iconoSuperior.TabIndex = 0;
            this.iconoSuperior.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Thistle;
            this.panel2.Controls.Add(this.pictureBox12);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox11);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox10);
            this.panel2.Controls.Add(this.pictureBox9);
            this.panel2.Controls.Add(this.lblSubtitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 607);
            this.panel2.TabIndex = 13;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(1052, 665);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(123, 104);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 11;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(163, 240);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(550, 111);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(915, 665);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(123, 104);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(508, 665);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(123, 104);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Britannic Bold", 22.2F);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTitulo.Location = new System.Drawing.Point(604, 584);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(370, 33);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "VETERINARIA -ZOOFIPETSS-";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(369, 665);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(123, 104);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(779, 665);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(123, 104);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(645, 665);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(123, 104);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitulo.Location = new System.Drawing.Point(655, 625);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(257, 23);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Desarrollado en la UPDS";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 607);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinaria - Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelSidebar;
        private Panel panelContent;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton BtnClientes;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton BtnReportes;
        private FontAwesome.Sharp.IconButton BtnConsultas;
        private FontAwesome.Sharp.IconButton BtnHistorial;
        private FontAwesome.Sharp.IconButton BtnMascotas;
        private FontAwesome.Sharp.IconButton BtnProductos;
        private FontAwesome.Sharp.IconButton BtnVentas;
        private FontAwesome.Sharp.IconButton BtnPersonal;
        private FontAwesome.Sharp.IconButton BtnConfiguracion;
        private FontAwesome.Sharp.IconButton BtnDashboard;
        private FontAwesome.Sharp.IconButton iconoSuperior;
        private Label tituloSuperior;
        private Label lblUsuario;
        private PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label lblEmail;
        private Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private Panel panel2;
        private PictureBox pictureBox12;
        private PictureBox pictureBox3;
        private PictureBox pictureBox11;
        private PictureBox pictureBox8;
        private Label lblTitulo;
        private PictureBox pictureBox6;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private Label lblSubtitulo;
    }
}
