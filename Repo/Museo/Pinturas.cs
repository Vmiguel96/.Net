using System;
using System.Collections.Generic;
using System.Text;

namespace Museo
{
    public class Pinturas : ObrasDeArte
    {
        public Pinturas():this(new Autor(),"","",0) 
        {

        }

        public Pinturas(Autor autor, string propiedades, string nombre, int fechaDeCreacion):base(autor,propiedades,nombre,fechaDeCreacion)
        {

        }
    }
}
