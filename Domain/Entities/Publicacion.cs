namespace Entities
{
    public class Publicacion
    {
        private static int id = 0;
        private string nombre;
        private string estado;
        private DateTime fecha_publicacion;
        private List<Articulo> articulos;
        private Cliente compra_realizada;
        private Administrador compra_finalizada;
        private DateTime fecha_finalizacion_compra;

        public Publicacion(
            string _nombre, 
            string _estado, 
            DateTime _fecha_publicacion, 
            List<Articulo> _articulos,
            Cliente _compra_realizada,
            Administrador _compra_finalizada,
            DateTime _fecha_finalizacion_compra
        ){
            nombre = _nombre;
            estado = _estado;
            fecha_publicacion = _fecha_publicacion;
            articulos = _articulos;
            compra_realizada = _compra_realizada;
            compra_finalizada = _compra_finalizada;
            fecha_finalizacion_compra = _fecha_finalizacion_compra;
        }
    }
}