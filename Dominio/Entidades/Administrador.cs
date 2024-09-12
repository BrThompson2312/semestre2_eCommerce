namespace Dominio.Entidades
{
    public class Administrador
    {
        private static int id = 0;
        private string nombre;
        private string apellido;
        private string email;
        private string contrasenia;

        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string Email {get; set;}
        public string Contrasenia {get; set;}

        public Administrador(string _nombre, string _apellido, string _email, string _contrasenia)
        {
            id++;
            nombre = _nombre;
            apellido = _apellido;
            email = _email;
            contrasenia = _contrasenia;
        }
    }
}