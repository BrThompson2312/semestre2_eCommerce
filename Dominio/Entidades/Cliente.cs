namespace Dominio.Entidades
{
    public class Cliente : Usuario
    {
        private int id;
        private static int ultimoId = 0;
        private int saldo;

        public Cliente(
            string _nombre,
            string _apellido, 
            string _email,
            string _contrasenia,
            int _saldo
        ) : base(_nombre, _apellido, _email, _contrasenia) {
            id = ultimoId++;
            saldo = _saldo;
        }

        public override void Validar()
        {
            if (saldo < 0) {
                throw new Exception("Error, saldo negativo");
            }   
            base.Validar();
        }

        // public override bool Equals(object obj)
        // {
        //     Cliente cliente = obj as Cliente;
        //     return cliente != null && id == cliente.id;
        // }
    }
}