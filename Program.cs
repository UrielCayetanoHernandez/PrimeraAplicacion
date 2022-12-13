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
            int[,] numeros = new int[10, 8];
            Random r = new Random();

            for(int x = 0; x < 10; x++)
            {
                for(int y = 0; y<8; y++)
                {
                    numeros[x, y] = r.Next(0, 9);
                    Console.Write(numeros[x, y] + " ");
                }
                Console.WriteLine();
            }
            int[] resultado = new int[10];

             for (int a = 0; a<8; a++)
            {
                resultado[a] = 0;
                for (int b = 0; b < 10; b++)

                {
                    resultado[a] += numeros[b, a];
                }
                Console.Write(resultado[a] + " ");
            }


            Console.Read();
        }
    }
}
