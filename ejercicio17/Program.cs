using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    //17.	Determinar la energía total que almacena un cuerpo si su energía cinética es
                    //½ de la masa por su velocidad al cuadrado y la energía potencial
                    //es el producto de la masa, altura y la constante de gravedad. Recuerde que ET = EC +EP.
                    double m, v, a, Energiacin, EnergiaPot, EnergiaTotal;
                    double gravedad = 9.8;
                    do
                    {
                        Console.Write("Ingrese la masa del cuerpo:  ");
                        m = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese la velocidad del cuerpo:  ");
                        v = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese la altura del cuerpo:  ");
                        a = int.Parse(Console.ReadLine());
                        if(a <= 0 || v <= 0 || m <= 0)
                        {
                            Console.WriteLine("No puede ingresar datos negativos o cero");
                        }
                    } while (a <= 0 || v <= 0 || m <= 0);
                    Energiacin = 0.5 * m * v * v;
                    EnergiaPot = m * a * gravedad;
                    EnergiaTotal = Energiacin + EnergiaPot;
                    Console.WriteLine("La energía total es: " + EnergiaTotal);
                    

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (true);
        }
    }
}
