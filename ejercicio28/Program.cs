using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //28.	Escriba un programa que lea dos números enteros como entrada y
                //escriba el mensaje signos opuestos si y solo si uno de los enteros es positivo y el otro negativo.
                int n1, n2;
                do
                {
                    Console.WriteLine("Programa para saber si 2 numeros son signos iguales u opuestos");
                    Console.WriteLine("Digite el numero 1");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el numero 2");
                    n2 = int.Parse(Console.ReadLine());
                    if (n1 == 0 || n2==0)
                    {
                        Console.WriteLine("No puede escribir cero");

                    }
                } while (n1 == 0 || n2 == 0);
                if ( (n1 < 0 && n2 < 0) || (n1 > 0 && n2 > 0) )
                {
                    
                    Console.WriteLine("El numero {0} y {1} son signos iguales",n1,n2);
                }
                else
                {
                    
                    Console.WriteLine("El numero {0} y {1} son signos opuestos", n1, n2);
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
