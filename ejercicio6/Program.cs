using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    //Ejercicio 6# Convertir N kilogramos a Libras.
                    double kg, lb;
                    do
                    {
                        Console.WriteLine("Programa para convertir N kg en libras");
                        Console.WriteLine("Ingrese un numero");
                        kg = double.Parse(Console.ReadLine());
                        if (kg <= 0)
                        {
                            Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                        }
                    } while (kg <= 0);
                    //la formula para pasar de kg a lb es 2.205
                    lb = kg * 2.205;
                    Console.WriteLine(" ");
                    Console.WriteLine("{0} kg son iguales a {1} lb", kg, lb);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("El error se encuentra: "+ex.Message);
                }
            } while (true);
        }
    }
}
