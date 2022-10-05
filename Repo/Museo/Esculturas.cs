using System;
using System.Collections.Generic;
using System.Text;

namespace Museo
{
    public class Esculturas : ObrasDeArte
    {
        string material;

        public string Material { get => material; set => material = value; }

        public Esculturas(Autor autor, string propiedades, string nombre, int fechaDeCreacion, string material) : base(autor,propiedades,nombre,fechaDeCreacion)
        {
            this.material = material;
        }

    public Esculturas() : this(new Autor(), "", "", 0, "")
    
        {

        }
       public override string ToString()
        {
            return $"Nombre: {nombre} Autor: {autor.ToString()}";
        }

    }
}
