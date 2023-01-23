using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //22.	Escribir un programa para calcular el interés de una capital conforme a la siguiente condición.
                //Si el capital prestado es mayor que 10,000 dólares entonces la tasa es del 7%
                //en caso contrario del 6% , debe imprimir el capital y su interés.
                double c, i;
                do
                {
                    Console.WriteLine("Programa para calcular el interes de una capital");
                    Console.WriteLine("Ingrese su capital");
                    c = double.Parse(Console.ReadLine());
                } while (c <= 0);
                if(c >= 10000)
                {
                    i = c * 0.07;
                    Console.WriteLine("Usted posee una capital de {0} y la tasa de interes es igual a {1}",c,i);
                }
                else
                {
                    i = c * 0.06;
                    Console.WriteLine("Usted posee una capital de {0} y la tasa de interes es igual a {1}", c, i);

                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
