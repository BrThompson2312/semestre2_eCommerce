namespace Dominio.Entidades
{
    public class Subasta : Publicacion
    {
        private List<Oferta> _ofertas = new List<Oferta>();

        public Subasta (string _nombre, DateTime _fechaPublicacion) : base(_nombre, _fechaPublicacion) {
        }

        public override void Validar()
        {
            base.Validar();
        }

        public override void AgregarOferta(Oferta unaOferta)
        {
            if (unaOferta == null)
            {
                throw new Exception("Invalido");
            }
            if (_ofertas.Contains(unaOferta))
            {
                throw new Exception("Oferta ya existente!");
            }
            _ofertas.Add(unaOferta);
        }

        public override string ToString()
        {
            string res = base.ToString();
            foreach (Oferta item in _ofertas)
            {
                res += $"{item}";
            }
            return res;
        }

        public override bool Equals(object obj)
        {
            Subasta subasta = obj as Subasta;
            return subasta != null && subasta.Id != Id;
        }

    }
}