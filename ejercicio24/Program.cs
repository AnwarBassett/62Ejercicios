using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //24 Escriba un programa que lea un numero A,
                //si A es un número positivo calcule Y=2^A, si es negativo calcule Y=A+5 imprimir el resultado de Y.
                int A;
                String var;
                bool com;
                do
                {
                    Console.WriteLine("Ingrese el Numero A");
                    A=int.Parse(Console.ReadLine());
                    if (A == 0 )
                    {
                        Console.WriteLine("No puede agregar cero");
                    }
                } while (A == 0);
                if (A > 0)
                {
                    Console.Clear();
                    Console.WriteLine("A es igual:{0}, asi que Y es igual:{1}", A, (Math.Pow(2, A)));
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("A es igual:{0}, asi que Y es igual:{1}", A, (A + 5));
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
