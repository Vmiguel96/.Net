using System;

namespace _01_06
{


    class Program
    {
        
        public static void Ejercicio1()
    {
            int[] numeros = new int[10];
            double suma = 0, media = 0;
            

            for (int i=0;i<numeros.Length;i++) 
            {
                Console.Write($"Introduce el numero {i+1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                suma += numeros[i];
            }

            media = suma / numeros.Length;
            Console.WriteLine($"Media: {media}");

            Console.WriteLine($"Numeros encima de la media: ");
            for (int j=0;j<numeros.Length;j++)
            {
                if (numeros[j]>media) 
                {
                    Console.Write($"{numeros[j]} ");
                }
            }
            

    }


        public static void Ejercicio2()
        {
            int notas=0;
            Console.WriteLine("Introduzca la cantidad de notas");
            notas = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[notas];
            double suma = 0, media = 0;


            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Introduce el numero {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                suma += numeros[i];
            }

            media = suma / numeros.Length;
            Console.WriteLine($"Media: {media}");

            Console.WriteLine($"Numeros encima de la media: ");
            for (int j = 0; j < numeros.Length; j++)
            {
                if (numeros[j] > media)
                {
                    Console.Write($"{numeros[j]} ");
                }
            }


        }

        public static void Ejercicio3()
        {
            int[] numeros = new int[10];
            int[] contenedosPares;
            int[] contenedorImpares;
            int pares=0;
            int impares=0;


            for (int i=0;i<numeros.Length;i++)
            {
                Console.Write($"Introduce el numero {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i =0; i<numeros.Length;i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    pares++;
                }
                else 
                {
                    impares++;
                }
            }

            contenedosPares = new int[pares];
            contenedorImpares = new int[impares];

            int indicePares = 0, indiceImpares = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    contenedosPares[indicePares] = numeros[i];
                    indicePares++;
                   
                }
                else
                {
                    contenedosPares[indiceImpares] = numeros[i];
                    indiceImpares++;
                }
            }

            Console.WriteLine($"Numeros pares: {pares} y Numeros impares: {impares}");

        }
        public static void  Ejercicio4() 
        {
            int[] numeros = new int[11];
            int suma = 0;
            int media;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Introduce el numero {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                suma += numeros[i];
            }
            media = suma / numeros.Length;
            Array.Sort(numeros);

            Console.WriteLine($"El numero minimo es: {numeros[0]}");
            Console.WriteLine($"El numero maximo es: {numeros[numeros.Length-1]}");
            Console.WriteLine($"La mediana es: {numeros[numeros.Length/2]}");
            Console.WriteLine($"La media es: {media}");

        }

        public static void Ejercicio5()
        {
            string nombre = "";
            Console.WriteLine("Introduce tu nombre: ");
            nombre = Console.ReadLine();

            for (int i=0;i<nombre.Length;i++) 
            {
                for (int j=0;j<=i;j++) 
                {
                    Console.Write($"{nombre[j]}");
                }
                Console.WriteLine("");
            }


        }

