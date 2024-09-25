using Dominio;
using Dominio.Entidades;

namespace Main
{
    internal class Program
    {
        static Sistema sistema = new Sistema();
        public static void Main(string[] args)
        {
            // Menu:
            int salida;
            do
            {
                Console.WriteLine(
                    "Bienvenido al programa, que desea?\n" +
                    "------------------------------------\n" +
                    "0 - Salir\n" +
                    "1 - Agregar Administrador\n" +
                    "2 - Agregar Cliente\n" +
                    "3 - Crear publicación\n" +
                    "4 - Crear oferta\n" +
                    "------------------------------------\n"
                );

                salida = int.Parse(Console.ReadLine());
                switch (salida)
                {
                    case 0:
                        return;
                    case 1:
                        AgregarAdministrador();
                        break;
                    case 2:
                        AgregarCliente();
                        break;
                }                
            } while (salida != 0);
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

            sistema.AgregarAdministrador(administrador);
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

            sistema.AgregarCliente(cliente);
        }

        public static void CrearPublicacion()
        {
            try {
                Console.WriteLine(" ¿Publicacion de tipo Venta o Subasta? ");
                Console.WriteLine(" 1- Venta\n 2-Subasta");
                int tipoPublicacion = int.Parse(Console.ReadLine());

                Console.WriteLine("Nombre de la publicacion: ");
                string nombrePublicacion = Console.ReadLine();

                string nombreArticulo;
                string categoriaArticulo;
                int precioArticulo;
                Articulo unArticulo;

                int salida = 1;
                do {
                    unArticulo = CrearArticulo();
                    sistema.ValidarArticulo(unArticulo);

                    Console.WriteLine("------------------ ");
                    Console.WriteLine(" ¿Desea agregar otro artículo a su publicación? ");
                    salida = int.Parse(Console.ReadLine());

                } while (salida != 0);

                //------------ ******** ------------//
                if (tipoPublicacion != 1 || tipoPublicacion != 2)
                {
                    throw new Exception("Eliga una opcion correcta!");
                }
                //------------ ******** ------------//

                switch (tipoPublicacion)
                {
                    case 1:
                        CrearPublicacionVenta(nombrePublicacion, unArticulo); break;
                    case 2:
                        CrearPublicacionSubasta(nombrePublicacion, unArticulo); break;
                }

            } catch(Exception e) {
                Console.WriteLine(e.Message);
            }

        }

        public static Articulo CrearArticulo()
        {
            Console.WriteLine("Agregue articulos: ");
            Console.WriteLine("------------------ ");

            Console.WriteLine("Nombre: ");
            string nombreArticulo = Console.ReadLine();

            Console.WriteLine("Categoria: ");
            string categoriaArticulo = Console.ReadLine();

            Console.WriteLine("Precio: ");
            int precioArticulo = int.Parse(Console.ReadLine());

            Articulo unArticulo = new Articulo(nombreArticulo, categoriaArticulo, precioArticulo);

            return unArticulo;
        }

        public static void CrearPublicacionVenta(string pNombrePublicacion, Articulo pArticulo)
        {
            List <Articulo> _auxArticulos = new List<Articulo>();
            _auxArticulos.Add(pArticulo);

            //------------ ******** ------------//
            decimal precioFinal = 0;

            Console.WriteLine(" ¿Oferta relámpago? ");
            Console.WriteLine(" 1- Si\n 2- No");
            int oferta = int.Parse(Console.ReadLine());
            if (oferta != 1 || oferta != 2)
            {
                throw new Exception("Eliga una opcion correcta!");
            }

            foreach (Articulo articuloVenta in _auxArticulos)
            {
                precioFinal += articuloVenta.Precio;
            }

            if (oferta == 1)
            {
                precioFinal = (precioFinal * 20) / 100;
            }

            // Creamos la publicacion y validamos cada articulo que se agrega a la lista del mismo, con un método
            Publicacion unaVenta = new Venta(pNombrePublicacion, true, precioFinal);
            foreach(Articulo articulo in _auxArticulos)
            {
                unaVenta.AgregarArticulo(articulo);
            }
            sistema.CrearPublicacionVenta(unaVenta);
        }

        public static void CrearPublicacionSubasta(string pNombrePublicacion, Articulo pArticulo)
        {
            
            List <Articulo> _auxArticulos = new List<Articulo>();
            _auxArticulos.Add(pArticulo);

            //------------ ******** ------------//
            Publicacion unaSubasta = new Subasta(pNombrePublicacion, null);

            foreach (Articulo unArticulo in _auxArticulos)
            {
                unaSubasta.AgregarArticulo(unArticulo);
            }

            sistema.CrearPublicacionSubasta(unaSubasta);
        }
        
        
        public static void CrearSubastaOferta()
        {
            Console.WriteLine("Cree una oferta");

            string nombreOferta;
            int usuarioId;
            int monto;

            int salida = 1;
            do {
                Console.WriteLine("Nombre de la oferta: ");
                nombreOferta = Console.ReadLine();

                Console.WriteLine("Id del usuario que hace la oferta: ");
                usuarioId = int.Parse(Console.ReadLine());

                Console.WriteLine("Monto ofrecido: ");
                monto = int.Parse(Console.ReadLine());
            } while (salida != 0);

            // Busqueda de usuario;
            Usuario unUsuario = BusquedaCliente(usuarioId);

            Oferta unaOferta = new Oferta(unUsuario, monto, DateTime.Now);
            sistema.AgregarOferta(unaOferta);

            Console.WriteLine(" ¿A qué publicación desea agregar dicha oferta? ");
            Console.WriteLine(" (Ingrese Id de la publicacion) ");
            // int publicacionId = int.Parse(Console.ReadLine());

            // if (publicacionId == null)
            // {
            //     throw new Exception("Invalido");
            // }
        }

        public static Usuario BusquedaCliente(int pId)
        {
            foreach (Usuario unUsuario in sistema.Usuarios)
            {
                if (unUsuario.Id == pId)
                {   
                    return unUsuario;
                }   
            }
            return null;
        }

        public static Publicacion BusquedaPublicacion(int pId)
        {
            foreach (Publicacion unaPublicacion in sistema.Publicaciones)
            {
                if (unaPublicacion.Id == pId)
                {
                    return unaPublicacion;
                }
            }
            return null;
        }

    }
}