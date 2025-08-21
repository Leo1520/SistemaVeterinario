using System.ComponentModel;

namespace SistemVeterinario.Navigation
{
    partial class PersonaSearch
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private IContainer components = null;

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
            // Llamar al InitializeComponent del SearchBase primero
            base.InitializeComponent();
            
            this.cmbFiltroTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbFiltroTipo
            // 
            this.cmbFiltroTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroTipo.FormattingEnabled = true;
            this.cmbFiltroTipo.Items.AddRange(new object[] {
            "Todas las personas",
            "Solo Físicas",
            "Solo Jurídicas"});
            this.cmbFiltroTipo.Location = new System.Drawing.Point(600, 18);
            this.cmbFiltroTipo.Name = "cmbFiltroTipo";
            this.cmbFiltroTipo.Size = new System.Drawing.Size(150, 23);
            this.cmbFiltroTipo.TabIndex = 4;
            this.cmbFiltroTipo.SelectedIndexChanged += new System.EventHandler(this.CmbFiltroTipo_SelectedIndexChanged);
            // 
            // PersonaSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PersonaSearch";
            this.Load += new System.EventHandler(this.PersonaSearch_Load);
            
            // Agregar el ComboBox al panel de búsqueda después de que los controles base estén inicializados
            this.panelBusqueda.Controls.Add(this.cmbFiltroTipo);
            
            this.ResumeLayout(false);

            components = new Container();
        }

        #region Componentes adicionales para PersonaSearch

        private System.Windows.Forms.ComboBox cmbFiltroTipo;

        #endregion

        #endregion
    }
}
