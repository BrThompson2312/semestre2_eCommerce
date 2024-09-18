namespace Dominio.Entidades
{
    public abstract class Publicacion
    {
        private int id;
        private static int ultimoId = 0;
        private string nombre;
        private string estado;
        private DateTime fecha_publicacion;
        private List<Articulo> articulos = new List<Articulo>();
        private Cliente compra_realizada;
        private Administrador compra_finalizada;
        private DateTime fecha_finalizacion_compra;

        public Publicacion(
            string _nombre, 
            string _estado, 
            DateTime _fecha_publicacion, 
            Articulo _articulo,
            Cliente _compra_realizada_cliente,
            Administrador _compra_finalizada_administrador,
            DateTime _fecha_finalizacion_compra
        ){
            id = ultimoId++;
            nombre = _nombre;
            estado = _estado;
            fecha_publicacion = _fecha_publicacion;
            articulos.Add(_articulo);
            compra_realizada = _compra_realizada_cliente;
            compra_finalizada = _compra_finalizada_administrador;
            fecha_finalizacion_compra = _fecha_finalizacion_compra;
        }
    }
}