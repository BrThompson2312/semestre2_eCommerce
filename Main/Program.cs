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
                Console.WriteLine("Bienvenido al programa, que desea?");
                do
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(
                        "\n------------------------------------\n" +
                        "0- Salir\n" +
                        "1- Precargar Datos\n" +
                        "2- Listado de clientes \n" +
                        "3- Filtrar articulos por categoría \n" +
                        "4- Crear artículo \n" +
                        "5- Listar publicaciones entre dos fechas \n" +
                        "------------------------------------\n"
                    );

                    int.TryParse(Console.ReadLine(), out salida);
                    switch (salida)
                    {
                        case 0:
                            return;
                        case 1: 
                            PrecargarDatos(); 
                            break;
                        case 2: 
                            ListadoClientes(); 
                            break;
                        case 3: 
                            ListadoArticulos(); 
                            break;
                        case 4: 
                            CrearArticulo(); 
                            break;
                        case 5: 
                            ListadoPublicaciones(); 
                            break;
                    }                
                } while (salida != 5);

            } catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void PrecargarDatos()
        {
            try {
                _sistema.PrecargarDatos();
                Console.WriteLine("Precarga de datos completa!");
                Console.ReadKey();
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public static void ListadoClientes()
        {
            List<Usuario> _clientes = _sistema.Usuarios;
            if (_clientes.Count == 0) {
                Console.WriteLine("**** No hay Clientes ****");
                Console.ReadKey();
            } else {
                Console.WriteLine("------------- Listado de clientes -------------");
                foreach (Usuario item in _clientes)
                {
                    if (item.TipoUsuario() == 0)
                    {
                        Console.WriteLine(item);
                    }
                }
                Console.ReadKey();
            }
        }

        public static void ListadoArticulos()
        {
            try {
                if (_sistema.Articulos.Count == 0) 
                {
                    Console.WriteLine("**** No hay artículos ****");
                    Console.ReadKey();
                } else 
                {
                    Console.WriteLine("Que categoria desea filtrar?");
                    string categoria = Console.ReadLine();
                    if (string.IsNullOrEmpty(categoria))
                    {
                        throw new Exception("Entrada inválida");
                    }
                    Console.WriteLine("------------- Listado de articulos filtrados -------------");
                    _sistema.ListadoArticulos(categoria);
                    Console.ReadKey();
                }
                
            } catch (Exception e) {
                throw new Exception(e.Message);
            }
        }
  
        public static void CrearArticulo()
        {
            Console.WriteLine("Agregue articulos: ");
            Console.WriteLine("------------------ ");

            Console.WriteLine("Nombre: ");
            string nombreArticulo = Console.ReadLine();

            Console.WriteLine("Categoria: ");
            string categoriaArticulo = Console.ReadLine();

            Console.WriteLine("Precio: ");
            int precioArticulo;
            int.TryParse(Console.ReadLine(), out precioArticulo);

            Articulo unArticulo = new Articulo(nombreArticulo, categoriaArticulo, precioArticulo);
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