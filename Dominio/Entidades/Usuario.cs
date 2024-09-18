namespace Dominio.Entidades
{
    public abstract class Usuario
    {
        private int id;
            private static int ultimoId = 0;
        private string nombre;
        private string apellido;
        private string email;
        private string contrasenia;
        private List<Publicacion> catalogos = new List<Publicacion>();

        // public int Id {get;}
        // public string Nombre {get;}
        // public string Apellido {get;}
        // public string Email {get;}
        // public string Contrasenia {get;}
        public List<Publicacion> Catalogos { get { return catalogos; } }

        // Constructor
        public Usuario(string _nombre, string _apellido, string _email, string _contrasenia)
        {
            id = ultimoId++;
            nombre = _nombre;
            apellido = _apellido;
            email = _email;
            contrasenia = _contrasenia;
        }

        public virtual void Validar()
        {
            return;
        }

        public override bool Equals(object obj)
        {
            Usuario usuario = obj as Usuario;
            return usuario != null && id == usuario.id;
        }
    }
}