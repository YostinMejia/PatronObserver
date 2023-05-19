using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    interface IObservable
    {
        void Agregar(Usuario usuario);
        void Eliminar(Usuario usuario);
        void Notificar();
    }
}
