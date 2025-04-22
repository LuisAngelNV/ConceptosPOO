using ConceptosPOO.Intrefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    public class Moto : Vehiculo, IConducible
    {
        // Propiedades específicas de la clase Moto - Atributos
        public bool TieneCasco;
        public void Conducir()
        {
            Console.WriteLine("Conduciendo una moto...");
        }

    }

}
