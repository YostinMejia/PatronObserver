using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    internal class Tienda:IObservable
    {
        List<Cliente> Clientes = new List<Cliente>();
        public void Agregar(Cliente cliente)
        {
            Clientes.Add(cliente);
        }
        public void Eliminar(Cliente cliente)
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
