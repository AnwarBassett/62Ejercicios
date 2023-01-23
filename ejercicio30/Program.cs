using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //30.	Escriba un programa que tenga como entrada la lectura de dos números llamados “X” y “Y” y que imprima una salida que corresponda a cada uno de los pares.
                /*a)	(-X, -Y) Entonces sumar los cuadrados de cada componente.
                  b)	(-X, Y) Entonces restar al valor Y el valor de X.
                  c)	(X, -Y) Entonces dividir X entre Y
                  d)	(X, Y) Entonces verificar si X es mayor que Y, si es así sumarle a X el valor de Y, si no obtener la raíz cuadrada de X.
                 */
                double X, Y, Z;
                do
                {
                    Console.WriteLine("Ingrese X");
                    X = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese Y");
                    Y=double.Parse(Console.ReadLine());
                    if (X == 0 || Y == 0)
                    {
                        Console.WriteLine("No puede agregar cero o letras");
                    }
                } while ( X == 0 || Y == 0);
                if (X < 0 && Y < 0)
                {
                    Z = Math.Pow(X, 2) + Math.Pow(Y, 2);
                    Console.WriteLine("Dado que X={0} y Y={1} son negativos, la suma de los cuadrados de los componentes es: {2}", X, Y, Z);
                }
                else if (X < 0 && Y > 0)
                {
                    Z = X - Y;
                    Console.WriteLine("Dado que X={0} es negativo y Y={1} es positivo, entonces la resta del valor Y con el valor de X es: {2}", X, Y, Z);
                }
                else if (X > 0 && Y < 0)
                {
                    Z = (X / Y);
                    Console.WriteLine("Dado que X={0} es positivo y Y={1} es negativo, entonces la division entre X & Y es: {2}", X, Y, Z);
                }
                else if (X > 0 && Y > 0)
                {
                    if (X > Y)
                    {
                        Z = X + Y;
                        Console.WriteLine("Dado que X={0} y Y={1} son positivos y X es mayor que Y, la suma de los componentes es: {2}", X, Y, Z);
                    }
                    else
                    {
                        Z = Math.Sqrt(X);
                        Console.WriteLine("Dado que X={0} y Y={1} son positivos y X es menor que Y, la raiz cuadrada de X es: {2}", X, Y, Z);
                    }

                }
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
