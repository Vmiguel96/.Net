using System;
using System.Collections.Generic;
using System.Text;

namespace _23_06
{
   public class Circulo:IFigura
    {
        double radio;

        public double Radio { get => radio; set => radio = value; }

        public  double Perimetro()
        {
            return 2*Math.PI *radio;
        }

        public  double Area()
        {
            return Math.PI*radio*radio;
        }


    }
}
