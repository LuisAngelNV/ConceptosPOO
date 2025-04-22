using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO.InterfacesRetoTres
{
    public interface IMetodoPago
    {
        void ProcesarPago(decimal monto);
    }

    public class PagoTarjeta : IMetodoPago
    {
        public void ProcesarPago(decimal monto)
        {
            Console.WriteLine($"Pagando {monto} con tarjeta de crédito...");
        }
    }

    public class PagoPayPal : IMetodoPago
    {
        public void ProcesarPago(decimal monto)
        {
            Console.WriteLine($"Pagando {monto} mediante PayPal...");
        }
    }

    public class PagoCripto : IMetodoPago
    {
        public void ProcesarPago(decimal monto)
        {
            Console.WriteLine($"Pagando {monto} con criptomonedas...");
        }
    }


    public class Checkout
    {
        private IMetodoPago _metodoPago;

        public Checkout(IMetodoPago metodoPago)
        {
            _metodoPago = metodoPago;
        }

        public void RealizarPago(decimal monto)
        {
            _metodoPago.ProcesarPago(monto);
        }

    }
}
