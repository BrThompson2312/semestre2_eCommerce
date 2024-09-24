namespace Dominio.Entidades
{
    public abstract class Publicacion
    {
        private int Id;
        private static int ultimoId = 0;
        private string Nombre;
        private int EstadoPublicacion = Estado.Abierto;
        private DateTime Fecha_publicacion;
        private List<Articulo> _articulos = new List<Articulo>();
        private Cliente Compra_realizada;
        private Administrador Compra_finalizada;
        private DateTime Fecha_finalizacion_compra;

        public Publicacion(
            string _nombre, 
            DateTime _fecha_publicacion, 
            Articulo _articulo,
            Cliente _compra_realizada_cliente,
            Administrador _compra_finalizada_administrador,
            DateTime _fecha_finalizacion_compra
        ){
            Id = ultimoId++;
            Nombre = _nombre;
            Fecha_publicacion = _fecha_publicacion;
            _articulos.Add(_articulo);
            Compra_realizada = _compra_realizada_cliente;
            Compra_finalizada = _compra_finalizada_administrador;
            Fecha_finalizacion_compra = _fecha_finalizacion_compra;
        }

        public virtual void Validar()
        {
        }

    }
}