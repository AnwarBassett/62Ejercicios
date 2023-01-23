using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //52 Leer 20 números desde el teclado y obtener cuantos son positivos, negativos e iguales a cero.
                int n, sumaP, sumaNE, sumaZR, x;
                sumaP = 0;
                sumaNE = 0;
                sumaZR = 0;
                x = 0;
                Console.WriteLine("Programa para contar numeros negativos, positivos y cero");
                for (int i = 0; i < 25; i++)
                {
                        Console.WriteLine("Ingrese el numero {0}", (i + 1));
                        n=int.Parse(Console.ReadLine());
                    if (n > 0)
                    {
                        sumaP = sumaP + 1;
                    }
                    else if (n < 0)
                    {
                        sumaNE = sumaNE + 1;
                    }
                    else
                    {
                        sumaZR = sumaZR + 1;
                    }
                }
                Console.WriteLine("Hay {0} numeros positivos", sumaP);
                Console.WriteLine("Hay {0} numeros negativos", sumaNE);
                Console.WriteLine("Hay {0} ceros", sumaZR);
                Console.ReadKey();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
