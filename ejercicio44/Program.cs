using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int edad;
                do
                {
                    //44 Dada la edad de una persona
                    //escriba un programa que imprima
                    //“niño” si la edad es menor que 13
                    //“joven” si la edad es mayor que 13 y menor o igual 25 y
                    //“adulto” si la edad es mayor que 25.
                    Console.WriteLine("Ingrese la edad de alguien");
                    edad=int.Parse(Console.ReadLine());
                    if (edad <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                    }
                } while (edad <= 0);
                if (edad < 13)
                {
                    Console.WriteLine("Usted tiene {0} años, usted es un niño", edad);
                }
                else if (edad >= 13 && edad <= 25)
                {
                    Console.WriteLine("Usted tiene {0} años, usted es un joven", edad);
                }
                else if (edad > 25)
                {
                    Console.WriteLine("Usted tiene {0} años, usted es un adulto", edad);
                }
                Console.ReadKey();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
