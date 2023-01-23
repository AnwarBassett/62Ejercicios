using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //55.	Hacer un programa que registre 20 números en un array de una dimensión
            //y muestre posteriormente los elementos que ocupan posiciones impares.
            try
            {
                int i, j=0, impar=0;
                int[] vector = new int[20];
                for(i=0; i<20; i++)
                {
                    Console.WriteLine("Escriba el numero "+(i+1));
                    vector[i] =int.Parse(Console.ReadLine());
                }
                Console.Clear();
                for(i=0;i<20; i++)
                {
                    if (vector[i] % 2 == 0)
                    {

                    }
                    else
                    {
                        impar = vector[i];
                        j = i;
                    }
                    Console.WriteLine("El numero {0} en la posicion{1} es impar",impar, j);
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
