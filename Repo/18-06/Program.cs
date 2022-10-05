using System;

namespace _18_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Ventana[] ventanas = new Ventana[10];
            Random r = new Random();

            for (int i = 0; i < ventanas.Length; i++) 
            {
                int dataAltura = r.Next(40,101);
                int dataAnchura = r.Next(90,121);
                ventanas[i] = new Ventana();
                ventanas[i].SetAltura(dataAltura);
                ventanas[i].SetAnchura(dataAnchura);
            }

            for (int i = 0; i < ventanas.Length; i++)
            {
                ventanas[i].Mostrar();
            }

            NumeroComplejo n = new NumeroComplejo(2,-5);
            NumeroComplejo n1 = new NumeroComplejo(2, -5);
            NumeroComplejo n2 = new NumeroComplejo(2, -5);
            Console.WriteLine(n.GetMagnitud());
            Console.WriteLine(n.ToString());

            NumeroComplejo n3 = NumeroComplejo.Suma(n1,n2);

            NumeroComplejo[] numerosConplejos = new NumeroComplejo[10];
            for (int i = 0; i < numerosConplejos.Length; i++)
            {
                numerosConplejos[i] = new NumeroComplejo();
            }
            numerosConplejos[0].SetReal(5);
            numerosConplejos[0].SetImaginaria(7);

            for (int i = 0; i < ventanas.Length; i++)
            {
               Console.WriteLine(numerosConplejos[i].GetMagnitud());
            }
        }
    }
}
