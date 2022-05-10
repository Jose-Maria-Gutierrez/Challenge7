using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest
{
    public class Escritor
    {
        private Archivo archivo;
        public Escritor(Archivo archivo)
        {
            this.archivo = archivo;
        }

        public void escribirArchivoConLista(List<String> lista)
        {
            archivo.escribir(lista);
            archivo.cerrar();
        }

    }
}
