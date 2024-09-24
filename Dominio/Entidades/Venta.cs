namespace Dominio.Entidades
{
    public class Venta : Publicacion
    {
        private bool Oferta_relampago {get; set;}
        private decimal Precio_final {get; set;}

        public Venta (
            string _nombre, 
            DateTime _fecha_publicacion, 
            Articulo _articulo,
            Cliente _compra_realizada_cliente,
            Administrador _compra_finalizada_administrador,
            DateTime _fecha_finalizacion_compra,
            bool _oferta_relampago,
            decimal _precio_final
        ) : base(_nombre, _fecha_publicacion, _articulo, _compra_realizada_cliente, _compra_finalizada_administrador, _fecha_finalizacion_compra) {
            Oferta_relampago = _oferta_relampago;
            Precio_final = _precio_final;
        }

        public override void Validar()
        {
            base.Validar();
        }

        public bool EsOfertaRelampago()
        {
            return true;
        }

    }
}