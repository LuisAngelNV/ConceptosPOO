using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO.RetoDos
{
    public class Triangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double LadoC { get; set; }

        public Triangulo() { Base = 0; Altura = 0; }

        // Constructor con base y altura
        public Triangulo(double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        // Constructor con los 3 lados (Fórmula de Herón)
        public Triangulo(double A, double B, double C)
        {
            double s = (A + B + C) / 2;
            this.Base = A;
            this.Altura = B;
            this.LadoC = C;
        }

        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Es un triángulo con base {Base} y altura {Altura}, Área: {CalcularArea()}");
        }
    }

}

