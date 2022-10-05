using System;
using System.Collections.Generic;
using System.Text;

namespace _18_06
{
   public class Ventana
    {
        int anchura;
        int altura;

        public Ventana()
        {
            anchura = 0;
            altura = 0;
        }

        public int GetAnchura() 
        {
            return anchura;
        }
        public int GetAltura() 
        {
            return altura;
        }
        public void SetAnchura(int anchura) 
        {
            this.anchura = anchura;
        }
        public void SetAltura(int altura)
        {
            this.altura = altura;
        }
        public void Mostrar() 
        {
            Console.WriteLine($"Altura: {altura} Anchura {anchura}");
        }
    }
}
