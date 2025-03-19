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
        // Atributo protegido
        protected string Marca;
        // Método
        public void AsignarMarca(string marca)
        {
            this.Marca = marca;
        }
        // Método
        public void MostrarMarca()
        {
            Console.WriteLine($"Marca: {Marca}");
        }
    }
}
