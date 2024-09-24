namespace Dominio.Entidades
{
    public class Cliente : Usuario
    {
        private int Saldo {get; set;}

        public Cliente(
            string _nombre,
            string _apellido, 
            string _email,
            string _contrasenia,
            int _saldo
        ) : base(_nombre, _apellido, _email, _contrasenia) {
            Saldo = _saldo;
        }

        public override void Validar()
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            Cliente cliente = obj as Cliente;
            return cliente != null;
        }

        public void CrearPublicacion()
        {
        }

    }
}