        public static void Ejercicio6()
        {
            const int MAXIMO = 10;
            char [,] tablero = new char[MAXIMO, MAXIMO];
            Random r = new Random();
            int coordenadaI, coordenadaJ;
            int barcos = 0;


            tablero[2, 3] = 'a';

            for (int i =0;i<MAXIMO;i++) 
            {
                for (int j = 0;j<MAXIMO;j++)
                {
                    tablero[i,j] = 'a';
                }
            }

            while (barcos < 10)
            {
                coordenadaI = r.Next(0, MAXIMO);
                coordenadaJ = r.Next(0, MAXIMO);

                if (tablero[coordenadaI,coordenadaJ] == 'a')
                {
                    tablero[coordenadaI, coordenadaJ] = 'b';
                    barcos++;
                }

            }

            for (int i=0;i<MAXIMO;i++) 
            {
                for (int j=0;j<MAXIMO;j++)
                {
                    Console.Write($"{tablero[i,j]} ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Introduce coordenada I");
            coordenadaI = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce coordenada J");
            coordenadaJ = Convert.ToInt32(Console.ReadLine());

            if (tablero[coordenadaI-1, coordenadaJ-1] == 'a')
            {
                Console.WriteLine("Agua");
            }
            else
            {
                Console.WriteLine("Hundido");
            }

        }

        public static void Ejercicio1Array() 
        {
            string [] nombres = new string [10];
            //int posicion = 0;
            string nombre = "";
            bool encontrado = false;

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Introduce un nombre");
                nombre = Console.ReadLine();

                for (int j=0;j <i && !encontrado;j++) 
                {
                    if (nombre == nombres[j])
                    {
                        encontrado = true;
                        Console.WriteLine($"El nombre {nombre} ya existe");
                    }
                }
                if (encontrado == true)
                {
                    i--;
                }
                else 
                {
                    nombres[i] = nombre;
                }
                encontrado = false;
            }



            //while (posicion <nombres.Length && encontrado)
            //{
            //    Console.WriteLine("Introduce un nombre");
            //    nombres[posicion] = Console.ReadLine();

            //    if (nombres[posicion] == nombre)
            //    {
            //        nombres[posicion] = nombre;
            //        posicion++;
            //    }
            //}



        }

        public static void Ejerciocio2Array()
        {
            string nombre;
            int numVocales = 0;
            Console.WriteLine("Escribe un nombre");
            nombre = Console.ReadLine();
            nombre = nombre.ToLower();

            for (int i=0;i<nombre.Length;i++) 
            {
               if(nombre[i] == 'a' || nombre[i] == 'a' || nombre[i] == 'e' || nombre[i] == 'i' || nombre[i] == 'o'  || nombre[i] == 'u') 
                {
                    numVocales++;
                }
            }
            Console.WriteLine($"El la palabra {nombre} hay {numVocales} vocales ");
        }

        public static void Ejercicio4Array()
        {
            string[] nombres = { "Sara", "Eduardo", "Emilio", "Carmen" };
            double[,] notas = { { 5, 7, 5.4, 2.75 }, {6.4,5.1,2.4,7.21 } ,{9.42,9.75,9.58,9.89 }, {8.12,5.32,4.42,1.15 } };

            for (int i =0;i<nombres.Length;i++) 
            {
                double media = 0;
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    media += notas[i,j];
                }
                Console.WriteLine($"La media de {nombres[i]} es {media/notas.GetLength(1):F2}");
            }

        }

        public static void Ejercicio4Escalonado() 
        {
            string[] nombres = {"Sara", "Eduardo","Emilio","Carmen" };
            double[][] notasE = {
            new double [] {5,7,5.4,2.75 },
            new double [] { 6.4, 5.1, 2.4, 7.21 },
            new double[] { 9.42, 9.75, 9.58, 9.89 },
            new double[] { 8.12, 5.32, 4.42, 1.15 }
            };


            for (int iE = 0; iE < notasE.Length; iE++) 
            {
                double media = 0;

                for(int jE=0;jE<notasE[iE].Length;jE++)
                {
                    media += notasE[iE][jE];
                }
                Console.WriteLine($"La media escalonada de {nombres[iE]} es {media / notasE[iE].GetLength(1):F2}");
            }
            
        }

