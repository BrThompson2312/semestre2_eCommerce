namespace Dominio.Entidades
{
    public class Subasta : Publicacion
    {
        private List<Oferta> _ofertas = new List<Oferta>();

        public Subasta (
            string _nombre,
            DateTime _fecha_publicacion,
            Articulo _articulo,
            Cliente _cliente,
            Administrador _administrador,
            DateTime _fecha_finalizacion_compra,
            Oferta _oferta
        ) : base(_nombre, _fecha_publicacion, _articulo, _cliente, _administrador, _fecha_finalizacion_compra) {
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