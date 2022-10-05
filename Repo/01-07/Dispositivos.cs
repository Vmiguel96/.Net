using System;
using System.Collections.Generic;
using System.Text;

namespace _01_07
{
   public abstract class Dispositivos
    {
       protected int velocidad;
       protected double pantalla;

        public int Velocidad { get => velocidad; set => velocidad = value; }
        public double Pantalla { get => pantalla; set => pantalla = value; }

        public Dispositivos(int velocidad, double pantalla)
        {
            this.velocidad = velocidad;
            this.pantalla = pantalla;
        }

        public Dispositivos() : this(0, 0)
        {

        }

        public abstract void Conectar();
    }
}
