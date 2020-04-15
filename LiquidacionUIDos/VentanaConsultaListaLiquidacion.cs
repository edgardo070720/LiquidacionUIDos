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
        LiquidacionCuotaModeradoraService service = new LiquidacionCuotaModeradoraService();
        List<LiquidacionCuotaModeradora> liquidacions = new List<LiquidacionCuotaModeradora>();
        public VentanaConsultaListaLiquidacion()
        {
            InitializeComponent();
            MostrarTabla();
        }

        public void MostrarTabla()
        {
            liquidacions = service.ConsultarListaLiquidacion();

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
    }
}
