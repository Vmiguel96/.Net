using System;
using System.IO;

namespace _15_06
{
    class Program
    {
        public static void Escribir100FicherosAdicionales()
        {
            try
            {
                StreamWriter writer = new StreamWriter("textFile2.txt",true);
                for (int i = 100; i < 200; i++)
                {
                    writer.WriteLine($"Linea{i + 1}");
                }
                writer.Close();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Error en el fichero puntero nulo");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Error en el fichero");
            }
            catch (Exception)
            {
                Console.WriteLine("Excepción");
            }

        }

        public static void PedirFichero() 
        {
            try
            {

                string ruta = "";
                int contadorLinea = 0;
                Console.WriteLine("Introduce el nombre del fichero");
                ruta = Console.ReadLine();


                StreamReader archivo = new StreamReader(ruta);
                string[] lineasAll = File.ReadAllLines(ruta);
                foreach (string linea in lineasAll) 
                {
                    contadorLinea++;
                    if (linea !="")
                    {
                        if (linea[0] == 'a' || linea[0] == 'A')
                        {
                            Console.WriteLine($"Linea{contadorLinea}: {linea}");
                        }
                    }
                    
                }

                

                string line;
                int contador = 0;
                StreamReader miFichero = new StreamReader(ruta);
                while ((line = archivo.ReadLine()) !=null) 
                {
                    contador++;
                    if (line != "")
                    {
                        if (line[0] == 'a' || line[0] == 'A')
                        {
                            Console.WriteLine($"Linea {contador} {line}");
                        }
                    }
                }
                archivo.Close();

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Fichero no encontrado");
            }
            catch (IOException)
            {
                Console.WriteLine("Excepcion");
            }
        }

