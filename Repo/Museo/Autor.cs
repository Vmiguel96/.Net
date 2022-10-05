using System;
using System.Collections.Generic;
using System.Text;

namespace Museo
{
   public class Autor : ObrasDeArte
    {
        string nombreObra;

        public string NombreObra { get => nombreObra; set => nombreObra = value; }


        public Autor(string nombreObra)
        {
            this.nombreObra = nombreObra;
        }
        public Autor():this("anónimo")
        {
            
        }
        public override string ToString()
        {
            return "Autor:"+nombreObra;
        }
    }
}
