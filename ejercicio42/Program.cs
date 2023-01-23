using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //42 Leer “N” números distintos de 0, si el número leído es positivo súmelo en caso contrario cuéntelo
                int n, m, CPositivos, CNegativos, suma;
                suma = 0;
                String var;
                bool com;
                int i = 0;
                CPositivos = 0;
                CNegativos = 0;
                do
                {
                    Console.WriteLine("Programa para sumar numeros positivos y contar numeros negativos");
                    Console.WriteLine("Ingrese la cantidad de numeros");
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
                        Console.WriteLine("Ingrese el numero {0}", (i + 1));
                        m=int.Parse(Console.ReadLine());
                        if (m == 0)
                        {
                            Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                        }
                    } while (m == 0);
                    if (m >= 0)
                    {
                        suma = m;
                        CPositivos = CPositivos + suma;
                    }
                    else
                    {
                        CNegativos = CNegativos + 1;
                    }

                }
                Console.WriteLine("La suma de los numeros positivos es: " + CPositivos);
                Console.WriteLine("Hay {0} numeros negativos", CNegativos);
                Console.ReadKey();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
