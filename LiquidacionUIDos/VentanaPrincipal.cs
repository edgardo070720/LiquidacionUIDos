using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiquidacionUIDos
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaRegistro ventanaRegistro = new VentanaRegistro();
            AbrirVentanaEnPanel(ventanaRegistro);
        }

        private void liquidacionIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            VentanaConsultaLiquidacion ventanaConsultaLiquidacion = new VentanaConsultaLiquidacion();
            AbrirVentanaEnPanel(ventanaConsultaLiquidacion);
        }

        private void lisatadoDeLiquidacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaConsultaListaLiquidacion ventanalistaLiquidacion = new VentanaConsultaListaLiquidacion();
            AbrirVentanaEnPanel(ventanalistaLiquidacion);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            VentanaModificar ventanaModificar = new VentanaModificar();
            AbrirVentanaEnPanel(ventanaModificar);
            
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            VentanaEliminar ventanaEliminar = new VentanaEliminar();
            AbrirVentanaEnPanel(ventanaEliminar);
        }

        private void AbrirVentanaEnPanel(object ventana)
        {
            if (this.PanelContenedorPnl.Controls.Count>0)
                this.PanelContenedorPnl.Controls.RemoveAt(0);
                Form vn = ventana as Form;
                vn.TopLevel = false;
                vn.Dock = DockStyle.Fill;
                this.PanelContenedorPnl.Controls.Add(vn);
                this.PanelContenedorPnl.Tag = vn;
                vn.Show();
            
        }
    }
}
