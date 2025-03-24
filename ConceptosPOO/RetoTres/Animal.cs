using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO.RetoTres
{
    class Animal
    {
        public virtual void HacerSonido()
        {
            Console.WriteLine("Sonido genérico de animal");
        }
    }

    class Perro : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El perro ladra: Guau Guau!");
        }
    }

    class Gato : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El gato maulla: Miau Miau!");
        }
    }
}
