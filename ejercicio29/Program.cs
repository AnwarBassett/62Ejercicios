using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //29 Escriba un programa que lea dos números enteros positivos distintos y escriba la diferencia entre el mayor y el menor.
                //Asegúrese que su programa escriba por ejemplo 8 si los números son 10 y 2 o bien 2 y 10.
                int n1, n2;
                do
                {
                    Console.WriteLine("Programa para conocer la diferencia entre 2 numeros");
                    Console.WriteLine("Ingrese un numero positivo");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese un segundo numero positivo");
                    n2=int.Parse(Console.ReadLine());
                    if (n1 <= 0 || n2 <= 0 || n1==n2)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o numeros iguales");
                    }
                } while (n1 <= 0 || n2 <= 0 || n1==n2);
                if (n1 < n2)
                {
                    Console.WriteLine("La diferencia entre {0} y {1} es igual a: {2}", n1, n2, (n2 - n1));
                }
                else
                {
                    Console.WriteLine("La diferencia entre {0} y {1} es igual a: {2}", n1, n2, (n1 - n2));
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
