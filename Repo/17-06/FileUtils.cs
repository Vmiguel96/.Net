using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _17_06
{
    class FileUtils
    {
        public static List<Persona> CargaEmpleados()
        {
            string linea;
            string[] trozos;
            Persona empleado;
            List<Persona> empleados = new List<Persona>();
            if (File.Exists("empleados.txt"))
            {
                try
                {
                    StreamReader reader = new StreamReader("empleados.txt", true);
                    while ((linea = reader.ReadLine()) != null) 
                    {
                        trozos = linea.Split(';');
                        empleado = new Persona();
                        empleado.SetNombre(trozos[0]);
                        empleado.Edad = Convert.ToInt32(trozos[1]);
                        empleado.Dni = trozos[2];
                        empleados.Add(empleado);
                        
                    }
                }
                catch(IOException) 
                {
                    Console.WriteLine("Error en el fichero de empleados");
                }

            }
            else 
            {

            }
                return empleados;
        }

        public static void GuardarEmpleados(List<Persona> empleados)
        {
            string linea;
            try
            {
                StreamWriter writer = new StreamWriter("empleados.txt");
                foreach (Persona p in empleados)
                {
                    linea = p.GetNombre() + ";" + p.Edad + ";" + p.Dni;
                    writer.WriteLine(linea);
                }
                writer.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("Error en el fichero");
            }
        }
    }
}
