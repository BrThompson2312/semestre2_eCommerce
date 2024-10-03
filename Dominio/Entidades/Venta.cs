namespace Dominio.Entidades
{
    public class Venta : Publicacion
    {
        public bool OfertaRelampago {get; set;}
        public decimal PrecioFinal {get; set;}

        public Venta ( string _nombre, DateTime _fechaPublicacion, bool _ofertaRelampago, decimal _precioFinal) : base(_nombre, _fechaPublicacion) {
            OfertaRelampago = _ofertaRelampago;
            PrecioFinal = _precioFinal;
        }

        public override void Validar()
        {
            base.Validar();
            if (PrecioFinal < 0)
            {
                throw new Exception($"Venta: PrecioFinal invalido: {PrecioFinal}");
            }
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
            return base.Equals(obj);
        }

    }
}