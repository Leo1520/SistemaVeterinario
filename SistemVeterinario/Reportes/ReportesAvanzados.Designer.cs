namespace SistemVeterinario.Reportes
{
    partial class ReportesAvanzados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            lblTitulo = new Label();
            panelControles = new Panel();
            groupBox1 = new GroupBox();
            cmbRangoFechas = new ComboBox();
            label1 = new Label();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            cmbTipoReporte = new ComboBox();
            label5 = new Label();
            cmbPeriodo = new ComboBox();
            label4 = new Label();
            cmbDatosEstadisticos = new ComboBox();
            label7 = new Label();
            groupBox3 = new GroupBox();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            label6 = new Label();
            btnGenerar = new Button();
            panelBotones = new Panel();
            btnVistaPrevia = new Button();
            btnImprimir = new Button();
            btnExportarWord = new Button();
            btnExportarExcel = new Button();
            btnExportarPDF = new Button();
            panelReporte = new Panel();
            panelStatus = new Panel();
            lblResultados = new Label();
            panelTop.SuspendLayout();
            panelControles.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panelBotones.SuspendLayout();
            panelStatus.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(31, 30, 68);
            panelTop.Controls.Add(lblTitulo);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4, 5, 4, 5);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1600, 92);
            panelTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(600, 23);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(392, 36);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "REPORTES AVANZADOS";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelControles
            // 
            panelControles.BackColor = Color.WhiteSmoke;
            panelControles.Controls.Add(groupBox1);
            panelControles.Controls.Add(groupBox2);
            panelControles.Controls.Add(groupBox3);
            panelControles.Controls.Add(btnGenerar);
            panelControles.Dock = DockStyle.Top;
            panelControles.Location = new Point(0, 92);
            panelControles.Margin = new Padding(4, 5, 4, 5);
            panelControles.Name = "panelControles";
            panelControles.Size = new Size(1600, 230);
            panelControles.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbRangoFechas);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpFechaFin);
            groupBox1.Controls.Add(dtpFechaInicio);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(16, 9);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(467, 166);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rango de Fechas";
            // 
            // cmbRangoFechas
            // 
            cmbRangoFechas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRangoFechas.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRangoFechas.FormattingEnabled = true;
            cmbRangoFechas.Location = new Point(133, 34);
            cmbRangoFechas.Margin = new Padding(4, 5, 4, 5);
            cmbRangoFechas.Name = "cmbRangoFechas";
            cmbRangoFechas.Size = new Size(312, 25);
            cmbRangoFechas.TabIndex = 5;
            cmbRangoFechas.SelectedIndexChanged += cmbRangoFechas_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(8, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 4;
            label1.Text = "Período:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(313, 115);
            dtpFechaFin.Margin = new Padding(4, 5, 4, 5);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(132, 23);
            dtpFechaFin.TabIndex = 3;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(133, 115);
            dtpFechaInicio.Margin = new Padding(4, 5, 4, 5);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(132, 23);
            dtpFechaInicio.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(309, 91);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 1;
            label3.Text = "Fecha Fin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(129, 91);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 17);
            label2.TabIndex = 0;
            label2.Text = "Fecha Inicio:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbTipoReporte);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cmbPeriodo);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cmbDatosEstadisticos);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(500, 9);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(467, 215);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Configuración del Reporte";
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoReporte.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Location = new Point(133, 115);
            cmbTipoReporte.Margin = new Padding(4, 5, 4, 5);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(312, 25);
            cmbTipoReporte.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(8, 120);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(95, 17);
            label5.TabIndex = 2;
            label5.Text = "Tipo Reporte:";
            // 
            // cmbPeriodo
            // 
            cmbPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPeriodo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPeriodo.FormattingEnabled = true;
            cmbPeriodo.Location = new Point(133, 54);
            cmbPeriodo.Margin = new Padding(4, 5, 4, 5);
            cmbPeriodo.Name = "cmbPeriodo";
            cmbPeriodo.Size = new Size(312, 25);
            cmbPeriodo.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(8, 58);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 17);
            label4.TabIndex = 0;
            label4.Text = "Agrupar Por:";
            // 
            // cmbDatosEstadisticos
            // 
            cmbDatosEstadisticos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDatosEstadisticos.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDatosEstadisticos.FormattingEnabled = true;
            cmbDatosEstadisticos.Location = new Point(133, 162);
            cmbDatosEstadisticos.Margin = new Padding(4, 5, 4, 5);
            cmbDatosEstadisticos.Name = "cmbDatosEstadisticos";
            cmbDatosEstadisticos.Size = new Size(312, 25);
            cmbDatosEstadisticos.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(8, 166);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(128, 17);
            label7.TabIndex = 4;
            label7.Text = "Datos Estadísticos:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLimpiar);
            groupBox3.Controls.Add(btnBuscar);
            groupBox3.Controls.Add(txtBuscar);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(984, 9);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(400, 166);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Búsqueda y Filtros";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(255, 128, 128);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(207, 105);
            btnLimpiar.Margin = new Padding(4, 5, 4, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(93, 38);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(128, 255, 128);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(100, 105);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(93, 38);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(100, 54);
            txtBuscar.Margin = new Padding(4, 5, 4, 5);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(265, 23);
            txtBuscar.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(8, 58);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 0;
            label6.Text = "Buscar:";
            // 
            // btnGenerar
            // 
            btnGenerar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerar.BackColor = Color.FromArgb(31, 30, 68);
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(1400, 38);
            btnGenerar.Margin = new Padding(4, 5, 4, 5);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(173, 108);
            btnGenerar.TabIndex = 3;
            btnGenerar.Text = "GENERAR REPORTE";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.LightGray;
            panelBotones.Controls.Add(btnVistaPrevia);
            panelBotones.Controls.Add(btnImprimir);
            panelBotones.Controls.Add(btnExportarWord);
            panelBotones.Controls.Add(btnExportarExcel);
            panelBotones.Controls.Add(btnExportarPDF);
            panelBotones.Dock = DockStyle.Top;
            panelBotones.Location = new Point(0, 322);
            panelBotones.Margin = new Padding(4, 5, 4, 5);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(1600, 118);
            panelBotones.TabIndex = 2;
            // 
            // btnVistaPrevia
            // 
            btnVistaPrevia.Anchor = AnchorStyles.None;
            btnVistaPrevia.BackColor = Color.FromArgb(255, 192, 128);
            btnVistaPrevia.FlatStyle = FlatStyle.Flat;
            btnVistaPrevia.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVistaPrevia.Location = new Point(867, 18);
            btnVistaPrevia.Margin = new Padding(4, 5, 4, 5);
            btnVistaPrevia.Name = "btnVistaPrevia";
            btnVistaPrevia.Size = new Size(147, 40);
            btnVistaPrevia.TabIndex = 4;
            btnVistaPrevia.Text = "Vista Completa";
            btnVistaPrevia.UseVisualStyleBackColor = false;
            btnVistaPrevia.Click += btnVistaPrevia_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = AnchorStyles.None;
            btnImprimir.BackColor = Color.FromArgb(128, 128, 255);
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(693, 18);
            btnImprimir.Margin = new Padding(4, 5, 4, 5);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(147, 40);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnExportarWord
            // 
            btnExportarWord.Anchor = AnchorStyles.None;
            btnExportarWord.BackColor = Color.FromArgb(128, 128, 255);
            btnExportarWord.FlatStyle = FlatStyle.Flat;
            btnExportarWord.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarWord.ForeColor = Color.White;
            btnExportarWord.Location = new Point(520, 18);
            btnExportarWord.Margin = new Padding(4, 5, 4, 5);
            btnExportarWord.Name = "btnExportarWord";
            btnExportarWord.Size = new Size(147, 40);
            btnExportarWord.TabIndex = 2;
            btnExportarWord.Text = "Exportar Word";
            btnExportarWord.UseVisualStyleBackColor = false;
            btnExportarWord.Click += btnExportarWord_Click;
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.Anchor = AnchorStyles.None;
            btnExportarExcel.BackColor = Color.FromArgb(128, 255, 128);
            btnExportarExcel.FlatStyle = FlatStyle.Flat;
            btnExportarExcel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarExcel.ForeColor = Color.Black;
            btnExportarExcel.Location = new Point(347, 18);
            btnExportarExcel.Margin = new Padding(4, 5, 4, 5);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(147, 40);
            btnExportarExcel.TabIndex = 1;
            btnExportarExcel.Text = "Exportar Excel";
            btnExportarExcel.UseVisualStyleBackColor = false;
            btnExportarExcel.Click += btnExportarExcel_Click;
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.Anchor = AnchorStyles.None;
            btnExportarPDF.BackColor = Color.FromArgb(255, 128, 128);
            btnExportarPDF.FlatStyle = FlatStyle.Flat;
            btnExportarPDF.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarPDF.ForeColor = Color.White;
            btnExportarPDF.Location = new Point(173, 18);
            btnExportarPDF.Margin = new Padding(4, 5, 4, 5);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(147, 40);
            btnExportarPDF.TabIndex = 0;
            btnExportarPDF.Text = "Exportar PDF";
            btnExportarPDF.UseVisualStyleBackColor = false;
            btnExportarPDF.Click += btnExportarPDF_Click;
            // 
            // panelReporte
            // 
            panelReporte.Dock = DockStyle.Fill;
            panelReporte.Location = new Point(0, 440);
            panelReporte.Margin = new Padding(4, 5, 4, 5);
            panelReporte.Name = "panelReporte";
            panelReporte.Size = new Size(1600, 560);
            panelReporte.TabIndex = 3;
            // 
            // panelStatus
            // 
            panelStatus.BackColor = Color.FromArgb(31, 30, 68);
            panelStatus.Controls.Add(lblResultados);
            panelStatus.Dock = DockStyle.Bottom;
            panelStatus.Location = new Point(0, 1000);
            panelStatus.Margin = new Padding(4, 5, 4, 5);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(1600, 46);
            panelStatus.TabIndex = 4;
            // 
            // lblResultados
            // 
            lblResultados.Anchor = AnchorStyles.Left;
            lblResultados.AutoSize = true;
            lblResultados.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultados.ForeColor = Color.White;
            lblResultados.Location = new Point(16, 12);
            lblResultados.Margin = new Padding(4, 0, 4, 0);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(299, 18);
            lblResultados.TabIndex = 0;
            lblResultados.Text = "Listo para generar reportes avanzados";
            // 
            // ReportesAvanzados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelReporte);
            Controls.Add(panelStatus);
            Controls.Add(panelBotones);
            Controls.Add(panelControles);
            Controls.Add(panelTop);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1333, 923);
            Name = "ReportesAvanzados";
            Size = new Size(1600, 1046);
            Load += FrmReportesAvanzados_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelControles.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panelBotones.ResumeLayout(false);
            panelStatus.ResumeLayout(false);
            panelStatus.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbRangoFechas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbTipoReporte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDatosEstadisticos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnVistaPrevia;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnExportarWord;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Button btnExportarPDF;
        private System.Windows.Forms.Panel panelReporte;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label lblResultados;
    }
}