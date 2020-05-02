using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;


namespace DAL
{
    public class LiquidacionCuotaModeradoraRepository
    {
        LiquidacionCuotaModeradora liquidacion;
        IList<LiquidacionCuotaModeradora> listaLiquidaciones;
        private const string NAME = @"Archivo de Liquidacion.txt";
        public LiquidacionCuotaModeradoraRepository()
        {
            listaLiquidaciones = new List<LiquidacionCuotaModeradora>();
        }

        public string GuardarArchivo(LiquidacionCuotaModeradora liquidacion)
        {
            try
            {

                FileStream file = new FileStream(NAME, FileMode.Append);
                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine(LlenarArchivo(liquidacion));
                writer.Close();
                file.Close();
                return "Se registro exitosamente";
            }
            catch (System.FormatException)
            {
                return "fallos al momento de registrar";
            }
            catch (System.IO.IOException)
            {
                return "se produjo un error al momento de habrir el archivo de registros";
            }


        }

        public IList<LiquidacionCuotaModeradora> LeerArchivo()
        {
            IList<LiquidacionCuotaModeradora> listaLiquidaciones = new List<LiquidacionCuotaModeradora>();
            string line = string.Empty;
            FileStream file = new FileStream(NAME, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            while ((line = reader.ReadLine()) != null)
            {
                string[] matrizLiquidacion = line.Split(';');
                ValidarInstancia(matrizLiquidacion[4]);
                liquidacion.NumeroLiquidacion = matrizLiquidacion[0];
                liquidacion.Cedula = matrizLiquidacion[1];
                liquidacion.Nombres = matrizLiquidacion[2];
                liquidacion.Apellidos = matrizLiquidacion[3];
                liquidacion.TipoAfiliacion = matrizLiquidacion[4];
                liquidacion.SalarioDevengado = Convert.ToDouble(matrizLiquidacion[5]);
                liquidacion.ValorServicio = Convert.ToDouble(matrizLiquidacion[6]);
                liquidacion.TarifaAplicada = matrizLiquidacion[7];
                liquidacion.ValorReal = Convert.ToDouble(matrizLiquidacion[8]);
                liquidacion.TopeMaximo = matrizLiquidacion[9];
                liquidacion.CuotaModeradora = Convert.ToDouble(matrizLiquidacion[10]);
                liquidacion.Fecha = matrizLiquidacion[11];
                listaLiquidaciones.Add(liquidacion);
            }
            reader.Close();
            file.Close();
            return listaLiquidaciones;
        }

        public void ValidarInstancia(string tipoAfiliacion)
        {
            if (tipoAfiliacion == "Regimen Contributivo")
            {
                liquidacion = new RegimenContributivo();
            }
            else
            {
                liquidacion = new RegimenSubsidiado();
            }
        }
        public string EliminarEnArchivo(string numeroLiquidacion)
        {
            bool control = false;
            int index = 0;
            List<LiquidacionCuotaModeradora> liquidacions = new List<LiquidacionCuotaModeradora>();
            liquidacions = LeerArchivo().ToList();
            foreach (LiquidacionCuotaModeradora liquidacion in liquidacions)
            {
                if (numeroLiquidacion == liquidacion.NumeroLiquidacion)
                {
                    control = true;
                    index = liquidacions.IndexOf(liquidacion);
                }
            }
            if (control)
            {
                liquidacions.RemoveAt(index);
                ModificarArchivo(liquidacions);

            }
            return "se elimino correctamente";
        }
        public void ModificarArchivo(List<LiquidacionCuotaModeradora> liquidacions)
        {
            FileStream file = new FileStream(NAME, FileMode.Create);
            StreamWriter writer = new StreamWriter(file);
            foreach (LiquidacionCuotaModeradora liquidacion in liquidacions)
            {
                writer.WriteLine(LlenarArchivo(liquidacion));
            }
            writer.Close();
            file.Close();
        }
        public string ModifocarEnArchivo(string numeroliquidacion, double valorServicio)
        {
            List<LiquidacionCuotaModeradora> liquidacions = new List<LiquidacionCuotaModeradora>();
            liquidacions = LeerArchivo().ToList();

            foreach (LiquidacionCuotaModeradora liquidacion in liquidacions)
            {
                if (numeroliquidacion == liquidacion.NumeroLiquidacion)
                {
                    liquidacion.ValorServicio = valorServicio;
                    liquidacion.CalcularCuotaModeradora();
                    ModificarArchivo(liquidacions);
                    return "se modifico correctamente";
                }
            }
            return null;
        }

        public IList< LiquidacionCuotaModeradora> ConsultarEnArchivo(string numeroLiquidacion)
        {
            IList<LiquidacionCuotaModeradora> liquidacions = new List<LiquidacionCuotaModeradora>();
            liquidacions = LeerArchivo().ToList();
            
            return liquidacions = liquidacions.Where(l=>l.NumeroLiquidacion.Equals(numeroLiquidacion)).ToList();
        }

        public List<LiquidacionCuotaModeradora> FiltrarLiquidacion(string tipoFiltro, string filtro)
        {
            IList<LiquidacionCuotaModeradora> liquidacionCuotas = new List<LiquidacionCuotaModeradora>();
            liquidacionCuotas = LeerArchivo();
            if (tipoFiltro == "Numero de Liquidacion")
            {
                if (!filtro.Trim().Equals(""))
                {
                    liquidacionCuotas = liquidacionCuotas.Where(l => l.NumeroLiquidacion.Contains(filtro.Trim())).ToList();
                }
            }
            if (tipoFiltro == "Cedula")
            {
                if (!filtro.Trim().Equals(""))
                {
                    liquidacionCuotas = liquidacionCuotas.Where(l => l.Cedula.Contains(filtro.Trim())).ToList();
                }
            }
            if (tipoFiltro == "Nombres")
            {
                if (!filtro.Trim().Equals(""))
                {
                    liquidacionCuotas = liquidacionCuotas.Where(l => l.Nombres.Contains(filtro.Trim())).ToList();
                }
            }
            if (tipoFiltro == "Apellidos")
            {
                if (!filtro.Trim().Equals(""))
                {
                    liquidacionCuotas = liquidacionCuotas.Where(l => l.Apellidos.Contains(filtro.Trim())).ToList();
                }
            }
            if (tipoFiltro == "Tipo de Afiliacion")
            {
                if (!filtro.Trim().Equals(""))
                {
                    liquidacionCuotas = liquidacionCuotas.Where(l => l.TipoAfiliacion.Contains(filtro.Trim())).ToList();
                }
            }

            if (tipoFiltro == "Fecha")
            {
                if (!filtro.Trim().Equals(""))
                {
                    liquidacionCuotas = liquidacionCuotas.Where(l => l.Fecha.Contains(filtro.Trim())).ToList();
                }
            }
            if (tipoFiltro == "Total Regimen Contributivo")
            {
                liquidacionCuotas = liquidacionCuotas.Where(l => l.TipoAfiliacion.Equals(filtro)).ToList();
            }
            if (tipoFiltro == "Total Regimen Subsidiado")
            {
                liquidacionCuotas = liquidacionCuotas.Where(l => l.TipoAfiliacion.Equals(filtro)).ToList();
            }
            return liquidacionCuotas.ToList();
        }

        public int FiltrarCantidadDeLiquidaciones(string tipoDeFiltro)
        {
            listaLiquidaciones = LeerArchivo();
            if (tipoDeFiltro == "Total Liquidaciones")
            {
                return listaLiquidaciones.Count(l => l.TipoAfiliacion.Equals("REGIMEN CONTRIBUTIVO") || l.TipoAfiliacion.Equals("REGIMEN SUBSIDIADO"));
            }
            if (tipoDeFiltro == "Total Regimen Contributivo")
            {
                return listaLiquidaciones.Count(l => l.TipoAfiliacion.Equals("REGIMEN CONTRIBUTIVO"));
            }
            if (tipoDeFiltro == "Total Regimen Subsidiado")
            {
                return listaLiquidaciones.Count(l => l.TipoAfiliacion.Equals("REGIMEN SUBSIDIADO"));
            }
            return 0;
        }

        public double FiltrarTotalDeCuotas(string tipoDeFiltro)
        {
            listaLiquidaciones = LeerArchivo();
            if (tipoDeFiltro == "Total Liquidaciones")
            {
                return listaLiquidaciones.Sum(l => l.CuotaModeradora);
            }
            if (tipoDeFiltro == "Total Regimen Contributivo")
            {
                return listaLiquidaciones.Where(l => l.TipoAfiliacion.Equals("REGIMEN CONTRIBUTIVO")).Sum(l => l.CuotaModeradora);
            }
            if (tipoDeFiltro == "Total Regimen Subsidiado")
            {
                return listaLiquidaciones.Where(l => l.TipoAfiliacion.Equals("REGIMEN SUBSIDIADO")).Sum(l => l.CuotaModeradora);
            }
            return 0;
        }


        public string LlenarArchivo(LiquidacionCuotaModeradora liquidacion)
        {
            return $"{liquidacion.NumeroLiquidacion};{liquidacion.Cedula};{liquidacion.Nombres};{liquidacion.Apellidos};" +
                    $"{liquidacion.TipoAfiliacion};{liquidacion.SalarioDevengado};{liquidacion.ValorServicio};{liquidacion.TarifaAplicada};{liquidacion.ValorReal};" +
                    $"{liquidacion.TopeMaximo};{liquidacion.CuotaModeradora};{liquidacion.Fecha}";
        }
    }
}
