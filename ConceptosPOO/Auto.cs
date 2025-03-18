using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    public class Auto
    {
        public string marca;
        public string modelo;
        public int año;

        // Método para mostrar la información del auto
        public void MostrarInfo()
        {
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Año: " + año);
        }
    }
}
