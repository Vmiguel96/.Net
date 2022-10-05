using System;

namespace TallerDeReparaciones
{
    class Program
    {
        public static void Menu() 
        {
            Console.WriteLine("1. Entrega de vehiculo");
            Console.WriteLine("2. Añadir Operación");
            Console.WriteLine("3. Recoger Vehiculo");
            Console.WriteLine("4. Listado de reparaciones pendientes");
            Console.WriteLine("5. Salir");
            Console.WriteLine();
            Console.WriteLine("Introduzca opcion");
        }

        public static Vehiculo CreaVehiculo() 
        {
            string matricula;
            string marca;
            string modelo;
            string propietario;
            Console.Write("Introduzca Matricula: ");
            matricula = Console.ReadLine();
            Console.Write("Introduzca Marca: ");
            marca = Console.ReadLine();
            Console.Write("Introduzca Modelo: ");
            modelo = Console.ReadLine();
            Console.Write("Introduzca Propietario: ");
            propietario = Console.ReadLine();

            return new Vehiculo(matricula,marca,modelo,propietario);
        }

        public static void Reparar(Taller taller) 
        {
            string matricula;
            string accion;
            double precio;
            Console.Write("Matricula: ");
            matricula = Console.ReadLine();
            Console.Write("Operacion realizada: ");
            accion = Console.ReadLine();
            Console.Write("Precio: ");
            precio = Convert.ToInt32(Console.ReadLine());
            taller.Reparar(matricula,accion,precio);
        }

        public static void RecogerVehiculo(Taller taller) 
        {
            string matricula;
            Console.Write("Matricula: ");
            matricula = Console.ReadLine();
            Console.WriteLine();
           Console.WriteLine(taller.TerminarReparacion(matricula));
        }
        static void Main(string[] args)
        {
            Taller taller= new Taller();
            taller.CargarReparacion();
            //Reparacion.CargaVehiculos();
            //Reparacion.CargaAcciones();

            bool salir = false;
            string opcion="";
            string averia;
            do
            {
                Menu();
                opcion = Console.ReadLine();
                switch (opcion) 
                {
                    case "1":
                        
                        Console.WriteLine("Introduzca la averia");
                        averia = Console.ReadLine();
                        taller.AñadirReparacion(new Reparacion(CreaVehiculo(),averia));
                        break;
                    case "2":
                        Reparar(taller);
                        break;
                    case "3":
                        RecogerVehiculo(taller);
                        break;
                    case "4":
                        taller.ListaReparaciones();
                        break;

                    case "5":
                        salir = true;
                        taller.GuardarReparaciones();
                       // Reparacion.GuardarVehiculo(Reparacion.CargaVehiculos());
                       // Reparacion.GuardarAcciones(Reparacion.CargaAcciones());
                        break;
                }
            } while (!salir);
        }
    }
}
