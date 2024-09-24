namespace Dominio.Entidades
{
    public abstract class Usuario
    {
        private int Id {get; set;}
        private static int ultimoId = 0;
        private string Nombre {get; set;}
        private string Apellido {get; set;}
        private string Email {get; set;}
        private string Contrasenia {get; set;}
        private List<Publicacion> _publicaciones = new List<Publicacion>();

        public List<Publicacion> Publicaciones { 
            get { return _publicaciones; } 
        }

        // Constructor
        public Usuario(string _nombre, string _apellido, string _email, string _contrasenia)
        {
            Id = ultimoId++;
            Nombre = _nombre;
            Apellido = _apellido;
            Email = _email;
            Contrasenia = _contrasenia;
        }

        public virtual void Validar()
        {
            return;
        }

        public override bool Equals(object obj)
        {
            Usuario usuario = obj as Usuario;
            return usuario != null && Id == usuario.Id;
        }

        public override string ToString()
        {
            string res = "";
            res += $"id: {Id}, nombre: {Nombre}, apellido: {Apellido}, email: {Email}, contraseña {Contrasenia}";
            foreach(Publicacion _publicacion in _publicaciones)
            {
                res += $"{_publicacion}";
            }
            return res;
        }

    }
}