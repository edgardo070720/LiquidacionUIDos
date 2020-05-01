using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RegimenContributivo : LiquidacionCuotaModeradora
    {
        public override void  CalcularTarifa()
        {
            if (SalarioDevengado < 1755606)
            {
                Tarifa= 0.15;
            }
            if ((SalarioDevengado >= 1755606) && (SalarioDevengado <= 4389015))
            {
                Tarifa=0.2;
            }
            if(SalarioDevengado > 4389015)
            {
                Tarifa= 0.25;
            }
           
        }

        public override void ValidarTopeMaximo()
        {
            bool control = true;
            if ((SalarioDevengado < 1755606) && (CuotaModeradora >= 250000))
            {
                CuotaModeradora = 250000;
                control = false;
            }
            if (((SalarioDevengado >= 1755606) && (SalarioDevengado <= 4389015)) && (CuotaModeradora >= 900000))
            {
                CuotaModeradora = 900000;
                control = false;
            }
            if ((SalarioDevengado > 4389015) && (CuotaModeradora >= 1500000))
            {
                CuotaModeradora = 15000000;
                control = false;
            }
            if (control)
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
