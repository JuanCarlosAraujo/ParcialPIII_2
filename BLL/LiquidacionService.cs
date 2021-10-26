using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LiquidacionService
    {
        private LiquidacioRepository liquidacionRepository;

        public LiquidacionService()
        {
            liquidacionRepository = new LiquidacioRepository();
        }


        public string Guardar(Liquidacion afiliado)
        {
            try
            {

                liquidacionRepository.Guardar(afiliado);
                return "Se ha guardado exitosamente!";


            }
            catch (Exception e)
            {
                return "Se ha presentado la excepcion: " + e.Message;
            }
        }
    }
}
