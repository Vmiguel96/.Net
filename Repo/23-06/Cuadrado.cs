using System;
using System.Collections.Generic;
using System.Text;

namespace _23_06
{
    public class Cuadrado:IFigura
    {
        double lado;

        public double Lado { get => lado; set => lado = value; }

        public  double Perimetro() 
        {
            return lado * 4;
        }
        public  double Area()
        {
            return lado*lado;
        }
    }
}
