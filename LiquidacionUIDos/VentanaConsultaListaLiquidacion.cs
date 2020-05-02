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
    public partial class VentanaConsultaListaLiquidacion : Form
    {
        LiquidacionCuotaModeradoraService service;
        
        public VentanaConsultaListaLiquidacion()
        {
            service = new LiquidacionCuotaModeradoraService();
            InitializeComponent();
            MostrarTabla(service.ConsultarListaListaLiquidacion());
            
        }

      
        public void MostrarTabla(List<LiquidacionCuotaModeradora> liquidacions)
        {
            
            foreach (LiquidacionCuotaModeradora liquidacion in liquidacions)
            {
                int i = TablaLiquidacionDtvg.Rows.Add();
                TablaLiquidacionDtvg.Rows[i].Cells[0].Value = liquidacion.NumeroLiquidacion;
                TablaLiquidacionDtvg.Rows[i].Cells[1].Value = liquidacion.Cedula;
                TablaLiquidacionDtvg.Rows[i].Cells[2].Value = liquidacion.Nombres;
                TablaLiquidacionDtvg.Rows[i].Cells[3].Value = liquidacion.Apellidos;
                TablaLiquidacionDtvg.Rows[i].Cells[4].Value = liquidacion.TipoAfiliacion;
                TablaLiquidacionDtvg.Rows[i].Cells[5].Value = liquidacion.SalarioDevengado;
                TablaLiquidacionDtvg.Rows[i].Cells[6].Value = liquidacion.ValorServicio;
                TablaLiquidacionDtvg.Rows[i].Cells[7].Value = liquidacion.TarifaAplicada;
                TablaLiquidacionDtvg.Rows[i].Cells[8].Value = liquidacion.ValorReal;
                TablaLiquidacionDtvg.Rows[i].Cells[9].Value = liquidacion.TopeMaximo;
                TablaLiquidacionDtvg.Rows[i].Cells[10].Value = liquidacion.CuotaModeradora;
                TablaLiquidacionDtvg.Rows[i].Cells[11].Value = liquidacion.Fecha;
            }
        }

        private void FiltroTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TablaLiquidacionDtvg.Rows.Clear();
            MostrarTabla(service.FiltrarLiquidacion(TipoFiltroCmb.Text, FiltroTxt.Text.ToUpper()));


        }

        private void TipoDeFiltroDosCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            TablaLiquidacionDtvg.Rows.Clear();
            CantidadTxt.Text=Convert.ToString(service.FiltrarCantidadDeLiquidacion(TipoDeFiltroDosCmb.Text));
            TotalCuotaTxt.Text = Convert.ToString(service.FiltrarTotalDeCuotas(TipoDeFiltroDosCmb.Text));
            if (TipoDeFiltroDosCmb.Text=="Total Liquidaciones")
            {
                MostrarTabla(service.FiltrarLiquidacion(TipoDeFiltroDosCmb.Text," "));
            } 
            if (TipoDeFiltroDosCmb.Text== "Total Regimen Contributivo")
            {
                MostrarTabla(service.FiltrarLiquidacion(TipoDeFiltroDosCmb.Text, "REGIMEN CONTRIBUTIVO"));
            }
            if (TipoDeFiltroDosCmb.Text== "Total Regimen Subsidiado")
            {
                MostrarTabla(service.FiltrarLiquidacion(TipoDeFiltroDosCmb.Text, "REGIMEN SUBSIDIADO"));
            }
            
            FiltroTxt.Text = " ";
        }

        private void TipoFiltroCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            TablaLiquidacionDtvg.Rows.Clear();
            MostrarTabla(service.ConsultarListaListaLiquidacion());
        }
    }
}
