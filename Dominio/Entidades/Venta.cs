namespace Dominio.Entidades
{
    public class Venta : Publicacion
    {
        private bool Oferta_relampago {get; set;}
        private decimal Precio_final {get; set;}

        public Venta ( string _nombre, bool _oferta_relampago, decimal _precio_final) : base(_nombre) {
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