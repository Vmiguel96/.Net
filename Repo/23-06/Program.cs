using System;
using System.Collections.Generic;

namespace _23_06
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigura[] misFiguras = new IFigura[2];

            //misFiguras[0] = new Circulo();
            //misFiguras[1] = new Cuadrado();
            //((Circulo)misFiguras[0]).Radio = 3;
            //((Cuadrado)misFiguras[1]).Lado = 3;
            //for (int i = 0; i < misFiguras.Length; i++)
            //{
            //    Console.WriteLine(misFiguras[i].Area());
            //    Console.WriteLine(misFiguras[i].Perimetro());
            //}

            List<Vehiculo> vehiculos = new List<Vehiculo>();
            vehiculos.Add(new Coche("marca", "modelo", "potencia", 1000, 1000, "color", 5));

            Console.WriteLine(vehiculos.Count);
            vehiculos.Add(new Motocicleta("Alfa", "modelo", "potencia", 1000, 1000, "color"));
            //Vehiculo[] misVehiculos = new Vehiculo[3];
            Console.WriteLine(vehiculos.Count);

            //misVehiculos[0] = new Coche("marca","modelo","potencia",1000,1000,"color", 5);
            //misVehiculos[1] = new Motocicleta("marca", "modelo", "potencia", 1000, 1000, "color");
            //misVehiculos[2] = new Camion("marca","modelo","potencia",12,1000,"color");

            foreach (Vehiculo v in vehiculos)
            {
                v.Acelerar();
                Console.WriteLine(v);
                
            }

            vehiculos.Sort();

            //if (vehiculos.Contains(new Coche("marca", "modelo", "potencia", 1000, 1000, "color", 5)))
            //{
            //    Console.WriteLine("Si esta");
            //}
            //else Console.WriteLine("No esta");

            for (int i = 0; i < vehiculos.Count; i++)
            {

                vehiculos[i].Acelerar();

                Console.WriteLine(vehiculos[i]);
            }
        }
    }
}
