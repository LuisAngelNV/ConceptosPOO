using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO.ClasesAbstractas.PruebaDos
{
    // Clase abstracta
    public abstract class RobotAutonomo
    {
        // atributos
        public string Modelo;

        // Constructor
        public RobotAutonomo(string modelo)
        {
            Modelo = modelo;
        }

        // Metodos
        // No abstractos
        public void Iniciar()
        {
            Console.WriteLine($"Iniciando robot modelo [{Modelo}]");
        }

        public void Detener()
        {
            Console.WriteLine($"Deteniendo robot modelo [{Modelo}]");
        }
        // Metodos
        // abstractos
        public abstract void RealizarTarea();
    }

    // Interfaz(es)
    public interface IVolador
    {
        public void Volar();
    }
    public interface INadador
    {
        public void Nadar();
    }
    public interface IArtillero
    {
        public void Disparar();
    }

    // Clase(s) derivada(s)
    public class RobotRescatista : RobotAutonomo, INadador
    {
        public RobotRescatista(string modelo)
            : base(modelo)
        {
            Modelo = modelo;
        }
        public override void RealizarTarea()
        {
            Console.WriteLine("Rescatando personas en zonas inundadas.");
        }
        public void Nadar()
        {
            Console.WriteLine("Nadando a través de las aguas peligrosas.");
        }
    }

    public class RobotAereo : RobotAutonomo, IVolador
    {
        public RobotAereo(string modelo)
            : base(modelo)
        {
            Modelo = modelo;
        }
        public override void RealizarTarea()
        {
            Console.WriteLine("Realizando reconocimiento aéreo.");
        }
        public void Volar()
        {
            Console.WriteLine("Elevándose a gran altura.");
        }
    }

    public class RobotDeCombate : RobotAutonomo, IVolador, IArtillero
    {
        public RobotDeCombate(string modelo)
            : base(modelo)
        {
            Modelo = modelo;
        }
        public override void RealizarTarea()
        {
            Console.WriteLine("Entrando en zona de combate.");
        }

        public void Volar()
        {
            Console.WriteLine("Moviéndose rápidamente entre obstáculos.");
        }
        public void Disparar()
        {
            Console.WriteLine("Disparando proyectiles al objetivo.");
        }

    }
}
