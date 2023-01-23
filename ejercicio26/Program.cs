using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    //26.	Escriba un programa independiente para cada inciso considerando una lectura de distintos números tal como se detallan a continuación. 
                    //a) XY b) XYZ c) XYZW

                    int x, y, z, w;
                    do
                    {
                        Console.Write("Ingrese el valor de X: ");
                        x = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el valor de Y: ");
                        y = int.Parse(Console.ReadLine());
                        if (x <= 0 || y <= 0)
                        {
                            Console.WriteLine("No ingrese cero ni numeros negativos");
                        }
                    } while (y <= 0 || x<=0);

                    Console.Write("Ingrese el valor de Z: ");
                    z = int.Parse(Console.ReadLine());
                    while (z <= 0)
                    {
                        Console.WriteLine("El número debe ser mayor a 0. Por favor ingresa un número válido.");
                        Console.Write("Ingrese el valor de Z: ");
                        z = int.Parse(Console.ReadLine());
                    }
                    Console.Write("Ingrese el valor de W: ");
                    w = int.Parse(Console.ReadLine());
                    while (w <= 0)
                    {
                        Console.WriteLine("El número debe ser mayor a 0. Por favor ingresa un número válido.");
                        Console.Write("Ingrese el valor de W: ");
                        z = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("X: {0}, Y: {1}, Z: {2}, W: {3}", x, y, z, w);
                    Console.ReadKey();
                }
                catch { Console.WriteLine("Error, Formato no valido"); }
            } while (true);
        }
    }
}
