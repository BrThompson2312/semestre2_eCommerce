namespace Dominio.Entidades
{
    public class Oferta
    {
        private int id;
        private static int ultimoId = 0;
        private Usuario usuario;
        private int monto;
        private DateTime fecha;

        public Oferta(Usuario _usuario, int _monto, DateTime _fecha)
        {
            id = ultimoId++;
            usuario = _usuario;
            monto = _monto;
            fecha = _fecha;
        }
    }
}