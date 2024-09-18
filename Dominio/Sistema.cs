using Dominio.Entidades;

namespace Dominio
{
    public class Sistema
    {
        private List<Usuario> _usuarios = new List<Usuario>();
        // private List<Administrador> _administradores = new List<Administrador>();
        // private List<Cliente> _clientes = new List<Cliente>();

        private List<Publicacion> _publicaciones = new List<Publicacion>();

        public void AgregarUsuario(Usuario usuario)
        {
            if (usuario == null) {
                throw new Exception("Objeto no valido");
            }
            usuario.Validar();
            _usuarios.Add(usuario);
        }

    }
}