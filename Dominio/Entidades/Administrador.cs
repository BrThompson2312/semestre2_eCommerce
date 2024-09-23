namespace Dominio.Entidades
{
    public class Administrador : Usuario
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

        public Administrador(
            string _nombre, 
            string _apellido, 
            string _email, 
            string _contrasenia
        ) : base(_nombre, _apellido, _email, _contrasenia) {
            id = ultimoId++;
        }

        public override void Validar()
        {
            base.Validar();
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            Administrador administrador = obj as Administrador;
            return administrador != null && id == administrador.id;
        }

        public void FinalizarPublicacion()
        {
        }

        public void ValidarSubasta()
        {
        }
        
    }
}