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
            string res = $"Articulo id_{Id}({Nombre}):";
            if (string.IsNullOrEmpty(Nombre))
            {
                throw new Exception($"{res} Nombre invalido");
            } 
            else if (string.IsNullOrEmpty(Categoria))
            {
                throw new Exception($"{res} Categoria invalido");
            }
            else if (Precio < 0 || Precio == 0)
            {
                throw new Exception($"{res} Precio invalido: {Precio}");
            }
        }

        public override string ToString()
        {
            string res = $" Id: {Id} ";
            res += $" Nombre: {Nombre} ";
            res += $" Categoria: {Categoria} ";
            res += $" Precio: {Precio} ";
            return res;
        }

        public override bool Equals(object obj)
        {
            Articulo articulo = obj as Articulo;
            return articulo != null && articulo.Id == Id || articulo.Nombre == Nombre && articulo.Categoria == Categoria;
        }
    }
}