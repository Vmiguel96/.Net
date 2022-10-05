using System;


namespace _27_05
{
    class Program
    {
        public static void Ejercicio1()
        {
            string[] meses = {"Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre" };
            Console.WriteLine("Introduce un numero correspondiente al mes");
            int numero = 0;
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El Mes elegido es {meses[numero-1]}");
        }

        public static void Ejercicio2()
        {
             int[] numeros = new int[10];
            int suma = 0;
            

            for (int i =0; i<numeros.Length;i++)
            {
                Console.Write($"Introduce el numero {i+1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                suma = suma + numeros[i];
                Console.Write($"{numeros[i]},");
            }
            Console.WriteLine($"\nSuma de los valores es: {suma}");

            double media = suma / (double)numeros.Length;

            Console.WriteLine($"La Media de los Valores es: {media}");

            int valorMax = numeros[0],valorMin = numeros [0];

            for (int i = 1;i <numeros.Length; i++) 
            {
                if (numeros[i] > valorMax) 
                {
                    valorMax = numeros[i];
                }
                if (numeros[i]< valorMin) 
                {
                    valorMin = numeros[i];
                }
                
            }Console.WriteLine($"Numero mayor es: {valorMax} \nNumero Mayor es: {valorMin}");
        }

        public static void Ejercicio3() 
        {
            double[] numeros = new double [10];
            
            

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Introduce el numero {i + 1}: ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }

            double suma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i];
                Console.Write($"{numeros[i]},");
            }

            double media = suma / numeros.Length;

            Console.WriteLine($"La Media de los Valores es: {media:F2}");
            Console.WriteLine($"Valores por encima de la media");

