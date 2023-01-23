using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //61 Elabore un programa que calcule los 20 primeros números de la serie de Fibonacci: 0,1,1,2,3,5,8,13,
                //Esta serie empieza con 0 y 1 y tiene la propiedad que cada número Fibonacci subsecuente es la suma de dos números Fibonacci previos.
                int A, B, C, Cont;
                Cont = 20;
                A = 0; B = 1;
                Console.Write("Serie de Fibonacci: ");
                Console.Write(A + " " + B + " ");
                for (int i = 3; i <= Cont; i++)
                {
                    C = A + B;
                    Console.Write(C + " ");
                    //Se hace un intercambio de valores
                    A = B;
                    B = C;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
