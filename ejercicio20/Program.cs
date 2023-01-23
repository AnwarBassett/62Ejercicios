using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    int n;
                    do
                    {
                        //20 Escriba un programa que lea un número cualquiera e imprima si es par o impar.
                        Console.WriteLine("Programa para saber si es par o impar");
                        Console.WriteLine("Ingrese un numero");
                        n = int.Parse(Console.ReadLine());
                        if (n <= 0)
                        {
                            Console.WriteLine("No puede agregar cero, numeros negativos");
                        }
                    } while (n <= 0);
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("Es par");
                    }
                    else
                    {
                        Console.WriteLine("Es impar");
                    }
                } while (true);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
