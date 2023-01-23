using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {

                    double a, b, c, d, e, f;
                    double x, y;
                    double determinante, determinanteX, determinanteY;
                    do
                    {
                        Console.Write("Ingrese el valor de a: ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el valor de b: ");
                        b = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el valor de c: ");
                        c = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el valor de d: ");
                        d = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el valor de e: ");
                        e = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el valor de f: ");
                        f = double.Parse(Console.ReadLine());
                        if(a <= 0 || b <= 0 || c <= 0 || d <= 0 || e <= 0 || f <= 0)
                        {
                            Console.WriteLine("no ingrse ceros ni negativos");
                        }
                    } while (a <= 0 || b <= 0 || c <= 0 || d <= 0 || e <= 0 || f <= 0);

                    determinante = a * e - b * d;
                    determinanteX = c * e - b * f;
                    determinanteY = a * f - c * d;
                    if (determinante == 0)
                    {
                        Console.WriteLine("La ecuación no tiene solución única.");
                    }
                    else
                    {
                        x = determinanteX / determinante;
                        y = determinanteY / determinante;
                        Console.WriteLine("Las soluciones son x = {0} y y = {1}", x, y);
                    }
                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("Error, Formato no valido");
                }
            } while (true);
        }
    }
}
