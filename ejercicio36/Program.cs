using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double n, m, suma, sumaActual, promedio;
                suma = 0;
                sumaActual = 0;
                int i = 0;
                do
                {
                    Console.WriteLine("Ingrese la cantidad de numeros");
                    n = double.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos");
                    }
                } while (n <= 0);
                for (i = 0; i < n; i++)
                {
                    do
                    {
                        Console.WriteLine("Ingrese el numero {0}", (i + 1));
                        m = double.Parse(Console.ReadLine());
                        if (m <= 0)
                        {
                            Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                        }
                    } while (m <= 0);
                    sumaActual = m;
                    suma = suma + sumaActual;
                }
                promedio = suma / n;
                Console.WriteLine("La suma de los numeros ingresados es: " + suma);
                Console.WriteLine("El promedio de la suma es: " + promedio);
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
