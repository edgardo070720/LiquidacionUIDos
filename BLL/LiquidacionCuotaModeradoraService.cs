using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class LiquidacionCuotaModeradoraService
    {
        LiquidacionCuotaModeradoraRepository repository = new LiquidacionCuotaModeradoraRepository();
        public string GuardarLiquidacion(LiquidacionCuotaModeradora liquidacion)
        {
            repository.GuardarArchivo(liquidacion);
            return "Se registro exitosamente"; 
        }
        public List<LiquidacionCuotaModeradora> ConsultarListaLiquidacion()
        {
          return  repository.LeerArchivo();
        }

        public string EliminarLiquidacion(List<LiquidacionCuotaModeradora>liquidacions)
        {
            repository.ModificarArchivo(liquidacions);

            return "Se ha eliminado correctamente";
        }

        public string ModificarLiquidacion(List<LiquidacionCuotaModeradora> liquidacions)
        {
            repository.ModificarArchivo(liquidacions);
            return "se ha modificado correctamente";
        }
    }
}
