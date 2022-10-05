using System;
using System.Collections.Generic;
using System.Text;

namespace _23_06
{
    class Motocicleta : Vehiculo
    {
        public Motocicleta():base()
        {
        }

        public Motocicleta(string marca, string modelo, string potencia, int ruedas, int peso, string color) : base(marca, modelo, potencia, 2, peso, color)
        {
            
        }

        public override void Frenar()
        {
            Console.WriteLine("Motocicleta frenando");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Motocicleta acelerando");
        }
    }
}
