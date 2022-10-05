using System;
using System.Threading;

namespace _08_06
{
    class Program
    {
        public static bool Salir(string palabra, string palabra2)
        {
            bool resultado;
            if ((palabra == "me rindo") || (palabra2=="me rindo") ) 
            {
                resultado = true;
            }
            else 
            {
                resultado = false;
            }
            return resultado;
            //return palabra == "me rindo";
        }

        public static void PalabrasEncadenadas() 
        {
            string palabra = "";
            string palabra2 = "";

            Console.Write("Introduzca palabra inicial jugador 1: ");
            palabra = Console.ReadLine();


            while (!Salir(palabra,palabra2) ) 
            {
                Console.Write("Introduzca palabra jugador 2: ");
                palabra = Console.ReadLine();
                if (EsCorrecto(palabra, palabra2))
                {
                    Console.WriteLine("Es Correcto");
                }
                else
                {
                    Console.WriteLine("Es Incorrecto");
                }
                Console.Write("Introduzca palabra jugador 1: ");
                palabra2 = Console.ReadLine();
                if (EsCorrecto(palabra2, palabra))
                {
                    Console.WriteLine("Es Correcto");
                }
                else
                {
                    Console.WriteLine("Es Incorrecto");
                }

            }

        }

        public static bool EsCorrecto(string palabra, string palabra2)
        {

            palabra=palabra.ToLower();
            palabra2=palabra2.ToLower();

            //if (String.Compare(Convert.ToString(palabra[palabra.Length - 1]), Convert.ToString(palabra2[0])) == 0)
            //{
            //    resultado = true;
            //}
            //else 
            //{
            //    resultado = false;
            //}

            
            return palabra[palabra.Length-1]==palabra[0];
        }
        public static void MaxMin(int[] ejemplo,ref int max, ref int min) 
        {
            Array.Sort(ejemplo);
            max = ejemplo[ejemplo.Length - 1];
            min = ejemplo[0];
        }

        public static void EscribeTexto(string cadena) 
        {
            cadena = cadena.ToLower();
            string aux = "";
            for (int i=0;i<cadena.Length;i++) 
            {
                if (Char.IsLetterOrDigit(cadena[i]))
                {

                }
                else 
                {
                    aux = cadena[i+1].ToString();
                    cadena = cadena.Remove(i+1,1);

                    cadena = cadena.Insert(i+1,aux.ToUpper());
                    cadena = cadena.Remove(i, 1);
                    i--;
                    //Console.WriteLine($"{aux}-{i}-{cadena}");
                    
                }
               
            }
            Console.WriteLine($"La cadena final:{cadena}");

        }

        public static bool NumeroHashad(int numero) 
        {
            string numeroLetra = numero.ToString();
            int suma = 0;
            for (int i=0;i<numeroLetra.Length;i++) 
            {
                suma += Convert.ToInt32(numeroLetra[i]);
            }
            if (numero % suma == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ContarParesImpares(int numero, out int pares, out int impares) 
        {
            pares = 0;
            impares = 0;

            string numeroLetra = numero.ToString();

            for (int i = 0; i < numeroLetra.Length; i++)
            {
                if (Convert.ToInt32(numeroLetra[i]) % 2 == 0)
                {
                    pares++;
                }
                else 
                {
                    impares++;
                }
            }
        }

        public static void Reloj() 
        {
            while (true) 
            {
                Console.Clear();
                Console.Write($"{DateTime.Now.Hour}/");
                Console.Write($"{DateTime.Now.Minute}/");
                Console.Write($"{DateTime.Now.Second}/");
                Console.Write(DateTime.Now.Millisecond);
                Thread.Sleep(1000);
            }
        }

        public static void DiaCumple() 
        {
            string fecha = "";
            string[] dias = { "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" };
            Console.WriteLine("Introduce la fecha de tu cumpleaños DD/MM/AAAA");
            fecha = Console.ReadLine();
            DateTime parsedDate = new DateTime();

            if (DateTime.TryParse(fecha, out parsedDate))
            {
                //Metodo1
                string diaHoy = dias[(int)parsedDate.DayOfWeek];
                Console.WriteLine($"Naciste el {fecha} un {diaHoy}");
                //Metodo 2 Sin DayOfWeek
                int posicion = 0;
                string fechaLarga = parsedDate.ToLongDateString();
                posicion = fechaLarga.IndexOf(',');
                string diaSemana = fechaLarga.Substring(0,posicion);
                Console.WriteLine(diaSemana);
                //Metodo 2 Super Pro
                DateTime fechaModificada = new DateTime(DateTime.Now.Year,parsedDate.Month,parsedDate.Day);
                if(DateTime.Now > fechaModificada)
                    fechaModificada = new DateTime(DateTime.Now.Year, parsedDate.Month, parsedDate.Day);
                Console.WriteLine($"Naciste el {fecha} un {fechaLarga.Substring(0,parsedDate.ToLongDateString().IndexOf(','))} ");
                var horas = (DateTime.Now - fechaModificada).ToString(@"dd\d\ hh\h\ mm\m\ ");
                Console.WriteLine($"{horas}");
            }
            else 
            {
                Console.WriteLine($"Error al convertir fecha: {fecha}");
            }


        }




        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("es-ES");
            int max=0, min=0;
            int[] ejemplo = {20,10,5,2 };
            MaxMin(ejemplo, ref max, ref min);
            Console.WriteLine($"El maximo es: {max} y el minimo es {min}");
            EscribeTexto("hola.que tal,,estAs");
            if (NumeroHashad(152))
            {
                Console.WriteLine("Si es un numero Harshad 152");
            }
            else 
            {
                Console.WriteLine("No es un numero Harshad");
            }



            int a =123456;
            int b = 0;
            int c = 0;
            ContarParesImpares(a, out b, out c);
            Console.WriteLine($"{a} {b} {c}");
            //Reloj();
            DiaCumple();
            

            //bool salir = false;
            //string menu = "";
            //Console.WriteLine("Bienvenido al Juego");
            //do 
            //{
            //    Console.WriteLine("1.- Palabras Encadenadas");
            //    Console.WriteLine("2.- Adivina el numero");
            //    Console.WriteLine("3.- Salir del Programa");

            //    menu = Console.ReadLine();

            //    switch (menu) 
            //    {
            //        case "1":
            //            PalabrasEncadenadas();
            //            break;
            //        case "2":

            //            break;
            //        case "3":
            //            salir = true;
            //            break;
            //    }
                
            //}while (!salir) ;
        }
    }
}
