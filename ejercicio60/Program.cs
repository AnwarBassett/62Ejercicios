using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //60 Elaborar un programa adivinanza.
                //Este programa preguntará ¿Cuál es la capital del folclore nicaragüense?
                //El usuario tendrá tres oportunidades de responder, si el usuario acierta antes de la tercera posibilidad
                //el programa le informara de su acierto si no acertara en ninguna el programa posteriormente suministrará la respuesta.
                int cont, comprobar;
                string resp;
                comprobar = 0; cont = 0;
                do
                {
                    Console.WriteLine("¿Cuál es la capital del folclore nicaragüense?");
                    Console.Write("Escriba su respuesta: ");
                    resp = Console.ReadLine();
                    if ((resp.ToUpper() == "MASAYA"))
                    {
                        comprobar = 1;
                        break;
                    }
                    else
                    {
                        cont++;
                    }
                } while (((cont < 3)));
                if (comprobar == 1)
                {
                    Console.WriteLine("Correcto! La respuesta es: " + resp);
                }
                else
                {
                    Console.WriteLine("No hay mas oportunidades");
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
