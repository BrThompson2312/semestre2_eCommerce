namespace Dominio.Entidades
{
    public class Oferta : IValidar
    {
        public int Id {get; set;}
        private static int ultimoId = 0;
        public Usuario Usuario {get; set;}
        public int Monto {get; set;}
        public DateTime Fecha {get; set;}

        public Oferta(Usuario _usuario, int _monto, DateTime _fecha)
        {
            Id = ultimoId++;
            Usuario = _usuario;
            Monto = _monto;
            Fecha = _fecha;
        }

        public void Validar()
        {
            if (Usuario == null)
            {
                throw new Exception($"Oferta: Usuario invalido");
            }
            else if (Monto < 0)
            {
                throw new Exception($"Oferta: Monto invalido: {Monto}");
            }
            else if (Fecha == null)
            {
                throw new Exception("Oferta: Fecha invalido");
            }
        }

        public override string ToString()
        {
            string res = $"Id {Id}";
            res += $"Usuario: {Usuario}";
            res += $"Monto: {Monto}";
            res += $"Fecha: {Fecha}";
            return res;
        }

        public override bool Equals(object? obj)
        {
            Oferta oferta = obj as Oferta;
            return oferta != null && oferta.Id == Id;
        }

    }
}