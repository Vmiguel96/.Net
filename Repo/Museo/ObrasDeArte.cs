using System;
using System.Collections.Generic;
using System.Text;

namespace Museo
{
   public class ObrasDeArte:IComparable<ObrasDeArte>
    {
        //protected string autor;
        protected Autor autor;
        protected string propietario;
        protected string nombre;
        protected int fechaDeCreacion;

        public ObrasDeArte(Autor autor, string propiedades, string nombre, int fechaDeCreacion)
        {
            this.autor = autor;
            this.propietario = propiedades;
            this.nombre = nombre;
            this.fechaDeCreacion = fechaDeCreacion;
        }

        public ObrasDeArte() : this(new Autor(), "", "", 0)
        {

        }



        public int FechaDeCreacion { get => fechaDeCreacion; set => fechaDeCreacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Propiedades { get => propietario; set => propietario = value; }
        internal Autor Autor { get => autor; set => autor = value; }


        public override string ToString()
        {
            return $"Nombre: {nombre} Autor: {autor.ToString()}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is ObrasDeArte)) return false;
            ObrasDeArte o = (ObrasDeArte)obj;
            return propietario == o.propietario && nombre == o.nombre;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(propietario, nombre);
        }

        public int CompareTo(ObrasDeArte o) 
        {
            return fechaDeCreacion.CompareTo(o.fechaDeCreacion);

            //if (fechaDeCreacion > o.fechaDeCreacion)
            //    return 1;
            //else
            //    if (fechaDeCreacion == o.fechaDeCreacion)
            //    return 0;
            //else
            //    return -1;

            //if (fechaDeCreacion == o.fechaDeCreacion)
            //{
            //    if (propietario.CompareTo(o.propietario) > 0) ;

            //}
            //else
            //    return fechaDeCreacion.CompareTo(FechaDeCreacion);
        }
    }
}
