﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Afiliado
    {
        public string TipoIdentificacion { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public DateTime FechaAfiliacion { get; set; }
        public string Estado { get; set; }

        public Afiliado(string tipoIdentificacion, string nombre, DateTime fechaDeNacimiento, DateTime fechaAfiliacion, string estado)
        {
            TipoIdentificacion = tipoIdentificacion;
            Nombre = nombre;
            FechaDeNacimiento = fechaDeNacimiento;
            FechaAfiliacion = fechaAfiliacion;
            Estado = estado;
        }

        public Afiliado()
        {
        }

        public string FormatoParaArchivo()
        {
            return $"{TipoIdentificacion};{Nombre};{FechaDeNacimiento};{FechaAfiliacion};{Estado}";
        }

    }
}
