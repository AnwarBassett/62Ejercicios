using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //10# Determine el valor de la fuerza de un cuerpo que tiene por masa “M” y aceleración “A”.
                double m, a;
                do
                {
                    Console.WriteLine("Programa para determinar el valor de la fuerza de un cuerpo que tiene por masa “M” y aceleración “A”.");
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingrese la masa");
                    m = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la aceleracion");
                    a = double.Parse(Console.ReadLine());
                    if (m <= 0 || a <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                    }
                } while (m <= 0 || a <= 0);
                Console.WriteLine(" ");
                Console.WriteLine("Masa:{0}, Aceleracion:{1}, Fuerza:{2} ", m, a, (m * a));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
