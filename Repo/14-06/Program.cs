using System;
using System.IO;

namespace _14_06
{
    class Program
    {
        public static void CrearFichero() 
        {
            try
            {
                string[] lineas = { "Hola", "Adiós" };
                StreamWriter writer = new StreamWriter("textFile.txt");
                foreach (string line in lineas)
                {
                    writer.WriteLine(line);
                }
                writer.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Excepción");
            }
        }

        public static void EscribirFichero() 
        {
            try
            {
                StreamWriter writer = new StreamWriter("textFile.txt");
                writer.WriteLine("Hola");
                writer.WriteLine("Adios");
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en el fichero");
            }
        }

        public static void Escribir100Ficheros() 
        {
            try
            {
                StreamWriter writer = new StreamWriter("textFile2.txt");
                for (int i = 0; i < 100; i++)
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

        public static bool EsPrimo(int numero) 
        {
            bool esPrimo = true;
            for (int i=2;i<numero && esPrimo;i++) 
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                }
            }
            return esPrimo;
        }

        public static void Primos50() 
        {
            try
            {
                int contadorPrimo = 0;

                StreamWriter writer = new StreamWriter("numerosPrimos.txt");
                for (int i = 1; contadorPrimo < 50; i++)
                {
                    if (EsPrimo(i))
                    {
                        contadorPrimo++;
                        writer.Write(i + " ");
                    }
                }
                //int numero = 1;
                //while (contadorPrimo<50) 
                //{
                //    if (EsPrimo(numero)) 
                //    {
                //        contadorPrimo++;
                //        writer.Write(numero + " ");
                //    }
                //    numero++;
                //}
                writer.Close();
            }
            catch (Exception)
            {

            }
        }

        public static void Ejercicio3() 
        {
            try
            {
                double media = 0;
                string perNotaAlta = "";
                string perNotaBaja = "";
                double notaBaja = 10;
                double notaAlta = 0;

                string ruta = Path.Join("archivos", "alumnos.txt");
                StreamReader archivo = new StreamReader(ruta);

                string[] lineas = File.ReadAllLines(ruta);
                foreach (string linea in lineas) 
                {
                  string[] trozos = linea.Split(";");
                    double nota = Convert.ToDouble(trozos[1]);
                    media += nota;
                    string nombre = trozos[0];
                    if (nota>notaAlta) 
                    {
                        notaAlta = nota;
                        perNotaAlta = nombre;
                    }
                    if (nota < notaBaja) 
                    {
                        notaBaja = nota;
                        perNotaBaja = nombre;
                    }

                }
                media = media / lineas.Length;
                Console.WriteLine($"La Nota media es: {media}");
                Console.WriteLine($"La nota más baja es: {notaBaja} de {perNotaBaja}");
                Console.WriteLine($"La nota más alta es: {notaAlta} de {perNotaAlta}");



                archivo.Close();
            }
            catch (PathTooLongException exp)
            {
                Console.WriteLine("La ruta del archivo es demasiado larga:" + exp.Message);
            }
            catch (FieldAccessException exp)
            {
                Console.WriteLine("No se encuentra el archivo:" + exp.Message);
            }
            catch (Exception exp) 
            {
                Console.WriteLine("Error desconocido:" + exp.Message);
            }
        }

        public static void Menu() 
        {
            bool salir = false;
            string opcion = "";
            Console.WriteLine("MENU");
            while (!salir)
            {
                try {
                    
                    Console.WriteLine("\t1) Mostrar productos");
                    Console.WriteLine("\t2) Añadir producto");
                    Console.WriteLine("\t0) Salir");
                    Console.WriteLine("\t Elija una opción");
                    opcion = Console.ReadLine();
                    switch (opcion)
                    {
                        case "1":
                            MostrarProductos();
                            break;
                        case "2":
                            AñadirProductos();
                            break;
                        case "0":
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Opción no reconocida");
                            break;
                    }
                }
                catch (Exception e) 
                {
                    opcion = "";
                }

                }
        }

        public static void MostrarProductos()
        {
            try
            {
                Console.WriteLine("        MOSTRAR PRODUCTOS");
                Console.WriteLine("-------------------------------");
                string ruta = Path.Join("archivos", "productos.txt");
                string[] lineas = File.ReadAllLines(ruta);

                foreach (string linea in lineas)
                {
                    string[] trozos = linea.Split(";");
                    string producto = trozos[0];
                    double precio = Convert.ToDouble(trozos[1]);
                    Console.WriteLine($"{producto,-20} {precio,10:F2}");
                }
            }
            catch (Exception exc) 
            {
                Console.WriteLine("Error desconocido"+ exc.Message);
            }
        }
        public static void AñadirProductos() 
        {
            string ruta = Path.Join("archivos", "productos.txt");
            string nombre = "";
            double precio = 0;
            Console.WriteLine("        AÑADIR PRODUCTOS");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Introduzca el nombre del producto");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduzca el precio del producto");
            if (!(Double.TryParse(Console.ReadLine(), out precio)))
            {
                Console.WriteLine("El precio introducido no es correcto.");
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(ruta, true))
                {
                    writer.WriteLine(nombre+";"+precio);
                }
            }
            
        }
        public static void Ejercicio4() 
        {
            Menu();
        }
        static void Main(string[] args)
        {
            //CrearFichero();
            //Escribir100Ficheros();
            //Primos50();
            //Ejercicio3();
            Ejercicio4();
        }
    }
}
