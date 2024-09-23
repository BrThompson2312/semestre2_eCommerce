namespace Dominio.Entidades
{
    public class Subasta : Publicacion
    {
        private int id;
            private static int ultimoId = 0;
        private string nombre;
        private int estado = Estado.Abierto;
        private DateTime fecha_publicacion;
        private List<Articulo> articulos = new List<Articulo>();
        private Cliente compra_realizada;
        private Administrador compra_finalizada;
        private DateTime fecha_finalizacion_compra;
        /* -------------------------------------------- */
        private List<Oferta> _ofertas = new List<Oferta>();
        /* -------------------------------------------- */

        public Subasta (
            string _nombre,
            DateTime _fecha_publicacion,
            Articulo _articulo,
            Cliente _cliente,
            Administrador _administrador,
            DateTime _fecha_finalizacion_compra,
            Oferta _oferta
        ) : base(_nombre, _fecha_publicacion, _articulo, _cliente, _administrador, _fecha_finalizacion_compra) {
            id = ultimoId++;
            _ofertas.Add(_oferta);
        }

        public override void Validar()
        {
            base.Validar();
        }


        public void ValidarSubasta()
        {
        }
        
    }
}