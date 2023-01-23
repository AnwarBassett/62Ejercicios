using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //27.	Unos pantalones se venden a 10 dólares cada uno si
                //se compran más de tres, 12 dólares en los demás casos,
                //estructure un programa que lea un número de entrada de
                //pantalones comprados e imprima el costo total.
                int cam, ttl;
                do
                {
                    Console.WriteLine("Programa para comprar pantalones");
                    cam = int.Parse(Console.ReadLine());
                    if (cam <= 0)
                    {
                        Console.WriteLine("No puede escribir numeros negativos o cero");

                    }
                } while (cam <= 0);
                if (cam > 3)
                {
                    ttl = cam * 10;
                    Console.WriteLine("El costo total de los pantalones es: "+ttl);
                }
                else
                {
                    ttl = cam * 12;
                    Console.WriteLine("El costo de los {0} pantalones es igual a {1}",cam,ttl);
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
