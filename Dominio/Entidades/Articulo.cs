namespace Dominio.Entidades
{
    public class Articulo
    {
        private static int id = 0;
        private string nombre;
        private string categoria;
        private int precio;
        public Articulo(string _nombre, string _categoria, int _precio)
        {
            id++;
            nombre = _nombre;
            categoria = _categoria;
            precio = _precio;
        }
    }
}