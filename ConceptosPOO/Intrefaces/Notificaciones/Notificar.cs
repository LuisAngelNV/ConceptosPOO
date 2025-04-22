using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO.Intrefaces.Notificaciones
{
    public class EmailNotificador : INotificador
    {
        public void Notificar(string mensaje)
        {
            Console.WriteLine($"📧 Email: {mensaje}");
        }
    }

    public class SmsNotificador : INotificador
    {
        public void Notificar(string mensaje)
        {
            Console.WriteLine($"📱 SMS: {mensaje}");
        }
    }

    public class PushNotificador : INotificador
    {
        public void Notificar(string mensaje)
        {
            Console.WriteLine($"🔔 Push: {mensaje}");
        }
    }

    public class Alerta
    {
        private INotificador _notificador;

        public Alerta(INotificador notificador)
        {
            _notificador = notificador;
        }

        public void EnviarAlerta()
        {
            _notificador.Notificar("¡Tienes una nueva alerta!");
        }
    }
}