        public static void PedirNombre() 
        {
            try
            {
                string ruta = "";
                int contadorLinea = 0;
                Console.Write("Introduce el nombre del fichero");
                ruta = Console.ReadLine();

                if (File.Exists(ruta))
                {
                    string[] lineasAll = File.ReadAllLines(ruta);
                    Console.WriteLine($"Tiene {lineasAll.Length} lineas");

                    string line;
                    StreamReader archivo = new StreamReader(ruta);
                    while ((line = archivo.ReadLine()) != null)
                    {
                        contadorLinea++;
                    }
                    archivo.Close();

                    Console.WriteLine($"Tiene {contadorLinea} lineas");
                }
                else 
                {
                    Console.WriteLine("No existe el fichero");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Fichero no encontrado");
            }
            catch (IOException)
            {
                Console.WriteLine("Excepcion");
            }
        }

        public static void PedirFrases() 
        {
            string frase="";
            do {
                StreamWriter writer = new StreamWriter("text.txt",true);
                writer.WriteLine(frase);
                writer.Close();
                Console.Write("Introduce una frase: ");
                frase = Console.ReadLine();


            } while (!(frase==""));
        }

        public static void ContarPalabras()
        {
            try
            {
                int palabras=0;
                string ruta = "";
                Console.Write("Introduce el nombre del fichero");
                ruta = Console.ReadLine();

                StreamReader archivo = new StreamReader(ruta);
                string lineas = File.ReadAllText(ruta);
                palabras = lineas.Split().Length;

                Console.WriteLine(palabras);
            }
            catch (Exception)
            {
                Console.WriteLine("Excepcion");
            }
            }

        public static void Ejercicio5() 
        {

                bool acierto = false;
                string palabra = "";
                int intentos = 1;

            try
            {
                string ruta = Path.Join("archivos", "palabras.txt");
                string[] lineas = File.ReadAllLines(ruta);
                int selecionado = new Random().Next(0, lineas.Length - 1);
                string palabraSeleccionada = lineas[selecionado];

                while (!acierto && intentos <= 3)
                {
                    Console.WriteLine($"Introduce palabra a adivinar - intentos:{4 - intentos}");
                    palabra = Console.ReadLine();

                    if (palabra == palabraSeleccionada)
                    {
                        Console.WriteLine("Felicidades has acertado la palabra");
                        acierto = true;
                    }
                    else
                    {

                        intentos++;
                    }
                }
                if (!acierto)
                {
                    Console.WriteLine($"La palabra secreta era {palabraSeleccionada}");
                }
            }
            catch (FileNotFoundException)
            {

            }
            catch (Exception e)
            {

            }
        }

        public static void Ahorcado() 
        {
            bool acierto = false;
            char letra;
            int intentos = 1;
            string asteriscos="";

            try
            {
                string ruta = Path.Join("archivos", "palabras.txt");
                string[] lineas = File.ReadAllLines(ruta);
                int selecionado = new Random().Next(0, lineas.Length - 1);
                string palabraSeleccionada = lineas[selecionado];

                for (int i=0; i<palabraSeleccionada.Length;i++) 
                {
                    asteriscos = String.Concat(asteriscos,"*");
                }
                //Console.WriteLine(String.Join("",palabraSeleccionada));
                //Console.WriteLine(String.Join("", asteriscos));
                while (!acierto && intentos <= 7)
                {
                    Console.WriteLine("\n" + String.Join("", asteriscos));
                    int posicionLetra = -1;
                    //Console.WriteLine($"{asteriscos}");
                    Console.Write($"Dime una Letra: -intentos {8-intentos} ");
                    letra = Console.ReadKey().KeyChar;

                    if (palabraSeleccionada.Contains(letra))
                    {
                        for (int i=0;i<palabraSeleccionada.Length;i++) 
                        {
                            posicionLetra = palabraSeleccionada.IndexOf(letra, i, palabraSeleccionada.Length-i);
                            if (posicionLetra != -1)
                            {
                                asteriscos = asteriscos.Remove(posicionLetra, 1);
                                asteriscos = asteriscos.Insert(posicionLetra, letra.ToString());
                                i = posicionLetra;
                                
                            }
                            else 
                            {
                                break;
                            }

                        }
                    }
                    else 
                    {
                        intentos++;
                    }
                    if (palabraSeleccionada == asteriscos)
                    {
                        acierto = true;
                        Console.WriteLine("Felicidades has ganado");
                    }
                    

                }

                if (!acierto)
                {
                    Console.WriteLine($"La palabra secreta era {palabraSeleccionada}");
                }
            }
            catch (FileNotFoundException)
            {

            }
            catch (Exception e)
            {

            }
        }

        public static void Ejercicio8() 
        {
            string ruta = "";
            string texto = "";
            Console.Write("Introduce el nombre del fichero");
            ruta = Console.ReadLine();
            try
            {
                
               texto = File.ReadAllText(ruta);

            }
            catch (FileNotFoundException e) 
            {
                Console.WriteLine($"No se encuentra elñ archivo {ruta}\n"+e.Message);
            }
        }

        public static void Ejercicio9()
        {
            string ruta = "";
            Console.Write("Introduce el nombre del fichero");
            ruta = Console.ReadLine();
            string[] filas;
            try
            {

                filas = File.ReadAllLines(ruta);
                for(int i = filas.Length-1;i>=0;i--)
                {
                    Console.WriteLine(filas[i]);
                }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"No se encuentra elñ archivo {ruta}\n" + e.Message);
            }
        }

        public static void Ejercicio10() 
        {
            string ruta = Path.Join("archivos", "palabras.txt"); ;
            string linea = "";
            int contador = 0;
            Console.Write("Introduce el nombre del fichero: ");
            ruta = Console.ReadLine();
            StreamReader lector;
            try
            {

                lector = new StreamReader(ruta);
                while ((linea = lector.ReadLine()) !=null) 
                {
                    contador++;
                    if (linea.Length > 79)
                    {
                        linea = linea.Substring(0, 79);

                    }
                    Console.WriteLine(linea);
                    if (contador>0 && contador % 24 == 0) 
                    {
                        Console.WriteLine();
                        Console.WriteLine("............Pulse Enter para continuar.............");
                        Console.ReadLine();
                    }
                }
                

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"No se encuentra elñ archivo {ruta}\n" + e.Message);
            }
        }

        static void Main(string[] args)
        {
            //Escribir100FicherosAdicionales();
            //PedirFichero();
            //PedirNombre();
            //PedirFrases();
            //ContarPalabras();
            //Ejercicio5();
            //Ahorcado();
            //Ejercicio8();
            Ejercicio9();
            //Ejercicio10();

        }
    }
}
