using System;

namespace _03_06
{
    class Program
    {
        public static bool EsPalindromo(int n1)
        {
            bool resultado;


            string numeroAuxiliar = "";
            int numeroAuxiliarEntero = 0;
            int numeroOriginal = n1;

            //string numeroEnCadena = Convert.ToString(n1);
            //string numeroCadenaAlReves = "";
            //for (int i= numeroEnCadena.Length;i>=0;i--) 
            //{
            //    numeroCadenaAlReves = numeroCadenaAlReves + numeroEnCadena[i];
            //}

            while (n1 > 0)
            {
                numeroAuxiliar = numeroAuxiliar + Convert.ToString(n1 % 10);
                n1 /= 10;
            }
            numeroAuxiliarEntero = Convert.ToInt32(numeroAuxiliar);


            if (numeroAuxiliarEntero == numeroOriginal)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            return resultado;
        }

        public static bool EsPrimo(int numero)
        {
            bool resultado = true;
            for (int i = 2; i <= numero - 1 && resultado; i++)
            {
                if (numero % i == 0)
                {
                    resultado = false;
                }
            }




            return resultado;
        }

        public static bool EsPrimoPalindromo(int numero)
        {
            //return (EsPrimo(numero)&&EsPalindromo(numero));
            bool resultado = true;

            if (EsPrimo(numero) == false || EsPalindromo(numero) == false)
            {
                resultado = false;
            }



            return resultado;
        }

        public static string QuitaEspacio(string cadena)
        {
            string resultado="";

            for (int i=0;i<cadena.Length;i++) 
            {
                if (cadena[i] != ' ')
                    /*(cadena[i]>='a' && cadena[i]<='z' || cadena[i]>='A' && cadena[i]<='Z')*/
                {
                    resultado += cadena[i];
                }
            }

            return resultado;
        }

        public static bool EsAlfabetico(char c) 
        {
            return c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z';
        }

        public static bool EsAlfabetico(string cadena)
        {
            bool resultado= true;

            for (int i = 0; i < cadena.Length && resultado; i++)
            {
                if (!EsAlfabetico(cadena[i]))
                {
                    resultado = false;
                }

            }
            return resultado;
        }

        public static void Ejercicio1() 
        {

            for (int i=0;i<20;i++) 
            {
                Console.Write("*");
            }
        }
        //PRO
        //Pueda pintar cualquier caracter.
        //Pueda pintar cualquier numero de veces
        //Devuelva una cadena (string) que no haga Console.Write.

        public static string Ejercio1Pro(char caracter ,int numero) 
        {
            string salida= "";

            for (int i = 0; i < numero; i++) 
            {
                salida += caracter;
            }

            return salida;
        }

        public static void Ejercicio2(string cadena, int min, int max) 
        {
            if (cadena.Length >= min && cadena.Length <= max)
            {
                Console.WriteLine($"{cadena} Tiene la Longitud permitida ");
            }
            else 
            {
                Console.WriteLine($"Error!!! No tiene la Longitud permitida");
            }   
        }
        public static void Ejercicio3(int min=0, int max=20) 
        {
            for (int i= min; i<=max;i++) 
            {
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        public static void Ejercicio4(char caracter, int numero) 
        {
            for (int i = 0; i < numero; i++) 
            {
                for (int j=0; j<numero;j++) 
                {
                    if (i == 0 || i == numero - 1)
                    {
                        Console.Write($"{caracter}");
                    }
                    else {
                        if (j==0 ||j == numero-1) 
                        {
                            Console.Write($"{caracter}");
                        }
                    else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine("");
            }
        }

        public static void Ejercicio5(string nombre, params string[]trabajos) 
        {
            if (trabajos.Length == 0)
            {
                Console.WriteLine($"{nombre} no ha trabajado nunca");
            }
            else 
            {
                Console.Write($"{nombre} es ");
                for (int i=0;i<trabajos.Length;i++) 
                {
                    Console.Write($"{trabajos[i]}, ");
                }
            }
        }

        public static bool Ejercicio6(int numero)
        {
            if (numero==1)
            {
                return true;
            }
            else
            {
                for (int i = 2; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        return  false;

                    }
                }
            }
            return true;

        }

        public static double Ejercicio7(int [] numeros) 
        {

            double media = 0; 
            for (int i=0;i<numeros.Length;i++) 
            {
                media += numeros[i]; 
            }
            return (media / numeros.Length);
        }

        public static string Ejercicio8(string[] cadenas) 
        {
            int azar = new Random().Next(0, cadenas.Length-1);
            return (cadenas[azar]);

        }

            static void Main(string[] args)
        {
            //Console.WriteLine(EsPalindromo(696)?"Si es palíndromo":"No es palíndromo");
            //Console.WriteLine(EsPrimo(5)?"El numero es primo":"El numero no es primo");
            //Console.WriteLine(EsPrimoPalindromo(313) ? "El numero es primo y Palindromo" : "El numero no es primo y palindromo");
            //Console.WriteLine(QuitaEspacio("Cadena Vacia y Prueba de Cadenas 210"));
            //Console.WriteLine(EsAlfabetico("Hola esto es una prueba de cadenas")?"Es una cadena":"No es una cadena" );
            //Ejercicio1();
            //Console.WriteLine();
            //Ejercicio1();
            //Console.WriteLine();
            //Ejercicio1();
            //Console.WriteLine();
            //Console.WriteLine(Ejercio1Pro('+',15));
            //Console.WriteLine(Ejercio1Pro('/', 5));
            //Console.WriteLine(Ejercio1Pro('D', 10));
            //Ejercicio2("Perro",3,6);
            //Ejercicio2("Buenas Tardes",4,6);
            //Ejercicio3(3,16);
            //Ejercicio3(min:3);
            //Ejercicio3(max:10);
            //Ejercicio3();
            //Ejercicio4('X',5);
            //Ejercicio5("Jose","Conserje","Carpintero","Chapista");
            //Ejercicio5("Luis");
            int numero = 7;
            Console.WriteLine(Ejercicio6(numero)?$"Es el numero {numero} es Primo": $"El numero {numero} No es Primo");

            int[] notas = { 4, 6, 7, 2, 4 };
            double media = Ejercicio7(notas);
            Console.WriteLine($"La media de las notas es: {media}");

            string[] palabrasSecretas = { "melon", "sandia", "pera", "melocoton" };

            //Console.WriteLine($"La palabra secreta es {Ejercicio8(palabrasSecretas)}");
            string palabraSeleccionada = Ejercicio8(palabrasSecretas);
            string palabraUsuario = "";
            int intentos = 0;
            bool acertar = false;
            do
            {
                Console.WriteLine($"Las posibles palbras son: {String.Join(",",palabrasSecretas)}");
                Console.WriteLine("Introduce la palabra Secreta");
                palabraSeleccionada = Console.ReadLine();
                if (String.Compare(palabraUsuario, palabraSeleccionada) == 0)
                {
                    break;
                    acertar = true;
                }
                else
                {
                    intentos++;
                }
                //if (intentos<=3) 
                //{
                //    break;
                //}
            } while (!acertar || intentos<=3);
            if (!acertar )
            {
                Console.WriteLine($"Has perdido, la palabra secreta es: {palabraSeleccionada}");
            }
            else 
            {
                Console.WriteLine("Enhorabuena, has ganado el juego de la palabra secreta ");
            }
        }
    }
}
