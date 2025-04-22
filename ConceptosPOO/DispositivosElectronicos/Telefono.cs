using ConceptosPOO.Intrefaces.DispositivosElectronicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO.DispositivosElectronicos
{
    public class Telefono : ILlamadas, IInternet, ICamara
    {
        public void Llamar(string numero)
        {
            Console.WriteLine($"Llamando al número {numero}...");
        }

        public void Navegar(string url)
        {
            Console.WriteLine($"Navegando en {url}...");
        }

        public void TomarFoto()
        {
            Console.WriteLine("Foto tomada con la cámara.");
        }
    }

}

