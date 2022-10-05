using System;
using System.Collections.Generic;
using System.Text;

namespace _01_07
{
    class Smartphones:Tactiles
    {
        public Smartphones(int velocidad, double pantalla) : base(velocidad, pantalla)
        {
        }

        public override void Conectar()
        {
            Console.WriteLine("Smartphone conectado");
        }

        public override string ToString()
        {
            return "Smartphone," +  velocidad + "," + pantalla;
        }
    }
}
