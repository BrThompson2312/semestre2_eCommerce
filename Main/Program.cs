using Dominio;
using Dominio.Entidades;

namespace Main
{
    internal class Program
    {
        static Sistema _sistema = new Sistema();
        public static void Main(string[] args)
        {
            try {
                int salida;
                do
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(
                        "Bienvenido al programa, que desea?\n" +
                        "------------------------------------\n" +
                        "0- Precargar Datos\n" +
                        "1- Listado de clientes \n" +
                        "2- Filtrar articulos por categoría \n" +
                        "3- Crear artículo \n" +
                        "4- Listar publicaciones entre dos fechas \n" +
                        "5- Salir\n" +
                        "------------------------------------\n"
                    );

                    salida = int.Parse(Console.ReadLine());
                    switch (salida)
                    {
                        case 0: 
                            PrecargarDatos(); 
                            break;
                        case 1: 
                            ListadoClientes(); 
                            break;
                        case 2: 
                            ListadoArticulos(); 
                            break;
                        case 3: 
                            CrearArticulo(); 
                            break;
                        case 4: 
                            ListadoPublicaciones(); 
                            break;
                        case 5: 
                            return;
                    }                
                } while (salida != 0);

            } catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void PrecargarDatos()
        {
            try {
                _sistema.PrecargarDatos();
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public static void ListadoClientes()
        {
            List<Usuario> clientes = _sistema.Usuarios;
            if (clientes.Count == 0) {
                Console.WriteLine("**** No hay Clientes ****");
                Console.ReadKey();
            } else {
                foreach (Administrador item in clientes)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static void ListadoArticulos()
        {
            try {

            } catch (Exception e) {
                throw new Exception(e.Message);
            }
        }
  
        public static void CrearArticulo()
        {
            string nombreArticulo;
            string categoriaArticulo;
            int precioArticulo;
            Articulo unArticulo;

            Console.WriteLine("Agregue articulos: ");
            Console.WriteLine("------------------ ");

            Console.WriteLine("Nombre: ");
            nombreArticulo = Console.ReadLine();

            Console.WriteLine("Categoria: ");
            categoriaArticulo = Console.ReadLine();

            Console.WriteLine("Precio: ");
            precioArticulo = int.Parse(Console.ReadLine());

            unArticulo = new Articulo(nombreArticulo, categoriaArticulo, precioArticulo);
            unArticulo.Validar();
            _sistema.AgregarArticulo(unArticulo);
        }

        public static void ListadoPublicaciones()
        {
            try {

                Console.WriteLine("Eliga fecha de inicio");
                int fechaInicio = int.Parse(Console.ReadLine());

                Console.WriteLine("Eliga fecha de fin");
                int fechaFin = int.Parse(Console.ReadLine());

                _sistema.ListadoPublicaciones(fechaInicio, fechaFin);
                
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

    }
}