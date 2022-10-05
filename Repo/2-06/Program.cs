using System;

namespace _2_06
{
    class Program
    {
        public static void Saluda() 
        {
            Console.WriteLine("!Hola!");
        }
        public static void Saluda(string nombre) 
        {
            Console.WriteLine($"!Hola! {nombre}");
        }
        public static int Suma(int n1, int n2) 
        {
            int resultado = n1 + n2;
            return resultado;
        }
        public static double Media(double n1, double n2, double n3)
        {
            double resultadoMedia = (n1 + n2 + n3) / 3;
            return resultadoMedia;
        }
        public static void MostarMedia(double n1, double n2, double n3)
        {
             double media = Media(n1,n2,n3);
            Console.WriteLine($"{media}");
        }

        public static bool EsAlfabetico(char c) 
        {
            bool resultado;
            if (c >= 'A' && c <= 'Z')
            {
                resultado = true;
            }
            else 
            {
                resultado = false;
            }
            return resultado;

        }

        static void Main(string[] args)
        {
            if (EsAlfabetico('a')) 
            {

            }
            Saluda();
            Saluda("Mari Chelo");
            int resultado = Suma(2,5);
            double resultadoMedia = Media(3,4,5);

            Console.WriteLine(Media(3,4,5));
            MostarMedia(2,3,4);
            if (EsAlfabetico('M'))
            {
                System.Console.WriteLine("Es un carácter alfabético");
            }

        }
    }
}
