using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LiquidacioRepository
    {
        private readonly string fileName = "Liquidaciones.txt";
        AfiliadoRepository afiliado = new AfiliadoRepository();
        public void Guardar(Liquidacion liquidacion)
        {
            FileStream file = new FileStream(fileName, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(liquidacion.FormatoParaArchivo());
            writer.Close();
            file.Close();
        }
        public void ValidarAfiliacion()
        {

        }

        public Liquidacion BuscarID(int id)
        {
            List<Liquidacion> listaCandidato = ConsultarTodos();
            foreach (var candidato in listaCandidato)
            {
                if (candidato.IDLiquidacion.Equals(id))
                    return candidato;
            }
            return null;
        }
        public List<Liquidacion> ConsultarTodos()
        {
            List<Liquidacion> afiliadoDelFile = new List<Liquidacion>();

            FileStream file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;

            while ((linea = reader.ReadLine()) != null)
            {
                afiliadoDelFile.Add(Map(linea));
            }

            reader.Close();
            file.Close();

            return afiliadoDelFile;
        }


        private Liquidacion Map(string linea)
        {
            string[] datoLiquidacion = linea.Split(';');
            Liquidacion liquidacion = new LiquidacionMensual();

            liquidacion.IDLiquidacion = Convert.ToInt32(datoLiquidacion[0]);
            liquidacion.MesALiquidar = Convert.ToInt32(datoLiquidacion[1]);
            liquidacion.AñoALiquidar = Convert.ToInt32(datoLiquidacion[2]);
            liquidacion.ValorLiquidacion = Convert.ToDouble(datoLiquidacion[3]);

            return liquidacion;

        }
    }
}
