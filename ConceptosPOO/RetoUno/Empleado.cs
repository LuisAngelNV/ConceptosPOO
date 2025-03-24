using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO.RetoUno
{
    public class Empleado
    {
        public string nombre;
        public string cargo;
        public int edad;
        private int salario;


        //Constructor(es)
        public Empleado()
        {
            nombre = "Desconocido";
            edad = 0; 
            salario = 0;

        }
        public Empleado(string nombre,string cargo, int edad, int salario)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.salario = salario;
            this.cargo = cargo;
        }

        // Propiedad para manejar el salario de forma más limpia
        public int Salario
        {
            get { return salario; }
            set
            {
                if (value >= 0)  // Validación dentro de la propiedad
                    salario = value;
            }
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Empleado: {nombre}, Edad: {edad}, Salario: {salario}, Cargo: {cargo}");
        }
    }
}
