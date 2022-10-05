using System;
using System.Collections.Generic;
using System.Text;

namespace _17_06
{
    public class PerroEnfadado:Perro
    {
        public PerroEnfadado(string nombre, string raza, int edad) : base(nombre, raza, edad) 
        {

        }
        public PerroEnfadado() : base() 
        {

        }
        public override void Ladrar()
        {
            Console.WriteLine($"{GetNombre()} tiene {GetEdad()} años: ¡Ruaaaaa! ");
        }
    }
}
