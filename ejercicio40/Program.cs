using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //40.	Escribir un programa que calcule la factorial de un número entero.
                /*3 != 1’ 2’ 3’= 6
                  5 != 1’ 2’ 3’ 4’ 5’= 120*/
                int n, z;
                z = 1;
                do
                {
                    Console.WriteLine("Programa para calcular el factorial");
                    Console.WriteLine("Ingrese un numero");
                    n=int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                    }
                } while (n <= 0);
                if (n == 0 || n == 1)
                {
                    Console.WriteLine(" " + 1);
                }
                else
                {
                    for (int i = 1; i <= n; i++)
                    {
                        z = z * i;
                    }
                }
                Console.WriteLine("El factorial es: " + (z));
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
