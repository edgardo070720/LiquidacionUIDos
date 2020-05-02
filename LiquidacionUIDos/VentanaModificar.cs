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
    public partial class VentanaModificar : Form
    {
        LiquidacionCuotaModeradoraService service = new LiquidacionCuotaModeradoraService();
     
        public VentanaModificar()
        {
            InitializeComponent();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            if (NumeroLiquidacionTxt.Text=="")
            {
                EpModificar.SetError(NumeroLiquidacionTxt, "Ingrese Numero de Liquidacion");
                NumeroLiquidacionTxt.Focus();
            }
            else
            {
                if (Buscar())
                {
                    ValorServicioLbl.Visible = true;
                    ValorServicioTxt.Visible = true;
                    ModificarBtn.Visible = true;
                    label1.Visible = false;
                    NumeroLiquidacionTxt.Visible = false;
                    BuscarBtn.Visible = false;
                }
                else
                {
                    MessageBox.Show("No se encotro registro con este numero", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NumeroLiquidacionTxt.Text = "";
                }
            }

            
        }
        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            if (ValorServicioTxt.Text=="")
            {
                EpModificar.SetError(ValorServicioTxt, "Ingrese el Valor del Servicio");
                ValorServicioTxt.Focus();
            }
            else
            {
                EpModificar.Clear();
                DialogResult dialog = MessageBox.Show("¿seguro desea modificar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialog == DialogResult.Yes)
                {
                    MessageBox.Show(service.ModificarLiquidacion(NumeroLiquidacionTxt.Text, Convert.ToDouble(ValorServicioTxt.Text)), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TablaLiquidacionDtgv.Rows.Clear();
                    LlenarTabla(service.ConsultarLiquidacion(NumeroLiquidacionTxt.Text));
                }
                else
                {
                    TablaLiquidacionDtgv.Rows.Clear();
                }
                ValorServicioTxt.Text = "";
                NumeroLiquidacionTxt.Text = "";
                ValorServicioLbl.Visible = false;
                ValorServicioTxt.Visible = false;
                ModificarBtn.Visible = false;
                label1.Visible = true;
                NumeroLiquidacionTxt.Visible = true;
                BuscarBtn.Visible = true;
            }
           
        }

        public bool Buscar()
        {
            if (service.ValidarExistencia(NumeroLiquidacionTxt.Text))
            {
                LlenarTabla(service.ConsultarLiquidacion(NumeroLiquidacionTxt.Text));
                return true;
            }
            else
            {
                return false;
            }
        }
        
       
        private void LlenarTabla(IList< LiquidacionCuotaModeradora> liquidacions)
        {
            foreach (LiquidacionCuotaModeradora liquidacion in liquidacions)
            {
                int i = TablaLiquidacionDtgv.Rows.Add();
                TablaLiquidacionDtgv.Rows[i].Cells[0].Value = liquidacion.NumeroLiquidacion;
                TablaLiquidacionDtgv.Rows[i].Cells[1].Value = liquidacion.Cedula;
                TablaLiquidacionDtgv.Rows[i].Cells[2].Value = liquidacion.Nombres;
                TablaLiquidacionDtgv.Rows[i].Cells[3].Value = liquidacion.Apellidos;
                TablaLiquidacionDtgv.Rows[i].Cells[4].Value = liquidacion.TipoAfiliacion;
                TablaLiquidacionDtgv.Rows[i].Cells[5].Value = liquidacion.SalarioDevengado;
                TablaLiquidacionDtgv.Rows[i].Cells[6].Value = liquidacion.ValorServicio;
                TablaLiquidacionDtgv.Rows[i].Cells[7].Value = liquidacion.TarifaAplicada;
                TablaLiquidacionDtgv.Rows[i].Cells[8].Value = liquidacion.ValorReal;
                TablaLiquidacionDtgv.Rows[i].Cells[9].Value = liquidacion.TopeMaximo;
                TablaLiquidacionDtgv.Rows[i].Cells[10].Value = liquidacion.CuotaModeradora;
                TablaLiquidacionDtgv.Rows[i].Cells[11].Value = liquidacion.Fecha;
            }
            
        }

        private void ValorServicioTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionCampos.ValidarCampoNumero(e);
        }

        private void NumeroLiquidacionTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionCampos.ValidarCampoNumero(e);
        }
    }
}
