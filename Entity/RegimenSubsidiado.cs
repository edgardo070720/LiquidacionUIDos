using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RegimenSubsidiado : LiquidacionCuotaModeradora
    {
        public override void CalcularTarifa()
        {
            Tarifa= 0.05;
        }

        public override void ValidarTopeMaximo()
        {
            bool control = true;
            if (CuotaModeradora >= 200000)
            {
                CuotaModeradora = 200000;
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
