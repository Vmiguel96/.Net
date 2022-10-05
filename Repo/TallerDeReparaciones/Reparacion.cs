using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace TallerDeReparaciones
{
    public class Reparacion
    {
        Vehiculo vehiculo;
        string averia;
        List<string> acciones;
        double precio;

        public static List<Vehiculo> CargaVehiculos()
        {
            string linea;
            string[] trozos;
            Vehiculo vehiculoReparacion;
            List<Vehiculo> vehiculos  = new List<Vehiculo>();

            if (File.Exists("vehiculos.txt"))
            {
                try
                {
                    StreamReader reader = new StreamReader("vehiculos.txt", true);
                    while ((linea = reader.ReadLine()) != null)
                    {
                        trozos = linea.Split(';');
                        vehiculoReparacion = new Vehiculo();
                        vehiculoReparacion.Matricula = trozos[0];
                        vehiculoReparacion.NombreDueño = trozos[1];
                        vehiculoReparacion.Marca = trozos[2];
                        vehiculoReparacion.Modelo = trozos[3];
                        vehiculos.Add(vehiculoReparacion);

                    }
                    reader.Close();
                }
                catch (IOException)
                {
                    Console.WriteLine("Error en el fichero de vehiculos");
                }

            }
            else
            {

            }
            return vehiculos;
        }

        public static void GuardarVehiculo(List<Vehiculo> vehiculosReparacion)
        {
            
            try
            {
                string linea;
                StreamWriter writer = new StreamWriter("vehiculos.txt",true);
                foreach (Vehiculo v in vehiculosReparacion)
                {
                    linea = v.Matricula + ";" + v.NombreDueño + ";" + v.Marca + ";" + v.Modelo;
                    writer.WriteLine(linea);
                }
                writer.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error en el fichero Vehiculo {e.Message}");
            }
            
        }

        public static List<string> CargaAcciones()
        {
            List<string> acciones = new List<string>();

            //Otra opcion si a no es null
            List<string> accionesReparadas = (from a in acciones where a.Contains("") == true select a).ToList();


            return accionesReparadas;
        }


        public static void GuardarAcciones(List<string> accionReparada)
        {
            if (File.Exists("reparaciones.txt"))
            {

                try
                {
                    StreamWriter writer = new StreamWriter("reparaciones.txt", true);

                    for (int i = 0; i > accionReparada.Count; i++)
                    {
                        writer.WriteLine(accionReparada[i]);
                    }

                    writer.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine($"Error en el fichero acciones {e.Message}");
                }
            }
            else { }
        }

        public Reparacion(Vehiculo vehiculo, string problema)
        {
            this.vehiculo = vehiculo;
            this.averia = problema;
            this.precio = 0;
            this.acciones = new List<string>();
        }

        public Reparacion()
        {

        }

        public void ListaAcciones() 
        {
            foreach (string accion in acciones) 
            {
                Console.WriteLine(accion);
            }
        }

        public void AddAccion(string accion)
        {
            acciones.Add(accion);
        }
        public void ActualizaPrecio(double precio) 
        {
            this.precio += precio;
        }

        public override string ToString()
        {
            return $"{vehiculo.Matricula}:{averia}";
        }

        public string Problema { get => averia; set => averia = value; }
        public double Precio { get => precio; set => precio = value; }
        internal Vehiculo Vehiculo { get => vehiculo; set => vehiculo = value; }
        public List<string> Acciones { get => acciones; set => acciones = value; }
    }
}
