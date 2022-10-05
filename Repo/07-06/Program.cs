using System;

namespace _07_06
{
    class Program
    {
        public static void ApropiadaCadena(ref string cadena)
        {

            //1-Pasar Cadena a minuscula(ToLower)
            cadena = cadena.ToLower();
            //2-Primera posicion en mayuscula (ToUpper)
            cadena = Convert.ToString(cadena[0]).ToUpper() + cadena.Substring(1);
            //cadena = cadena.Substring(0,1).ToUpper()+cadena.Substring(1);
            //cadena = cadena.ToUpper();
            //Localizar todos los '.' con IndexOf con while
            //Ir haciendo subString para buscar los siguientes "."
            // Cambiar a mayuscula la siguiente letra despues del punto con Replace
            //while (cadena.IndexOf(".",indice)>=0) 
            //{
            //    cadenaTemporal = cadena.Substring(indice, cadena.IndexOf(".", indice));
            //    indice = cadena.IndexOf(".",indice);

            //}

            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == '.')
                {
                    cadena = cadena.Substring(0, i) + cadena.Substring(i + 1, 1).ToUpper() + cadena.Substring(i + 2);

                }

            }

        }

        public static int SumaCifras(int numero)
        {
            int resultado=0;

            while (numero>0)
            {
                resultado += numero % 10;
                numero /= 10; 
                
            }
            return resultado;
        }

        public static string EscribirAlRever(string cadena) 
        {
            for (int i=cadena.Length-1;i>=0;i--) 
            {
                Console.Write(cadena[i]);
            }
            return cadena;
        }

        public static void CuantasVocalesDeCada(string cadena, out int a, out int e, out int i, out int o, out int u) 
        {
             a = 0;
             e = 0;
             i = 0;
             o = 0;
             u = 0;

            for (int j=0;j<cadena.Length;j++) 
            {
                switch (cadena[j])
                {
                    case 'a':
                        a++;
                        break;
                    case 'e':
                        e++;
                        break;
                    case 'i':
                        i++;
                        break;
                    case 'o':
                        o++;
                        break;
                    case 'u':
                        u++;
                        break;
                }
            }
        }

        public static double Media(string notas) 
        {
            double media = 0;
            int cantidadErrores=0;

            string[] auxiliar = notas.Split(';');
            for (int i=0;i<auxiliar.Length;i++)
            {
                 double temp=0;
                media += Convert.ToDouble(auxiliar[i]);


                //solucion pro
                if (Double.TryParse(auxiliar[i],out temp)) 
                {
                media = media + temp;
            }
                else
            {
                cantidadErrores++;
                Console.WriteLine($"");
            }
        }
            media = media / auxiliar.GetLength(0);

            return media;
        }


        public static string[] ArrayCadena(string[] palabras) 
        {
            Array.Sort(palabras);
            Array.Reverse(palabras);
            return palabras;
        }

        public static int ArrayNumeros(int[] numeros,int buscar) 
        {

            int [] numeroValor = Array.FindAll(numeros,n=> n == buscar);
            return numeroValor.Length;
        }

        public static string ConvertirFecha(DateTime fecha) 
        {
            string[] dias = { "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" };
            string diaHoy = dias[(int)fecha.DayOfWeek];
            return $"Hoy es {diaHoy}, {fecha.Day:D2}/{fecha.Month:D2}/{fecha.Year}";
        }

        public static DateTime ConsultaFecha(string fecha)
        {
            string[] partes = fecha.Split("-");
            int dia = Convert.ToInt32(partes[0]);
            int mes = Convert.ToInt32(partes[1]);
            int anyo = Convert.ToInt32(partes[2]);
            DateTime fechanueva = new DateTime(anyo,mes,dia);
            DateTime fechaFutura = fechanueva.AddYears(2).AddMonths(3).AddDays(3);
            return fechaFutura;


        }

        static void Main(string[] args)
        {
            //int a=0, e=0, i=0, o=0, u=0;
            //string cadena = "esta es .la prueba.n ";
            //ApropiadaCadena(ref cadena);
            //Console.WriteLine(cadena);
            //Console.WriteLine(SumaCifras(654));
            //EscribirAlRever("Hola");

            //CuantasVocalesDeCada("aeiideioeodeaw", out a, out e, out i, out o, out u);
            //Console.WriteLine($"\nA:{a} E:{e} I:{i} O:{o} U:{u}");

            string numeros = "5;5;5;5;5;5,5891";
            Console.WriteLine(Media(numeros));

            string[] ListaPalabras = {"Boligrafo","Mando","TV","Monitor","Raton","Teclado","Xbox","Libreta" };
            Console.WriteLine($"{String.Join(", ", ArrayCadena(ListaPalabras))}");

            int[] listaNumeros = {1,3,2,4,5,1,2,6,9 };

            Console.WriteLine($"Las veces que aparece el numero {String.Join("*", ArrayNumeros(listaNumeros,4))}");
            Console.WriteLine(DateTime.Now);

            //DateTime

            DateTime fechaHoy = new DateTime(2021, 06,07,19,59,59);
            Console.WriteLine(fechaHoy);
            DateTime fechaAhora = DateTime.Today;
            Console.WriteLine(fechaAhora);

            Console.WriteLine(ConvertirFecha(DateTime.Now));
            Console.WriteLine(ConsultaFecha("06-10-2021"));



        }
    }
}
