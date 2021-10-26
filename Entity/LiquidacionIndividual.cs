using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class LiquidacionIndividual : Liquidacion
    {
        public Afiliado afiliado { get; set; }
        public LiquidacionIndividual(int mesALiquidar, int añoALiquidar) : base(mesALiquidar, añoALiquidar)
        {
        }


        public override double CalcularValorLiquidacion()
        {
            return NumeroLiquidaciones * VALORUPC;
        }

        public override string FormatoParaArchivo()
        {
            throw new NotImplementedException();
        }
    }
}
