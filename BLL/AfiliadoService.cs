using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AfiliadoService
    {
        private AfiliadoRepository afiliadoRepository;

        public AfiliadoService()
        {
            afiliadoRepository = new AfiliadoRepository();
        }


        public string Guardar(Afiliado afiliado)
        {
            try
            {

                afiliadoRepository.Guardar(afiliado);
                return "Se ha guardado exitosamente!";


            }
            catch (Exception e)
            {
                return "Se ha presentado la excepcion: " + e.Message;
            }
        }

    }
}
