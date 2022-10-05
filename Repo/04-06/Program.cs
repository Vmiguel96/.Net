using System;

namespace _04_06
{
    class Program
    {
        public static void Modifica(ref string p) 
        {
            p = "MODIFICADO";
        }

        public static void ModificaArray(int[] a) 
        {
            a[1]= 100;
        }

        public static int Ejercicio1(params int[] numeros) 
        {
            int numeroMax = 0; 

            for (int i=0;i<numeros.Length;i++) 
            {
                //Funcion Max
                numeroMax = Math.Max(numeroMax, numeros[i]);
                //if (numeros[i] > numeroMax) 
                //{
                //    numeroMax = numeros[i];
                //}
            }



            return numeroMax;
        }

        public static int Ejercicio2(string texto, string buscar) 
        {
            int posicion = 0;
            int veces = 0;

            do
            {
                posicion = texto.IndexOf(buscar, posicion+buscar.Length);
                if (posicion != -1)
                {
                    posicion = posicion + buscar.Length;
                    veces++;
                }

            } while (posicion !=
            -1);

            return veces;
        }

        public static string Ejercicio3(string cadena, string separdor, int repetir) 
        {

            for (int i =0;i<cadena.Length;i = i + repetir+1) 
            {
                cadena = cadena.Insert(i, separdor);
            }

            return cadena;
        }

        static void Main(string[] args)
        {
            //string palabra = "INICIAL";
            //Console.WriteLine($"ANTES: {palabra}");
            //Modifica(ref palabra);
            //Console.WriteLine($"DESPUES:{palabra}");
            //int[] numeros = { 1, 2, 3, 4, 5 };
            //ModificaArray(numeros);
            //for (int i=0;i<numeros.Length;i++) 
            //{
            //    Console.Write($"{numeros[i]}");
            //}
            //Console.WriteLine();
            //int[] numeros2 = {3, 4, 5, 6, 7 };
            //numeros2 = numeros;
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.Write($"{numeros[i]}");
            //}
            //Console.WriteLine();
            //numeros2[1] = 99;
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.Write($"{numeros[i]}");
            //}
            //Console.WriteLine();
            //int[] numeros3 = new int [numeros.Length];
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //numeros3[i] = numeros[i];
            //numeros3[1] = 2;
            //    Console.Write($"{numeros[i]}");

            //string p1 = "Hola";
            //string p2 = " Que tal";

            //Console.WriteLine(String.Concat(p1,p2));


            //double[] notas = { 5.65, 7.85, 6.5, 9 };
            //Console.WriteLine($"Mis notas son: {String.Join(", ", notas)}");

            //string s1 = "A1aaa";
            //string s2 = "a";
            //Console.WriteLine(String.Compare(s1, s2));

            //string s = "Mi perro se llama Comeniños";
            //Console.WriteLine(s.IndexOf("perro"));
            //Console.WriteLine(s.IndexOf("gato"));

            //string s = "Mi perro se llama Comeniños";
            //Console.WriteLine(s.Contains("perro"));
            //Console.WriteLine(s.Contains("gato"));

            //string s = "Mi perro se llama Comeniños";
            //Console.WriteLine(s);
            //string s1 = s.Remove(3, 5);
            //Console.WriteLine(s1);
            //string s2 = s1.Insert(3, "koala");
            //Console.WriteLine(s2);

            //string s = "Mi perro se llama Comeniños";
            //string s1 = s.Replace("perro", "koala");
            //Console.WriteLine(s1); // Mi koala se llama Comeniños

            //string s = "pato,gato,perro,koala";
            //string[] animales = s.Split(",");
            //Console.WriteLine($"Hay {animales.Length} animales.{animales[0]}");
            //int[] n = { 1, 418, 6, 3, 1, 100 };
            //Console.WriteLine($"El numero maximo es: {Ejercicio1(n)}");

            string texto1 = "Prueba de texto para combrobación de buscar";
            string buscar = "de";

            Console.WriteLine(Ejercicio2(texto1,buscar));
            string caracter = "*";
            int repetir=3;
            string original = "Hay una mosca en mi sopa";
            Console.WriteLine(Ejercicio3(original,caracter,repetir));

        }
    }
}
