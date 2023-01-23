using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x;
                do
                {
                    //21.	Escriba un programa que lea un número que verifique
                    //si X es negativo que calcule X^4 en caso contrario que calcule X^2.
                    Console.WriteLine("Ingrese un numero X");
                    x=int.Parse(Console.ReadLine());
                    if (x == 0)
                    {
                        Console.WriteLine("No puede agregar cero");
                    }
                } while (x == 0);
                if (x > 0)
                {
                    Console.WriteLine("X es positivo");
                    Console.WriteLine("El valor de X es ahora: " + (Math.Pow(x, 2)));
                }
                else
                {
                    Console.WriteLine("X es negativo");
                    Console.WriteLine("El valor de X es ahora: " + (Math.Pow(x, 4)));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
