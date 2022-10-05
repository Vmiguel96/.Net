using System;
using System.Collections.Generic;
using System.Text;

namespace _18_06
{
   public class NumeroComplejo
    {
        double real;
        double imaginaria;


        public NumeroComplejo():this(0,0) 
        {
            //real=0;
            //imaginaria=0;
        }
        public NumeroComplejo(double real, double imaginaria)
        {
            this.real = real;
            this.imaginaria = imaginaria;
        }

        public NumeroComplejo(NumeroComplejo n):this(n.real,n.imaginaria)
        {
            //real = n.real;
            //imaginaria = n.imaginaria;
        }


        public double GetReal()
        {
            return real;
        }
        public double GetImaginario()
        {
            return imaginaria;
        }

        public void SetReal(double real)
        {
            this.real = real;
        }

        public void SetImaginaria(double imaginaria)
        {
            this.imaginaria = imaginaria;
        }


        public double GetMagnitud() 
        {
            //double potencia = Math.Pow(real + imaginaria, 2);
             double magnitud = Math.Sqrt(Math.Pow(real,2)+Math.Pow(imaginaria,2));;
            // Math.Sqrt(Math.Pow(real,2)+Math.Pow(imaginaria,2));
            return magnitud ;
        }

        public override string ToString()
        {
            string resultado = $"{real}";
                if (imaginaria < 0)
            {
                resultado += $"{imaginaria}i";
            }
            else 
            {
                resultado += $"+{imaginaria}i";
            }
            return resultado;
        }

        public static NumeroComplejo Suma(NumeroComplejo n1, NumeroComplejo n2)
        {
            NumeroComplejo resultado = new NumeroComplejo();

            resultado.SetReal(n1.GetReal() + n2.GetReal());
            resultado.SetImaginaria(n1.GetImaginario() + n2.GetImaginario());
            return resultado;
        }

    }
}
