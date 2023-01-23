using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //12# Obtener el promedio de N notas.
                double c, p;
                p = 0;
                int n;
                
                do
                {
                    Console.WriteLine("Programa para obtener el promedio de notas");
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingrese la cantidad de notas");
                    n = int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                    }
                } while (n <= 0);
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("Ingresa la nota {0}: ", i);
                    c = double.Parse(Console.ReadLine());
                    p = p + c;
                    Console.WriteLine();
                }
                if (n == 0)
                {
                    p = 0;
                }
                else
                {
                    p = p / n;
                }
                Console.WriteLine(" ");
                Console.WriteLine("El promedio: " + p);
            }
            catch(Exception ex)
            {
                Console.WriteLine("El error es: "+ex.Message);
            }
        }
    }
}
