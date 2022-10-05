using System;
using System.Collections.Generic;
using System.Linq;
namespace _02_07
{
    class Program
    {
        public static void FuncionLinq ()
        {
            List<double> numeros = new List<double> { 14, 7, 21, 4, 6, 11, 71, 3, 2, 19, 0, 1, 5, 8, 7, 9 };
            List<double> mayores10 = (from n in numeros where (n > 10) select n).Distinct().ToList();

            foreach (double n in mayores10) 
            {
                Console.WriteLine(n);
            }
            Console.WriteLine(mayores10);
        }

        public void ListaCadena(string cadena) 
        {

        }
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            lista.Add("cadena1");
            lista.Add("cadena2");
            lista.Add("otra cadena");
            lista.Add("diferente");


            List<string> resultado = (from s in lista where s.Contains("cadena") select s).ToList();

            FuncionLinq();

            foreach (string s in resultado) 
            {
                Console.WriteLine(s);
            }
        }
    }
}
