using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO.RetoDos
{
    class Cuadrado: Figura
    {
        public double Lado { get; set; }

        public Cuadrado()
        {
            Lado = 0;
        }

        public override double CalcularArea()
        {
            return (Lado * Lado);
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Es un cuadrado con un Área: {CalcularArea()}");
        }
    }
}
