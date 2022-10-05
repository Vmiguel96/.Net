using System;
using System.Collections.Generic;
using System.Text;

namespace _17_06
{
    public class Empresa
    {
        string nombre;
        List<Persona> empleados;

        public Empresa(string nombre)
        {
            this.nombre = nombre;
            this.empleados = new List<Persona>();
        }
        public Empresa():this("")
        {

        }

        public void ContrataEmpleado(Persona p) 
        {
            empleados.Add(p) ; 
        }

        public void DespideEmpleadoPosicion(int posicion)
        {
            empleados.RemoveAt(posicion) ;
        }

        public void DespideEmpleadoDni(string dni)
        {
            empleados.Remove(new Persona("", 0, dni));
        }

        public void ListaEmpleados() 
        {
            foreach (Persona p in empleados)
            {
                Console.WriteLine(p);
            }
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Persona> Empleados { get => empleados;}
    }
}
