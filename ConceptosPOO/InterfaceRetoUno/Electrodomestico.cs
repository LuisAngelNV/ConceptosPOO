using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO.InterfaceRetoUno
{
    public  class  Electrodomestico
    {
        // Atributos
        private string Nombre;

        public Electrodomestico(string nombre)
        {
            this.Nombre = nombre;
        }

    }

    public class Televisor : Electrodomestico, IEncendible, IApagable
    {
        public Televisor(string nombre) : base(nombre) { }

        public void Encender()
        {
            Console.WriteLine("El televisor se ha encendido");
        }

        public void Apagar()
        {
            Console.WriteLine("El televisor se ha apagado");
        }
    }

    public class Refrigerador : Electrodomestico, IEncendible, IApagable
    {
        public Refrigerador(string nombre) : base(nombre) { }

        public void Apagar()
        {
            Console.WriteLine("El refrigerador se ha apagado");
        }

        public void Encender()
        {
            Console.WriteLine("El refrigerador está funcionando");
        }
    }

    public interface IEncendible
    {
        public void Encender();
    }
    public interface IApagable
    {
        public void Apagar();
    }


}
