using System;

namespace Calcula
{
    class Program
    {


        static void Main(string[] args)
        {
            int suma=0, resta =0, multiplica =0 , divide=0;

            if (args.Length != 3)
            {
                Console.WriteLine("Error, No hay valores suficientes");
            }
            else 
            {
                if (args[0] == "suma")
                {
                    suma = Convert.ToInt32(args[1]) + Convert.ToInt32(args[2]);
                    Console.WriteLine($"{suma}");
                }
                else if (args[0] == "resta")
                {
                    resta = Convert.ToInt32(args[1]) - Convert.ToInt32(args[2]);
                    Console.WriteLine($"{resta}");
                }
                else if (args[0] == "multiplica")
                {
                    multiplica = Convert.ToInt32(args[1]) * Convert.ToInt32(args[2]);
                    Console.WriteLine($"{multiplica}");
                }
                else if (args[0] == "divide")
                {
                    if (!(Convert.ToInt32(args[1]) < Convert.ToInt32(args[2])))
                    {
                        divide = Convert.ToInt32(args[1]) / Convert.ToInt32(args[2]);
                        Console.WriteLine($"{divide}");

                    }
                    else 
                    {
                        Console.WriteLine("El divisor el mayor que el numero");
                    }
                }
            }

        }
    }
}
