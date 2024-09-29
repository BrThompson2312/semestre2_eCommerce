namespace Dominio.Entidades
{
    public class Venta : Publicacion
    {
        public bool OfertaRelampago {get; set;}
        public decimal PrecioFinal {get; set;}

        public Venta ( string _nombre, bool _ofertaRelampago, decimal _precioFinal) : base(_nombre) {
            OfertaRelampago = _ofertaRelampago;
            PrecioFinal = _precioFinal;
        }

        public override void Validar()
        {
            base.Validar();
        }

        public override void AgregarOferta(Oferta unaOferta)
        {
            throw new Exception("Venta no puede tener ofertas");
        }

        public override string ToString()
        {
            string res = base.ToString();
            res += $"Oferta relampago: {OfertaRelampago}";
            res += $"Precio final: {PrecioFinal}";
            return res;
        }

        public override bool Equals(object obj)
        {
            Venta venta = obj as Venta;
            return venta != null && venta.Id != Id;
        }

    }
}