using System;
using System.Collections.Generic;
using System.Text;

namespace _17_06
{
    public class Persona
    {
       protected string nombre;
       protected int edad;
        private string dni;

        public int Edad 
        {
            get { return edad; }
            set 
            {
                if (value>0)
                {

                    edad = value;
                }
            }
        }

        public string Dni { get => dni; set => dni = value; }

        public Persona()
        {
            nombre = "John Doe";
            edad = 18;
            dni = "";
        }

        public Persona(string nombre, int edad, string dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }

        public Persona(Persona p1)
        {
            this.nombre = p1.nombre;
            this.edad = p1.edad;
            this.dni = p1.dni;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public int GetEdad() 
        {
            return edad;
        }

        public void SetEdad(int nuevaedad) 
        {
            edad = nuevaedad;
        }

        public void SetNombre(string nombre) 
        {
            this.nombre = nombre;
        }

        public virtual void Saluda() 
        {
            Console.WriteLine($"Hola soy {nombre} y tengo {edad} años");
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Persona)) return false;
            Persona p = (Persona)obj;
            return dni == p.dni;
        }

        public override string ToString()
        {
            return dni+ " " +nombre+" ";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(dni);
        }
    }
}
