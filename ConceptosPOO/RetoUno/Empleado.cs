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
        protected int salario;
        

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


        // Corregir métodos de acceso
        public int GetSalario()
        {
            return salario;
        }

        public void SetSalario(int _Salario)
        {
            if (_Salario >= 0) // Validamos que el salario no sea negativo
            {
                salario = _Salario;
            }
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Empleado: {nombre}, Edad: {edad}, Salario: {salario}, Cargo: {cargo}");
        }
    }
}
