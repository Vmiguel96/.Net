using System;
using System.Collections.Generic;
using System.Text;

namespace _23_06
{
    class Camion:Vehiculo
    {

        public Camion():base()
        {
        }

        public Camion(string marca, string modelo, string potencia, int ruedas, int peso, string color) : base(marca, modelo, potencia, ruedas, peso, color)
        {
            //ruedas =PedirRuedas();
        }

        //public int PedirRuedas() 
        //{
        //    Console.WriteLine("Cuantas Ruedas tiene el camión");
        //    int ruedasCamion = Convert.ToInt32(Console.ReadLine());
        //    return ruedasCamion;
        //}

        public override void Frenar()
        {
            Console.WriteLine("Camion frenando");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Camion acelerando");
        }

    }
}
