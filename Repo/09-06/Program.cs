using System;

namespace _09_06
{
    class Program
    {
        public static void Espacios()
        {
            Console.WriteLine("Escribre una frase");
            string palabra = Console.ReadLine();
            string palabraEspacio = "";
            for (int i = 0; i < palabra.Length; i++)
            {
                if (i < palabra.Length)
                {
                    palabraEspacio += palabra[i] + " ";
                }
                else
                {
                    palabraEspacio += palabra[i];
                }

            }




            //Opcion1
            //for (int i = 0; i < palabra.Length; i++)
            //{
            //        palabraEspacio += palabra[i] + " ";
            //    if (i < palabra.Length)
            //        palabraEspacio += palabra[i];
            //}
            //Console.WriteLine($"{palabraEspacio}");
            //Opcion2
            //for (int i = 0; i < palabra.Length; i++)
            //{
            //        palabraEspacio += palabra[i] + " ";
            //}
            //        palabraEspacio += palabra[i];
            //Console.WriteLine($"{palabraEspacio}");

        }

        public static void Cadenas()
        {
            Console.WriteLine("Escribe una frase");
            string cadena = Console.ReadLine();

            string mayuscula = cadena.ToUpper();
            string minuscula = cadena.ToLower();
            string borrar = cadena.Remove(1, 2);
            string insertar = cadena.Insert(2, "yo");
            string remplazar = cadena.Replace(" ", "_");
            string quitarEspaciosIzq = cadena.TrimStart();
            string quitarEspaciosDer = cadena.TrimEnd();
            string remplazarA = cadena.Replace("a", "A");
            string[] trocear = cadena.Split();

            for (int i = 0; i < trocear.Length; i++)
            {
                Console.Write(trocear[i]);
            }

            Console.WriteLine($"Mayusculas: {mayuscula}");
            Console.WriteLine($"Minusculas: {minuscula}");
            Console.WriteLine($"Borrar segunda y tercera letra: {borrar}");
            Console.WriteLine($"Insertar yo en la segunda y tercera linea: {insertar}");
            Console.WriteLine($"Remplazar espacios por _: {remplazar}");
            Console.WriteLine($"Quitar espacios a la izquierda: {quitarEspaciosIzq}");
            Console.WriteLine($"Quitar espacios a derecha: {quitarEspaciosDer}");
            Console.WriteLine($"Remplazar a minuscula por mayuscula: {remplazarA}");
            //Console.WriteLine($"Contains: {cadena.Contains("la")?$"{cadena} contiene");



        }

        public static string PonerTexto(string frase) 
        {
            int mayusculas = 0;
            for (int i=0;i<frase.Length;i++) 
            {
                if (frase[i]>='A' && frase[i]<='Z' || frase[i]== 'Ñ') 
                {
                    mayusculas++;
                }
            }
            if (mayusculas==frase.Length) 
            {
               frase = frase.ToLower();
               frase = frase.Substring(0, 1).ToUpper() + frase.Substring(1);
            }

            return frase;

        }

        public static void GestionArrays()
        {
            string opcion = "";
            string[] nombres = new string[10];
            bool Salir = false;
            do {

                Console.WriteLine("1. Rellenar Array");
                Console.WriteLine("2. Buscar un nombre concreto");
                Console.WriteLine("3. Buscar nombres que empiezen por: ");
                Console.WriteLine("4. Buscar un nombre que contenga un texto introducido");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Introduce un opción");
                opcion = Console.ReadLine();

                switch (opcion)
                {

                    case "1":
                        RellenarArray(nombres);
                        break;
                    case "2":
                        BuscarNombre(nombres);
                        break;
                    case "3":
                        BuscarPosteriores(nombres);
                        break;
                    case "4":
                        BuscarContenga(nombres);
                        break;
                    case "5":
                        Salir = true;
                        break;
                }
            }while (!Salir) ;

        }


        public static void RellenarArray(string[] nombres) 
        {
            for (int i=0;i<10;i++) 
            {
                Console.WriteLine($"Introduce nombre: {i+1}");
                nombres[i] = Console.ReadLine();
            }
            
        }

        public static void BuscarNombre(string[] nombres) 
        {
            string nombre = "";
            Console.WriteLine("Introduce un nombre a buscar");
            nombre = Console.ReadLine();

            for (int i=0;i<nombres.Length;i++) 
            {
                if (nombres[i] == nombre)
                {
                    Console.WriteLine($"{i+1}. {nombres[i]}");
                }
            }
        }




        public static void BuscarPosteriores(string[] nombres) 
        {

            Console.WriteLine("Introduce texto");
            string texto = Console.ReadLine();
            for (int i=0;i<nombres.Length;i++) 
            {
                if (String.Compare(nombres[i],texto)>0) 
                {
                    Console.WriteLine($"{i+1}. {nombres[i]}");
                }
            }
        }

        public static void BuscarContenga(string[] nombres)
        {

            Console.WriteLine("Introduce texto");
            string texto = Console.ReadLine();
            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i].Contains(texto))
                {
                    Console.WriteLine($"{i + 1}. {nombres[i]}");
                }
            }
        }


        public static void NombreApellido(string nombreApellido) 
        {
            Console.WriteLine("Introduzca Nombre y Apellido");
            nombreApellido = Console.ReadLine();
            nombreApellido = nombreApellido.Trim();
            string cadenaRemplazo = "";
            string[] trozos = nombreApellido.Split(' ');

            if (trozos.Length >= 3)
            {
                cadenaRemplazo = "Sr/Sra" + trozos[2] + "," + trozos[0] + " " + trozos[1];
            }
            else
            {
                //Console.WriteLine(String.Join(" ,", trozos));
                cadenaRemplazo = "Sr/Sra" + trozos[1] + "," + trozos[0];
                Console.WriteLine(cadenaRemplazo);
            }
        }

        static void Main(string[] args)
        {
            //Espacios();
            //Cadenas();
            //GestionArrays();
            Console.WriteLine(PonerTexto("HOLAQUETAL"));
            NombreApellido("");
        }
    }
}
