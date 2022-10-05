using System;

namespace Dia_21_05
{
    class Program
    {
        static void Main(string[] args)
        {


            //int n1 = 4;
            //int n2 = 7;
            //int diferencia = n1 > n2 ? n1 - n2 : n2 - n1;
            //Console.WriteLine(diferencia);




            //Ejercicio 8

            //int num = 0;
            //Console.WriteLine("Escribe un numero");
            //num = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"{num} es {(num % 2 == 0 ? "par" : "impar")}");

            //Ejercicio 2

            //int numeroMultiplo10 = 0;

            //Console.WriteLine($"Introduce un Numero");
            //numeroMultiplo10 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"{numeroMultiplo10} es {(numeroMultiplo10 % 10 == 0 && !(numeroMultiplo10 == 0) ? "Es Multiplo de 10" : "No es multiplo de 10")}");
            ////Doble Operador ternario
            //Console.WriteLine($"El {numeroMultiplo10} {(numeroMultiplo10==0 ? "NO":numeroMultiplo10 %10 ==0?"Si":"No")} ");

            //Ejercicios Extra 1

            //int numero3 = 0;
            //Console.WriteLine("Escribe un valor");

            //numero3 = Convert.ToInt32(Console.ReadLine());
            //int valorSigno = (numero3 > 0 ? 1 : (numero3 < 0 ? -1 : 0));
            //Console.WriteLine($"La variable tiene valor {valorSigno}");

            //Ejercicios Extra 2

            int valorUsuario =0;

            Console.WriteLine("Escribe un numero ");
            valorUsuario = Convert.ToInt32(Console.ReadLine());
            int numeroMulpiplo = valorUsuario % 2 == 0  &&  valorUsuario % 3 == 0 ?1:0;
            Console.WriteLine($"El numero {valorUsuario} {(numeroMulpiplo == 1?"Si":"No")} es multiplo de 2 y 3.");

            //Ejercicio

            //double sueldo;
            //int antiguedad;
            //Console.WriteLine("Introduze tu Salario");
            //sueldo = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Introduze tu Antiguedad");
            //antiguedad = Convert.ToInt32(Console.ReadLine());

            //if (sueldo < 500 && antiguedad >= 10)
            //{
            //    sueldo = sueldo + (sueldo * 20) / 100;
            //    Console.WriteLine($"El sueldo es: {sueldo}");
            //}
            //else if (sueldo < 500 && antiguedad < 10)
            //{
            //    sueldo = sueldo + (sueldo * 5) / 100;
            //    Console.WriteLine($"El sueldo es: {sueldo}");
            //}
            //else if (sueldo >= 500) 
            //{
            //    Console.WriteLine($"El sueldo es: {sueldo}");
            //}

            int cantidad, monedas1, billetes5, billetes10, billetes20, billetes50, billetes100, billetes200, billetes500;
            int cantidadRestante;


            Console.WriteLine("Introduce un numero de euros");
            cantidad = Convert.ToInt32(Console.ReadLine());

            cantidadRestante = cantidad;

            if (cantidad >= 500)
            {
                billetes500 = cantidad / 500;
                cantidadRestante = cantidadRestante % 500;
            }
            else
            {
                billetes500 = 0;
            }
            if (cantidadRestante >= 200)
            {
                billetes200 = cantidad / 200;
                cantidadRestante = cantidadRestante % 200;
            }
            else
            {

                billetes200 = 0;
            }
            if (cantidadRestante >= 100)
            {
                billetes100 = cantidad / 100;
                cantidadRestante = cantidadRestante % 100;
            }
            else 
            {
                billetes100 = 0;
            }
            if (cantidadRestante >=50)
            {
                billetes50 = cantidad / 50;
                cantidadRestante = cantidadRestante % 50;
            }
            else 
            {
                billetes50 = 0;
            }
            if (cantidadRestante >= 20)
            {
                billetes20 = cantidad / 20;
                cantidadRestante = cantidadRestante % 20;
            }
            else 
            {
                billetes20 = 0;
            }
            if (cantidadRestante >= 10)
            {
                billetes10 = cantidad / 10;
                cantidadRestante = cantidadRestante % 10;
            }
            else
            {
                billetes10 = 0;
            }
            if (cantidadRestante >= 5)
            {
                billetes5 = cantidad / 5;
                cantidadRestante = cantidadRestante % 5;
            }
            else
            {
                billetes5 = 0;
            }
            if (cantidadRestante >= 1)
            {
                monedas1 = cantidad / 1;
                cantidadRestante = cantidadRestante % 1;
            }
            else
            {
                monedas1 = 0;
            }



            Console.WriteLine($"La cantidad de Billetes de 500 es :{billetes500}");
            Console.WriteLine($"La cantidad de Billetes de 200 es :{billetes200}");
            Console.WriteLine($"La cantidad de Billetes de 100 es :{billetes100}");
            Console.WriteLine($"La cantidad de Billetes de 50 es :{billetes50}");
            Console.WriteLine($"La cantidad de Billetes de 20 es :{billetes20}");
            Console.WriteLine($"La cantidad de Billetes de 10 es :{billetes10}");
            Console.WriteLine($"La cantidad de Billetes de 5 es :{billetes5}");
            Console.WriteLine($"La cantidad de Monedas de 1 es :{monedas1}");

            //int numeroAño;

            //Console.WriteLine("Escribe un año");
            //numeroAño = Convert.ToInt32(Console.ReadLine());

            //if (numeroAño%4==0 && !(numeroAño % 100 == 0))
            //{
            //    Console.WriteLine("El año es Bisiesto");
            //}
            //else 
            //{
            //    Console.WriteLine("El año no es Bisiesto");
            //}

            //int numeroMes;
            //Console.Write("Escribe un numero de mes: ");

            //numeroMes = Convert.ToInt32(Console.ReadLine());

            //switch (numeroMes)
            //{
            //    case 1:
            //        Console.WriteLine("Enero");
            //        break;
            //    case 2:
            //        Console.WriteLine("Febrero");
            //        break;
            //    case 3:
            //        Console.WriteLine("Marzo");
            //        break;
            //    case 4:
            //        Console.WriteLine("Abril");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayo");
            //        break;
            //    case 6:
            //        Console.WriteLine("Junio");
            //        break;
            //    case 7:
            //        Console.WriteLine("Julio");
            //        break;
            //    case 8:
            //        Console.WriteLine("Agosto");
            //        break;
            //    case 9:
            //        Console.WriteLine("Septiembre");
            //        break;
            //    case 10:
            //        Console.WriteLine("Octubre");
            //        break;
            //    case 11:
            //        Console.WriteLine("Nobiembre");
            //        break;
            //    case 12:
            //        Console.WriteLine("Diciembre");
            //        break;
            //}

            // int numeroMeses;
            // Console.Write("Escribe un numero de mes: ");

            // numeroMeses = Convert.ToInt32(Console.ReadLine());

            // if (numeroMeses > 0 && numeroMeses < 13)
            // {

            //     if (numeroMeses == 4 || numeroMeses == 6 || numeroMeses == 9 || numeroMeses == 11)
            //     {
            //         Console.Write("El mes tiene 30 dias ");
            //     }
            //     else if (numeroMeses == 2)
            //     {
            //         Console.Write("El mes tiene 28 dias ");
            //     }
            //     else
            //     {
            //         Console.Write("El mes tiene 31 dias ");
            //     }

            // }
            // else 
            // {
            //     Console.Write("Valor Incorrecto");
            // }

            // switch (numeroMeses)
            // {
            //     case 1:
            //     case 3:
            //     case 5:
            //     case 7:
            //     case 8:
            //     case 10:
            //     case 12:
            //         Console.WriteLine("31 dias");
            //         break;
            //     case 4:
            //     case 6:
            //     case 9:
            //     case 11:
            //         Console.WriteLine("30 dias");
            //         break;
            //     case 2:
            //         Console.WriteLine("28 dias");
            //         break;
            //     default:
            //         Console.WriteLine("Valor Incorrecto");
            //         break;
            // }


            // char valor;
            // Console.Write("Escribe un valor: ");

            //valor  = Convert.ToChar(Console.ReadLine());

            // switch (valor)
            // {
            //     case '.':
            //     case ',':
            //     case ';':
            //     case ':':
            //         Console.WriteLine("Es un Signo");
            //         break;
            //     case '0':
            //     case '1':
            //     case '2':
            //     case '3':
            //     case '4':
            //     case '5':
            //     case '6':
            //     case '7':
            //     case '8':
            //     case '9':
            //         Console.WriteLine("Es un numero");
            //         break;
            //     default:
            //         Console.WriteLine("Es otro carácter");
            //         break;


            // }


            //double numero1, numero2;
            //string opcion;

            //Console.Write("Escribe un numero: ");
            //numero1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Escribe un numero: ");
            //numero2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("\t 1 Sumar");
            //Console.WriteLine("\t 2 Restar ");
            //Console.WriteLine("\t 3 Multiplicar");
            //Console.WriteLine("\t 4 Dividir");

            //Console.WriteLine("Selecione opción");
            //opcion = Console.ReadLine();

            //switch (opcion)

            //{
            //    case "1":
            //        Console.Write($"Suma de {numero1} + {numero2} es {numero1+numero2}");
            //        break;
            //    case "2":
            //        Console.Write($"Resta de {numero1} - {numero2} es {numero1 - numero2}");
            //        break;
            //    case "3":
            //        Console.Write($"Multiplicacion de {numero1} * {numero2} es {numero1 * numero2}");
            //        break;
            //    case "4":
            //        if (numero2 != 0)
            //        {
            //            Console.Write($"Division de {numero1} / {numero2} es {numero1 / numero2}");
            //        }
            //        else 
            //        {
            //            Console.WriteLine($"No se puede dividir por {numero2}");
            //        }
            //        break;

            //}

            //double precio = 50;
            //int edad;
            //string socio = "";

            //Console.WriteLine("Que edad tienes");

            //edad = Convert.ToInt32(Console.ReadLine());

            //if (edad < 18) 
            //{
            //    precio = precio - (precio * 25)/100;
            //    Console.WriteLine($"El precio es: {precio}");
            //}
            //else
            //    Console.WriteLine("Eres socio");
            //    socio = Console.ReadLine();

            //if (edad > 65)
            //{
            //    precio = precio - (precio * 75) / 100;
            //    Console.WriteLine($"El precio es: {precio}");
            //}

            //else
            //            if (socio == "si")
            //{
            //    precio = precio - (precio * 40) / 100;
            //    Console.WriteLine($"El precio es: {precio}");
            //}

            //else 
            //{
            //    Console.WriteLine($"El precio es: {precio}");
            //}



            //string figuras;
            //double baseNumero, alturaNumero,ladoNumero,radio;

            //Console.WriteLine(" 1 Triangulo");
            //Console.WriteLine(" 2 Rectangulo ");
            //Console.WriteLine(" 3 Cuadrado");
            //Console.WriteLine(" 4 Circulo");

            //Console.WriteLine("Selecione opción");
            //figuras = Console.ReadLine();

            //switch (figuras)
            //{
            //    case "1":
            //        Console.WriteLine("Valor Base: ");
            //        baseNumero = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Valor Altura: ");
            //        alturaNumero = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine((baseNumero*alturaNumero)/2);
            //        break;
            //    case "2":
            //        Console.WriteLine("Valor Base: ");
            //        baseNumero = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Valor Altura: ");
            //        alturaNumero = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine(baseNumero*alturaNumero);
            //        break;
            //    case "3":
            //        Console.WriteLine("Valor Lado: ");
            //        ladoNumero = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine(ladoNumero*ladoNumero);
            //        break;
            //    case "4":
            //        Console.WriteLine("Valor Radio: ");
            //        radio = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine(Math.PI * Math.Pow(radio,2));
            //        break;
            //    default:
            //        Console.WriteLine("Opción Incorrecta");
            //        break;
            //}

            //string nombre;

            //Console.WriteLine("Introduzca Nombre");
            //nombre = Console.ReadLine();

            //switch (nombre) 
            //{
            //    case "Antonio":
            //        Console.WriteLine("Hola Toni");
            //        break;
            //    case "Jesús":
            //        Console.WriteLine("Cómo va Chechu");
            //        break;
            //    case "Mária":
            //        Console.WriteLine("Buenos Días Doña María");
            //        break;
            //    case "Lidia":
            //        Console.WriteLine("Tenga un buen día Señora Lidia");
            //        break;
            //    default:
            //        Console.WriteLine("Usuario no autorizado");
            //        break;
            //}

        }



    }
}
