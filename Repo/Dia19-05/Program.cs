using System;

namespace Dia19_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numero, numero2;
            //Console.WriteLine("Introduce un Numero: ");
            //numero = Convert.ToInt32(Console.ReadLine());
            //numero2 = 1; 
            //Console.WriteLine($"{numero} x 1 = {numero* numero2}");
            //numero2++;
            //Console.WriteLine($"{numero} x {numero2} = {numero* numero2}");
            //numero2++;
            //Console.WriteLine($"{numero} x 1 = {numero* numero2}");
            //numero2++;
            //Console.WriteLine(numero* numero2);
            //numero2++;
            //Console.WriteLine(numero* numero2);
            //numero2++;
            //Console.WriteLine(numero* numero2);
            //numero2++;
            //Console.WriteLine(numero * numero2);
            //numero2++;
            //Console.WriteLine(numero * numero2);
            //numero2++;
            //Console.WriteLine(numero * numero2);
            //numero2++;
            //Console.WriteLine(numero * numero2);


            //int segundosUsuario, segundos, minutos , horas;
            //Console.WriteLine("Introduce Un Numero de Segundos: ");
            //segundosUsuario = Convert.ToInt32(Console.ReadLine());


            //minutos = segundosUsuario / 60;
            //segundos = segundosUsuario % 60;
            //horas = minutos / 60;

            //Console.WriteLine($"{segundosUsuario} segundos son: {horas}horas {minutos}minutos {segundos}segundos");

            //int dato, dato2;
            //Console.WriteLine("Introduce Primer Numero");
            //dato = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Introduce Segundo Numero");
            //dato2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"La Suma de {dato} + {dato2} es: {dato + dato2}");
            //Console.WriteLine($"La Resta de {dato} - {dato2} es: {dato - dato2}");
            //Console.WriteLine($"Multiplicación :{dato * dato2}");
            //Console.WriteLine(dato / dato2);

            //int metros;
            //double millas;
            //Console.WriteLine("Introduce Numero de Metros");
            //metros = Convert.ToInt32(Console.ReadLine());
            //millas = (double)metros / 1609;
            //Console.WriteLine($"{metros}metros son {millas} millas");

            //string nombre;
            //int edad;
            //Console.WriteLine("Introduce Nombre");
            //nombre = Console.ReadLine();
            //Console.WriteLine("Introduce la Edad");
            //edad = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{nombre} tiene {edad} años");

            //int botellas;
            //int precio = 25;
            //int precioTotal;
            //int euros, centimos;


            //Console.WriteLine("Intoduce el Numero de Botellas");
            //botellas = Convert.ToInt32(Console.ReadLine());

            //precioTotal = precio * botellas;

            //euros = precioTotal / 100;
            //centimos = precioTotal % 100;

            //Console.WriteLine($"Las {botellas} tiene un precio de:{euros}euros,{centimos}centimos");

            //int horaEntrada;
            //int horaSalida;
            //int horaE;
            //int horaS;
            //int precioEuros;
            //int precioCentimos;

            //Console.WriteLine("Introduce Hora Entrada");
            //horaEntrada = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Introduce Hora Salida");
            //horaSalida = Convert.ToInt32(Console.ReadLine());
            //horaE = horaEntrada / 100;
            //horaS = horaSalida / 100;
            //precioEuros = (horaS - horaE) * 60/100;

            //Console.WriteLine($"Precio a pagar: {precioEuros}");


            //double gradosC , gradosF;

            //Console.WriteLine("Introduce Grados C");
            //gradosC = Convert.ToDouble(Console.ReadLine());

            //gradosF = gradosC * 33.8;

            //Console.WriteLine($"Los {gradosC} Grados Celsius son:{gradosF} Grados Fahrenheit");

            //string nombreUsuario;
            //Console.WriteLine("Introduce Nombre");
            //nombreUsuario = Console.ReadLine();
            //Console.WriteLine($"Buenos Dias {nombreUsuario}");

            //int numeroEntero;
            //Console.Write("Introduce Numero: ");
            //numeroEntero = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"El doble de {numeroEntero} es {numeroEntero * 2}");
            //Console.WriteLine($"El triple de {numeroEntero} es {numeroEntero * 3}");
            //Console.WriteLine($"El cuadrado de {numeroEntero} es {Math.Pow(numeroEntero,2)}");
            //Console.WriteLine($"El cubo de {numeroEntero} es {Math.Pow(numeroEntero, 3)}");
            //Console.WriteLine($"La raiz cuadrada de {numeroEntero} es {Math.Sqrt(numeroEntero)}");

            //int gradosCentigrados;
            //double gradosFahrenheit;

            //Console.Write("Introduzca Grados centigrados");
            //gradosCentigrados = Convert.ToInt32(Console.ReadLine());
            //gradosFahrenheit = 32 +(9 * gradosCentigrados / 5);
            //Console.WriteLine($"Los {gradosCentigrados} grados centigrados son: {gradosFahrenheit:F2} Grados Fanhrenheit");

            //int numeroEntero, unidades, decenas, centenas, auxiliar;

            //Console.Write("Intoduce un Numero de 3 Cifras");
            //numeroEntero = Convert.ToInt32(Console.ReadLine());
            //auxiliar = numeroEntero / 10;
            //unidades = numeroEntero % 10;
            //centenas = auxiliar / 10;
            //decenas = auxiliar % 10;
            //Console.WriteLine($"Centenas{centenas}");
            //Console.WriteLine($"Decenas{decenas}");
            //Console.WriteLine($"Unidades{unidades}");


            //int dia, mes, anyo, sumaFecha;
            //int miles, centenas, decenas, unidades,auxiliar;
            //Console.Write("Intoduce tu Dia de Nacimiento");
            //dia = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Intoduce tu Mes de Nacimiento");
            //mes = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Intoduce tu Año de Nacimiento");
            //anyo = Convert.ToInt32(Console.ReadLine());

            //sumaFecha = dia + mes + anyo;
            //unidades = sumaFecha % 10;
            //auxiliar = sumaFecha / 10;

            //decenas = auxiliar % 10;
            //auxiliar = auxiliar / 10;

            //centenas = auxiliar % 10;
            //miles = auxiliar / 10;
            //Console.WriteLine($"{sumaFecha}: -Valores {miles},{centenas},{decenas},{unidades}");
            //Console.WriteLine($"Tu numero de la suerte es:{miles+centenas+decenas+unidades}");

            string producto1,producto2,producto3;
            double precio1,precio2,precio3;

            Console.Write("Nombre del Primer Producto");
            producto1 = Console.ReadLine();
            Console.Write("Precio del Primer Producto");
            precio1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nombre del Segundo Producto");
            producto2 = Console.ReadLine();
            Console.Write("Precio del Segundo Producto");
            precio2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nombre del Tercer Producto");
            producto3 = Console.ReadLine();
            Console.Write("Precio del Tercer Producto");
            precio3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{"NOMBRE",-15}{"PRECIO",12}{"CON IVA",12}");
            Console.WriteLine($"{producto1,-15}{precio1,12:F2}€{precio1* 1.21,12:F2}");
            Console.WriteLine($"{producto2,-15}{precio2,12:F2}€{precio2* 1.21,12:F2}");
            Console.WriteLine($"{producto3,-15}{precio3,12:F2}€{precio3* 1.21,12:F2}");
        }
    }
}
