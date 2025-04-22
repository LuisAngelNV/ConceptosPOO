using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO.Intrefaces.DispositivosElectronicos
{
    public interface ITelefono
    {

    }
    public interface ILlamadas
    {
        void Llamar(string numero);
    }

    public interface IInternet
    {
        void Navegar(string url);
    }

    public interface ICamara
    {
        void TomarFoto();
    }
}
