using System;
using System.Collections.Generic;

namespace Museo
{
    class Program
    {
        static void Main(string[] args)

        {
            //string opcion;
            //string autor="";
            //string propiedades;
            //string nombre;
            //int fechaCreacion;
            //string material;

            Autor autor = new Autor("autor1");


            List<ObrasDeArte> obras = new List<ObrasDeArte>();
            obras.Add(new Pinturas(autor, "pro", "obra1", 2000));
            obras.Add(new Esculturas(autor, "aa", "obra2", 2000, "marmol"));
            //obras[0].Equals(obras[1]);
            foreach (ObrasDeArte o in obras)
            {
                Console.WriteLine(o);
            }
            obras.Sort();
            foreach (ObrasDeArte o in obras)
            {
                Console.WriteLine(o);
            }

            //ObrasDeArte[] miObra = new ObrasDeArte[1];


            //for (int i=0;i<miObra.Length;i++) 
            //{
            //    Console.WriteLine("Pintura o Escultura");
            //    opcion = Console.ReadLine();

            //    if (opcion.ToLower() == "pintura")
            //    {
            //        Console.WriteLine("Introduce el nombre del Autor");
            //        autor = Console.ReadLine();

            //        Console.WriteLine("Introduce el nombre del Propiedades");
            //        propiedades = Console.ReadLine();
            //        Console.WriteLine("Introduce el nombre de la Obra");
            //        nombre = Console.ReadLine();
            //        Console.WriteLine("Introduce la Fecha de creación");
            //        fechaCreacion = Convert.ToInt32(Console.ReadLine());
            //        Autor miAutor = new Autor(autor);
            //        miObra[i] = new Pinturas(miAutor,propiedades,nombre,fechaCreacion);


            //    }

            //    else if (opcion.ToLower()== "escultura")
            //    {
            //        Console.WriteLine("Introduce el nombre del Autor");
            //        autor = Console.ReadLine();

            //        Console.WriteLine("Introduce el nombre del Propiedades");
            //        propiedades = Console.ReadLine();
            //        Console.WriteLine("Introduce el nombre de la Obra");
            //        nombre = Console.ReadLine();
            //        Console.WriteLine("Introduce la Fecha de creación");
            //        fechaCreacion = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Introduce el tipo de material");
            //        material = Console.ReadLine();
            //        Autor miAutor = new Autor(autor);
            //        miObra[i] = new Esculturas(miAutor, propiedades, nombre, fechaCreacion,material);
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Datos Incorreptos");
            //    }

        

        //for (int i=0;i<miObra.Length;i++) 
        //{
        //    Console.WriteLine(miObra[i]);
        //}
      
        }
    }
}
