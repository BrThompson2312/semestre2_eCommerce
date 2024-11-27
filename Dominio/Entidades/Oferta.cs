namespace Dominio.Entidades
{
    public class Oferta : IValidar
    {
        public int Id {get; set;}
        private static int ultimoId = 0;
        public Cliente Cliente {get; set;}
        public int Monto {get; set;}
        public DateTime Fecha {get; set;}

        public Oferta(Cliente _cliente, int _monto, DateTime _fecha)
        {
            Id = ultimoId++;
            Cliente = _cliente;
            Monto = _monto;
            Fecha = _fecha;
        }

        public void Validar()
        {
            if (Cliente == null)
            {
                throw new Exception($"Oferta: Usuario null");
            }
            if (Monto <= 0)
            {
                throw new Exception($"Oferta: Monto invalido: {Monto}");
            }
            if (Fecha == null)
            {
                throw new Exception($"Oferta: Fecha invalido: {Fecha}");
            }
        }

        public override string ToString()
        {
            string res = "";
            res += $" Cliente: {Cliente.Nombre} {Cliente.Apellido} | ";
            res += $" Monto: {Monto} | ";
            res += $" Fecha: {Fecha} ";
            return res;
        }

        public override bool Equals(object obj)
        {
            Oferta oferta = obj as Oferta;
            return oferta != null && oferta.Id == Id || oferta.Cliente == Cliente && oferta.Monto == Monto;
        }

    }
}