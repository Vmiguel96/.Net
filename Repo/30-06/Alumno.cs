using System;
using System.Collections.Generic;
using System.Text;

namespace _30_06
{


    public class Alumno : Persona
    {
        Dictionary<string, double> notas;

        public Alumno(string nombre, int edad, string dni) : base(nombre, edad, dni)
        {
            notas = new Dictionary<string, double>();
        }

        public Alumno() : this("", 0, "")
        {

        }

        public void AddNota(string asignatura, double nota)
        {
            notas.Add(asignatura, nota);
        }

        public double Media() 
        {
            double notaFinal=0;
            foreach(KeyValuePair<string,double> nota in notas) 
            {
                notaFinal += nota.Value;
            }
            return notaFinal / notas.Count;
        }

        public double Nota(string asignatura) 
        {
            return notas.GetValueOrDefault(asignatura, 0);
        }

        public void MostrarNotas() 
        {
            foreach (KeyValuePair<string, double> nota in notas)
            {
                Console.WriteLine($"{nota.Key} {nota.Value}");
            }
        }




    }
}
