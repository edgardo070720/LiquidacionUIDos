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
                DialogResult dialog = MessageBox.Show("¿seguro desea eliminar?","",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                if (dialog==DialogResult.Yes)
                {
                    MessageBox.Show(service.EliminarLiquidacion(NumeroLiquidacionTxt.Text), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                NumeroLiquidacionTxt.Text = "";
            }
        }

     


        private void NumeroLiquidacionTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionCampos.ValidarCampoNumero(e);
        }
    }
}
