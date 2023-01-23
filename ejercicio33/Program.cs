using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //33. Escriba un programa que imprima los números del 1 al 100.
                Console.WriteLine("Programa que escribe los numeros del 1 al 100");
                Console.WriteLine(" ");
                for (int n = 0; n < 100; n++)
                {
                    Console.Write("" + (n + 1) + "-");
                }
                Console.Write("Fin");
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
