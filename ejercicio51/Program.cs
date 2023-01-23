using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n, x, y, resi;
                x = 2;
                y = 0;
                do
                {
                    //51 Diseñar un programa para averiguar su un número digitado por el usuario es primo.
                    Console.WriteLine("Programa para conocer si un numero es primo");
                    Console.WriteLine("Ingrese un numero");
                    n=int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos");
                    }
                } while (n <= 0);
                while (x < n && y == 0)
                {
                    resi = n % x;
                    if (resi == 0)
                    {
                        y = 1;
                    }
                    else
                    {
                        x = x + 1;
                    }
                }
                if (y == 0)
                {
                    Console.WriteLine("El numero {0} es numero primo", n);
                }
                else
                {
                    Console.WriteLine("El numero {0} no es un numero primo", n);
                }
                Console.ReadKey();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
