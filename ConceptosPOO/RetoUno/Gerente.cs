using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConceptosPOO.RetoUno
{
    class Gerente : Empleado
    {
        public string departamento { get; set; }
        public Gerente()
        {
            departamento = "Desconocido";
        }
        public Gerente(string nombre, int edad, int salario, string cargo, string departamento)
        : base(nombre, cargo, edad, salario)
        {
            this.departamento = departamento;
        }

        public new void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Departamento: {departamento}");
        }
    }

}
