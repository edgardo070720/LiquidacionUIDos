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
            if (ValidarExistencia(liquidacion.NumeroLiquidacion))
            {
                 return " ya existe un registro con este numero";
            }
            else
            {
               return repository.GuardarArchivo(liquidacion);
            }
        }
        public List<LiquidacionCuotaModeradora> ConsultarListaListaLiquidacion()
        {
          return  repository.LeerArchivo().ToList();
        }

        public string EliminarLiquidacion(string nuemroLiquidacion)
        {
            if (ValidarExistencia(nuemroLiquidacion))
            {
                return repository.EliminarEnArchivo(nuemroLiquidacion);
            }
            else
            {
                return "no se encontro liquidacion con ese numero";
            }
            
        }

        public string ModificarLiquidacion(string numeroLiquidacion, double valorServicio)
        {
            if (ValidarExistencia(numeroLiquidacion))
            {
                return repository.ModifocarEnArchivo(numeroLiquidacion, valorServicio);
            }
            else
            {
                return "no se encontro registro con este numero";
            }
        }
        public IList< LiquidacionCuotaModeradora> ConsultarLiquidacion(string numeroliquidacion)
        {
            return repository.ConsultarEnArchivo(numeroliquidacion);
        }

        public List<LiquidacionCuotaModeradora> FiltrarLiquidacion(string tipoFiltro, string filtro)
        {
            return repository.FiltrarLiquidacion(tipoFiltro, filtro);
        }
        public int FiltrarCantidadDeLiquidacion(string tipoDeFiltro)
        {
            return repository.FiltrarCantidadDeLiquidaciones(tipoDeFiltro);
        }
        public double FiltrarTotalDeCuotas(string tipoDeFiltro)
        {
            return repository.FiltrarTotalDeCuotas(tipoDeFiltro);
        }
        public bool ValidarExistencia(string numeroLiquidacion)
        {
            
            bool control = false;
            foreach (LiquidacionCuotaModeradora liquidacion in ConsultarListaListaLiquidacion())
            {
                if (numeroLiquidacion == liquidacion.NumeroLiquidacion)
                {
                    control = true;
                }
            }
            return control;
        }
    }
}
