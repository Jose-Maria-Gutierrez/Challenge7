﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest.sustitucionLiskov
{
    public abstract class Persona
    {
        private string nombre;
        private int edad;
        public string Nombre { get { return nombre; } }
        public int Edad { get { return edad; } }

        public Persona(string nombre,int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public abstract void pagar();
    }
}
