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
        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            Administrador administrador = obj as Administrador;
            return administrador != null;
        }

        public void FinalizarPublicacion()
        {
        }

        public void ValidarSubasta()
        {
        }
        
    }
}