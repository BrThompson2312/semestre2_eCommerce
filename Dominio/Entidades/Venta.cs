namespace Dominio.Entidades
{
    public class Venta : Publicacion
    {
        private int id;
            private static int ultimoId = 0;
        private string nombre;
        private string estado;
        private DateTime fecha_publicacion;
        private List<Articulo> articulos = new List<Articulo>();
        private Cliente compra_realizada;
        private Administrador compra_finalizada;
        private DateTime fecha_finalizacion_compra;
        /* -------------------------------------------- */
        private bool oferta_relampago;
        private decimal precio_final;
        public Venta (
            string _nombre, 
            string _estado, 
            DateTime _fecha_publicacion, 
            Articulo _articulo,
            Cliente _compra_realizada_cliente,
            Administrador _compra_finalizada_administrador,
            DateTime _fecha_finalizacion_compra,
            /* -------------------------------------------- */
            bool _oferta_relampago,
            decimal _precio_final
        ) : base(_nombre, _estado, _fecha_publicacion, _articulo, _compra_realizada_cliente, _compra_finalizada_administrador, _fecha_finalizacion_compra) {
            id = ultimoId++;
            oferta_relampago = _oferta_relampago;
            precio_final = _precio_final;
        }
    }
}