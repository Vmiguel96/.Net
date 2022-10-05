using System;
using System.Collections.Generic;
using System.Text;

namespace _01_07
{
    class Tablets:Tactiles
    {
        public Tablets(int velocidad, double pantalla) : base(velocidad, pantalla)
        {
        }

        public override void Conectar()
        {
            Console.WriteLine("Tablet conectado");
        }

        public override string ToString()
        {
            return "Tablet," + velocidad + "," + pantalla;
        }
    }
}
