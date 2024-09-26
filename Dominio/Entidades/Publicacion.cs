namespace Dominio.Entidades
{
    public abstract class Publicacion : IValidar
    {
        private int Id {get; set;}
        private static int ultimoId = 0;
        private string Nombre {get; set;}
        private int EstadoPublicacion {get; set;}
        private DateTime FechaPublicacion {get; set;}
        private List<Articulo> _articulos {get;}
        private Cliente CompraRealizadaCliente {get; set;}
        private Administrador CompraFinalizadaAdministrador {get; set;}
        private DateTime FechaFinalizacionCompra {get; set;}

        public Publicacion(string _nombre){
            Id = ultimoId++;
            Nombre = _nombre;
            EstadoPublicacion = Estado.Abierto;
            FechaPublicacion = DateTime.Now;
            _articulos = new List<Articulo>();
        }

        public virtual void Validar()
        {
        }

        public override string ToString()
        {
            string res = "";
            res += $"Id: {Id}";
            res += $"Nombre: {Nombre}";
            res += $"EstadoPublicacion: {EstadoPublicacion}";
            res += $"Fecha_publicacion: {FechaPublicacion}";

            res += $"Articulos: ";
            foreach (Articulo unArticulo in _articulos)
            {
                res += $"///: {unArticulo}";
            }

            res += $"Cliente que realizó la compra: {CompraRealizadaCliente}";
            res += $"Administrador que FINALIZÓ la compra: {CompraFinalizadaAdministrador}";
            res += $"Fecha de compra finalizada: {FechaFinalizacionCompra}";
            return res;
        }

        public virtual void AgregarArticulo(Articulo unArticulo)
        {
            unArticulo.Validar();
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