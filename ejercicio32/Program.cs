using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //32.	Las calificaciones de los alumnos en un instituto son consideradas de la siguiente forma:
                /*a)	A es 90 o más.
                b)	B es al menos 80 pero menos de 90.
                c)	C es al menos 70 pero menos de 80.
                d)	D es al menos 65 pero menos de 70.
                e)	E es menos de 65.
                Escriba un programa que considere la entrada de nota en número e imprima su codificación en letra.*/
                int n;
                do
                {
                    Console.WriteLine("Programa para convertir la nota numerica en alfabetica");
                    Console.WriteLine("Ingrese la nota");
                    n=int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos");
                    }
                } while (n <= 0);
                if (n >= 90)
                {
                    Console.WriteLine("Usted tiene una nota de {0} que es una nota A", n);
                }
                else if (n >= 80 && n < 90)
                {
                    Console.WriteLine("Usted tiene una nota de {0} que es una nota B", n);
                }
                else if (n >= 70 && n < 80)
                {
                    Console.WriteLine("Usted tiene una nota de {0} que es una nota C", n);
                }
                else if (n >= 65 && n < 70)
                {
                    Console.WriteLine("Usted tiene una nota de {0} que es una nota D", n);
                }
                else if (n < 65)
                {
                    Console.WriteLine("Usted tiene una nota de {0} que es una nota E", n);
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
