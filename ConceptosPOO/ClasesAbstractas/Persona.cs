using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO.ClasesAbstractas
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public void Presentarse()
        {
            Console.WriteLine($"Hola, soy {Nombre} y tengo {Edad} años.");
        }

        public abstract void Trabajar(); // cada uno trabaja distinto
    }

    public interface IRemoto
    {
        void TrabajarDesdeCasa();
    }

    public interface IExtra
    {
        void HacerHorasExtra();
    }

    public class Programador : Persona, IRemoto, IExtra
    {
        public Programador(string nombre, int edad) 
            : base(nombre, edad) { }

        public override void Trabajar()
        {
            Console.WriteLine("Escribiendo código...");
        }

        public void TrabajarDesdeCasa()
        {
            Console.WriteLine("Trabajando desde casa por videollamada.");
        }

        public void HacerHorasExtra()
        {
            Console.WriteLine("Trabajando hasta tarde arreglando bugs.");
        }
    }
    public class Obrero : Persona
    {
        public Obrero(string nombre, int edad) : base(nombre, edad) { }

        public override void Trabajar()
        {
            Console.WriteLine("Trabajando en la obra.");
        }
    }


}
