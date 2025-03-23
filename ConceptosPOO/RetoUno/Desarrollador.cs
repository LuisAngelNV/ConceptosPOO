using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConceptosPOO.RetoUno
{
    class Desarrollador: Empleado
    {
        public string lenguaje;

        // constructor
        public Desarrollador()
        {
            lenguaje = "Desconocido";
        }
        // Constructor con base
        public Desarrollador(string nombre, int edad, int salario, string cargo, string lenguaje)
            : base(nombre, cargo, edad, salario)
        {
            this.lenguaje = lenguaje;
        }

        public new void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Lenguaje de programación: {lenguaje}");
        }
    }
}
