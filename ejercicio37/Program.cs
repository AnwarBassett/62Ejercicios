using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //37 Escriba un programa que tenga como entrada “n” números enteros
                //y que calcule el número de números pares e impares.
                int n, m, Cpar, Cimpar;
                int i = 0;
                Cpar = 0;
                Cimpar = 0;
                do
                {
                    Console.WriteLine("programa para calcular la cantidad de numeros pares o/y impares");
                    Console.WriteLine("Ingrese la cantidad de numeros");
                    n=int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                    }
                } while (n <= 0);
                for (i = 0; i < n; i++)
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
                    if (m % 2 == 0)
                    {
                        Cpar = Cpar + 1;
                    }
                    else
                    {
                        Cimpar = Cimpar + 1;
                    }
                }
                Console.WriteLine("Ingreso {0} numeros pares", Cpar);
                Console.WriteLine("Ingreso {0} numeros impares", Cimpar);
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
