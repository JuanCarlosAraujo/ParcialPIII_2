﻿using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DAL
{
    public class AfiliadoRepository
    {
        private readonly string fileName = "Afiliados.txt";
        public void Guardar(Afiliado afiliado)
        {
            FileStream file = new FileStream(fileName, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(afiliado.FormatoParaArchivo());
            writer.Close();
            file.Close();
        }
        public List<Afiliado> ConsultarTodos()
        {
            List<Afiliado> afiliadoDelFile = new List<Afiliado>();

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
        private Afiliado Map(string linea)
        {
            string[] datoAfiliado = linea.Split(';');
            Afiliado afiliado = new Afiliado();

            afiliado.TipoIdentificacion = datoAfiliado[0];
            afiliado.Nombre = datoAfiliado[1];
            afiliado.FechaDeNacimiento = Convert.ToDateTime(datoAfiliado[2]);
            afiliado.FechaAfiliacion = Convert.ToDateTime(datoAfiliado[3]);
            afiliado.Estado = datoAfiliado[4];

            return afiliado;

        }
        public List<Afiliado> FiltrarPorFecha(DateTime fecha)
        {
            IEnumerable<Afiliado>
                filtroDato = from var in ConsultarTodos()
                             where var.FechaAfiliacion.Month == fecha.Month &&
                             var.FechaAfiliacion.Year == fecha.Year
                             select var;
            return filtroDato.ToList();
        }

        public List<Afiliado> FiltrarEstado(string estado)
        {
            IEnumerable<Afiliado>
                filtroDato = from var in ConsultarTodos() where var.Estado == estado select var;
            return filtroDato.ToList();
        }
    }
}
