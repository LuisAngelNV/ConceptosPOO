using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO.RetoDos
{
    public class Figura
    {
        public virtual double CalcularArea()
        {
            return 0;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine("Es una figura geométrica");
        }
    }
}
