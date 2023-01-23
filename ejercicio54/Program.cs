using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //54 Elaborar un programa que permita leer N números desde el teclado y calcule la media aritmética(promedio).
                int n;
                Console.WriteLine("Programa para calcular la media aritmetica");
                Console.WriteLine("Ingrese la cantidad de numeros");
                n = int.Parse(Console.ReadLine());
                int[] vector = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Numero {0} ", (i + 1));
                    vector[i] = int.Parse(Console.ReadLine());

                }
                Console.Write("Lista de numeros [");
                for (int i = 0; i < n; i++)
                {

                    Console.Write(" " + vector[i] + " ");
                }
                Console.Write("] ");
                int sumatoria = 0;
                for (int x = 0; x < n; x++)//Sumar datos
                {
                    int numeroActual = vector[x];
                    sumatoria = sumatoria + numeroActual;
                }
                Console.WriteLine(" ");
                Console.WriteLine("La media aritmetica es: {0}", (sumatoria / n));
                Console.ReadKey();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
