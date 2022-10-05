using System;
using System.IO;

namespace _11_06
{
    class Program
    {
        public static void Ejercicio1() //Leer ficheros
        {
            int suma = 0;
            string linea;
            int contarLineas = 0;


            //Opcion 1
            StreamReader lector = new StreamReader("numeros.txt"); //Declaramos variables tipo StreamReaader
            while ((linea = lector.ReadLine()) != null) //Recorremos el array hasta encontrar null
            {
                contarLineas++;
            }

            lector.Close();

            int[] numeros = new int[contarLineas];
            contarLineas = 0;

            lector = new StreamReader("numeros.txt");

            while ((linea = lector.ReadLine()) != null) //Recorremos el array hasta encontrar null
            {
                suma += Convert.ToInt32(linea);
                numeros[contarLineas] = Convert.ToInt32(linea);
                contarLineas++;
            }

            
            Console.WriteLine($"{String.Join("+",numeros)}={suma}");

            lector.Close();//SIEMPRE HE DE CERRAR
            //Opcion 2
            suma = 0;
            string[] lineas = File.ReadAllLines("numeros.txt");
            foreach (string l in lineas) 
            {
                suma += Convert.ToInt32(l);
            }
            Console.WriteLine($"{String.Join("+", numeros)}={suma}");
        }

        public static void Ejercicio2() 
        {
            string texto = "";
            StreamWriter writer = new StreamWriter("Ejercicio2.txt");

            while (texto !="FIN") {

                Console.WriteLine("Escribe las lineas hasta que escribas (fin)");
                texto = Console.ReadLine();
                writer.WriteLine(texto);
                
                
            }
            writer.Close();

            
        }

        public static void Ejercicio26() 
        {
            string pelicula="";
            Console.WriteLine("Introduce una lista de peliculas separadas por un -");
            pelicula = Console.ReadLine();
            string[] peliculas = pelicula.Split("-");
            
        }

        public static bool ComprobarCaractertes(char c)
        {
            bool correcto= true;
            string especiales = "!#$%&'*+-/=?^_`{|}~;";
            
                if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
                {
                    if (!(c >= '0' && c <= '9'))
                    {
                        if (!(especiales.IndexOf(c)>=0))
                        {
                            correcto=false;
                         }
                    }
                }
                





            
            return correcto;
        }



        //public static bool ComprobarEmail(string cadena) 
        //{
        //    bool correcto true;
        //    for (int i=0;i<cadena.Length;i++)
        //    {
        //        if () 
        //        {

        //        }
        //    }
        //}

        static void Main(string[] args)
        {
            string cadena="sdsa@df.";
            bool corecto = true;
            for (int i=0;i<cadena.Length;i++) 
            {
                if (!(cadena[i]=='@') && !(cadena[i]=='.')) 
                {
                    if (!ComprobarCaractertes(cadena[i])) 
                    {
                        corecto = false;
                    }
                }
            }
            if (cadena[0]=='.' || cadena[cadena.Length-1]=='@') 
            {
                corecto = false;
            }
            if (cadena.IndexOf('@') >= 0)
            {
                if (!(cadena.IndexOf('@') == cadena.LastIndexOf('@')))
                {
                    corecto = false;
                }
            }
            else 
            {
                corecto = false;
            }
            if (cadena.IndexOf('.') >= 0)
            {
                if (!(cadena.IndexOf('.') == cadena.LastIndexOf('.')))
                {
                    corecto = false;
                }
            }
            else 
            {
                corecto = false;
            }

            Console.WriteLine(corecto? "Email  valido": "Email no valido");
            //string temporal = "";
            //string cadena = "";
            //string[] palabras;
            //Console.WriteLine("Introduce una lista de peliculas separadas por un -");
            //cadena = Console.ReadLine();
            //string[] peliculas = cadena.Split('-');

            //for (int i=0;i<peliculas.Length;i++) 
            //{
            //    palabras = peliculas[i].Split();
            //    if (palabras[0].ToUpper() == "LA" || palabras[0].ToUpper() == "EL" || palabras[0].ToUpper() == "LOS" || palabras[0].ToUpper() == "LAS")
            //    {
                    
            //        for (int j=1;j<palabras.Length;j++) 
            //        {
            //            temporal += palabras[j]+" ";
                            
            //        }

            //        temporal = temporal.TrimEnd();
            //        temporal += ", " + palabras[0];
            //        peliculas[i] = temporal;
            //    }
            //    peliculas[i]=peliculas[i].ToUpper();

            //}

            //Array.Sort(peliculas);

            //for (int i=0;i<peliculas.Length;i++) 
            //{
            //    Console.WriteLine($"{i+1}. {peliculas[i]}");
            //}


            //int contador = 0;
            //string line; System.IO.StreamReader file = new System.IO.StreamReader("prueba.txt"); //Declaramos variables tipo StreamReaader
            //while ((line = file.ReadLine()) != null) //Recorremos el array hasta encontrar null
            //{
            //    System.Console.WriteLine(line);
            //    contador++;
            //}
            //file.Close();//SIEMPRE HE DE CERRAR
            //Console.WriteLine(contador);
            //Console.WriteLine("");
            //string texto = File.ReadAllText("prueba.txt");
            //Console.WriteLine(texto);


            //string[] l2 = texto.Split("\n");
            //Console.WriteLine(l2.Length);

            //foreach (string l in l2)
            //{
            //    Console.WriteLine(l);
            //}
            //Ejercicio1();
            //Ejercicio2();

        }
    }
}
