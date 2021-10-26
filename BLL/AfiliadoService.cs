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

        public AfiliadoConsultarResponse ConsultarTodos()
        {
            try
            {
                List<Afiliado> afiliadosDelFile = afiliadoRepository.ConsultarTodos();
                return new AfiliadoConsultarResponse(afiliadosDelFile);
            }
            catch (Exception e)
            {
                return new AfiliadoConsultarResponse("Se ha presentado la excepcion: " + e.Message);
            }
        }
        public AfiliadoResponse BuscarFecha(DateTime fechaLiquidacion)
        {
            try
            {
                List<Afiliado> liquidacionesDelFile = afiliadoRepository.FiltrarPorFecha(fechaLiquidacion);
                return new AfiliadoResponse(liquidacionesDelFile);
            }
            catch (Exception e)
            {
                return new AfiliadoResponse("Se ha presentado la excepcion: " + e.Message);
            }
        }

        public AfiliadoConsultarResponse FiltrarEstados(string estados)
        {
            try
            {
                List<Afiliado> estudiantesDelFile = afiliadoRepository.FiltrarEstado(estados);
                return new AfiliadoConsultarResponse(estudiantesDelFile);
            }
            catch (Exception e)
            {
                return new AfiliadoConsultarResponse("Se ha presentado la excepcion: " + e.Message);
            }
        }


        public class AfiliadoConsultarResponse
        {
            public List<Afiliado> Afiliados { get; set; }
            public bool Error { get; set; }
            public string MensajeDeError { get; set; }

            public AfiliadoConsultarResponse(List<Afiliado> afiliados)
            {
                Afiliados = afiliados;
                Error = false;
            }
            public AfiliadoConsultarResponse(string mensajeDeError)
            {
                MensajeDeError = mensajeDeError;
                Error = true;
            }

        }

        public class AfiliadoResponse
        {
            public List<Afiliado> Afiliados { get; set; }
            public Afiliado AfiliadoEncontrado { get; set; }
            public bool Repetido { get; set; }
            public string MessageError { get; set; }
            public bool ExistError { get; set; }

            public AfiliadoResponse(List<Afiliado> afiliado)
            {
                Afiliados = afiliado;
                ExistError = false;
            }
            public AfiliadoResponse(Afiliado afiliado)
            {
                AfiliadoEncontrado = afiliado;
                Repetido = true;
                ExistError = false;
            }
            public AfiliadoResponse(string messageError)
            {
                MessageError = messageError;
                Repetido = false;
                ExistError = true;
            }

        }
    }
}
