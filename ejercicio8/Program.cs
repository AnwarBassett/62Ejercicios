using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Ejercicio 8# Calcular el área de un triangulo conociendo sus tres lados.
                //la formula es Raiz cuadrada de S(s-a)*(s-b)*(s-b), siendo S semiPerimetro
                double l1, l2, l3, p, s, a;
                String var1, var2, var3;
                bool com1, com2, com3;
                do
                {
                    Console.WriteLine("Ingrese el lado uno");
                    var1 = Console.ReadLine();
                    com1 = double.TryParse(var1, out l1);
                    Console.WriteLine("Ingrese el lado dos");
                    var2 = Console.ReadLine();
                    com2 = double.TryParse(var2, out l2);
                    Console.WriteLine("Ingrese el lado tres");
                    var3 = Console.ReadLine();
                    com3 = double.TryParse(var3, out l3);
                    if (l1 <= 0 || l2 <= 0 || l3 <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                    }
                } while (!com1 || !com2 || !com3 || l1 <= 0 || l2 <= 0 || l3 <= 0);
                p = l1 + l2 + l3;
                s = p / 2;
                a = s * ((s - l1) * (s - l2) * (s - l3)); ;
                Console.WriteLine("Perimetro:{0}, SemiPerimetro:{1}, Area{2}", p, s, Math.Sqrt(a));
            }
            catch(Exception ex)
            {
                Console.WriteLine("El error es: "+ex.Message);
            }
        }
    }
}
