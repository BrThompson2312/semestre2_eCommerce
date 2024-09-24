namespace Dominio.Entidades
{
    public class Articulo
    {
        private int Id {get; set;}
        private static int ultimoId = 0;
        private string Nombre {get; set;}
        private string Categoria {get; set;}
        private int Precio {get; set;}
        public Articulo(string _nombre, string _categoria, int _precio)
        {
            Id = ultimoId++;
            Nombre = _nombre;
            Categoria = _categoria;
            Precio = _precio;
        }
        
    }
}