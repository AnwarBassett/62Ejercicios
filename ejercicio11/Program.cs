using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 11# Obtener el valor del Coseno de un número cualquiera
                double n, cs;
                do
                {
                    Console.WriteLine("Programa para obtener el valor del coseno");
                    Console.WriteLine("Ingrese un numero");
                    n = double.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos");
                    }
                } while (n <= 0);
                cs =Math.Cos(n);
                Console.WriteLine(" ");
                Console.WriteLine("El valor de coseno de {0} es igual a {1}",n,cs);
            }
            catch (Exception ex)
            {
                Console.WriteLine("El error es: "+ex.Message);
            }
        }
    }
}
