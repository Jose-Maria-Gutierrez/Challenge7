using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest.segregacionInterfaces
{
    internal interface IPersonaje
    {
        public void mover(int x,int y);
        public void recibirAtaque(int ataque);
        public void recibirCura(int cura);
    }
}
