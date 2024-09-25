using Dominio.Entidades;

namespace Dominio
{
    public class Sistema
    {
        private List<Usuario> _usuarios = new List<Usuario>();
        private List<Publicacion> _publicaciones = new List<Publicacion>();
        public List<Articulo> _auxArticulos = new List<Articulo>();

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

        public void CrearVenta(Publicacion unaPublicacion)
        {
            Venta esVenta = unaPublicacion as Venta;
            if (unaPublicacion == null)
            {
                throw new Exception("Invalido");
            }
            _publicaciones.Add(unaPublicacion);
        }

        public void CrearSubasta(Publicacion unaPublicacion)
        {
            Subasta esSubasta = unaPublicacion as Subasta;
            if (esSubasta == null)
            {
                throw new Exception("Invalido");
            }
            _publicaciones.Add(unaPublicacion);
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

        public void ListadoAdministradores()
        {
            foreach (Administrador unAdministrador in _usuarios)
            {
                Console.WriteLine(unAdministrador);
            }
        }
        public void ListadoClientes()
        {
            foreach (Cliente unCliente in _usuarios)
            {
                Console.WriteLine(unCliente);
            }
        }
        public void ListadoVentas()
        {
            foreach (Venta unaVenta in _publicaciones)
            {
                Console.WriteLine(unaVenta);
            }
        }
        public void ListadoSubastas()
        {
            foreach (Subasta unaSubasta in _publicaciones)
            {
                Console.WriteLine(unaSubasta);
            }
        }
    }
}