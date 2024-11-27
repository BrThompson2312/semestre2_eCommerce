namespace Dominio.Entidades
{
    public abstract class Publicacion : IValidar
    {
        public int Id {get; set;}
        private static int ultimoId = 0;
        public string Nombre {get; set;}
        public decimal PrecioFinal { get; set; }
        public Estado EstadoPublicacion {get; set;}
        public DateTime FechaPublicacion {get; set;}
        private List<Articulo> _articulos = new List<Articulo>();
        public Usuario CompraRealizada {get; set;}
        public Usuario CompraFinalizada {get; set;}
        public DateTime FechaFinalizacionCompra {get; set;}

        public IEnumerable<Articulo> Articulos {
            get { return _articulos; }
        }

        public enum Estado
        {
            Abierto,
            Cerrado,
            Cancelado,
        }

        public Publicacion() 
        {
        }

        public Publicacion(string _nombre, DateTime _fechaPublicacion){
            Id = ultimoId++;
            Nombre = _nombre;
            EstadoPublicacion = Estado.Abierto;
            FechaPublicacion = _fechaPublicacion;
        }

        public virtual void Validar()
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                throw new Exception($"Publicacion id_{Id}({Nombre}): Nombre invalido");
            }
            if (EstadoPublicacion != Estado.Abierto && 
                EstadoPublicacion != Estado.Cerrado && 
                EstadoPublicacion != Estado.Cancelado)
            {
                throw new Exception($"Publicacion: Estado invalido: {EstadoPublicacion}");
            }
        }

        public virtual void AgregarArticulo(Articulo pArticulo)
        {
            pArticulo.Validar();
            _articulos.Add(pArticulo);
        }

        public abstract void AgregarOferta(Oferta unaOferta);

        public abstract decimal PrecioPublicacion(Articulo articulo);

        public abstract Oferta OfertaConMasValor();

        public abstract int CantidadOfertas();

        public virtual decimal ObtenerPrecioFinal()
        {
            return PrecioFinal;
        }

        public abstract void ValidarOferta(int monto);

        public virtual void FinalizarPublicacion(Usuario usuario1, Usuario usuario2)
        {
            CompraRealizada = usuario1;
            CompraFinalizada = usuario2;
            EstadoPublicacion = Estado.Cerrado;
        }

        public virtual void CancelarSubasta(Usuario admin)
        {
            CompraFinalizada = admin;
            EstadoPublicacion = Estado.Cancelado;
        }

        public abstract Oferta ObtenerOfertaEspecifica(int i);

        public abstract void AsignarOfertaFinal(Oferta oferta);

        public abstract Oferta ObtenerOfertaFinal();

        public override string ToString()
        {
            string res = "";
            res += $"Id: {Id} -------------------------\n";
            res += $"Nombre: {Nombre}\n";
            res += $"EstadoPublicacion: {EstadoPublicacion}\n";
            res += $"Fecha_publicacion: {FechaPublicacion}\n";

            res += $"Articulos:\n";
            foreach (Articulo unArticulo in _articulos)
            {
                res += $"///: {unArticulo}\n";
            }

            res += $"Usuario que realizó la compra: {CompraRealizada}\n";
            res += $"Usuario que finalizó la compra: {CompraFinalizada}\n";
            res += $"Fecha de compra finalizada: {FechaFinalizacionCompra}\n";
            return res;
        }

        public override bool Equals(object obj)
        {
            Publicacion publicacion = obj as Publicacion;
            return publicacion != null && publicacion.Id == Id;
        }
    }
}