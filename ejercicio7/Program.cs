using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Ejercicio 7# Convertir X grados Fahrenheit a grados Celsius. Celsius= 5/9 (Fahrenheit -32).
                double cels, fhnr;
                do
                {
                    Console.WriteLine("Ingrese los grados Fahrenheit");
                    fhnr = double.Parse(Console.ReadLine());
                    if (fhnr <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                    }
                } while (fhnr <= 0);
                //el nueve y cinco deben ir como decimales porque si van como enteros C# lo tomara como una division entera dando cero
                cels = (fhnr - 32) * (5.0 / 9.0);
                Console.WriteLine("{0} grados fahrenheit son iguales a {1} grados celcius", fhnr, cels);
            }
            catch(Exception ex)
            {
                Console.WriteLine("El error es: "+ex.Message);
            }
        }
    }
}
