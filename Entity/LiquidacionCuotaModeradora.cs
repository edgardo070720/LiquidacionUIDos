using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class LiquidacionCuotaModeradora
    {
        public LiquidacionCuotaModeradora()
        {

        }
        RegimenContributivo contributivo;
        RegimenSubsidiado subsidiado;
        public int NumeroLiquidacion { get; set; }
        public string Cedula { get; set; }
        public string TipoAfiliacion { get; set; }
        public double SalarioDevengado { get; set; }
        public double ValorServicio { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public double CuotaModeradora { get; set; }
        public double ValorReal { get; set; }
        public string TopeMaximo { get; set; }
        public string TarifaAplicada { get; set; }
        public double Tarifa { get; set; }
        public string Fecha { get; set; }

        public abstract void  CalcularTarifa();
        public abstract void ValidarTopeMaximo();

        public void CalcularCuotaModeradora()
        {
                CalcularTarifa();
                CuotaModeradora = ValorServicio * Tarifa; 
                ValorReal = CuotaModeradora;
                TarifaAplicada = $"{Tarifa*100}%";
                ValidarTopeMaximo();
        }

    }
}
