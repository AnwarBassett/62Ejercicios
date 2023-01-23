using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //48.	Dado un arreglo Bidimensional de orden “N” escriba un programa por cada inciso que determine:
            //a) Que lea el arreglo y lo imprima en el orden dado.
            //b) Que imprima los elementos que están sobre la diagonal principal.
            //c) Que imprima los elementos que están encima de la diagonal principal.
            //d) Que imprima los elementos que están por debajo y sobre la diagonal principal.

            do
            {
                try
                {
                    int i = 0, j = 0;
                    Console.Clear();
                    do
                    {
                        Console.WriteLine("Dijite la cantidad de filas");
                        i = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dijite la cantidad de columnas");
                        j = int.Parse(Console.ReadLine());
                        if (i <= 0 || j <= 0)
                        {
                            Console.WriteLine("No puede escribir numeros negativos o ceros");// validacion
                        }
                    } while (i <= 0 || j <= 0);
                    int[,] mat = new int[i, j];

                    for (int fil = 0; fil < i; fil++)
                    {
                        for (int col = 0; col < j; col++)
                        {
                            do
                            {
                                Console.WriteLine("Escriba el numero de la posicion {0},{1}", fil, col);
                                mat[fil, col] = int.Parse(Console.ReadLine());
                                if (mat[fil, col] <= 0)
                                {
                                    Console.WriteLine("No puede escribir numeros negativos o ceros");
                                }
                            } while (mat[fil, col] <= 0);

                        }
                    }
                    /////
                    Console.Clear();
                    for (int fil = 0; fil < i; fil++)
                    {
                        for (int col = 0; col < j; col++)
                        {
                            Console.Write("|" + mat[fil, col] + "|");
                        }
                        Console.Write("\n");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Elemetos por arriba de la diagonal principal");
                    for (int fil = 0; fil < i; fil++)
                    {
                        for (int col = 0; col < j; col++)
                        {
                            if (fil < col)
                            {
                                int[] array = new int[i * 2];
                                array[fil] = mat[fil, col];
                                Console.Write("|" + array[fil] + "|");
                            }
                        }
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Diagonal Principal");
                    for (int fil = 0; fil < i; fil++)
                    {
                        for (int col = 0; col < j; col++)
                        {
                            if (fil == col)
                            {
                                int[] array = new int[i];
                                array[fil] = mat[fil, col];
                                Console.Write("|" + array[col] + "|");
                            }
                        }
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Elemetos sobre y por abajo de la diagonal principal");
                    for (int fil = 0; fil < i; fil++)
                    {
                        for (int col = 0; col < j; col++)
                        {
                            if (fil > col)
                            {
                                int[] array = new int[i * 2];
                                array[fil] = mat[fil, col];
                                Console.Write("|" + array[fil] + "|");
                            }
                        }
                    }
                    Console.WriteLine(" ");
                    for (int fil = 0; fil < i; fil++)
                    {
                        for (int col = 0; col < j; col++)
                        {
                            if (fil < col)
                            {
                                int[] array = new int[i * 2];
                                array[fil] = mat[fil, col];
                                Console.Write("|" + array[fil] + "|");
                            }
                        }
                    }
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (true);
        }
    }
}
