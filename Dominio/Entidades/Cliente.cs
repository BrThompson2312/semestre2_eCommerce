namespace Dominio.Entidades
{
    public class Cliente
    {
        private int saldo;
        private List<Publicacion> catalogos;

        public Cliente()
        {
            Console.WriteLine("Cliente!");
        }
    }
}