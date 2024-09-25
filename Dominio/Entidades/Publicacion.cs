namespace Dominio.Entidades
{
    public abstract class Publicacion
    {
        private int id;
        private static int ultimoId = 0;
        private string nombre;
        private int estadoPublicacion = Estado.Abierto;
        private DateTime fechaPublicacion = DateTime.Now;
        private List<Articulo> _articulos = new List<Articulo>();
        private Cliente compraRealizadaCliente;
        private Administrador compraFinalizadaAdministrador;
        private DateTime fechaFinalizacionCompra;

        public int Id 
        {
            get { return id; }
        }
        public string Nombre 
        {
            get { return nombre; }
        }
        public int EstadoPublicacion 
        {
            get { return estadoPublicacion; }
            set { estadoPublicacion = value; }
        }
        public DateTime FechaPublicacion
        {
            get { return fechaPublicacion; }
        }
        public List<Articulo> Articulos {
            get { return _articulos; }
        }
        public Cliente CompraRealizadaCliente
        {
            get { return compraRealizadaCliente; }
        }
        public Administrador CompraFinalizadaAdministrador
        {
            get { return compraFinalizadaAdministrador; }
        }
        public DateTime FechaFinalizacionCompra
        {
            get { return fechaFinalizacionCompra; }
        }

        public Publicacion(string _nombre){
            id = ultimoId++;
            nombre = _nombre;
        }

        public virtual void Validar()
        {
        }

        public override string ToString()
        {
            string res = "";
            res += $"Id: {id}";
            res += $"Nombre: {nombre}";
            res += $"EstadoPublicacion: {estadoPublicacion}";
            res += $"Fecha_publicacion: {fechaPublicacion}";

            res += $"Articulos: ";
            foreach (Articulo unArticulo in _articulos)
            {
                res += $"///: {unArticulo}";
            }

            res += $"Cliente que realizó la compra: {compraRealizadaCliente}";
            res += $"Administrador que FINALIZÓ la compra: {compraFinalizadaAdministrador}";
            res += $"Fecha de compra finalizada: {fechaFinalizacionCompra}";
            return res;
        }

        public virtual void ValidarArticulo(Articulo unArticulo)
        {

        }

        public virtual void AgregarArticulo(Articulo unArticulo)
        {
            ValidarArticulo(unArticulo);
            _articulos.Add(unArticulo);
        }

        public virtual void FinalizarCompra()
        {

        }

        public virtual void AgregarOfertaSubasta()
        {

        }
        public virtual void AgregarListaOfertas(Oferta unaOferta)
        {
            if (unaOferta == null)
            {
                throw new Exception("Invalido");
            }
        }

    }
}