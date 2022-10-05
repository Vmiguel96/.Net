using System;

namespace _28_05
{
    class Program
    {
        public static void Ejercicios5()
        {
            int numeroUsuarios = 0;
            Console.WriteLine("Numero de alumnos a introducir");
            numeroUsuarios = Convert.ToInt32(Console.ReadLine());
            string[] nombres = new string[numeroUsuarios];
            double[] notas = new double[numeroUsuarios];
            string buscar = "";
            bool encontrado = false;


            for (int i = 0; i < numeroUsuarios; i++)
            {
                Console.WriteLine($"Introduce el nombre del alumno {i + 1}");
                nombres[i] = Console.ReadLine();

                Console.WriteLine($"Introduce la nota{i + 1}");
                notas[i] = Convert.ToDouble(Console.ReadLine());

            }

            //Pedimos un nombre y mostramos su nota
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Introduce el nombre de un alumno que quieras buscar");
            buscar = Console.ReadLine();

            int posicionEncontrada = 0;
            for (int i = 0; i < numeroUsuarios && !encontrado; i++)
            {
                if (buscar == nombres[i]) {
                    encontrado = true;
                    posicionEncontrada = i;
                }
            }
            Console.WriteLine($"El alumnos {nombres[posicionEncontrada]} tiene una nota de  {notas[posicionEncontrada]}");
            Console.WriteLine("-----------------------------------------------------");
            //Mostramos todos los nombres y notas.
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Alumno {nombres[i]} y Nota {notas[i]}");
            }
        }


        public static void Ejercicios6()
        {
            int[] numeros = new int[10];
            int valor = 0;
            Console.WriteLine("Introduce un numero");
            valor = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < numeros.Length; i++)
            {
                numeros[i - 1] = i * valor;
            }

            for (int j = 0; j < numeros.Length; j++)
            {
                Console.WriteLine($"{valor} x {j + 1} = {numeros[j]}");
            }
        }

        public static void Ejercicio7()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] numeros2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] numeros3 = new int[10];
            
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros3[i] = numeros[i] + numeros2[i];
            }
            for (int j = 0; j < numeros.Length; j++)
            {
                Console.WriteLine($"La suma {numeros3[j]} = {numeros[j]} + {numeros2[j]}");
            }
        }
        public static void Ejercicio8()
        {
            char[] password = new char[8];
            char[] reverse = new char[8];
            string cadenaVacia = "";

            Console.WriteLine("Escribe tu contraseña de 8 caracteres");
            for (int i=0;i<password.Length;i++) 
            {
                password[i] = Console.ReadKey(true).KeyChar;
            }

            for (int i=password.Length-1; i >=0;i--)
            {
                reverse[(password.Length-1)-i] = password[i];
            }
            Console.WriteLine("La contraseña es:");
            for (int i=0; i<reverse.Length;i++)
            {
                Console.Write($"{reverse[i]}");
            }

            //Solucion Pro

            for (int i = password.Length-1;i>=0;i--) 
            {
                cadenaVacia = cadenaVacia + password[i];
            }
            Console.WriteLine($"El password invertido es {cadenaVacia}");
        }

        public static void juegoAhorcado()
        {
            string[] solucion = {"programa","vector","ordenar","pantalla","raton","monitor","bicicleta","Calendario" };
            int adivina = 0;
            string palabraSecreta = "";
            string palabraArterisco = "";
            string letra = "";
            string palabraSustitucion = "";
            string resolver = "N";
            string palabraResolver ="";
            bool ganar = false;
            int intentosFallidos = 0;
            bool IntentoAcertado = false;


            adivina = new Random().Next() % solucion.Length;
            palabraSecreta = solucion[adivina];

            for (int i = 0; i< palabraSecreta.Length;i++)
            {
                palabraArterisco = palabraArterisco + "*";
            }
            //    Console.WriteLine($"{palabraSecreta} - {palabraArterisco}");
            // Comienza el juego
            do
            {
                
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("-         JUEGO DEL AHORCADO          -");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"La palabra a adivinar es {palabraArterisco}");
                Console.Write("Introduce una Letra: ");
                letra = Console.ReadLine();
                IntentoAcertado = false;
                //Buscar la letra en la palabra secreta
                for (int i =0; i<palabraSecreta.Length;i++)
                {
                    if (palabraSecreta[i] == letra[0] ) 
                    {

                        //palabraArterisco[i] = letra[0];
                        //Realizar sustitucion de asterisco por letra
                        for (int j =0; j<palabraSecreta.Length;j++) 
                        {
                            if (i == j)
                            {
                                palabraSustitucion = palabraSustitucion + letra[0];
                            }
                            else
                            {
                                palabraSustitucion = palabraSustitucion + palabraArterisco[j];
                            }
                            
                        }
                        palabraArterisco = palabraSustitucion;
                        palabraSustitucion = "";
                    }
                }

                if (IntentoAcertado == false)
                {
                    intentosFallidos++;
                    Console.WriteLine($"La letra {letra} no esta en la palabra   Intentos Fallidos. {intentosFallidos}/7");
                }
                //Pedir la Solucion
                Console.WriteLine("Quieres resolver S|N ");
                resolver = Console.ReadLine();

                if (resolver =="S" || resolver =="s")
                {
                    Console.WriteLine("Cual es la respuesta?");
                    palabraResolver = Console.ReadLine();
                    if (palabraResolver == palabraSecreta)
                    {
                        Console.WriteLine("Felicidades a adivinado la palabra secreta");
                        ganar = true;
                    }
                }
                if (intentosFallidos > 7)
                {
                    Console.WriteLine($"Has perdido el juego  La palabra secreta era: {palabraSecreta}");
                }
                Console.Clear();

            } while (!ganar || intentosFallidos < 7);


        }
        



        static void Main(string[] args)
        {
            //Recorrer una cadena como si fuera un array de caracteres
            //string texto = "EMOS SIO ENGAÑADOS";

            //for (int i = 0; i < texto.Length;i++)
            //{

            //}

            //Ejercicios5();
            //Ejercicios6();
            //Ejercicio7();
            //Ejercicio8();
            juegoAhorcado();
        }
    }
}
