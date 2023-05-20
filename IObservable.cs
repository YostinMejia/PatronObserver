using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    interface IObservable
    {
        void Agregar(Cliente usuario);
        void Eliminar(Cliente usuario);
        void Notificar();
    }
}
