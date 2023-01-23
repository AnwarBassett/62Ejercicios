using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //57 Dado un número determinar la suma de sus dígitos.
                String numeros;
                Console.WriteLine("Programa para sumar los digitos de un numero");
                Console.WriteLine("Escriba un numero");
                numeros = Console.ReadLine();
                char[] ListaNum = numeros.ToCharArray();


                int suma = 0;
                foreach (char numero in ListaNum
                    )
                {
                    Console.WriteLine("Numero: " + numero);
                    suma += int.Parse(numero.ToString());
                }

                Console.WriteLine("suma:  " + suma);
                Console.ReadKey();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
