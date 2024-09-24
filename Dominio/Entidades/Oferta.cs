namespace Dominio.Entidades
{
    public class Oferta
    {
        private int Id {get; set;}
        private static int ultimoId = 0;
        private Usuario Usuario {get; set;}
        private int Monto {get; set;}
        private DateTime Fecha {get; set;}

        public Oferta(Usuario _usuario, int _monto, DateTime _fecha)
        {
            Id = ultimoId++;
            Usuario = _usuario;
            Monto = _monto;
            Fecha = _fecha;
        }
    }
}