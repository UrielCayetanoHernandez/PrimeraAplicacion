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
            Persona objpersona = new Persona();
            objpersona.crearpersona("Uriel Cayetano", 25, "27-03-1997");

            Console.WriteLine("Nombre:" + objpersona.Nombre + " Edad: " + objpersona.Edad + " Fecha Nacimiento: " + objpersona.FechaNacimiento);


            Console.WriteLine("Sobre carga de metodo" + objpersona.crearPersona());

            Console.ReadLine();
        }
    }
}
