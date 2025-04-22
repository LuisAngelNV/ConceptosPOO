using ConceptosPOO.RetoUno;
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

    interface IEmpleado
    {
        void Trabajar();
    }

    public class IGerente : IEmpleado
    {
        public void Trabajar()
        {
            {
                Console.WriteLine("El gerente está organizando reuniones.");
            }
        }
    }
    public class IDesarrollador : IEmpleado
    {
        public  void Trabajar()
        {
            Console.WriteLine("El desarrollador está escribiendo código.");
        }
    }
}
