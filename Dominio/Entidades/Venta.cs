namespace Dominio.Entidades
{
    public class Venta : Publicacion
    {
        public bool OfertaRelampago {get; set;}
        public Venta ( 
            string _nombre, 
            DateTime _fechaPublicacion, 
            bool _ofertaRelampago
        ) : base( _nombre, _fechaPublicacion ) {
            OfertaRelampago = _ofertaRelampago;
            PrecioFinal = 0;
        }

        public override void Validar()
        {
            string res = $"Venta id_{Id}({Nombre})";
            base.Validar();
            if (PrecioFinal < 0)
            {
                throw new Exception($"{res}: PrecioFinal invalido: {PrecioFinal}");
            }
        }

        public override void AgregarArticulo(Articulo articulo)
        {
            base.AgregarArticulo(articulo);
            PrecioFinal += PrecioPublicacion(articulo);
        }

        public override void AgregarOferta(Oferta unaOferta)
        {
            throw new Exception("No implementado");
        }

        public override decimal PrecioPublicacion(Articulo articulo)
        {
            decimal precioFinal = 0;
            if (OfertaRelampago == true)
            {
                precioFinal = articulo.Precio - ((articulo.Precio * 10) / 100);
            }
            else
            {
                precioFinal = articulo.Precio;
            }
            return precioFinal;
        }

        public override Oferta OfertaConMasValor()
        {
            throw new Exception("No implementado");
        }

        public override int CantidadOfertas()
        {
            throw new Exception("No implementado");
        }

        public override void ValidarOferta(int monto)
        {
            throw new Exception("No implementado");
        }

        public override Oferta ObtenerOfertaEspecifica(int i)
        {
            throw new Exception("No implementado");
        }

        public override void AsignarOfertaFinal(Oferta oferta)
        {
            throw new Exception("No implementado");
        }

        public override Oferta ObtenerOfertaFinal()
        {
            throw new Exception("No implementado");
        }

        public override string ToString()
        {
            string res = base.ToString();
            res += $"Oferta relampago: {OfertaRelampago}\n";
            res += $"Precio final: {PrecioFinal}\n";
            res += "-------------------------\n";
            return res;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

    }
}