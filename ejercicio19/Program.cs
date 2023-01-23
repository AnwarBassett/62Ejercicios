using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //19 Escriba un programa que lea la edad de una persona e
                //imprima es votante dado que tiene 16 o más años de edad.
                int edad;
                do
                {
                    Console.WriteLine("Ingrese su edad");
                    edad = int.Parse(Console.ReadLine());
                    if (edad <= 0 || edad > 90)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos, numeros mayores");
                    }
                } while (edad <= 0 || edad > 90);
                if (edad < 16)
                {
                    Console.WriteLine("Usted no puede votar, es menor de edad");
                }
                else
                {
                    Console.WriteLine("Es votante dado que tiene 16 o más años de edad, su edad es: " + edad);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
