using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    int[,] ArrayA;
                    int[,] ArrayB;
                    int[,] ArraySm;
                    int[,] ArraySm2;
                    ArrayA = new int[80, 80];
                    ArrayB = new int[80, 80];
                    ArraySm = new int[80, 80];
                    ArraySm2 = new int[80, 80];
                    int i = 0, j = 0, Filas = 0, Columnas = 0;
                    do
                    {
                        Console.WriteLine("Digite la cantidad de filas");
                        Filas = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite la cantidad de columnas");
                        Columnas = int.Parse(Console.ReadLine());
                        if (Filas <= 0 || Columnas <= 0)
                        {
                            Console.WriteLine("No puede ingresar ceros o valores negativos");
                        }
                    } while (Filas <= 0 || Columnas <= 0);

                    for (i = 0; i < Filas; i++)
                    {
                        for (j = 0; j < Columnas; j++)
                        {
                            Console.WriteLine("Ingrese los elementos del primer array: " + (i + 1, j + 1));
                            ArrayA[i, j] = int.Parse(Console.ReadLine());
                        }
                    }

                    for (i = 0; i < Filas; i++)
                    {
                        for (j = 0; j < Columnas; j++)
                        {
                            Console.WriteLine("Ingrese los elementos del segundo array: " + (i + 1, j + 1));
                            ArrayB[i, j] = int.Parse(Console.ReadLine());

                        }
                    }
                    for (i = 0; i < Columnas; i++)
                    {
                        for (j = 0; j < Columnas; j++)
                        {
                            ArraySm[i, j] = ArrayA[i, j] + ArrayB[i, j];
                        }
                    }
                    for (i = 0; i < Columnas; i++)
                    {
                        for (j = 0; j < Columnas; j++)
                        {
                            ArraySm2[i, j] = (2 * ArrayA[i, j]) + (3 * ArrayB[i, j]);
                        }
                    }
                    Console.WriteLine("Esta es la suma de la matriz");
                    for (i = 0; i < Columnas; i++)
                    {
                        for (j = 0; j < Columnas; j++)
                        {
                            Console.Write(ArraySm[i, j] + " ");

                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Esta es la suma de la segunda matriz");
                    for (i = 0; i < Columnas; i++)
                    {
                        for (j = 0; j < Columnas; j++)
                        {
                            Console.Write(ArraySm2[i, j] + " ");

                        }
                        Console.WriteLine();
                    }
                }catch(Exception ex)
                {
                    Console.WriteLine("Error en: "+ex.Message);
                }
            } while (true);
        }
    }
}
