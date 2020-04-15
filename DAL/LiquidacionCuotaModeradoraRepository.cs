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
        string name = @"Archivo de Liquidacion.txt";

        public void  GuardarArchivo(LiquidacionCuotaModeradora liquidacion)
        {
            FileStream file = new FileStream(name, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{liquidacion.NumeroLiquidacion};{liquidacion.Cedula};{liquidacion.Nombres};{liquidacion.Apellidos};" +
                $"{liquidacion.TipoAfiliacion};{liquidacion.SalarioDevengado};{liquidacion.ValorServicio};{liquidacion.TarifaAplicada};{liquidacion.ValorReal};" +
                $"{liquidacion.TopeMaximo};{liquidacion.CuotaModeradora};{liquidacion.Fecha}");
            writer.Close();
            file.Close();
            
        }

        public List<LiquidacionCuotaModeradora> LeerArchivo()
        {
            List<LiquidacionCuotaModeradora> listaLiquidaciones = new List<LiquidacionCuotaModeradora>();
            string line = string.Empty;
            FileStream file = new FileStream(name, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            while ((line=reader.ReadLine())!=null)
            {
                string[] matrizLiquidacion = line.Split(';');
                ValidarInstancia(matrizLiquidacion[4]);
                liquidacion.NumeroLiquidacion = Convert.ToInt32( matrizLiquidacion[0]);
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
            if (tipoAfiliacion== "Regimen Contributivo")
            {
                liquidacion = new RegimenContributivo();
            }
            else
            {
                liquidacion = new RegimenSubsidiado();
            }
        }
        public void ModificarArchivo(List<LiquidacionCuotaModeradora> liquidacions)
        {
            FileStream file = new FileStream(name, FileMode.Create);
            StreamWriter writer = new StreamWriter(file);
            foreach (LiquidacionCuotaModeradora liquidacion in liquidacions)
            {
                writer.WriteLine($"{liquidacion.NumeroLiquidacion};{liquidacion.Cedula};{liquidacion.Nombres};{liquidacion.Apellidos};" +
                $"{liquidacion.TipoAfiliacion};{liquidacion.SalarioDevengado};{liquidacion.ValorServicio};{liquidacion.TarifaAplicada};{liquidacion.ValorReal};" +
                $"{liquidacion.TopeMaximo};{liquidacion.CuotaModeradora};{liquidacion.Fecha}");
            }
            writer.Close();
            file.Close();
        }
    }
}
