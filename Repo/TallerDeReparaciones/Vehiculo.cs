using System;
using System.Collections.Generic;
using System.Text;

namespace TallerDeReparaciones
{
   public class Vehiculo
    {
       protected string matricula;
       protected string nombreDueño;
       protected string marca;
       protected string modelo;

        public string Matricula { get => matricula; set => matricula = value; }
        public string NombreDueño { get => nombreDueño; set => nombreDueño = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }

        public Vehiculo(string matricula, string nombreDueño, string marca, string modelo)
        {
            this.matricula = matricula;
            this.nombreDueño = nombreDueño;
            this.marca = marca;
            this.modelo = modelo;
        }

        public Vehiculo() 
        {

        }

        public override string ToString()
        {
            return $"{matricula};{marca};{modelo};{nombreDueño}";
        }

    }
}
