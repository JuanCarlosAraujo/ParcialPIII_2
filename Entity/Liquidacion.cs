using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Liquidacion
    {
        public int IDLiquidacion { get; set; }
        public int MesALiquidar { get; set; }
        public int AñoALiquidar { get; set; }
        public int NumeroLiquidaciones { get; set; }
        public double ValorLiquidacion { get; set; }
        public static double VALORUPC = 900.000;

        public Liquidacion(int mesALiquidar, int añoALiquidar)
        {
            MesALiquidar = mesALiquidar;
            AñoALiquidar = añoALiquidar;
            ValorLiquidacion = CalcularValorLiquidacion();

        }

        protected Liquidacion()
        {
        }

        public abstract string FormatoParaArchivo();
        public abstract double CalcularValorLiquidacion();

    }
}
