using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO.ClasesAbstractas.PruebaUno
{
    // Clase abstracta
    public abstract class DispositivoInteligente
    {
        // / Atributos
        public string Nombre;
        public bool Encendido;

        // constructores
        public DispositivoInteligente(string Nombre)
        {
            this.Nombre = Nombre;
        }
        // Métodos
        //No abstracto(s)
        public void Encender()
        {
            Console.WriteLine($"Dispositivo {Nombre} encendido.");
        }
        public void Apagar()
        {
            Console.WriteLine($"Dispositivo {Nombre} apagado.");
        }

        // abstracto(s)
        public abstract void FuncionPrincipal();
    }


    // Intwrface(s)
    public interface IConectividad
    {
        public void ConectarInternet();
    }
    public interface ITemporizador
    {
        public void ProgramarTemporizador(int minutos);
    }

    // Clase(s) derivada(s)
    public class LamparaInteligente : DispositivoInteligente, ITemporizador
    {
        public LamparaInteligente(string Nombre) 
            : base(Nombre)
        {
            this.Nombre = Nombre;
        }
        public override void FuncionPrincipal()
        {
            Console.WriteLine("La lámpara cambia de color automáticamente.");
        }
        public void ProgramarTemporizador(int minutos)
        {
            Console.WriteLine($"La lámpara se apagará en {minutos} minutos.");
        }

    }

    public class CafeteraInteligente: DispositivoInteligente, ITemporizador
    {
        public CafeteraInteligente(string Nombre)
            : base(Nombre)
        {
            this.Nombre = Nombre;
        }
        public override void FuncionPrincipal()
        {
            Console.WriteLine("La cafetera prepara café automáticamente.");
        }

        public void ProgramarTemporizador(int minutos)
        {
            Console.WriteLine($"La cafetera se apagará en {minutos} minutos.");
        }
    }
    public class RobotAspiradora: DispositivoInteligente, IConectividad
    {
        // Constructor
        public RobotAspiradora(string Nombre)
            : base(Nombre)
        {
            this.Nombre = Nombre;
        }

        public override void FuncionPrincipal()
        {
            Console.WriteLine("El robot aspiradora comienza a limpiar la casa.");

        }
        public void ConectarInternet()
        {
            Console.WriteLine("El robot aspiradora se conecta a la red Wi-Fi.");
        }
    }
}
