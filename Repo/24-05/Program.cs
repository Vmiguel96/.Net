using System;

namespace _24_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //string contraseña ="";

            // Ejercicio While
            //while (contraseña != "1111") 
            //{
            //    Console.Write($"Escribe contraseña ");
            //    contraseña = Console.ReadLine();

            //}
            //Console.Write($"Contraseña Correcta ");

            //Ejercicio Do While

            //do
            //{
            //    Console.WriteLine("Escribe la contraseña");
            //    contraseña = Console.ReadLine();

            //} while (contraseña != "1111");
            //Console.Write($"Contraseña Correcta ");

            //Ejercicio 2

            //int num = 1;
            //while (num != 0)
            //{
            //    Console.WriteLine("Introduce un numero");
            //    num = Convert.ToInt32(Console.ReadLine());
            //    if (num != 0)
            //    {
            //        if (num % 2 == 0)
            //        {
            //            Console.WriteLine($"El numero {num} es par");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"El numero {num} es impar");
            //        }
            //    }
            //}

            //Ejercicio 2 Do while

            //do
            //{
            //    Console.WriteLine("Introduce un numero");
            //    num = Convert.ToInt32(Console.ReadLine());
            //} while (num != 0);
            //if (num !=0)
            //{
            //    if (num % 2 == 0)
            //    {
            //        Console.WriteLine($"El numero {num} es par");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"El numero {num} es impar");
            //    }
            //} while (num != 0) ;


            //Ejercicio 3

            //int numero1 = 1;
            //int numero2 = 0;

            //Console.WriteLine("Introduce el primer numero");
            //numero1 = Convert.ToInt32(Console.ReadLine());

            //while (numero2 == 0)
            //{


            //    Console.WriteLine("Introduce el segundo numero");
            //    numero2 = Convert.ToInt32(Console.ReadLine());
            //}
            //    Console.WriteLine($"El numero de le la division entre {numero1} y {numero2} es {numero1 / numero2}");



            //Ejercicio 3 do while

            //int numerador, denominador = 0;

            //do
            //{

            //    Console.WriteLine("Introduce el primer numero");
            //    numerador = Convert.ToInt32(Console.ReadLine());
            //} while (denominador == 0);
            //Console.WriteLine($"El numero de le la division entre {numerador} y {denominador} es {numerador / denominador}");

            // Ejercicio 4 

            //int numeropositivo1, numeropositivo2;

            //    Console.WriteLine("Introduce el primer numero");
            //    numeropositivo1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Introduce el segundo numero");
            //    numeropositivo2 = Convert.ToInt32(Console.ReadLine());
            //int cuantos = 0;

            //if (numeropositivo1 > 0 && numeropositivo2 > 0)
            //{
            //    Console.WriteLine($"Hay dos numeros positivos {numeropositivo1} y {numeropositivo2}");
            //}
            //else if (numeropositivo1 < 0 && numeropositivo2 < 0)
            //{
            //    Console.WriteLine($"Hay ningun numero positivos {numeropositivo1} y {numeropositivo2}");
            //}
            //else 
            //{
            //    Console.WriteLine($"Hay un numero positivo {numeropositivo1} y {numeropositivo2}");
            //}

            ////Ternario
            //cuantos = numeropositivo1 > 0 && numeropositivo2 > 0 ? 2 : numeropositivo1 < 0 && numeropositivo2 < 0 ? 0 : 1;
            //Console.WriteLine($"Hay {cuantos} numeros positivos");

            //Ejercicio 5

            //int veces=2, contador=0,num1;
            //while (veces > 0)
            //{
            //    Console.WriteLine("Escribe un numero");
            //    num1 = Convert.ToInt32(Console.ReadLine());
            //    if (num1 > 0)
            //    {
            //        contador++;
            //    }
            //    veces--;
            //}
            //Console.WriteLine($"Hay {contador} numeros positivos");

            //Ejercicio 6

            //int numeros =1;
            //int contadorPositivo = 0, contadorNegativo = 0 ;

            //while (numeros !=0)
            //{
            //    Console.WriteLine("Introduce un numero");
            //    numeros = Convert.ToInt32(Console.ReadLine());

            //    if (numeros >0)
            //    {
            //        contadorPositivo++;
            //    }
            //    else if (numeros < 0) 
            //    {
            //        contadorNegativo++;
            //    }
            //}

            //Console.WriteLine($"Numeros positivos: {contadorPositivo} \nNumeros negativos: {contadorNegativo}");

            //Ejercicios 6

            //string usuario="",password="";
            //Console.WriteLine("Introduce un usuario");
            //usuario = Console.ReadLine();
            //Console.WriteLine("Introduce una contraseña");
            //password = Console.ReadLine();

            //while (usuario != "1212" && password != "1234") 
            //{
            //    Console.WriteLine("Introduce un usuario");
            //    usuario = Console.ReadLine();
            //    Console.WriteLine("Introduce una contraseña");
            //    password = Console.ReadLine();
            //}
            //Console.WriteLine("Usuario y contraseña Correctos");

            //Ejercicio 7 Do while condicion inversa

            //do
            //{
            //    Console.WriteLine("Introduce un usuario");
            //    usuario = Console.ReadLine();
            //    Console.WriteLine("Introduce una contraseña");
            //    password = Console.ReadLine();
            //} while (usuario !="1212" || password !="1234");

            //Console.WriteLine("Usuario y contraseña Correctos");

            //Ejercicio 8

            //string usuario = "", password = "";
            //int intentos = 0;
            //Console.WriteLine("Introduce un usuario");
            //usuario = Console.ReadLine();
            //Console.WriteLine("Introduce una contraseña");
            //password = Console.ReadLine();

            //do
            //{
            //    Console.WriteLine("Introduce un usuario");
            //    usuario = Console.ReadLine();
            //    Console.WriteLine("Introduce una contraseña");
            //    password = Console.ReadLine();
            //    if (usuario != "1212" && password != "1234")
            //    {
            //        intentos++;
            //    }
            //} while (usuario != "1212" || password != "1234" && intentos <3 );

            //if (intentos == 3)
            //{
            //    Console.WriteLine("Intentos Superados");
            //}
            //Console.WriteLine("Usuario y contraseña Correctos");

            //Ejercicio 9

            //int numeroValor;
            //int numeroContador = 1;

            //Console.WriteLine("Introduce un numero");
            //numeroValor = Convert.ToInt32(Console.ReadLine());

            //while (numeroContador <= numeroValor)
            //{
            //    if (numeroContador % 2 == 0)
            //    {
            //        if (numeroContador < numeroValor)
            //            Console.Write($"{numeroContador}, ");
            //        else
            //            Console.Write($"{numeroContador}\n ");
            //    }


            //    numeroContador++;

            //}
            //numeroContador = 1;
            //while (numeroContador <= numeroValor)
            //{
            //    if (numeroContador % 3 == 0)
            //    {
            //        if (numeroContador < numeroValor)
            //            Console.Write($"{numeroContador}, ");
            //        else
            //            Console.Write($"{numeroContador}\n ");
            //    }

            //    numeroContador++;
            //}


            //Ejercicio 10

            //int valor = 1;
            //int contador = 1;
            //int pares = 0, impares = 0;

            //Console.WriteLine("Introduce un numero");
            //valor = Convert.ToInt32(Console.ReadLine());

            //while (contador <= valor) 
            //{
            //    if (valor%2 ==0)

            //        pares++;

            //    else

            //        impares++;

            //    contador++;
            //}
            //Console.WriteLine($"Numeros pares {pares} e impares {impares}");


            //Ejercicio 11

            //int valorN;
            //int contadorN = 1;


            //Console.WriteLine("Introduce un numero");
            //valorN = Convert.ToInt32(Console.ReadLine());

            //while (contadorN <= valorN)
            //{
            //    Console.Write($"{Math.Pow(contadorN,2)} ");
            //    contadorN++;
            //}

            int adivina = new Random().Next() % 10 + 1;
            int oportunidades = 0;
            int numeroGenerado = 0;
            bool ganador = false;

            while (oportunidades <= 4 && ganador == false)
            {
                if (numeroGenerado >= adivina -5 && numeroGenerado <= +5)
                {
                    Console.WriteLine("Caliente");
                }
                else 
                {
                    Console.WriteLine("Frio");
                }
                Console.WriteLine("Introduce el numero correcto");
                numeroGenerado = Convert.ToInt32(Console.ReadLine());

                if (numeroGenerado==adivina)
                {
                    Console.WriteLine($"Felicidades el numero es {adivina}");
                    ganador = true;
                }
                    oportunidades++;
            }
            if (ganador ==false)
            Console.WriteLine($"Mala Suerte el numero era {adivina}");



        }
    }
}
