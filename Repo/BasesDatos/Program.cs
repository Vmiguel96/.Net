using System;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace BasesDatos
{
    class Program
    {
        public static void EOI() 
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=EOI;Uid=root;password=;";
            MySqlConnection conexion = new MySqlConnection(connectionString);
            MySqlCommand comando = new MySqlCommand();
            MySqlDataReader reader;
            string IdCliente;
            Console.Write("Introduce el codigo del cliente: ");
            IdCliente = Console.ReadLine();
            try
            {
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandText = "select * from clientes where num_clie = ?idCliente";
                comando.Parameters.Add("?idCliente", MySqlDbType.Int32).Value = IdCliente;

                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"{reader.GetInt32("num_clie")} - {reader.GetString(1)} - {reader.GetInt32(2)} - {reader.GetInt32("limite_credito") }");
                }
                reader.Close();

                conexion.Close();
                conexion.Dispose();
                Console.WriteLine("Conexión Correcta");


            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void EOI2() 
        {

            try
            {
                string connectionString = "Server=127.0.0.1;Port=3306;Database=eoi2;Uid=root;password=";
                MySqlConnection conexion = new MySqlConnection(connectionString);
                conexion.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "select * from empleados where num = ?numempleado";
                comando.Parameters.Add("?numempleado", MySqlDbType.Int32).Value = 1000;
                MySqlDataReader r = comando.ExecuteReader();
                while (r.Read())
                {
                    Console.WriteLine($"{r.GetInt32(0)}- {r.GetString(1)}- {r.GetInt32(2)}- {r.GetInt32(3)}-{r.GetInt32(4)}-{r.GetDateTime(5)} ");
                }

                

                r.Close();
                conexion.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static int Borrar()
        {
            int filasAfectadas = 0;
            string connectionString = "Server=127.0.0.1;Port=3306;Database=eoi;Uid=root;password=";
            try
            {
                MySqlConnection conectar = new MySqlConnection(connectionString);
                conectar.Open();
                MySqlCommand comandoDelete = new MySqlCommand();
                comandoDelete.Connection = conectar;
                comandoDelete.CommandText = "DELETE FROM pedidos where num_pedido=?num_pedido";

                comandoDelete.Parameters.Add("?num_pedido", MySqlDbType.Int32).Value = 113069;


                filasAfectadas = comandoDelete.ExecuteNonQuery();
                conectar.Close();
                conectar.Dispose();
            }
            catch (MySqlException m)
            {
                Console.WriteLine($"Se ha producidu un error {m.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Se ha producido un error{e.Message}");
            }

            return filasAfectadas;
        }

        public static int Actualizar() 
        {
            int filasAfectadas = 0;
            string connectionString = "Server=127.0.0.1;Port=3306;Database=eoi;Uid=root;password=";
            try
            {
                MySqlConnection conectar = new MySqlConnection(connectionString);
                conectar.Open();
                MySqlCommand comandoUpdate = new MySqlCommand();
                comandoUpdate.Connection = conectar;
                comandoUpdate.CommandText = "UPDATE productos SET descripcion=?descripcion, precio=?precio,existencias=?existencias WHERE id_fab=?id_fab AND id_producto=?id_producto";

                comandoUpdate.Parameters.Add("?descripcion", MySqlDbType.VarChar).Value = "Sony PlayStation 5";
                comandoUpdate.Parameters.Add("?precio", MySqlDbType.Int32).Value = 499.99;
                comandoUpdate.Parameters.Add("?existencias", MySqlDbType.Int32).Value = 100;
                comandoUpdate.Parameters.Add("?id_fab", MySqlDbType.VarChar).Value = "ACI";
                comandoUpdate.Parameters.Add("?id_producto", MySqlDbType.VarChar).Value = "41001";

                filasAfectadas = comandoUpdate.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    Console.WriteLine($"Actualizacion realizada con exitos {filasAfectadas}");
                }
                else
                {
                    Console.WriteLine($"No se ha podido realizar la actualizacion {filasAfectadas}");
                }
                conectar.Close();
                conectar.Dispose();
            }
            catch (MySqlException m)
            {
                Console.WriteLine($"Se ha producidu un error {m.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Se ha producido un error{e.Message}");
            }

            return filasAfectadas;
        }

        public static int Insertar() 
        {
            
            int filasAfectadas = 0;
            //1 Contruir connectionString
            string connectionString = "Server=127.0.0.1;Port=3306;Database=eoi;Uid=root;password=";
            try
            {
                //2 Crear la conexion
                MySqlConnection conn = new MySqlConnection(connectionString);
                // 3Abrir conexion
                conn.Open();
                // 4 Declarar el comando
                MySqlCommand comandoInsert = new MySqlCommand();
                comandoInsert.Connection = conn;
                comandoInsert.CommandText = "INSERT INTO repventas (num_empl,nombre,edad,oficina_rep,titulo,contrato,director,cuota,ventas)VALUES(?num_empl, ?nombre, ?edad, ?oficina_rep, ?titulo, ?contrato, ?director, ?cuota, ?ventas); ";

                comandoInsert.Parameters.Add("?num_empl", MySqlDbType.Int32).Value = 1111;
                comandoInsert.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = "Alvaro Morata";
                comandoInsert.Parameters.Add("?edad", MySqlDbType.Int32).Value = 29;
                comandoInsert.Parameters.Add("?oficina_rep", MySqlDbType.Int32).Value = 13;
                comandoInsert.Parameters.Add("?titulo", MySqlDbType.VarChar).Value = "Rept Ventas";
                comandoInsert.Parameters.Add("?contrato", MySqlDbType.DateTime).Value = new DateTime(2021, 06, 28);
                comandoInsert.Parameters.Add("?director", MySqlDbType.Int32).Value = 104;
                comandoInsert.Parameters.Add("?cuota", MySqlDbType.Int32).Value = 22500;
                comandoInsert.Parameters.Add("?ventas", MySqlDbType.Int32).Value = 11000;

                //5 Ejecutar el comando
                filasAfectadas = comandoInsert.ExecuteNonQuery();
                // 6 Obtener y procesar resultados
                if (filasAfectadas > 0)
                {
                    Console.WriteLine($"Inserción realizada con exito {filasAfectadas}");
                }
                else
                {
                    Console.WriteLine($"No se ha podido realizar la inserción {filasAfectadas}");
                }
                // 7 Cerrar aplicación
                conn.Close();
                conn.Dispose();
            }
            catch (MySqlException m)
            {
                Console.WriteLine($"Se ha producidu un error {m.Message}");
            }
            catch (Exception e) 
            {
                Console.WriteLine($"Se ha producido un error{e.Message}");
            }
            return filasAfectadas;
        }

        static void Main(string[] args)
        {
            //EOI2();
            //Actualizar();
            //Insertar();
            Borrar();
        }
    }
}
