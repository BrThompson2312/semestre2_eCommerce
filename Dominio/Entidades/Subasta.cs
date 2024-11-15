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

        public Subasta (string _nombre, DateTime _fechaPublicacion) : base(_nombre, _fechaPublicacion) {}

        public override void Validar()
        {
            base.Validar();
        }

        public override void AgregarOferta(Oferta unaOferta)
        {
            string res = $"Subasta id_{Id}({Nombre})";
            if (unaOferta == null)
            {
                throw new Exception($"{res}: Oferta invalido");
            }
            if (_ofertas.Contains(unaOferta))
            {
                throw new Exception($"{res}: Oferta existente: {unaOferta}");
            }
            if (unaOferta.Fecha < FechaPublicacion)
            {
                throw new Exception($"{res}: oferta con fecha menor a la de la publicacion: \n Fecha de publicacion: {FechaPublicacion} \n Fecha de oferta(id_{unaOferta.Id}): {unaOferta.Fecha}");
            }
            unaOferta.Validar();
            _ofertas.Add(unaOferta);
        }

        public override decimal PrecioPublicacion(Publicacion unaPublicacion)
        {
            return 0;
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