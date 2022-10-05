using System;
using System.Collections.Generic;
using System.Text;

namespace _23_06
{
    class Coche : Vehiculo
    {
        int puertas;

        
        public Coche():base()
        {

        }

        public override string ToString()
        {
            return base.ToString() + " " + puertas;
        }

        public Coche(string marca, string modelo, string potencia, int ruedas, int peso, string color,int puertas) : base(marca,modelo, potencia, 4, peso, color)
        {
            this.puertas = puertas;
        }

        public override void Frenar()
        {
            Console.WriteLine("Coche frenando");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Coche acelerando");
        }
    }
}
