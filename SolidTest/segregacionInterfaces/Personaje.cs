using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest.segregacionInterfaces
{
    public abstract class Personaje : IPersonaje
    {
        private string nombre;
        private int salud;
        private int x;
        private int y;
        public string Nombre { get => nombre; }
        public int Salud { get => salud; }
        public int X { get => x; }
        public int Y { get => y; }
        public Personaje(string nombre, int salud,int x,int y)
        {
            this.nombre = nombre;
            this.salud = salud;
            this.x = x;
            this.y = y;
        }

        public void mover(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void recibirAtaque(int ataque)
        {
            this.salud -= ataque;
            if (this.salud < 0)
            {
                this.salud = 0;
            }
        }

        public void recibirCura(int cura)
        {
            this.salud += cura;
        }
    }
}
