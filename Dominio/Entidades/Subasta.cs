namespace Dominio.Entidades
{
    public class Subasta : Publicacion
    {
        private List<Oferta> _ofertas {get; set;}

        public Subasta (
            string _nombre
        ) : base(_nombre) {
            _ofertas = new List<Oferta>();
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