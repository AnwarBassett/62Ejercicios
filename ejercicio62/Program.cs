using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //62.	Escriba un programa que encuentre los primeros tres números perfectos.
                //Un número perfecto es un número entero positivo, que es igual a la suma de todos los enteros positivos
                //(excluidos el mismo) que son divisores del número.
                //El primer número es 6 ya que los divisores de 6 son 1,2,3 y 1+2+3=6
                Console.WriteLine("Programa para conocer los primeros 3 numeros perfectos");
                int b, s;
                for (int i = 2; i <= 500; i++)
                {
                    b = 0;
                    s = i / 2;
                    for (int j = 1; j <= s; j++)
                    {
                        if ((i % j) == 0)
                        {
                            b = b + j;
                        }
                    }
                    if (b == i)
                    {
                        Console.WriteLine("El numero perfecto es: " + i);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
