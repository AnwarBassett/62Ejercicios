using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //35 Escriba un programa que lea tres números cualesquiera y que calcule la suma de ellos y su promedio.
                Console.WriteLine("Programa para conocer la suma y el promedio de 3 numeros");
                double n, suma, sumaActual;
                suma = 0;
                sumaActual = 0;
                for (int i = 0; i < 3; i++)
                {
                    do
                    {
                        Console.WriteLine("Ingrese el numero {0}", (i + 1));
                        n=double.Parse(Console.ReadLine());
                        if (n <= 0)
                        {
                            Console.WriteLine("No puede agregar cero, numeros negativos");
                        }
                    } while ( n <= 0);
                    sumaActual = n;
                    suma = suma + sumaActual;
                    

                }
                double promedio = suma / 3;
                Console.WriteLine("La suma de los numeros ingresados es:{0} y su promedio es: {1}",suma, promedio);
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
