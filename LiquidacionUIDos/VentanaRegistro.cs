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
    public partial class VentanaRegistro : Form
    {
        LiquidacionCuotaModeradora liquidacion;
        LiquidacionCuotaModeradoraService service;


        public VentanaRegistro()
        {
            InitializeComponent();
            MostrarFecha();
        }

        public void MostrarFecha()
        {
            DateTime date = DateTime.Now;
            FechaLbl.Text = date.ToShortDateString();
        }
        private void RegistrarBtn_Click(object sender, EventArgs e)
        {

            if (ValidarCampos())
            {
                    Registrar();
            }
        }

        public void Registrar()
        {
           
            service = new LiquidacionCuotaModeradoraService();
            ValidarInstancia();
            liquidacion.NumeroLiquidacion =  NumeroLiquidacionTxt.Text.ToUpper();
            liquidacion.Cedula = CedulaTxt.Text.ToUpper();
            liquidacion.Nombres = NombreTxt.Text.ToUpper();
            liquidacion.Apellidos = ApellidoTxt.Text.ToUpper();
            liquidacion.SalarioDevengado = Convert.ToDouble(SalarioDevengadoTxt.Text);
            liquidacion.ValorServicio = Convert.ToDouble(ValorServicioTxt.Text);
            liquidacion.TipoAfiliacion = TipoAfiliacionCmb.Text.ToUpper();
            liquidacion.Fecha = FechaLbl.Text.ToUpper();
            liquidacion.CalcularCuotaModeradora();
            MessageBox.Show(service.GuardarLiquidacion(liquidacion), "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarTexto();
        }
        public bool ValidarCampos()
        {
            int controlador = 0;
            if (NumeroLiquidacionTxt.Text=="")
            {
                EpRegistrar.SetError(NumeroLiquidacionTxt,"ingrese numero de liquidacion");
                NumeroLiquidacionTxt.Focus();
                controlador = 1;
            }
            else
            {
                EpRegistrar.Clear();
                
            }
            if (CedulaTxt.Text=="")
            {
                EpRegistrar.SetError(CedulaTxt,"ingrese cedula");
                CedulaTxt.Focus();
                controlador = 1;
            }
            else
            {
                EpRegistrar.Clear();
               
            }
            if (NombreTxt.Text=="")
            {
                EpRegistrar.SetError(NombreTxt,"ingrese nombres");
                NombreTxt.Focus();
                controlador = 1;
            }
            else
            {
                EpRegistrar.Clear();
                
            }
            if (ApellidoTxt.Text=="")
            {
                EpRegistrar.SetError(ApellidoTxt,"ingrese apellidos");
                ApellidoTxt.Focus();
                controlador = 1;
            }
            else
            {
                EpRegistrar.Clear();
                
            }
            if (SalarioDevengadoTxt.Text=="")
            {
                EpRegistrar.SetError(SalarioDevengadoTxt,"ingrese salario");
                SalarioDevengadoTxt.Focus();
                controlador = 1;
            }
            else
            {
                EpRegistrar.Clear();
               
            }
            if (ValorServicioTxt.Text=="")
            {
                EpRegistrar.SetError(ValorServicioTxt,"ingrese valor");
                ValorServicioTxt.Focus();
                controlador = 1;
            }
            else
            {
                EpRegistrar.Clear();
            }
            if (TipoAfiliacionCmb.Text=="")
            {
                EpRegistrar.SetError(TipoAfiliacionCmb,"ingrese afiliacion");
                TipoAfiliacionCmb.Focus();
                controlador = 1;
            }
            else
            {
                EpRegistrar.Clear();
                
            }
            if (controlador==0)
            {
                return true;
            }
            else
            {
                return false;
                
            }
        }
        
        public void ValidarInstancia()
        {
            if (TipoAfiliacionCmb.Text== "Regimen Contributivo")
            {
                liquidacion = new RegimenContributivo();
            }
            else
            {
                liquidacion = new RegimenSubsidiado();
            }
        }
        public void LimpiarTexto()
        {
            NumeroLiquidacionTxt.Text = "";
            CedulaTxt.Text = "";
            NombreTxt.Text = "";
            ApellidoTxt.Text = "";
            SalarioDevengadoTxt.Text = "";
            ValorServicioTxt.Text = "";
           
        }

       

        private void NumeroLiquidacionTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionCampos.ValidarCampoNumero(e);
        }

        private void CedulaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionCampos.ValidarCampoNumero(e);
        }

        private void NombreTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionCampos.ValidarCampoLetra(e);
        }

        private void ApellidoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionCampos.ValidarCampoLetra(e);
        }

        private void SalarioDevengadoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionCampos.ValidarCampoNumero(e);
        }

        private void ValorServicioTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionCampos.ValidarCampoNumero(e);
        }
    }
}
