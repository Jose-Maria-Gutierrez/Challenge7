using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest
{
    internal class ArchivoTexto : Archivo
    {
        private StreamWriter sr;
        public ArchivoTexto(string nombreArchivo) : base(nombreArchivo)
        {
            this.sr = new StreamWriter(nombreArchivo);
        }

        public override void escribir(List<string> lista)
        {
            foreach (string s in lista)
            {
                sr.WriteLine(s);
            }
        }

        public override void cerrar()
        {
            this.sr.Close();
        }

    }
}