        public static void Ejercicio5Array()
        {


            string[] nombres;
            double[,] notas;
            int alumnos = 0, numNotas ;

            Console.WriteLine("¿Cuantos alumnos vas a introducir?");
            alumnos = Convert.ToInt32(Console.Read());
           
            
            nombres = new string[alumnos];
            Console.WriteLine("¿Cuantas notas vas a introducir?");
            numNotas = Convert.ToInt32(Console.Read());
            notas = new double[alumnos,numNotas];

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Introduce el nombre del alumno");
                nombres[i] = Console.ReadLine();
                for (int j = 0; j < notas.GetLength(1); j++)

                {
                    Console.WriteLine($"Introduce las notas del alumno{j+1}");
                    notas[i, j] = Convert.ToDouble(Console.ReadLine());

                }


            }
            for (int i = 0; i < nombres.Length; i++)
            {
                double media = 0;
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    media += notas[i, j];
                }
                Console.WriteLine($"La media de {nombres[i]} es {media / notas.GetLength(1):F2}");
            }

        }

        public static void Ejercicio6Array() 
        {
            
            string[,] productos = {
                                {"Mesa", "99,50", "3" },
                                {"Silla", "14,95", "4" },
                                {"Armario","200", "5" }
                                };
            double precio = 0;
            int cantidad = 0;

            Console.WriteLine($"{"NOMBRE",-15}{"PRECIO",8}{"CANTIDAD",8}{"TOTAL",8}");
            Console.WriteLine("---------------------------------------------");
            for (int i=0;i<productos.GetLength(0);i++) 
            {
                precio = Convert.ToDouble(productos[i,1]);
                cantidad = Convert.ToInt32(productos[i,2]);

                Console.WriteLine($"{productos[i,0],10}{productos[i,1],10}{productos[i,2],10}{precio*cantidad,10}");

            }
        }

        public static void Ejercicio6Escalonada() 
        {
            string[][] productos =
            {
                new string[] {"Mesa","99,50","3","10" },
                new string[] { "Silla", "14,95","4"},
                new string[] { "Armario","200","5","50"}
            };
            double precio = 0;
            int cantidad = 0;

            Console.WriteLine($"{"NOMBRE",-15}{"PRECIO",8}{"CANTIDAD",8}{"TOTAL",8}{"OFERTA",8}");
            Console.WriteLine("---------------------------------------------");

            for (int iE=0;iE<productos.Length;iE++) 
            {
                    precio = Convert.ToDouble(productos[iE][1]);
                    cantidad = Convert.ToInt32(productos[iE][2]);

                if (productos[iE].Length == 3)
                {
                    Console.WriteLine($"{productos[iE][0]}{productos[iE][1],10}{productos[iE][2],10}{precio * cantidad,10}");
                }
                else
                {
                    Console.WriteLine($"{productos[iE][0]}{productos[iE][1],10}{productos[iE][2],10}{precio * cantidad,10}{productos}");
                }
            }
        }

        public static void GestionArrays() 
        {
            
            int dimension = 0;
            Console.WriteLine("Introduce el tamaño de la matriz");
            dimension = Convert.ToInt32(Console.ReadLine());

            int[][] matriz = new int [dimension][];

            for (int i=0;i<matriz.Length;i++) 
            {
                matriz[i] = new int[dimension];
            }
            Random rnd = new Random();
            int valorDiagonal=0;
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j=0; j <matriz[i].Length; j++) 
                {
                    
                    matriz[i][j] = rnd.Next(0,9);
                    Console.Write($"[{matriz[i][j]}]");
                    if (i==j)
                    {
                        valorDiagonal += matriz[i][j];
                     }

                    Console.Write("");
                }
                Console.WriteLine($"La diagonal vale {valorDiagonal}");
            }


        }

        public static void Ejercicio7Array() 
        {
            string[,] productos;
            double precio = 0;
            int cantidad = 0;
            int numProductos=0;
            Console.WriteLine("Cuantos productos vas a introducir");
            numProductos = Convert.ToInt32(Console.ReadLine());

            productos = new string[numProductos,3];
            for (int i = 0; i < productos.GetLength(0); i++)
            {
                Console.WriteLine($"Introduce el nombre: {i+1}");
                productos[i,0] = Console.ReadLine();
                Console.WriteLine($"Introduce el precio: {i+1}");
                productos[i,1]= Console.ReadLine();
                Console.WriteLine($"Introduce la cantidad: {i+1}");
                productos[i, 2] = Console.ReadLine();
            }

            Console.WriteLine($"{"NOMBRE",-15}{"PRECIO",8}{"CANTIDAD",8}{"TOTAL",8}");
            Console.WriteLine("---------------------------------------------");
            for (int i = 0; i < productos.GetLength(0); i++)
            {
                precio = Convert.ToDouble(productos[i, 1]);
                cantidad = Convert.ToInt32(productos[i, 2]);

                Console.WriteLine($"{productos[i, 0],10}{productos[i, 1],10}{productos[i, 2],10}{precio * cantidad,10}");

            }
        }

        static void Main(string[] args)
        {
            //int suma = 0;
            //if (args.Length == 2)
            //{
            //    suma = Convert.ToInt32(args[0]) + Convert.ToInt32(args[1]);
            //    Console.WriteLine($"El resultado es:  {suma}");
            //}
            //else
            //{
            //    Console.WriteLine("Error el programa necesita 2 parámetros");
            //}
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio3();
            //Ejercicio4();
            //Ejercicio5();
            //Ejercicio6();
            //Ejercicio4Array();
            //Ejercicio5Array();
            //Ejercicio6Array();
            //Ejercicio7Array();
            //Ejercicio6Escalonada();
            GestionArrays();
        }


        
    }
}