            for (int i=1; i<numeros.Length;i++)
            {
                if (numeros[i] >media)
                {
                    Console.Write($"{numeros[i]} ");
                }
            }
        }

        public static void Ejercicio4()
        {
            int[] dias = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] meses = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"  };

            int mes = 0, dia = 0;
            int totalDias = 0;
            string mesLetra = "";
            bool encontrado = false;
            int posicionMes = 0;
            int mesEncontrado = 0;

            Console.WriteLine("Introduce un mes");
            //mes = Convert.ToInt32(Console.ReadLine());
            mesLetra = Console.ReadLine();

            Console.WriteLine("Introduce un dia");
            dia = Convert.ToInt32(Console.ReadLine());

            //Buscamos el mes introducido
            

            for (posicionMes= 0; posicionMes<meses.Length && !encontrado;posicionMes++) 
            {
                if (meses[posicionMes] == mesLetra) 
                {
                    encontrado = true;
                    mesEncontrado = posicionMes;
                }
            }

            for (int i =0;i<mesEncontrado;i++)
            {
                    totalDias += dias[i];   
            }
            totalDias = totalDias + dia;
            Console.WriteLine($"El {dia} de {meses[mesEncontrado]} es el dia {totalDias} del año  ");
        }





        static void Main(string[] args)
        {
            //Ejercicio 13
            //int numeroDivisible;
            //Console.WriteLine("Introduce un numero");
            //numeroDivisible = Convert.ToInt32(Console.ReadLine());
            //bool numeroPrimo = true;

            //for (int i = 1;i<=numeroDivisible;i++ )
            //{
            //    numeroPrimo = true;
            //    for (int j = 2; j <= i - 1; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            numeroPrimo = false;
            //        }
            //    }
            //    if (numeroPrimo)
            //    {
            //            Console.Write($"{i},");
            //    }
            //}

            //Ejercicio 14
            //int numero = 0;
            //Console.WriteLine("Introduce un numero");
            //numero = Convert.ToInt32(Console.ReadLine());

            //for (int i =numero; i>=1;i--)
            //{
            //    for (int j=0; j <i; j++)
            //    {
            //    Console.Write($"#");
            //    }
            //    Console.WriteLine();
            //}

            //Ejercicio 15

            //int numero = 0;
            //Console.WriteLine("Introduce un numero");
            //numero = Convert.ToInt32(Console.ReadLine());

            //for (int i =1; i< numero; i++)
            //{
            //    for (int j = 1; j <= numero; j++)
            //    {

            //        if (j<i)
            //        {
            //            Console.Write($" ");
            //        }
            //        else
            //        {
            //            Console.Write($"#");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //int numero = 0;
            //Console.Write("Introduce un numero");
            //numero = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < numero; i++)
            //{
            //        for (int espacios=0;espacios<i;espacios++)
            //        {
            //            Console.Write($" ");
            //        }
            //        for(int caracteres=0;caracteres<numero-i;caracteres++)
            //        {
            //            Console.Write($"#");
            //        }
            //    Console.WriteLine();
            //}

            //Ejercicio 16
            //int numero = 0;
            //Console.Write("Introduce un numero ");
            //numero = Convert.ToInt32(Console.ReadLine());
            //int factorial = 1;

            //for (int i =numero ; i > 0; i--)
            //{ 
            //    {
            //        factorial *= i;
            //    }
            //}
            //Console.WriteLine($"Factorial de {numero} es {factorial}");

            //Ejercicio 20 y 21
            //int numero = 1;

            //int contador = 0;

            //while (numero != 0) 
            //{
            //    Console.Write("Introduce un numero ");
            //    numero = Convert.ToInt32(Console.ReadLine());
            //    if (numero %5==0 && numero !=0) 
            //    {
            //        contador++;
            //    }
            //}
            //Console.WriteLine($"Numeros introducidos {contador} multiplos de 5");

            //Ejercicio 17
            //int cantidad, precio;
            //int total=0,sumaTotal= 0;

            //Console.WriteLine("Introduce cantidad: ");
            //cantidad = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Introduce precio: ");
            //precio = Convert.ToInt32(Console.ReadLine());

            //while (!(cantidad ==0 || precio==0)) 
            //{
            //    total = cantidad * precio;
            //    sumaTotal += total;
            //    Console.WriteLine($"Total: {total}");

            //    Console.WriteLine("Introduce cantidad: ");
            //    cantidad = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Introduce precio: ");
            //    precio = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine($"Total Final: {sumaTotal}");

            //Ejercicio 18
            //int numero1,numero2;
            //int contador = 0;

            //Console.WriteLine("Introduce un numero: ");
            //numero1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Introduce otro numero: ");
            //numero2 = Convert.ToInt32(Console.ReadLine());

            //bool numeroPrimo = true;

            //for (int i = numero1; i <= numero2; i++)
            //{
            //    numeroPrimo = true;
            //    for (int j = 2; j <= i - 1; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            numeroPrimo = false;
            //        }
            //    }
            //    if (numeroPrimo)
            //    {
            //        contador++;
            //    }
            //}
            //Console.WriteLine($"Hay {contador} numeros primos");

            ////Ejercio 19

            //int numero1, numero2,numero;
            //Console.WriteLine("Introduce un numero: ");
            //numero1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Introduce otro numero: ");
            //numero2 = Convert.ToInt32(Console.ReadLine());


            //if (numero1 > numero2)
            //{
            //    numero = numero2;
            //}
            //else 
            //{
            //    numero = numero1;
            //}

            //for (int i =1;i<=numero;i++ ) 
            //{

            //        if (numero1 % i == 0 && numero2%i==0)
            //        {
            //            Console.WriteLine(i+" ");
            //        }
            //}


            //int[] numeros = new int[5];

            //numeros[0] = 12;
            //numeros[1] = 23;
            //numeros[2] = 53;
            //numeros[3] = 5;
            //numeros[4] = 92;

            //int[] numeros2 = { 12, 23, 53, 5, 92 };
            //Console.WriteLine($"Lenght = {numeros2.Length}");
            ////Recorrer array
            //for (int i=0; i<numeros2.Length;i++)
            //{
            //    Console.WriteLine($"En la posicion {i} esta el valor {numeros2[i]}");
            //}
            ////foreach
            //foreach (int num in numeros)
            //{
            //    Console.WriteLine($"el valor {num}");
            //}


            ////Pedir Numero 
            //for (int i = 0;i < 100;i++)
            //{
            //    if (100 % i == 0)
            //    {

            //    }
            //}

            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio3();
            Ejercicio4();
        }
    }
}
