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
        public string Tarifa { get; set; }
        public string Fecha { get; set; }

        public abstract double CalcularTarifa(double salarioDevengado);

        public void CalcularCuotaModeradora()
        {
            if (TipoAfiliacion == "Regimen Contributivo")
            {
                contributivo = new RegimenContributivo();
                CuotaModeradora = ValorServicio * contributivo.CalcularTarifa(SalarioDevengado);
                ValorReal = CuotaModeradora;
                Tarifa = $"{contributivo.CalcularTarifa(SalarioDevengado)*100}%";
                ValidarTopeMaximoContributivo(CuotaModeradora);
            }
            if (TipoAfiliacion == "Regimen Subsidiado")
            {
                subsidiado = new RegimenSubsidiado();
                CuotaModeradora = ValorServicio * subsidiado.CalcularTarifa(SalarioDevengado);
                ValorReal = CuotaModeradora;
                Tarifa = $"{subsidiado.CalcularTarifa(SalarioDevengado)*100}%";
                ValidarTopeMaximoSubsidiado(CuotaModeradora);
            }
        }

        public void ValidarTopeMaximoContributivo(double cuota)
        {
            int control = 0;
            if ((SalarioDevengado<1755606)&&(cuota>= 250000))
            {
                CuotaModeradora = 250000;
                control = 1;
            }
            if (((SalarioDevengado>= 1755606) &&(SalarioDevengado<=4389015))&&(cuota>= 900000))
            {
                CuotaModeradora = 900000;
                control = 1;
            }
            if ((SalarioDevengado> 4389015) &&(cuota>=1500000))
            {
                CuotaModeradora= 15000000;
                control = 1;
            }
            if (control==0)
            {
                TopeMaximo = "No aplica";
            }
            else
            {
                TopeMaximo = "Aplica";
            }
        }
        public void ValidarTopeMaximoSubsidiado(double cuota)
        {
            int control = 0;
            if (cuota>= 200000)
            {
                CuotaModeradora = 200000;
                control = 1;
            }
            if (control == 0)
            {
                TopeMaximo = "No aplica";
            }
            else
            {
                TopeMaximo = "Aplica";
            }
        }

    }
}
