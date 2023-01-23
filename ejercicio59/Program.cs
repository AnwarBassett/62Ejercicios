using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //59 Escribir un programa para averiguar si un número digitado por el usuario es perfecto.
                //Un numero es perfecto si la suma de sus divisores distintos de el mismo es igual a este. Ejemplo: 6= 1+2+3.
                int i, suma = 0, n;
                Console.WriteLine("Programa pasa saber si un numero es perfecto o no");
                Console.WriteLine("Introduce un número: ");
                n = int.Parse(Console.ReadLine());
                for (i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        suma = suma + i;
                    }
                }
                if (suma == n)
                {
                    Console.WriteLine("Perfecto");
                }
                else
                {
                    Console.WriteLine("No es perfecto");

                }
                Console.ReadKey();


                //62.	Escriba un programa que encuentre los primeros tres números perfectos.
                //Un número perfecto es un número entero positivo, que es igual a la suma de todos los enteros positivos
                //(excluidos el mismo) que son divisores del número.
                //El primer número es 6 ya que los divisores de 6 son 1,2,3 y 1+2+3=6
                /*int b, s, a;
                for(int i=2; i<=500; i++)
                {
                    b = 0;
                    s = i / 2;
                    for(int j=1; j<=s; j++)
                    {
                        if((i%j) == 0)
                        {
                            b = b + j;
                        }
                    }
                    if (b == i)
                    {
                        Console.WriteLine("El numero perfecto es: " + i);
                    }
                }
                */
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
