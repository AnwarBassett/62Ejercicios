using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    /*Ejercicio 5# Evaluar la Función Y= 5X^4 + 2X^3 + 3X^2 + 7 para el valor de 
                      a)	X = 1;
                      b)	X un número cualquiera.*/
                    double x, y1, y2, y3, y;
                    int opc;
                    do
                    {
                        Console.WriteLine("Seleccione una opcion para evaluar la funcion Y= 5X^4 + 2X^3 + 3X^2 + 7 ");
                        Console.WriteLine("1.X=1");
                        Console.WriteLine("2.X es un numero cualquiera");
                        Console.WriteLine("3.Limpiar");
                        Console.WriteLine("4.Salir");
                        opc = int.Parse(Console.ReadLine());
                        if (opc <= 0)
                        {
                            Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                        }
                    } while (opc <= 0 || opc > 4);

                    switch (opc)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("1.X=1");
                            Console.WriteLine(" ");
                            x = 1;
                            y1 = 5 * Math.Pow(x, 4);
                            y2 = 2 * Math.Pow(x, 3);
                            y3 = 3 * Math.Pow(x, 2);
                            y = y1 + y2 + y3 + 7;
                            Console.WriteLine("La funcion evaluada en x=1 tiene por respuesta Y=" + y);
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("2.X es un numero cualquiera");
                            Console.WriteLine(" ");
                            do
                            {
                                Console.WriteLine("Digite el valor de X");
                                x = double.Parse(Console.ReadLine());
                                if (x <= 0)
                                {
                                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                                }
                            } while (x <= 0);
                            y1 = 5 * Math.Pow(x, 4);
                            y2 = 2 * Math.Pow(x, 3);
                            y3 = 3 * Math.Pow(x, 2);
                            y = y1 + y2 + y3 + 7;
                            Console.WriteLine("La funcion evaluada en x=1 tiene por respuesta Y=" + y);
                            break;
                        case 3:
                            Console.Clear();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("El error se encuentra en: " + ex.Message);
                }
                Console.ReadKey();
            } while (true);
        }
    }
}
