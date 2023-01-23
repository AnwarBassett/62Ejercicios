using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //23  Escribir un programa que lea la calificación de un alumno e imprima el mensaje de aprobado
                //si su calificación es mayor o igual a 60, en caso contrario imprima reprobado.
                int nt;
                do
                {
                    Console.WriteLine("Programa para saber si un alumno esta aprobado o reprobado");
                    Console.WriteLine("Ingrese la nota");
                    nt=int.Parse(Console.ReadLine());
                    if (nt < 0 || nt > 100)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos, mayores de 100");
                    }
                } while (nt < 0 || nt > 100);
                if (nt >= 60)
                {
                    Console.WriteLine("Su nota es {0}, usted esta aprobado", nt);
                }
                else
                {
                    Console.WriteLine("Su nota es {0}, usted esta reprobado", nt);
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
