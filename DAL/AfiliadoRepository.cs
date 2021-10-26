using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AfiliadoRepository
    {
        private readonly string fileName = "Afiliados.txt";
        public void Guardar(Afiliado estudiante)
        {
            FileStream file = new FileStream(fileName, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(estudiante.FormatoParaArchivo());
            writer.Close();
            file.Close();
        }

    }
}
