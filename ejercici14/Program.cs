using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercici14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14.	Determinar la solución lineal que tiene la forma ax + b =0 donde a y b son números reales.
            do
            {
                try
                {
                    double a, b;
                    double x;
                    do
                    { 
                        Console.Write("Ingrese el valor de a: ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el valor de b: ");
                        b = double.Parse(Console.ReadLine());
                        if (a == 0)
                        {
                            Console.WriteLine("La ecuación no es de primer grado.");
                        }
                        else
                        {
                            x = -b / a;
                            Console.WriteLine("La solución es x = {0}", x);
                        }
                    } while (a >= 0 && b >= 0);
                    Console.ReadKey();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error en: "+ex.Message);
                }
            } while (true);
        }
    }
}
