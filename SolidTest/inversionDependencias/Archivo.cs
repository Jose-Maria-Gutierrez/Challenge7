using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest
{
    public abstract class Archivo : IEscritura
    {
        private string nombreArchivo;

        public string NombreArchivo { get { return nombreArchivo; } }

        public Archivo(string nombreArchivo)
        {
            this.nombreArchivo = nombreArchivo;
        }

        public abstract void escribir(List<string> lista);
        public abstract void cerrar();
    }
}
