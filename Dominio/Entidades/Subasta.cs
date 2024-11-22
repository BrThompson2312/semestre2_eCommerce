namespace Dominio.Entidades
{
    public class Subasta : Publicacion
    {
        private List<Oferta> _ofertas = new List<Oferta>();

        public IEnumerable<Oferta> Ofertas
        {
            get { return _ofertas; }
        }

        public Subasta() 
        {
        }

        public Subasta (string _nombre, DateTime _fechaPublicacion) : base(_nombre, _fechaPublicacion) 
        {
            PrecioFinal = 0;
        }

        public override void Validar()
        {
            base.Validar();
        }

        public override void AgregarOferta(Oferta oferta)
        {
            string res = $"Subasta id_{Id}({Nombre})";
            if (oferta == null)
            {
                throw new Exception($"{res}: Oferta invalido");
            }
            if (_ofertas.Contains(oferta))
            {
                throw new Exception($"{res}: Oferta existente: {oferta}");
            }
            if (oferta.Fecha < FechaPublicacion)
            {
                throw new Exception($"{res}: oferta con fecha menor a la de la publicacion: \n Fecha de publicacion: {FechaPublicacion} \n Fecha de oferta(id_{oferta.Id}): {oferta.Fecha}");
            }
            if (oferta.Monto > PrecioFinal)
            {
                oferta.Validar();
                PrecioFinal = oferta.Monto;
                _ofertas.Add(oferta);
            }
            else
            {
                throw new Exception("Monto insuficiente");
            }
        }

        public override decimal PrecioPublicacion(Articulo articulo)
        {
            throw new Exception("No implementado");
        }

        public override Oferta OfertaConMasValor()
        {
            Oferta mioferta = null;
            if (_ofertas.Count() != 0)
            {
                mioferta = _ofertas[_ofertas.Count() - 1];
            }
            return mioferta;
        }

        public override int CantidadOfertas()
        {
            return Ofertas.Count();
        }

        public override decimal ObtenerPrecioFinal()
        {
            throw new Exception("No implementado");
        }

        public override void ComprarVenta(Usuario usuario)
        {
            throw new Exception("No implementado");
        }

        public override void FinalizarVenta(Usuario usuario)
        {
            throw new Exception("No implementado");
        }

        public override void ValidarOferta(int monto)
        {
            if (monto < PrecioFinal)
            {
                throw new Exception("Insuficiente");
            }
            PrecioFinal = monto;
        }

        public override string ToString()
        {
            string res = base.ToString();
            res += "Ofertas: \n";
            foreach (Oferta item in _ofertas)
            {
                res += $"/// {item}\n";
            }
            res += "-------------------------\n";
            return res;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

    }
}