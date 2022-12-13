using System;
using System.Collections.Generic;
using System.IO;
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
            string archivo = "archivo.txt";
            string contenido;

            FileStream fsSource = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fsSource))
            {
                contenido = sr.ReadToEnd();
            }

            Console.WriteLine(contenido);

            Console.ReadLine();
        }
    }
}
