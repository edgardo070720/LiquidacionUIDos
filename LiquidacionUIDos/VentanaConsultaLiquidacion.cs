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
    public partial class VentanaConsultaLiquidacion : Form
    {
        LiquidacionCuotaModeradoraService service = new LiquidacionCuotaModeradoraService();
        
        public VentanaConsultaLiquidacion()
        {
            InitializeComponent();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
           
            if (ValidarCampo())
            {
                BuscarLiquidacion();
            }
            NumeroLiquidacionTxt.Text = "";
            
        }
        public void BuscarLiquidacion()
        {
            
            
            if (service.ValidarExistencia(NumeroLiquidacionTxt.Text))
            {
                LlenarTabla(service.ConsultarLiquidacion(NumeroLiquidacionTxt.Text));
            }
            else
            {
                MessageBox.Show("No se encontro liquidacion registrada con ese numero", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TablaLiquidacionDtgv.Rows.Clear();
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

        public bool ValidarCampo()
        {
            if (NumeroLiquidacionTxt.Text=="")
            {
                EpBuscar.SetError(NumeroLiquidacionTxt, "Ingrese Numero de Liquidacion");
                NumeroLiquidacionTxt.Focus();
                
                return false;
            }
            else
            {
                EpBuscar.Clear();
                return true;
            }
        }

        private void NumeroLiquidacionTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionCampos.ValidarCampoNumero(e);
        }
    }
}
