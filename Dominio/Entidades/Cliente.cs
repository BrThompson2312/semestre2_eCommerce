namespace Dominio.Entidades
{
    public class Cliente : Usuario
    {
        public int Saldo {get; set;}

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
            base.Validar();
            if (Saldo < 0)
            {
                throw new Exception($"Cliente: Saldo invalido: {Saldo}");
            }
        }

        //public override int TipoUsuario()
        //{
        //    return 0;
        //}

        public override string ToString()
        {
            string res = base.ToString();
            res += $"Saldo: {Saldo}";
            return res;
        }
        
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

    }
}