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
            int tabla = 4, num = 1, limite = 10;

            for(num = num; num<= limite; num++)
            {
                Console.WriteLine(tabla + " * " + num + " = " + tabla * num); // 4* 1= 4
            }

            Console.Read();
        }
    }
}
