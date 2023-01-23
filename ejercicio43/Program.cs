using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (int i = 0; i < 25; i++)
                {
                    //43.	En un curso de 25 alumnos se practican 3 exámenes los datos de cada estudiante se registran así: Nombre, Nota1, Nota2, Nota3.
                    //Escriba un programa que calcule por cada estudiante el promedio de las notas.
                    String nombre;
                    double nota1, nota2, nota3, prom;
                    do
                    {
                        Console.WriteLine("Programa para calcular el promedio de las notas");
                        Console.WriteLine("Escriba el nombre del estudiante");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese un numero");
                        nota1=double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese un numero");
                        nota2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese un numero");
                        nota3 = double.Parse(Console.ReadLine());
                        if (nota1 < 0 || nota2 < 0 || nota3 < 0)
                        {
                            Console.WriteLine("No puede agregar numeros negativos o numeros mayores a 100");
                        }
                    } while (nota1 < 0 || nota2 < 0 || nota3 < 0);
                    prom = (nota1 + nota2 + nota3) / 3;
                    Console.WriteLine("Estudiante {0}, Nota 1: {1}, Nota 2: {2}, Nota 3: {3}, Promedio: {4}", nombre, nota1, nota2, nota3, prom);
                }
                Console.ReadKey();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
