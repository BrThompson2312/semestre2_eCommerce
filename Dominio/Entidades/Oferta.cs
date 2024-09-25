namespace Dominio.Entidades
{
    public class Oferta
    {
        private int id {get; set;}
        private static int ultimoId = 0;
        private Usuario usuario {get; set;}
        private int monto {get; set;}
        private DateTime fecha;

        public int Id 
        {
            get { return id; }
        }
        public Usuario Usuario
        {
            get { return usuario; }
        }
        public int Monto
        {
            get { return monto; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
        }

        public Oferta(Usuario _usuario, int _monto, DateTime _fecha)
        {
            id = ultimoId++;
            usuario = _usuario;
            monto = _monto;
            fecha = _fecha;
        }
    }
}