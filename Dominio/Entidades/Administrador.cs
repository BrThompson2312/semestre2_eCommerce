namespace Dominio.Entidades
{
    public class Administrador : Usuario
    {

        public Administrador()
        {
        }

        public Administrador(
            string _nombre, 
            string _apellido, 
            string _email, 
            string _contrasenia,
            string _rol
        ) : base(_nombre, _apellido, _email, _contrasenia, _rol) {
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
            return base.Equals(obj);
        }
        
    }
}