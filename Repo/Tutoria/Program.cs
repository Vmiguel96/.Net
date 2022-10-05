using System;

namespace Tutoria
{
    class Program
    {
        public static bool Numeros(int numeros) 
        {
            bool resultado;
            if (numeros != 0)
            {
                 resultado = true;
            }
            else 
            {
                resultado = false;
            }
            return resultado;
        }

        public static void PedirDatos() 
        {
            int precio = 1, cantidad = 1;
            int acumulado = 0;
            while (acumulado <10000 && !(cantidad ==0 || precio==0))
            //while (acumulado <10000 && cantidad !=0 && precio!=0)
            {
                Console.WriteLine($"Escribe una cantidad");
                cantidad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Escribe un precio");
                precio = Convert.ToInt32(Console.ReadLine());

                acumulado += precio* cantidad;
            }


        }

        public static void PedirPalabras(string cadena) 
        {
            string palabra=cadena;
            while (palabra.Contains(cadena))
            {
                Console.WriteLine($"Escribe un palabra");
                palabra = Console.ReadLine();
                
            }

        }

        static void Main(string[] args)
        {
            PedirPalabras("ana");

            //string usuario = "";
            //string password = "";

            //while (!(usuario == "usuario" && password == "usuario")) 
            //{
            //    Console.WriteLine($"Escribe una palabra");
            //    usuario = Console.ReadLine();
            //    Console.WriteLine($"Escribe una palabra");
            //    password = Console.ReadLine();

            //}

            int numeros = 1;
            int resto = 0;
            //while(Numeros(numeros))
            //{
            //    Console.WriteLine($"Escribe un numero");
            //    numeros = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine($"Escribe un numero");
            //numeros = Convert.ToInt32(Console.ReadLine());
            //while (numeros/10!=0) 
            //{

            //    numeros /=10 ;
            //    resto = numeros % 10;
            //    //numeros = numeros / 10;
            //    Console.WriteLine($"{numeros}");
            //}
            PedirDatos();

            
            //Console.WriteLine("Hello World!");
        }
    }
}
