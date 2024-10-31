namespace Dominio.Entidades
{
    public class Administrador : Usuario
    {

        public Administrador(
            string _nombre, 
            string _apellido, 
            string _email, 
            string _contrasenia
        ) : base(_nombre, _apellido, _email, _contrasenia) {
        }

        public override void Validar()
        {
            base.Validar();
        }

        //public override int TipoUsuario()
        //{
        //    return 1;            
        //}

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        
    }
}