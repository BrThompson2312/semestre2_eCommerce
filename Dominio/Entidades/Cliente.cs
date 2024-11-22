namespace Dominio.Entidades
{
    public class Cliente : Usuario
    {
        public decimal Saldo {get; set;}

        public Cliente()
        {
        }

        public Cliente(
            string _nombre,
            string _apellido, 
            string _email,
            string _contrasenia,
            int _saldo,
            string _rol
        ) : base(_nombre, _apellido, _email, _contrasenia, _rol) {
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

        public override void RecargarSaldo(int monto)
        {
            if (monto <= 0)
            {
                throw new Exception("Recarga invalido");
            }
            Saldo += monto;
        }

        public override decimal ObtenerSaldo()
        {
            return Saldo;
        }

        public override void DescontarSaldo(decimal monto)
        {
            Saldo -= monto;
        }


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