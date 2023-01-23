using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {

                    double[,] matrix = new double[2, 2];
                    double determinant;
                    do {
                        Console.Write("Ingrese el valor del elemento [0,0]: ");
                        matrix[0, 0] = double.Parse(Console.ReadLine());

                        Console.Write("Ingrese el valor del elemento [0,1]: ");
                        matrix[0, 1] = double.Parse(Console.ReadLine());

                        Console.Write("Ingrese el valor del elemento [1,0]: ");
                        matrix[1, 0] = double.Parse(Console.ReadLine());

                        Console.Write("Ingrese el valor del elemento [1,1]: ");
                        matrix[1, 1] = double.Parse(Console.ReadLine());
                    } while (matrix[0, 0] <= 0 || matrix[0, 1] <=0 || matrix[1, 0]<=0 || matrix[1, 1]<=0);
                    determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
                    Console.WriteLine("El valor del determinante es: {0}", determinant);
                    Console.ReadKey();

                }
                catch
                {
                    Console.WriteLine("Error, Formato no valido");
                }
            } while (true);
        }
    }
}
