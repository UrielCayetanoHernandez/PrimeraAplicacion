using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Hola aprendiendo nuevas cosas
 para el desallo de uno
Cargar esto*/

namespace PrimeraAplicacion
{
    public class Program
    {
        static void Main(string[] args)
        {
            String opcion = "A";

            switch (opcion)
            {
                case "A":
                    Console.WriteLine("Opcion 1");
                    break;
                case "B":
                    Console.WriteLine("Opcion 2");
                    break;
                case "c":
                    Console.WriteLine("Opcion 3");
                    break;
                default:
                    Console.WriteLine("Opcion Invalida");
                    break;
            }


            Console.Read();
        }
    }
}
