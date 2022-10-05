using System;
using System.Collections.Generic;
using System.Text;

namespace _17_06
{
    public class PersonaInglesa:Persona
    {
        public override void Saluda() 
        {
            Console.WriteLine($"Hello my name is {GetNombre()} and I´m {GetEdad()} years old");
        }
    }
}
