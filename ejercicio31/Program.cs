using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //31.	UN triangulo es equilátero si posee sus tres lados iguales, es Isósceles si tiene solamente dos lados iguales y
                //es escaleno cuando todos sus lados son desiguales.
                //Escribir un programa que lea las dimensiones de los lados del triángulo y presente como salida el mensaje de su clasificación de triangulo.
                int l1, l2, l3;
                do
                {
                    Console.WriteLine("Programa pasa saber el tipo de triangulo segun sus lados");
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingrese lado 1");
                    l1=int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese lado 2");
                    l2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese lado 3");
                    l3 = int.Parse(Console.ReadLine());
                    if (l1 <= 0 || l2 <= 0 || l3 <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos");
                    }
                } while (l1 <= 0 || l2 <= 0 || l3 <= 0);
                if (l1 == l2 && l2 == l3 && l3 == l1)
                {
                    Console.WriteLine("Los lados forman un triangulo equilatero");
                }
                else if (l1 == l3 || l2 == l1 || l3 == l2)
                {
                    Console.WriteLine("Los lados forman un triangulo Isoceles");
                }
                else if (l1 != l2 && l2 != l3 && l3 != l1)
                {
                    Console.WriteLine("Los lados forman un triangulo Escaleno");
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
