using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest
{
    public interface IEscritura
    {
        public void escribir(List<String> lista);
        public void cerrar();
    }
}
