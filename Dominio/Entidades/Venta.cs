namespace Dominio.Entidades
{
    public class Venta : Publicacion
    {
        private bool OfertaRelampago {get; set;}
        private decimal PrecioFinal {get; set;}

        public Venta ( string _nombre, bool _ofertaRelampago, decimal _precioFinal) : base(_nombre) {
            OfertaRelampago = _ofertaRelampago;
            PrecioFinal = _precioFinal;
        }

        public override void Validar()
        {
            base.Validar();
        }

    }
}