namespace Dominio.Entidades
{
    public abstract class Publicacion : IValidar
    {
        public int Id {get; set;}
        private static int ultimoId = 0;
        public string Nombre {get; set;}
        public int EstadoPublicacion {get; set;}
        public DateTime FechaPublicacion {get; set;}
        private List<Articulo> _articulos = new List<Articulo>();
        public Cliente CompraRealizadaCliente {get; set;}
        public Administrador CompraFinalizadaAdministrador {get; set;}
        public DateTime FechaFinalizacionCompra {get; set;}

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
                throw new Exception("Publicacion: Nombre invalido");
            }
            if (EstadoPublicacion != Estado.Abierto || EstadoPublicacion != Estado.Cerrado || EstadoPublicacion != Estado.Terminado)
            {
                throw new Exception($"Publicacion: Estado invalido: {EstadoPublicacion}");
            }
        }

        public virtual void AgregarArticulo(Articulo unArticulo)
        {
            unArticulo.Validar();
            _articulos.Add(unArticulo);
        }

        public abstract void AgregarOferta(Oferta unaOferta);

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

        public override bool Equals(object obj)
        {
            Publicacion publicacion = obj as Publicacion;
            return publicacion != null && publicacion.Id == Id;
        }

    }
}