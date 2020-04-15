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
        int numeroLiquidacion;
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
                    NumeroLiquidacionTxt.Text = "";
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
                Modificar();
                ValorServicioTxt.Text = "";
                MessageBox.Show("Se modifico correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            int control = 0;

            foreach (LiquidacionCuotaModeradora liquidacion in service.ConsultarListaLiquidacion())
            {
                if (liquidacion.NumeroLiquidacion==Convert.ToInt32( NumeroLiquidacionTxt.Text))
                {
                    TablaLiquidacionDtgv.Rows.Clear();
                    LlenarTabla(liquidacion);
                    numeroLiquidacion = liquidacion.NumeroLiquidacion;
                    control = 1;
                }
            }
            if (control==0)
            {
                return false;
            }
            else
            {
                return true;
            }       

        }
        
        public void Modificar()
        {
            List<LiquidacionCuotaModeradora> liquidacions = new List<LiquidacionCuotaModeradora>();
            liquidacions = service.ConsultarListaLiquidacion();
            foreach (LiquidacionCuotaModeradora liquidacion in liquidacions)
            {
                if (liquidacion.NumeroLiquidacion==numeroLiquidacion)
                {
                    TablaLiquidacionDtgv.Rows.Clear();
                    liquidacion.ValorServicio = Convert.ToDouble( ValorServicioTxt.Text);
                    liquidacion.CalcularCuotaModeradora();
                    service.ModificarLiquidacion(liquidacions);
                    LlenarTabla(liquidacion);
                }
            }
        }
        public void LlenarTabla(LiquidacionCuotaModeradora liquidacion)
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
