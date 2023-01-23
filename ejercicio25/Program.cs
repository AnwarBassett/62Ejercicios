using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //25 Escribir un programa que lea un número cualquiera e imprima si el número leído es divisible por tres.
                int n;
                do
                {
                    Console.WriteLine("Ingrese un numero para saber si es divisible entre 3");
                    n=int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                    }
                } while (n <= 0);
                if (n % 3 == 0)
                {
                    Console.WriteLine("El numero {0} si es divisible entre 3", n);
                }
                else
                {
                    Console.WriteLine("El numero {0} no es divisible entre 3", n);
                }
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
