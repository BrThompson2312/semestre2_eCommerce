namespace Dominio.Entidades
{
    public class Articulo : IValidar
    {
        public int Id {get; set;}
        private static int ultimoId = 0;
        public string Nombre {get; set;}
        public string Categoria {get; set;}
        public int Precio {get; set;}

        public Articulo(string _nombre, string _categoria, int _precio)
        {
            Id = ultimoId++;
            Nombre = _nombre;
            Categoria = _categoria;
            Precio = _precio;
        }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                throw new Exception("Nombre vacio!");
            } 
            else if (string.IsNullOrEmpty(Categoria))
            {
                throw new Exception("Categoria vacio!");
            }
            else if (Precio < 0)
            {
                throw new Exception("Precio negativo!");
            }
        }

        public override string ToString()
        {
            string res = $"Id: {Id}";
            res += $"Nombre: {Nombre}";
            res += $"Categoria: {Categoria}";
            res += $"Precio: {Precio}";
            return res;
        }

        public override bool Equals(object? obj)
        {
            Articulo articulo = obj as Articulo;
            return articulo != null && articulo.Id != Id;
        }
    }
}