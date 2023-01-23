using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //9# Calcular el volumen de un cilindro conociendo su radio y altura
                double r, h, v;
                do
                {
                    Console.WriteLine("Ingrese el radio");
                    r = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura");
                    h = double.Parse(Console.ReadLine());
                    if (r <= 0 || h <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                    }
                } while (r <= 0 || h <= 0);
                v = (Math.PI * Math.Pow(r, 2)) * h;
                Console.WriteLine("El volumen del cilindro es: " + v);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
