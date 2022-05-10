using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest.sustitucionLiskov
{
    public class Adulto : Persona
    {
        private int tarjeta;
        public int Tarjeta { get { return this.tarjeta; } }

        public Adulto(string nombre, int edad,int tarjeta) : base(nombre, edad)
        {
            this.tarjeta = tarjeta;
        }

        public override void pagar()
        {
            Console.WriteLine(Tarjeta + " ha realizado el pago");
        }

    }
}
