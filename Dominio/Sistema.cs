using Dominio.Entidades;

namespace Dominio
{
    public class Sistema
    {
        private List<Usuario> _usuarios = new List<Usuario>();
        private List<Publicacion> _publicaciones = new List<Publicacion>();

        public List<Usuario> Usuarios {
            get { return _usuarios; }
        }
        public List<Publicacion> Publicaciones {
            get { return _publicaciones; }
        }

        public void AgregarAdministrador() 
        {
        }

        public void AgregarCliente()
        {
        }

        public void CrearPublicacion()
        {
        }

    }
}