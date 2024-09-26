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
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(
                        "Bienvenido al programa, que desea?\n" +
                        "------------------------------------\n" +
                        "0- Precargar Datos\n" +
                        "1- Agregar Administrador\n" +
                        "2-     Listado\n" +
                        "3- Agregar Cliente\n" +
                        "4-     Listado\n" +
                        "5- Crear publicacion\n" +
                        "6-     Listado de ventas\n" +
                        "7-     Listado de subastas\n" +
                        "8- Crear oferta\n" +
                        "9- Salir\n" +
                        "------------------------------------\n"
                    );
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Black;

                    salida = int.Parse(Console.ReadLine());
                    switch (salida)
                    {
                        case 0: 
                            PrecargarDatos(); break;
                        case 1: 
                            AgregarAdministrador(); break;
                        case 2: 
                            ListadoAdministradores(); break;
                        case 3: 
                            AgregarCliente(); break;
                        case 4: 
                            ListadoClientes(); break;
                        case 5: 
                            CrearPublicacion(); break;
                        case 6: 
                            ListadoVentas(); break;
                        case 7: 
                            ListadoSubastas(); break;
                        case 8: break;
                        case 9: return;
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

        public static void AgregarAdministrador()
        {   
            Console.WriteLine("Ingrese nombre: ");
            string _nombre = Console.ReadLine();

            Console.WriteLine("Ingrese apellido: ");
            string _apellido = Console.ReadLine();

            Console.WriteLine("Ingrese email: ");
            string _email = Console.ReadLine();

            Console.WriteLine("Ingrese contraseña: ");
            string _contrasenia = Console.ReadLine();

            Usuario administrador = new Administrador(_nombre, _apellido, _email, _contrasenia);
            _sistema.AgregarAdministrador(administrador);
        }

        public static void ListadoAdministradores()
        {
            List<Usuario> administradores = _sistema.Usuarios;
            if (administradores.Count == 0) {
                Console.WriteLine("**** No hay Administradores ****");
                Console.ReadKey();
            } else {
                foreach (Administrador item in administradores)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static void AgregarCliente()
        {
            Console.WriteLine("Ingrese nombre: ");
            string _nombre = Console.ReadLine();

            Console.WriteLine("Ingrese apellido: ");
            string _apellido = Console.ReadLine();

            Console.WriteLine("Ingrese email: ");
            string _email = Console.ReadLine();

            Console.WriteLine("Ingrese contraseña: ");
            string _contrasenia = Console.ReadLine();

            Console.WriteLine("Ingrese saldo inicial: ");
            int _saldo = int.Parse(Console.ReadLine());

            Usuario cliente = new Cliente(_nombre, _apellido, _email, _contrasenia, _saldo);

            _sistema.AgregarCliente(cliente);
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
  
        public static void CrearPublicacion()
        {
            Console.WriteLine(" ¿Publicacion de tipo Venta o Subasta? ");
            Console.WriteLine(" 1- Venta\n 2-Subasta");
            int tipoPublicacion = int.Parse(Console.ReadLine());

            //------------ Control de error ------------//
            if (tipoPublicacion != 1 || tipoPublicacion != 2)
            {
                throw new Exception("Invalido");
            }
            //------------ Control de error ------------//

            CrearArticulo();

            switch (tipoPublicacion)
            {
                case 1:
                    CrearVenta(); break;
                case 2:
                    CrearSubasta(); break;
            }
        }

        public static void CrearArticulo()
        {
            string nombreArticulo;
            string categoriaArticulo;
            int precioArticulo;
            Articulo unArticulo;

            int salida = 1;
            do {
                Console.WriteLine("Agregue articulos: ");
                Console.WriteLine("------------------ ");

                Console.WriteLine("Nombre: ");
                nombreArticulo = Console.ReadLine();

                Console.WriteLine("Categoria: ");
                categoriaArticulo = Console.ReadLine();

                Console.WriteLine("Precio: ");
                precioArticulo = int.Parse(Console.ReadLine());

                unArticulo = new Articulo(nombreArticulo, categoriaArticulo, precioArticulo);
                _sistema.ValidarArticulo(unArticulo);
                // _sistema._auxArticulos.Add(unArticulo);

                Console.WriteLine("------------------ ");
                Console.WriteLine(" ¿Desea agregar otro artículo a su publicación? ");
                salida = int.Parse(Console.ReadLine());
            } while (salida != 0);
        }

        public static void CrearVenta()
        {
            Console.WriteLine("Nombre de la publicacion: ");
            string nombrePublicacion = Console.ReadLine();
            
            decimal precioFinal = 0;

            Console.WriteLine(" ¿Oferta relámpago? ");
            Console.WriteLine(" 1- Si\n 2- No");
            int oferta = int.Parse(Console.ReadLine());

            //------------ Control de error ------------//
            if (oferta != 1 || oferta != 2)
            {
                throw new Exception("Invalido");
            }
            //------------ Control de error ------------//

            if (oferta == 1)
            {
                precioFinal = (precioFinal * 20) / 100;
            }

            Publicacion unaVenta = new Venta(nombrePublicacion, true, precioFinal);
            _sistema.CrearVenta(unaVenta);

            // foreach (Articulo unArticulo in _sistema._auxArticulos)
            // {
            //     unArticulo.Validar();
            //     unaVenta.AgregarArticulo(unArticulo);
            // }

            // _sistema._auxArticulos.Clear();
        }

        public static void CrearSubasta()
        {
            Console.WriteLine("Nombre de la publicacion: ");
            string nombrePublicacion = Console.ReadLine();

            Publicacion unaSubasta = new Subasta(nombrePublicacion);
            _sistema.CrearSubasta(unaSubasta);

            // foreach (Articulo unArticulo in _sistema._auxArticulos)
            // {
            //     unArticulo.Validar();
            //     unaSubasta.AgregarArticulo(unArticulo);
            // }

            // _sistema._auxArticulos.Clear();
        }

        public static void ListadoVentas()
        {
            List<Publicacion> ventas = _sistema.Publicaciones;
            if (ventas.Count == 0) {
                Console.WriteLine("**** No hay Ventas ****");
                Console.ReadKey();
            } else {
                foreach (Subasta item in ventas)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static void ListadoSubastas()
        {
            List<Publicacion> subastas = _sistema.Publicaciones;
            if (subastas.Count == 0) {
                Console.WriteLine("**** No hay Subastas ****");
                Console.ReadKey();
            } else {
                foreach (Subasta item in subastas)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}