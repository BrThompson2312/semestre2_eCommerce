namespace Dominio.Entidades
{
    public class Administrador : Usuario
    {

        public Administrador()
        {
            Rol = "Administrador";
        }

        public Administrador(
            string _nombre, 
            string _apellido, 
            string _email, 
            string _contrasenia
        ) : base(_nombre, _apellido, _email, _contrasenia) {
            Rol = "Administrador";
        }

        public override void Validar()
        {
            base.Validar();
        }

        public override void RecargarSaldo(int monto)
        {
            throw new Exception("No implementado");
        }

        public override void DescontarSaldo(decimal monto)
        {
            throw new Exception("No implementado");
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}