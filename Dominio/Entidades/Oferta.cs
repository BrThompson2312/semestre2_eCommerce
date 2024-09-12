namespace Dominio.Entidades
{
    public class Oferta
    {
        private static int id = 0;
        private Usuario usuario;
        private int monto;
        private DateTime fecha;

        public Oferta(Usuario _usuario, int _monto, DateTime _fecha)
        {
            id++;
            usuario = _usuario;
            monto = _monto;
            fecha = _fecha;
        }
    }
}