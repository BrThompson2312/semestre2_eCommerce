using Dominio.Entidades;

namespace Dominio
{
    public class Sistema
    {
        private List<Usuario> _usuarios = new List<Usuario>();
        private List<Publicacion> _publicaciones = new List<Publicacion>();
        private List<Articulo> _articulos = new List<Articulo>();

        public List<Usuario> Usuarios {
            get { return _usuarios; }
        }
        public List<Publicacion> Publicaciones {
            get { return _publicaciones; }
        }

        public void AgregarAdministrador(object obj) 
        {
            Usuario unAdministrador = obj as Administrador;
            if (unAdministrador == null)
            {
                throw new Exception("Invalido");
            }
            unAdministrador.Validar();
            _usuarios.Add(unAdministrador);
        }

        public void AgregarCliente(object obj)
        {
            Usuario unCliente = obj as Cliente;
            if (unCliente == null)
            {
                throw new Exception("Invalido");
            }
            unCliente.Validar();
            _usuarios.Add(unCliente);
        }

        public void CrearPublicacionVenta(Publicacion unaPublicacion)
        {
            if (unaPublicacion == null)
            {
                throw new Exception("Invalido");
            }
        }

        public void CrearPublicacionSubasta(Publicacion unaPublicacion)
        {
            if (unaPublicacion == null)
            {
                throw new Exception("Invalido");
            }
        }

        public void AgregarOferta(Oferta unaOferta)
        {
            if (unaOferta == null)
            {
                throw new Exception("Invalido");
            }
        }

        public void ValidarArticulo(Articulo unArticulo)
        {
            if (unArticulo == null)
            {
                throw new Exception("Invalido");
            }
        }

    }
}