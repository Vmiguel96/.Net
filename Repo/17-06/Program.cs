using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _17_06
{
    class Program
    {
        public static void Prueba()
        {
            //Persona persona1 = new Persona();
            //Persona persona2 = new Persona("Mari Chelo",22);
            //Persona persona3 = new Persona(persona1);
            //persona1.Saluda();
            //persona2.Saluda();

            ////persona1.SetEdad(26);
            //;
            //persona1.Saluda();
            //persona2.Edad = 25;
            //persona3.Edad = 33;
            //persona2.Saluda();
            //persona1.Saluda();
            //persona3.Saluda();
            //if (persona1.Edad > persona2.Edad)
            //{
            //    Console.WriteLine($"{persona1.GetNombre()} es mayor que {persona2.GetNombre()}");
            //}
            //if (persona1.GetEdad() > persona2.GetEdad()) 
            //{
            //    Console.WriteLine($"{persona1.GetNombre()} es mayor que {persona2.GetNombre()}");
            //}
        }

        public static void EscribirBinario()
        {
            string archivo = "AppSettings.dat";
            using (BinaryWriter writer = new BinaryWriter(File.Open(archivo, FileMode.OpenOrCreate)))
            {
                writer.Write(1.2000);
                writer.Write("MI CARRO ME LO ROBARON");
                writer.Write(true);
                writer.Write(1234);
            }
        }

        public static void LeerBinario()
        {
            string archivo = "AppSettings.dat";
            double a1;
            string a2;
            bool a3;
            int a4;

            using (BinaryReader lector = new BinaryReader(File.Open(archivo, FileMode.Open)))
            {
                a1 = lector.ReadDouble();
                a2 = lector.ReadString();
                a3 = lector.ReadBoolean();
                a4 = lector.ReadInt32();
            }
            Console.WriteLine($"{a1}-{a2}-{a3}-{a4}");
        }

        public static void LeerAleatorio()
        {
            try
            {
                FileStream fichero = File.OpenRead("H.exe");
                if (fichero.Length > 30)
                {
                    fichero.Seek(19, SeekOrigin.Begin);
                    int nuevoDato = fichero.ReadByte();
                    Console.WriteLine("El byte 20 es un {0}", nuevoDato);
                    Console.WriteLine("La posicion actual es {0}", fichero.Position);
                    nuevoDato = fichero.ReadByte();
                    Console.WriteLine("");
                }
                fichero.Close();
            }
            catch (Exception)
            {

            }
        }


        public static void LeerMP3()
        {
            const int TAG = 3;
            const int TITULO = 30;
            const int ARTISTA = 30;
            const int ALBUM = 30;
            const int ANYO = 4;
            const int COMENTARIO = 30;
            const int GENERO = 1;

            byte[] tag = new byte[TAG];
            byte[] titulo = new byte[TITULO];
            byte[] artista = new byte[ARTISTA];
            byte[] album = new byte[ALBUM];
            byte[] anyo = new byte[ANYO];
            byte[] comentario = new byte[COMENTARIO];
            byte[] genero = new byte[GENERO];

            string archivoMp3 = "input.mp3";
            using (FileStream archivo = File.OpenRead(archivoMp3))
            {
                archivo.Seek(-128, SeekOrigin.End);
                archivo.Read(tag, 0, TAG);
                archivo.Read(titulo, 0, TITULO);
                archivo.Read(artista, 0, ARTISTA);
                archivo.Read(album, 0, ALBUM);
                archivo.Read(anyo, 0, ANYO);
                archivo.Read(comentario, 0, COMENTARIO);
                archivo.Read(genero, 0, GENERO);
            }

            Console.WriteLine($"{Encoding.Default.GetString(tag)}");
            Console.WriteLine($"{Encoding.Default.GetString(titulo)}");
            Console.WriteLine($"{Encoding.Default.GetString(artista)}");
            Console.WriteLine($"{Encoding.Default.GetString(album)}");
            Console.WriteLine($"{Encoding.Default.GetString(anyo)}");
            Console.WriteLine($"{Encoding.Default.GetString(comentario)}");
            int generoNumero = genero[0];
            Console.WriteLine($"{generoNumero}");

        }

        public static void LeerBMP()
        {
            const int ALTO = 4;
            const int ANCHO = 4;

            byte[] alto = new byte[ALTO];
            byte[] ancho = new byte[ANCHO];

            string archivoBmp = "logo.bmp";
            using (FileStream archivo = File.OpenRead(archivoBmp))
            {
                archivo.Seek(18, SeekOrigin.Begin);
                archivo.Read(alto, 0, ALTO);
                archivo.Read(ancho, 0, ANCHO);
            }

            int altoN = alto[0] + alto[1] * 256 + alto[2] * (256 * 256) + alto[3] * (256 * 256 * 256);
            int anchoN = ancho[0] + ancho[1] * 256 + ancho[2] * (256 * 256) + ancho[3] * (256 * 256 * 256);
            Console.WriteLine($"{altoN}x{anchoN}");

        }

        public static void Menu()
        {
            Console.WriteLine("1. Contrata empleado");
            Console.WriteLine("2. Despedir empleado");
            Console.WriteLine("3. Listar empleado");
            Console.WriteLine("4. Buscar empleado");
            Console.WriteLine("5. Existe empleado");
            Console.WriteLine("6.Salir");

        }

        public static Persona CreaEmpleado()
        {
            Persona empleado = new Persona();
            Console.WriteLine("Nombre");
            empleado.SetNombre(Console.ReadLine());
            Console.WriteLine("Edad");
            empleado.Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dni");
            empleado.Dni = Console.ReadLine();
            return empleado;
        }

        public static void Despedir(Empresa empresa) 
        {
            string dato="";
            int posicion=0;
            Console.WriteLine("Introduzca Dni o Enter para pedir posición");
            if (dato == "")
            {
                Console.WriteLine("Introduzca posicion");
                posicion = Convert.ToInt32(Console.ReadLine())-1;
                empresa.DespideEmpleadoPosicion(posicion);
            }
            else 
            {
                empresa.DespideEmpleadoDni(dato);
            }
        }

        public static void Buscar(Empresa empresa)
        {
            string nombre;
            Console.WriteLine("Nombre a buscar");
            nombre = Console.ReadLine();
            empresa.Empleados.Find(p => p.GetNombre()==nombre);
        }



        static void Main(string[] args)
        {

            List<Persona> personas = new List<Persona>();
            List<Persona> mayores;

            personas.Add(new Persona("Jose", 14, "11111"));
            personas.Add(new Persona("Luis", 19, "15121"));
            personas.Add(new Persona("Maria", 12, "14275"));
            personas.Add(new Persona("Natalia", 18, "13427"));
            personas.Add(new Persona("Ramon", 17, "11111"));
            personas.Add(new Persona("Antonio", 20, "11111"));
            personas.Add(new Persona("Josefa", 29, "11111"));


            mayores = (from p in personas where p.Edad > 18 select p).ToList();

            foreach (Persona p in mayores) 
            {
                Console.WriteLine(p);
            }
            //Persona[] personas = new Persona[10];
            //for (int i=0;i<personas.Length;i++) 
            //{
            //    personas[i] = new Persona();
            //}
            //personas[0].Edad = 10;
            ////personas[0].Saluda();
            //for (int i=0;i<personas.Length;i++) 
            //{
            //    personas[i].Saluda();
            //}
            //Perro[] perros = new Perro[5];
            //for (int i=0;i<perros.Length;i++) 
            //{
            //    perros[i] = new Perro();
            //}
            //perros[0].SetNombre("Bongo");
            //perros[1].SetNombre("Tiger");
            //perros[1].SetEdad(7);
            //perros[2].SetNombre("Java");
            //for (int i=0;i<perros.Length;i++) 
            //{
            //    perros[i].Ladrar();
            //}
            //PersonaInglesa pI = new PersonaInglesa();
            //pI.Saluda();
            //Persona p1 = new Persona("Raquel",22,"1111");
            //Persona p2 = new Persona("Raquel", 22, "1111");


            //if (pI.Equals(p2))
            //{
            //    Console.WriteLine("Son iguales");
            //}
            //else
            //{
            //    Console.WriteLine("No son iguales");
            //}


            //Perro pe1 = new Perro("Tiger","Pastor",7);
            //Perro pe2 = new Perro("Tiger","Pastor",4);

            //if (pe1.Equals(pe2))
            //{
            //    Console.WriteLine("Son iguales");
            //}
            //else
            //{
            //    Console.WriteLine("No son iguales");
            //}

            //Empresa empresa = new Empresa("Ramon S.L");
            //Console.WriteLine($"He creado la empresa {empresa.Nombre}");
            //Persona empleado = new Persona("Empleado1", 23, "1111");
            //empresa.ContrataEmpleado(empleado);
            //empleado = new Persona("Empleado2", 23, "1112");
            //empresa.ContrataEmpleado(empleado);
            //empleado = new Persona("Empleado3", 23, "1113");
            //empresa.ContrataEmpleado(empleado);
            //empleado = new Persona("Empleado4", 23, "1114");
            //empresa.ContrataEmpleado(empleado);
            //foreach (Persona p in empresa.Empleados) 
            //{
            //    Console.WriteLine(p);
            //}
            //Console.WriteLine("Despido posicion 2");
            //empresa.DespideEmpleadoPosicion(2);
            //foreach (Persona p in empresa.Empleados)
            //{
            //    Console.WriteLine(p);
            //}
            //Console.WriteLine("Despido dni 1111");
            //empresa.DespideEmpleadoDni("1111");
            //foreach (Persona p in empresa.Empleados)
            //{
            //    Console.WriteLine(p);
            //}
            //PerroEnfadado p1 = new PerroEnfadado("","",0);
            //p1.Ladrar();

            //EscribirBinario();
            //LeerBinario();
            //LeerMP3();
            //LeerBMP();



            //Empresa empresa = new Empresa();
            //bool salir= false;
            //string opcion = "";
            //Persona empleado;
            //string dni;

            //empresa.Empleados.AddRange(FileUtils.CargaEmpleados());

            //do
            //{
            //    Menu();
            //    opcion = Console.ReadLine();
            //    switch (opcion)
            //    {
            //        case "1":
            //            empleado = CreaEmpleado();
            //            empresa.ContrataEmpleado(empleado);
            //            break;
            //        case "2":
            //            Despedir(empresa);
            //            break;
            //        case "3":
            //            empresa.ListaEmpleados();
            //            break;
            //        case "4":
            //            Buscar(empresa);
            //            break;
            //        case "5":
            //            Console.WriteLine("Introduce un dni");
            //            dni = Console.ReadLine();
            //            if (empresa.Empleados.Contains(new Persona("", 0, dni)))
            //            {
            //                Console.WriteLine("Sí existe");
            //            }
            //            else 
            //            {
            //                Console.WriteLine("No existe");
            //            } 
            //            break;
            //        case "6":
            //            salir = true;
            //            FileUtils.GuardarEmpleados(empresa.Empleados);
            //            break;
            //    }

            //} while (!salir);
        }
    }
}
