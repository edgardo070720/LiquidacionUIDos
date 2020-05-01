namespace LiquidacionUIDos
{
    partial class VentanaPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lIQUIDACIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liquidacionIndividualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lisatadoDeLiquidacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelContenedorPnl = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lIQUIDACIONESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lIQUIDACIONESToolStripMenuItem
            // 
            this.lIQUIDACIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.lIQUIDACIONESToolStripMenuItem.Name = "lIQUIDACIONESToolStripMenuItem";
            this.lIQUIDACIONESToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.lIQUIDACIONESToolStripMenuItem.Text = "Menu";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liquidacionIndividualToolStripMenuItem,
            this.lisatadoDeLiquidacionesToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // liquidacionIndividualToolStripMenuItem
            // 
            this.liquidacionIndividualToolStripMenuItem.Name = "liquidacionIndividualToolStripMenuItem";
            this.liquidacionIndividualToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.liquidacionIndividualToolStripMenuItem.Text = "Liquidacion ";
            this.liquidacionIndividualToolStripMenuItem.Click += new System.EventHandler(this.liquidacionIndividualToolStripMenuItem_Click);
            // 
            // lisatadoDeLiquidacionesToolStripMenuItem
            // 
            this.lisatadoDeLiquidacionesToolStripMenuItem.Name = "lisatadoDeLiquidacionesToolStripMenuItem";
            this.lisatadoDeLiquidacionesToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.lisatadoDeLiquidacionesToolStripMenuItem.Text = "Lisatado de Liquidaciones";
            this.lisatadoDeLiquidacionesToolStripMenuItem.Click += new System.EventHandler(this.lisatadoDeLiquidacionesToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // PanelContenedorPnl
            // 
            this.PanelContenedorPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedorPnl.Location = new System.Drawing.Point(0, 24);
            this.PanelContenedorPnl.Name = "PanelContenedorPnl";
            this.PanelContenedorPnl.Size = new System.Drawing.Size(1370, 725);
            this.PanelContenedorPnl.TabIndex = 1;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.PanelContenedorPnl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaPrincipal";
            this.Text = "LiquidacionUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lIQUIDACIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liquidacionIndividualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lisatadoDeLiquidacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Panel PanelContenedorPnl;
    }
}

