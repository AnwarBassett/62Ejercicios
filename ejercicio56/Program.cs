using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //56 Hacer un programa que registre 20 números en un array de una dimensión
            //y muestre posteriormente los elementos que contienen números múltiplos de 3.
            try
            {
                Console.WriteLine("Programa para registrar numeros multiplos de 3");
                Console.WriteLine(" ");
                int i, j = 0, mult = 0;
                int[] vector = new int[20];
                for (i = 0; i < 20; i++)
                {
                    Console.WriteLine("Escriba el numero " + (i + 1));
                    vector[i] = int.Parse(Console.ReadLine());
                }
                Console.Clear();
                for (i = 0; i < 20; i++)
                {
                    if (vector[i] % 3 == 0)
                    {
                        mult = vector[i];
                        j = i;
                    }
                    Console.WriteLine("El numero {0} en la posicion {1} es multiplo de 3", mult, (j+1));
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
