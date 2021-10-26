using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class LiquidacionMensual : Liquidacion
    {
        public List<LiquidacionIndividual> liquidaciones {get; set;}

        public LiquidacionMensual(int mesALiquidar, int añoALiquidar) : base(mesALiquidar, añoALiquidar)
        {
        }

        public LiquidacionMensual()
        {
        }

        public override double CalcularValorLiquidacion()
        {
            double valor = 0;
            

            return valor;
        }

        public override string FormatoParaArchivo()

        {
            return $"{IDLiquidacion};{MesALiquidar}; {liquidaciones};" +
                $"{AñoALiquidar};{NumeroLiquidaciones};{ValorLiquidacion};";
        }
    }
}
