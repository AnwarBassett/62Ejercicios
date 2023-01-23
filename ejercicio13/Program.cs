using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    double i, f, p, cm;
                    int opc;
                    do
                    {
                        //13# Convertir Y yardas, F pies y I pulgadas a Centímetros.
                        Console.WriteLine("Programa para convertir Y yardas, F pies y I pulgadas a Centímetros.");
                        Console.WriteLine("Seleccione una opcion");
                        Console.WriteLine("1.Yardas a centimetros");
                        Console.WriteLine("2.Pies a centimetros");
                        Console.WriteLine("3.Pulgadas a centimetros");
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
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("1.Yardas a centimetros");
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese las yardas");
                                f= double.Parse(Console.ReadLine());
                                if (f <= 0)
                                {
                                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                                }
                            } while (f <= 0);
                            cm = f * 91.44;
                            Console.WriteLine("{0} yardas son igual a {1} centimetros", f, cm);
                            break;
                        case 2:
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("2.Pies a centimetros");
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese los Pies");
                                p = double.Parse(Console.ReadLine());
                                if (p <= 0)
                                {
                                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                                }
                            } while (p <= 0);
                            cm = p * 30.48;
                            Console.WriteLine("{0} Pies son igual a {1} centimetros", p, cm);
                            break;
                        case 3:
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("3.Pulgadas a centimetros");
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese las Pulgadas");
                                i = double.Parse(Console.ReadLine());
                                if (i <= 0)
                                {
                                    Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                                }
                            } while (i <= 0);
                            cm = i * 2.54;
                            Console.WriteLine("{0} Pulgadas son igual a {1} centimetros", i, cm);
                            break;
                        case 4:
                            Console.WriteLine("Que tenga buen dia");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Opcion no validad");
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("El error es: "+ex.Message);
                }
                Console.ReadKey();
            } while (true);
        }
    }
}
