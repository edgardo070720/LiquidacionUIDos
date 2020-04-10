using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RegimenContributivo : LiquidacionCuotaModeradora
    {
        public override double CalcularTarifa(double salarioDevengado)
        {
            if (salarioDevengado < 1755606)
            {
                return 0.15;
            }
            if ((SalarioDevengado <= 1755606) && (salarioDevengado <= 4389015))
            {
                return 0.2;
            }
            if(salarioDevengado > 4389015)
            {
                return 0.25;
            }
            return 0;
        }
    }
}
