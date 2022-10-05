using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TallerDeReparaciones
{
   public class Taller
    {
        Dictionary<string,Reparacion> reparaciones;

        public Taller() 
        {
            reparaciones = new Dictionary<string, Reparacion>();
        }
        public void AñadirReparacion(Reparacion r) 
        {
            if (!reparaciones.ContainsKey(r.Vehiculo.Matricula))
            {
                reparaciones.Add(r.Vehiculo.Matricula, r);
            }
            else 
            {
                Console.WriteLine("El vehiculo ya esta en el taller");
            }
        }
        public double TerminarReparacion(string matricula) 
        {
            double precio=0;
            if (reparaciones.ContainsKey(matricula))
            {
                precio = reparaciones[matricula].Precio;
                reparaciones.Remove(matricula);
            }
            return precio;
        }
        public void Reparar(string matricula, string accion,double precio) 
        {
            if (reparaciones.ContainsKey(matricula)) 
            {
                reparaciones[matricula].AddAccion(accion);
                reparaciones[matricula].ListaAcciones();
                reparaciones[matricula].ActualizaPrecio(precio);
            }
        }

        public void ListaReparaciones()
        {
            foreach (KeyValuePair<string,Reparacion> pareja in reparaciones)
            {
                Console.WriteLine(pareja.Value);
            }
        }


        public void GuardarReparaciones() 
        {
            StreamWriter writer = new StreamWriter("reparaciones.txt");
            foreach (KeyValuePair<string,Reparacion>  r in reparaciones)
            {
                writer.Write(r.Value.Vehiculo);
                writer.Write($";{r.Value.Problema};{r.Value.Precio}");
                foreach (string s in r.Value.Acciones) 
                {
                    writer.Write($";{s}");
                }
                writer.WriteLine();
                
            }
            writer.Close();
        }

        public void CargarReparacion() 
        { 
                string linea;
                string[] trozos;
                Vehiculo vehiculo;
                Reparacion rep;

            if (File.Exists("reparaciones.txt")) 
            {

                StreamReader lector = new StreamReader("reparaciones.txt");

                while ((linea = lector.ReadLine()) != null) 
                {
                    trozos = linea.Split(';');
                    vehiculo = new Vehiculo(trozos[0],trozos[3],trozos[1],trozos[2]);
                    rep = new Reparacion(vehiculo, trozos[4]);
                    rep.Precio = Convert.ToDouble(trozos[5]);
                    for (int i=6;i<trozos.Length;i++) 
                    {
                        rep.AddAccion(trozos[i]);
                    }
                    reparaciones.Add(trozos[0],rep);
                }
                lector.Close();
            }
        }
    }
}
