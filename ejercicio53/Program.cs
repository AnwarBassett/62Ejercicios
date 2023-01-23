using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //53 Leer 20 números desde el teclado y averiguar la suma de los números pares e impares.
                int m, Cpar, Cimpar, sumaActual;
                Cpar = 0;
                Cimpar = 0;
                Console.WriteLine("Programa para averiguar la suma de los numeros pares e impares");
                for (int i = 0; i < 20; i++)
                {
                    do
                    {
                        Console.WriteLine("Ingrese el numero {0}", (i + 1));
                        m=int.Parse(Console.ReadLine());
                        if (m <= 0)
                        {
                            Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                        }
                    } while (m <= 0);
                    if (m % 2 == 0)
                    {
                        sumaActual = m;
                        Cpar = Cpar + sumaActual;
                    }
                    else
                    {
                        sumaActual = m;
                        Cimpar = Cimpar + sumaActual;
                    }

                }
                Console.Clear();
                Console.WriteLine("Ingreso {0} numeros pares", Cpar);
                Console.WriteLine("Ingreso {0} numeros impares", Cimpar);
                Console.ReadKey();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
