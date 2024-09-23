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
        private List<Publicacion> _publicaciones = new List<Publicacion>();

        public List<Publicacion> Publicaciones { 
            get { return _publicaciones; } 
        }

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

        public override string ToString()
        {
            string res = "";
            res += $"id: {id}, nombre: {nombre}, apellido: {apellido}, email: {email}, contraseña {contrasenia}";
            foreach(Publicacion _publicacion in _publicaciones)
            {
                res += $"{_publicacion}";
            }
            return res;
        }

    }
}