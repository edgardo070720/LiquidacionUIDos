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
            ventanaRegistro.Show();
        }

        private void liquidacionIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            VentanaConsultaLiquidacion ventanaConsultaLiquidacion = new VentanaConsultaLiquidacion();
            ventanaConsultaLiquidacion.Show();
        }

        private void lisatadoDeLiquidacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaConsultaListaLiquidacion ventanaConsultaLista = new VentanaConsultaListaLiquidacion();
            ventanaConsultaLista.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            VentanaModificar ventanaModificar = new VentanaModificar();
            ventanaModificar.Show();
            
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            VentanaEliminar ventanaEliminar = new VentanaEliminar();
            ventanaEliminar.Show();
        }
    }
}
