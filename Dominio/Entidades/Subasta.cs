namespace Dominio.Entidades
{
    public class Subasta : Publicacion
    {
        private List<Oferta> _ofertas = new List<Oferta>();

        public Subasta (
            string _nombre,
            Oferta _oferta
        ) : base(_nombre) {
            _ofertas.Add(_oferta);
        }

        public override void Validar()
        {
            base.Validar();
        }


        public void ValidarSubasta()
        {
        }

        public override void AgregarListaOfertas(Oferta unaOferta)
        {
            base.AgregarListaOfertas(unaOferta);
            _ofertas.Add(unaOferta);
        }
        
    }
}