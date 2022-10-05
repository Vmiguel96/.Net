using System;
using System.Collections.Generic;
using System.Text;

namespace _23_06
{
   public abstract class Vehiculo:IComparable<Vehiculo>
    {
       protected string marca;
       protected string modelo;
       protected string potencia;
       protected int ruedas;
       protected int peso;
       protected string color;



        protected Vehiculo(string marca, string modelo, string potencia, int ruedas, int peso, string color)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.potencia = potencia;
            this.ruedas = ruedas;
            this.peso = peso;
            this.color = color;
        }

        protected Vehiculo()
        {

        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Potencia { get => potencia; set => potencia = value; }
        public int Ruedas { get => ruedas; set => ruedas = value; }
        public int Peso { get => peso; set => peso = value; }
        public string Color { get => color; set => color = value; }

        public abstract void Acelerar();
        public abstract void Frenar(); 
        

        

        public override string ToString()
        {
            return marca+" "+modelo+" "+potencia+" ";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Vehiculo)) return false;
            Vehiculo v = (Vehiculo)obj;
            return marca == v.marca && modelo == v.modelo;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(marca, modelo);
        }

        public int CompareTo(Vehiculo v) 
        {
            return marca.CompareTo(v.marca);
        }
    }
}
