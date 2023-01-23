using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n;
                do
                {
                    //50 Escribir un programa para averiguar todos los divisores de un número digitado por el usuario.
                    Console.WriteLine("Programa para conocer el divisor de un numero");
                    Console.WriteLine("Ingrese un numero");
                    n=int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                    }
                } while (n <= 0);
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine("{0} es divisor de {1}", n, i);
                    }
                }
                Console.ReadKey();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
