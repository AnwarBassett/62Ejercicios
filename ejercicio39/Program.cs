using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //39 Escriba un programa que lea las notas de “N” alumnos y
                //calcule cuantos aprobados y desaprobados hay (está aprobado si la nota es mayor de 60).
                int n, m, CAprobados, CDesaprobados;
                String var;
                bool com;
                int i = 0;
                CAprobados = 0;
                CDesaprobados = 0;
                do
                {
                    Console.WriteLine("Ingrese la cantidad de Estudiantes a evaluar");
                    n=int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                    }
                } while (n <= 0);
                for (i = 0; i < n; i++)
                {
                    do
                    {
                        Console.WriteLine("Ingrese la nota del estudiante {0}", (i + 1));
                        m=int.Parse(Console.ReadLine());
                        if (m <= 0)
                        {
                            Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                        }
                    } while (m <= 0 || m > 100);
                    if (m >= 60)
                    {
                        CAprobados = CAprobados + 1;
                    }
                    else
                    {
                        CDesaprobados = CDesaprobados + 1;
                    }

                }
                Console.WriteLine("Hay {0} estudiantes aprobados", CAprobados);
                Console.WriteLine("Hay {0} estudiantes desaprobados", CDesaprobados);
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
