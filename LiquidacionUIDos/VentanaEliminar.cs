using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace LiquidacionUIDos
{
    public partial class VentanaEliminar : Form
    {
        LiquidacionCuotaModeradoraService service = new LiquidacionCuotaModeradoraService();
      
        public VentanaEliminar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaConsultaLiquidacion ventanaConsultaLiquidacion = new VentanaConsultaLiquidacion();
            ventanaConsultaLiquidacion.Show();
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            if (NumeroLiquidacionTxt.Text=="")
            {
                EpNumeroLiquidacion.SetError(NumeroLiquidacionTxt, "Ingrese Numero de Liquidacion");
                NumeroLiquidacionTxt.Focus();
                
            }
            else
            {
                EpNumeroLiquidacion.Clear();
                Eliminar();
                
            }
        }

        private void ConsultarListaBtn_Click(object sender, EventArgs e)
        {
            VentanaConsultaListaLiquidacion ventanaConsultaLista = new VentanaConsultaListaLiquidacion();
            ventanaConsultaLista.Show();
        }

        public void Eliminar()
        {
            int index=0;
            int control = 0;
            List<LiquidacionCuotaModeradora> liquidacions = new List<LiquidacionCuotaModeradora>();
            liquidacions = service.ConsultarListaLiquidacion();
            foreach (LiquidacionCuotaModeradora liquidacion in liquidacions )
            {
                if (liquidacion.NumeroLiquidacion == Convert.ToInt32(NumeroLiquidacionTxt.Text))
                {
                     index=liquidacions.IndexOf(liquidacion);
                    control = 1;
                    
                }
            }
            
            if (control==0)
            {
                MessageBox.Show("No se encontro registro con ese nuemro", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NumeroLiquidacionTxt.Text = "";
            }
            else
            {
                liquidacions.RemoveAt(index);
                MessageBox.Show(service.EliminarLiquidacion(liquidacions), "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NumeroLiquidacionTxt.Text = "";
            }
        }

        private void NumeroLiquidacionTxt_Validated(object sender, EventArgs e)
        {
            
        }

        private void NumeroLiquidacionTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionCampos.ValidarCampoNumero(e);
        }
    }
}
