using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*1.determine el area de un rectangulo que tiene por base "b" y por altura "H", imprima la base,
            la altura y su area
            2.determine le perimetro de una circunferencia y el area de un circulo
            3.determine el valor de Y=X*C-2 donde C es una constante con valor C=2.5
            a)sabiendo que X=2
            b)considerando a X un valor cualquiera*/
                int opc;
                String valor1, valor2;
                bool com;
                do
                {
                    try
                    {
                        do
                        {
                            do
                            {
                                Console.WriteLine("Seleccione que operacion realizara");
                                Console.WriteLine("1.Area de un Rectangulo");
                                Console.WriteLine("2.Perimetro y Area de una circunferencia");
                                Console.WriteLine("3.Y=X*C-2");
                                Console.WriteLine("4.Salir");
                                valor1 = Console.ReadLine();
                                com = int.TryParse(valor1, out opc);
                            } while (!com);

                        } while (opc <= 0 || opc > 4);

                        switch (opc)
                        {
                            case 1:
                                int b, h;
                                do
                                {
                                    Console.WriteLine("Digite la base");
                                    valor1 = Console.ReadLine();
                                    com = int.TryParse(valor1, out b);
                                    Console.WriteLine("Digite la altura");
                                    valor2 = Console.ReadLine();
                                    com = int.TryParse(valor2, out h);
                                } while (b <= 0 || h <= 0 || !com);
                                Console.WriteLine("La base:{0}, la altura:{1}, el area:{2} ", b, h, (b * h));
                                break;
                            case 2:
                                double r, a, p;
                                do
                                {
                                    Console.WriteLine("Digite el radio");
                                    r = int.Parse(Console.ReadLine());
                                    valor1 = Console.ReadLine();
                                    com = int.TryParse(valor1, out opc);
                                } while (r <= 0 || !com);
                                a = Math.PI * (Math.Pow(r, 2));
                                p = 2 * Math.PI * r;
                                Console.WriteLine("Radio:{0}, Area:{1}, Perimetro:{2}", r, a, p);
                                break;
                            case 3:
                                double y, c, x, op;
                                c = 2.5;
                                do
                                {
                                    Console.WriteLine("Elija su opcion dependiendo del valor X");
                                    Console.WriteLine("1.X=2");
                                    Console.WriteLine("2.X es un valor diferente");
                                    valor1 = Console.ReadLine();
                                    com = double.TryParse(valor1, out op);
                                } while (op <= 0 || op > 2 || !com);

                                switch (op)
                                {
                                    case 1:
                                        x = 2;
                                        y = x * c - 2;
                                        Console.WriteLine("El valor de Y=X*C-2 es:");
                                        Console.WriteLine("Y={0}*{1}-2={2}", c, x, y);
                                        break;
                                    case 2:
                                        do
                                        {
                                            Console.WriteLine("Ingrese el valor de X");
                                            valor1 = Console.ReadLine();
                                            com = double.TryParse(valor1, out x);
                                        } while (x <= 0 || !com);
                                        y = x * c - 2;
                                        Console.WriteLine("El valor de Y=X*C-2 es:" + y);
                                        break;
                                }
                                break;
                            case 4:
                                Console.WriteLine("Que tenga un buen dia");
                                Environment.Exit(0);
                                break;
                        }
                    }
                    catch (FormatException error)
                    {
                        Console.WriteLine("Invalido " + error);
                    }

                    Console.ReadKey();

                } while (true);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
