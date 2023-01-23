using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Programa para registrar numeros multiplos de 5");
                Console.WriteLine(" ");
                int i, j = 0, mulc = 0;
                int[] vector = new int[20];
                for (i = 0; i < 20; i++)
                {
                    Console.WriteLine("Escriba el numero " + (i + 1));
                    vector[i] = int.Parse(Console.ReadLine());
                }
                Console.Clear();
                for (i = 0; i < 20; i++)
                {
                    if (vector[i] % 5 == 0)
                    {
                        mulc = vector[i];
                        j = i;
                    }
                    Console.WriteLine("El numero {0} en la posicion {1} es multiplo de 5", mulc, (j + 1));
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
