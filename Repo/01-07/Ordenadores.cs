using System;
using System.Collections.Generic;
using System.Text;

namespace _01_07
{
    class Ordenadores:ConTeclado
    {
        public Ordenadores(int velocidad, double pantalla) : base(velocidad,pantalla) 
        {

        }

        public override void Conectar() 
        {
            Console.WriteLine("Ordenador conectado");
        }

        public override string ToString()
        {
            return  "Ordenador,"+velocidad + "," + pantalla;
        }
    }
}
