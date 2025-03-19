using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    public class Auto : Vehiculo
    {
        // Propiedades específicas de la clase Auto - Atributos
        public int NumeroPuertas;


        public void CambiarMarca(string nuevaMarca)
        {
            this.Marca = nuevaMarca; // Se puede acceder porque es 'protected'
            Console.WriteLine($"nueva marca {nuevaMarca}");
        }
    }
}
