using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RegimenSubsidiado : LiquidacionCuotaModeradora
    {
        public override double CalcularTarifa(double salarioDevengado)
        {
            return 0.05;
        }
    }
}
