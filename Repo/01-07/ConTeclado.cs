using System;
using System.Collections.Generic;
using System.Text;

namespace _01_07
{
  public abstract class ConTeclado:Dispositivos
    {
        public ConTeclado(int velocidad, double pantalla):base (velocidad,pantalla) 
        {
        }
    }
}
