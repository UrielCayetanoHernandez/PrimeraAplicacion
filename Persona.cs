using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAplicacion
{
    class Persona
    {
        private string nombre;
        private int edad;
        private string fechanacimiento;

        public Persona()
        {
            Console.WriteLine("Soy el constructor");
        }

        public string Nombre { get => nombre.ToUpper(); set => nombre = value; }

        public int Edad { get => edad; set => edad = value; }


        public string FechaNacimiento { get => fechanacimiento; set => fechanacimiento = value; }

        public void crearpersona(string _nombre, int _edad, string _fechanacimiento)
        {
            nombre = _nombre;
            this.edad = _edad;
            FechaNacimiento = _fechanacimiento;
        }

        public string crearPersona()
        {
            return "Nombre:" + Nombre + " Edad: " + Edad + " Fecha Nacimiento: " + FechaNacimiento;
        } 
    }
}
