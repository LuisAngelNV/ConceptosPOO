using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO.InterfaceRetoDos
{
    public interface INotificador
    {
        void Notificar(string mensaje);
    }

    public class EmailNotificador : INotificador
    {
        public void Notificar(string mensaje)
        {
            Console.WriteLine($"📧 Email: Bienvenido al sistema");
        }
    }
    public class SmsNotificador : INotificador
    {
        public void Notificar(string mensaje)
        {
            Console.WriteLine($"📱 SMS: Bienvenido al sistema");
        }
    }
    public class PushNotificador : INotificador
    {
        public void Notificar(string mensaje)
        {
            Console.WriteLine($"🔔 Push: Bienvenido al sistema");
        }
    }

    public class Alerta
    {
        private INotificador _notificador;

        public Alerta(INotificador notificador)
        {
            _notificador = notificador;
        }

        public void Enviar(string mensaje)
        {
            _notificador.Notificar(mensaje);
        }

    }
}
