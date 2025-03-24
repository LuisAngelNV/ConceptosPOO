using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO.RetoDos
{
    class Circulo : Figura
    {
        public double radio { get; set; }

        public Circulo()
        {
            radio = 0;
        }

        public override double CalcularArea()
        {
            return (Math.PI * Math.Pow(radio, 2));
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Es un Circulo con un radio de {radio} y Área: {CalcularArea()}");
        }
    }
}
