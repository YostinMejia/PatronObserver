using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    internal class Tienda:IObservable
    {
        List<Usuario> Clientes = new List<Usuario>();
        public void Agregar(Usuario cliente)
        {
            Clientes.Add(cliente);
        }
        public void Eliminar(Usuario cliente)
        {
            Clientes.Remove(cliente);

        }
        public void Notificar()
        {
            foreach(var cliente in Clientes)
            {
                cliente.Notificar();
                
            }
        }
    }
}
