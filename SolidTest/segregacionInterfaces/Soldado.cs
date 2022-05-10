using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest.segregacionInterfaces
{
    public class Soldado : Personaje,IAtacar
    {
        private int ataque;
        public int Ataque { get { return ataque; } }
        public Soldado(string nombre, int salud, int x, int y,int ataque) : base(nombre, salud, x, y)
        {
            this.ataque = ataque;
        }

        public void atacar(Personaje personaje)
        {
            personaje.recibirAtaque(this.Ataque);
        }
    }

}
