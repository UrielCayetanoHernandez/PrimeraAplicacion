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

        public string Nombre { get => nombre; set => nombre = value; }

        public int Edad { get => edad; set => edad = value; }

        internal void crearpersona()
        {
            throw new NotImplementedException();
        }

        public string FechaNacimiento { get => fechanacimiento; set => fechanacimiento = value; }

        public void crearpersona(string _nombre, int _edad, string _fechanacimiento)
        {
            nombre = _nombre;
            this.edad = _edad;
            FechaNacimiento = _fechanacimiento;
        }
    }
}
