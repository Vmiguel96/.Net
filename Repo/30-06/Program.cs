using System;
using System.Collections.Generic;

namespace _30_06
{
    class Program
    {
        public static void MediaAlta(Dictionary<string, Alumno> clase, out string nombre, out double media)
        {
            media = 0;
            nombre = "";

            foreach (KeyValuePair<string, Alumno> alumno in clase)
            {

                if (alumno.Value.Media()>media)
                {
                    media = alumno.Value.Media();
                    nombre = alumno.Value.GetNombre();
                }

            }

        }

        static void Main(string[] args)
        {

            //Dictionary<string, Persona> dni = new Dictionary<string, Persona>();

            //dni.Add("1111", new Persona("Jose", 18, "1111"));
            //dni.Add("2222", new Persona("Laura", 24, "2222"));
            //dni.Add("3333", new Persona("Maria", 30, "3333"));

            //foreach (KeyValuePair<string, Persona> pair in dni)
            //{
            //    System.Console.WriteLine($"Dni:{pair.Key} Valor: {pair.Value}");
            //}
            //if (dni.ContainsKey("1111"))
            //{
            //    Console.WriteLine();
            //    Console.WriteLine(dni["1111"]);
            //}
            //Console.WriteLine(dni.GetValueOrDefault("2222", new Persona()));


            Dictionary<string, Alumno> miClase = new Dictionary<string, Alumno>();


            miClase.Add("1111", new Alumno("Jose", 18, "1111"));
            miClase.Add("2222", new Alumno("Laura", 24, "2222"));
            miClase.Add("3333", new Alumno("Maria", 30, "3333"));
            miClase["1111"].AddNota("Matematicas",10);
            miClase["2222"].AddNota("Lengua", 3);

            miClase["3333"].AddNota("Musica",8);

            Console.WriteLine(miClase["1111"].Media());
            string nombre;
            double nota;
            MediaAlta(miClase,out nombre, out nota);
            Console.WriteLine($"{nombre} {nota}");
        }
    }
}
