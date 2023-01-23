using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //18. Leer un numero de 3 cifras e imprimirlo en orden invertido
                int n, i, d, u, c;
                do
                {
                    Console.WriteLine("Ingrese un numero de 3 Cifras");
                    n=int.Parse(Console.ReadLine());
                    if (n < 100 || n > 999)
                    {
                        Console.WriteLine("No puede agregar numeros menores ni mayores de 3 cifras o letras");
                    }
                } while (n < 100 || n > 999);
                c = n / 100;
                n = n % 100;
                d = n / 10;
                u = n % 10;
                i = (u * 100) + (d * 10) + c;
                Console.WriteLine("El numero invertido es: " + i);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
