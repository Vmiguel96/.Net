using System;
using System.Collections.Generic;

namespace _01_07
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dispositivos> misDispositivos = new List<Dispositivos>();
            misDispositivos.Add(new Ordenadores(2056, 17));
            misDispositivos.Add(new Tablets(1044, 10));
            misDispositivos.Add(new Smartphones(2056, 7.4));
            misDispositivos.Add(new Ordenadores(16800, 42));
            misDispositivos.Add(new Smartphones(2056, 6.2));

            foreach (Dispositivos d in misDispositivos) 
            {
                Console.WriteLine(d);
                d.Conectar();
            }
            





            //Tablets tablet = new Tablets(1024,7.8);
            //Ordenadores ordenador = new Ordenadores(4094,27.2);
            //Smartphones smartphone = new Smartphones(2048,6.2);
            //tablet.Conectar();
            //ordenador.Conectar();
            //smartphone.Conectar();
            //Console.WriteLine($"{tablet} {ordenador} {smartphone}");
        }
    }
}
