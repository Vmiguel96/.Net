using System;
using System.Collections.Generic;
using System.Text;

namespace _17_06
{
    
    public class Perro
    {
        string nombre;
        string raza;
        int edad;
        public string GetNombre()
        {
            return nombre;
        }
        public string GetRaza()
        {
            return raza;
        }
        public int GetEdad() 
        {
            return edad;
        }

        public void SetEdad(int edad) 
        {
            this.edad = edad * 7;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetRaza(string raza) 
        {
            this.raza = raza;
        }
        public Perro() 
        {
            nombre = "";
            raza = "";
        }
        public Perro(string nombre,string raza,int edad) 
        {
            this.nombre = nombre;
            this.raza = raza;
            this.edad = edad;

        }



        public virtual void Ladrar() 
        {
            Console.WriteLine($"{nombre} tiene {edad} años: ¡Guau! ");
        }


        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Perro)) return false;
            Perro p = (Perro)obj;
            return nombre == p.nombre && raza==p.raza;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(nombre, raza);
        }
    }
}
