namespace Dominio.Entidades
{
    public abstract class Usuario : IValidar
    {
        public int Id {get; set;}
        private static int ultimoId = 0;
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string Email {get; set;}
        public string Contrasenia {get; set;}
        private List<Publicacion> _publicaciones = new List<Publicacion>();

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
            string res = $"Usuario id_{Id}({Nombre})";
            if (string.IsNullOrEmpty(Nombre))
            {
                throw new Exception($"{res}: Nombre invalido");
            } 
            else if(string.IsNullOrEmpty(Apellido)) 
            {
                throw new Exception($"{res}: Apellido invalido");
            }
            else if(string.IsNullOrEmpty(Email)) 
            {
                throw new Exception($"{res}: Email invalido");
            }
            else if(string.IsNullOrEmpty(Contrasenia)) 
            {
                throw new Exception($"{res}: Contraseña invalido");
            }
        }

        public virtual void AgregarPublicacion(Publicacion unaPublicacion)
        {
            unaPublicacion.Validar();
            _publicaciones.Add(unaPublicacion);
        }

        public override string ToString()
        {
            string res = $" Id: {Id} ";
            res += $" Nombre: {Nombre} ";
            res += $" Apellido: {Apellido} ";
            res += $" Email: {Email} ";
            res += $" Contraseña: {Contrasenia} ";
            foreach(Publicacion _publicacion in _publicaciones)
            {
                res += $" {_publicacion} ";
            }
            return res;
        }

        public override bool Equals(object obj)
        {
            Usuario usuario = obj as Usuario;
            return usuario != null && Id == usuario.Id || usuario.Email == Email;
        }

        public abstract int TipoUsuario();

    }
}