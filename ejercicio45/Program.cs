using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //45 De una lista de n voltajes escriba el programa que calcule el voltaje mínimo,
                //el voltaje máximo y el promedio de todos.
                do
                {

                    try
                    {
                        int pos;
                        int i;
                        int suma = 0;
                        int op;
                        int n;
                        double promedio = 0;
                        int[] valores;
                        Console.WriteLine("Ingrese el tamaño del array");
                        n = int.Parse(Console.ReadLine());
                        valores = new int[n];
                        Console.WriteLine("Arreglo creado");
                        int menor, mayor;
                        for (i = 0; i < n; i++)
                        {
                            Console.WriteLine("Ingrese el valor:" + (i + 1));
                            valores[i] = int.Parse(Console.ReadLine());





                        }
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("Elija la opcion deseada");
                            Console.WriteLine("1-Menor voltaje");
                            Console.WriteLine("2-Mayor voltaje");
                            Console.WriteLine("3-Promedio");
                            op = int.Parse(Console.ReadLine());

                            switch (op)
                            {

                                case 1:

                                    menor = valores[0];

                                    for (int f = 1; f < valores.Length; f++)
                                    {
                                        if (valores[f] < menor)
                                        {
                                            menor = valores[f];
                                            pos = f;
                                        }
                                    }
                                    Console.WriteLine("El menor elemeto:" + menor);

                                    break;

                                case 2:

                                    mayor = valores[0];

                                    for (int f = 1; f > valores.Length; f++)
                                    {
                                        if (valores[f] < mayor)
                                        {
                                            mayor = valores[f];
                                            pos = f;
                                        }
                                    }
                                    Console.WriteLine("El mayor elemeto:" + mayor);
                                    break;
                                case 3:
                                    for (i = 0; i < n; i++)
                                    {

                                        suma = suma + valores[i];
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine("La suma es:" + suma);

                                    }
                                    promedio = suma / n;
                                    Console.WriteLine("El promedio es:" + promedio.ToString("0.00"));
                                    break;
                            }
                        } while (op <= 0 || op > 3);
                    }
                    catch
                    {
                        Console.WriteLine("Error,No se aceptan letras");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (true);
                Console.ReadKey();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
