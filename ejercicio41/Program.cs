using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //41 Calcule e imprima el producto de “N” números
                int n, num, prod, x;
                String var;
                bool com;
                num = 1;
                prod = 0;

                do
                {
                    Console.WriteLine("Programa para calcular el producto de 'n' numeros");
                    Console.WriteLine("Ingrese la cantidad de numeros");
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
                        x=int.Parse(Console.ReadLine());
                        if (x <= 0)
                        {
                            Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                        }
                    } while (x <= 0);
                    num = num * x;
                    prod = num;


                }
                Console.WriteLine("El producto de los numeros es " + prod);
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
