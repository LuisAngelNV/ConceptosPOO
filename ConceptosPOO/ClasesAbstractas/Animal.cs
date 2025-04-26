using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO.ClasesAbstractas
{
    public abstract class CAAnimal
    {
        public string Nombre { get; set; }

        public abstract void HacerSonido(); // Sin implementación

        public void Comer()
        {
            Console.WriteLine($"{Nombre} está comiendo.");
        }
    }
    public class Perro : CAAnimal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("Guau Guau!");
        }
    }


}
