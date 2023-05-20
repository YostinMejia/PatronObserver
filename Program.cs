namespace Tienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente usuario1 = new Cliente();
            Cliente usuario2 = new Cliente();
            Cliente usuario3 = new Cliente();


            Tienda tienda = new Tienda();

            tienda.Agregar(usuario1);
            tienda.Agregar(usuario2);
            tienda.Agregar(usuario3);

            tienda.Eliminar(usuario1);

            tienda.Notificar();
    

        }
    }
}