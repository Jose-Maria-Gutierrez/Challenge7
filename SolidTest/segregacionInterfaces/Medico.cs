using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest.segregacionInterfaces
{
    public class Medico : Personaje,ICurar
    {
        private int cantidadCuracion;
        public int CantidadCuracion { get { return cantidadCuracion; } }
        public Medico(string nombre, int salud, int x, int y,int cant) : base(nombre, salud, x, y)
        {
            this.cantidadCuracion = cant;
        }

        public void curar(Personaje p)
        {
            p.recibirCura(this.cantidadCuracion);
        }
    }
}
