using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    internal class Cliente: IObservador
    {
        public void Notificar()
        {
            Console.WriteLine("Ya tenemos lo que estaba esperando");
        }
    }
}
