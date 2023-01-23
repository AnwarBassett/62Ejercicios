using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //34. Escriba un programa que lea “n” números enteros y que los imprima.
                int n, m;
                String var;
                bool com;
                do
                {
                    Console.WriteLine("Ingrese la cantidad de numeros a imprimir");
                    n=int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                    }
                } while (n <= 0);
                for (int i = 0; i < n; i++)
                {
                    do
                    {
                        Console.WriteLine("Ingrese el numero {0}", (i + 1));
                        m=int.Parse(Console.ReadLine());
                        if (m <= 0)
                        {
                            Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                        }
                    } while (m <= 0);
                    Console.WriteLine("El numero {0} es: {1}", (i + 1), m);
                    Console.ReadKey();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
