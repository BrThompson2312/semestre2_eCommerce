namespace Dominio.Entidades
{
    public class Articulo : IValidar
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

        public void Validar()
        {
        }

        public override string ToString()
        {
            string res = $"Id: {Id}";
            res += $"Nombre: {Nombre}";
            res += $"Categoria: {Categoria}";
            res += $"Precio: {Precio}";
            return res;
        }
    }
}