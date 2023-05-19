namespace Tienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario1 = new Usuario();
            Usuario usuario2 = new Usuario();
            Usuario usuario3 = new Usuario();


            Tienda tienda = new Tienda();

            tienda.Agregar(usuario1);
            tienda.Agregar(usuario2);
            tienda.Agregar(usuario3);

            tienda.Eliminar(usuario1);

            tienda.Notificar();
    

        }
    }
}