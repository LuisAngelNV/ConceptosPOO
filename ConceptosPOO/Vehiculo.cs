using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    // Clase padre o superclase
    public class Vehiculo
    {
        // Propiedades de la clase Vehiculo - Atributos
        public string Marca;
        public string Modelo;

        // Método de la clase Vehiculo - Comportamiento
        public void MostrarInfo()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}");
        }
    }
}
