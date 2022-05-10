using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest.sustitucionLiskov
{
    public class Menor : Persona
    {
        private Adulto adulto;
        public Menor(string nombre, int edad,Adulto adulto) : base(nombre, edad)
        {
            this.adulto = adulto;
        }
        public override void pagar()
        {
            Console.WriteLine(this.Nombre + " delega a ");
            adulto.pagar(); //delegacion
        }
    }
}
