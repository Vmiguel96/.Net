using System;

namespace _26_05
{
    class Program
    {
        static void Main(string[] args)
        {

            //Juego Suma Numero randow

            //int numero, resultado = 0,numerUsuario;
            //string nombre,seguir="S";

            //int contador = 0;
            //Random r = new Random();
            //Console.Write("Nombre: ");
            //nombre = Console.ReadLine();



            //while (seguir == "S")
            //{
            //    contador = 0;
            //    resultado = 0;
            //    do
            //    {
            //        numero = r.Next(1, 51);
            //        Console.WriteLine($"Numero: {numero}");
            //        numerUsuario = Convert.ToInt32(Console.ReadLine());
            //        resultado += numero;
            //        if (numerUsuario == resultado)
            //        {
            //            contador++;
            //        }
            //    } while (numerUsuario == resultado);
            //    Console.WriteLine($"{nombre} acertaste {contador - 1} veces");
            //    Console.WriteLine($"Quieres volver a jugar {nombre} (S/N)");
            //    seguir = Console.ReadLine();
            //}

            // Menu Repetitivo

            //double numero1, numero2;
            //string opcion;

            //do
            //{

            //Console.Write("\nEscribe un numero: ");
            //numero1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("\nEscribe un numero: ");
            //numero2 = Convert.ToDouble(Console.ReadLine());



            //Console.WriteLine("\t 1 Sumar");
            //Console.WriteLine("\t 2 Restar ");
            //Console.WriteLine("\t 3 Multiplicar");
            //Console.WriteLine("\t 4 Dividir");
            //Console.WriteLine("\t 5 Salir del Programa");

            //Console.WriteLine("Selecione opción");
            //opcion = Console.ReadLine();

            //    switch (opcion)

            //    {
            //        case "1":
            //            Console.Write($"Suma de {numero1} + {numero2} es {numero1 + numero2}");
            //            break;
            //        case "2":
            //            Console.Write($"Resta de {numero1} - {numero2} es {numero1 - numero2}");
            //            break;
            //        case "3":
            //            Console.Write($"Multiplicacion de {numero1} * {numero2} es {numero1 * numero2}");
            //            break;
            //        case "4":
            //            if (numero2 != 0)
            //            {
            //                Console.Write($"Division de {numero1} / {numero2} es {numero1 / numero2}");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"No se puede dividir por {numero2}");
            //            }
            //            break;
            //        case "5":

            //            break;


            //    }
            //} while (opcion != "5");

            //Ejercicio For
            //int num;
            //Console.WriteLine("Introduce el numero a multiplicar: ");
            //num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"Tabla del numero {num}*{i}={num*i}");
            //}

            //Ejercicio 9 Contar Pares

            //int numeroUsuario,pares=0,impares=0;

            //Console.WriteLine("Introduce un numero");
            //numeroUsuario = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= numeroUsuario; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        pares++;
            //    }
            //    else
            //    {
            //        impares++;
            //    }
            //}
            //Console.WriteLine($"Hay {pares} números pares");
            //for (int i = 2; i <= numeroUsuario; i=+2)
            //{
            //        pares++;
            //}
            //Console.WriteLine($"Hay {pares} números pares");

            // Ejercicio 10 Contar Pares e impares

            //Console.WriteLine("Introduce un numero");
            //numeroUsuario = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= numeroUsuario; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        pares++;
            //    }
            //    else
            //    {
            //        impares++;
            //    }
            //}
            //Console.WriteLine($"Hay {pares} números pares , hay {impares} numeros impares");

            //Ejercicio 11

            //int numeroCuadrado;

            //Console.WriteLine("Introduce un numero");
            //numeroCuadrado = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i < numeroCuadrado; i++)
            //{
            //    Console.WriteLine($"{Math.Pow(i,2)}");
            //}

            //Ejercicio 12

            //int numeroDivisible;
            //Console.WriteLine("Introduce un numero");
            //numeroDivisible = Convert.ToInt32(Console.ReadLine());
            //bool numeroPrimo = true;

            //for (int i =2; i<numeroDivisible-1;i++) 
            //{
            //    if (numeroDivisible%i==0)
            //    {
            //        numeroPrimo = false;
            //    }
            //}
            //if (numeroPrimo)
            //{
            //    Console.WriteLine($"El numero {numeroDivisible} es  Primo");
            //}
            //else
            //{
            //    Console.WriteLine($"El numero {numeroDivisible} no es  Primo");
            //}

            //Ejercicio 1

            //for (int i = 20; i >= 1; i--)
            //{
            //    Console.WriteLine($" {i}");
            //}

            //Ejercio 2

            //int suma,variableUsuario = 0;

            //Console.WriteLine("Introduce un numero");
            //variableUsuario = Convert.ToInt32(Console.ReadLine());

            //do
            //{
            //    Console.WriteLine("Introduce un numero");
            //    variableUsuario = Convert.ToInt32(Console.ReadLine());
            //    suma = suma + variableUsuario;
            //    Console.WriteLine($"Valor de la Variable acumulado es: {variable}");
            //} while (variableUsuario !=0);


            //for (int i=0; i <= 0; i--) 
            //{
            //    Console.WriteLine("Introduce un numero");
            //    variableUsuario = Convert.ToInt32(Console.ReadLine());
            //    suma = suma + variableUsuario;
            //    Console.WriteLine($"Valor de la Variable acumulado es: {variable}");
            //    if (variableUsuario==0) 
            //    {
            //        i = 23;
            //      //break Rompe el Bucle
            //    }
            //}

            // Ejercicio 3

            //int numero =0 ;
            //int cifras = 0;

            //    Console.WriteLine("Introduce un numero");
            //    numero = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i <= 0; i--)
            //{
            //    numero = numero / 10;
            //    cifras++;
            //    if (numero == 0)
            //    {
            //        i = 23;
            //    }
            //}
            //Console.WriteLine($" Hay {cifras} cifras ");

            //Ejercicio 4

            //int numero = 0;


            //Console.WriteLine("Introduce un numero");
            //numero = Convert.ToInt32(Console.ReadLine());

            //for (int  i=1; i<=numero;i++) 
            //{
            //    Console.Write("*");
            //}

            //for (int i = 0; i <= 0; i--)
            //{
            //    numero = numero / 10;
            //    Console.Write("*");
            //    if (numero == 0)
            //    {
            //        i = 23;
            //    }
            //}

            //Ejercicio 5

            //for (int i=1;i<=30;i++) 
            //{
            //    if (i %3==0)
            //    {
            //        Console.WriteLine($"{i}");
            //    }
            //}

            ////Ejercicio 6

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine($"{i}");
            //    }
            //}
            ////Version sin If
            //for (int i = 1; i <= 100; i=i+5)
            //{
            //        Console.WriteLine($"{i}");   
            //}

            //Ejercicio 7
            //int numero;
            //Console.WriteLine("Introduce un numero");
            //numero = Convert.ToInt32(Console.ReadLine());

            //for (int i =1; i<=numero;i++)
            //{
            //    if (i != numero )
            //    {
            //        Console.Write($"{i},");
            //    }
            //    else 
            //    {
            //        Console.Write($"{i}");
            //    }
            //}

            //int numero;
            //Console.WriteLine("Introduce un numero");
            //numero = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Los divisores de {numero} son: ");
            //for (int i=1; i<=numero;i++) 
            //{
            //    if (numero%i==0) 
            //    {
            //        Console.Write($" {i} ");
            //    }
            //}

            //Ejercicio 10
            //for(int i=1; i<=5; i++)
            //{
            //    for (int j=1;j<=9;j++) 
            //    {
            //        Console.Write($"{j}");
            //    }
            //    Console.Write("\n");
            //}

            //Ejercicio 11
            //for (int i = 9; i >= 1; i--)
            //{

            //        for (int j = 1; j<= i; j++)
            //        {
            //            Console.Write($"{j}");
            //        }
            //        Console.Write("\n");

            //}


            //Ejercicio 12
            int numero;
            Console.Write("Introduce numero");
            numero = Convert.ToInt32(Console.ReadLine());

            //for (int filas=1; filas<=numero ; filas++)
            //{
            //    for (int columnas=1 ; columnas<=numero ; columnas++) 
            //    {
            //        Console.Write($"*");
            //    }
            //    Console.Write("\n");
            //}

            //Ejercicio 13
            //for (int filas = 1; filas <= numero; filas++)
            //{
            //    for (int columnas = 1; columnas <= filas; columnas++)
            //    {
            //        Console.Write($"*");
            //    }
            //    Console.Write("\n");
            //}

            //Ejercicios 14

            for (int filas = 1; filas <= numero; filas++)
            {
                for (int columnas = 1; columnas <= numero; columnas++)
                {
                    if (columnas <= numero - filas)
                    {
                        Console.Write($"");
                    }
                    else
                    {
                        Console.Write($"*");
                    }
                }
                Console.Write("\n");

                //Ejercicio 15
            }
        }
    }
}
