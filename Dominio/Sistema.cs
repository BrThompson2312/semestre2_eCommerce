using Dominio.Entidades;

namespace Dominio
{
    public class Sistema : IValidar
    {
        private List<Usuario> _usuarios = new List<Usuario>();
        private List<Publicacion> _publicaciones = new List<Publicacion>();
        public List<Articulo> _articulos = new List<Articulo>();

        public List<Usuario> Usuarios {
            get { return _usuarios; }
        }
        public List<Publicacion> Publicaciones {
            get { return _publicaciones; }
        }
        public List<Articulo> Articulos {
            get { return _articulos; }
        }

        public void PrecargarDatos()
        {
            PrecargarAdministradores();
            PrecargarClientes();
            PrecargarArticulos();
            // PrecargarVentas();
            // PrecargarSubastas();
            // PrecargarOfertas();
        }

        public void Validar()
        {
        }

        /*-------------- Precarga de datos --------------*/
        private void PrecargarAdministradores()
        {
            Usuario admin1 = new Administrador("Carlos", "Gomez", "carlos.gomez@gmail.com", "passCarlos1");
            AgregarUsuario(admin1);

            Usuario admin2 = new Administrador("Lucia", "Fernandez", "lucia.fernandez@gmail.com", "luciaFernandez123");
            AgregarUsuario(admin2);

            // Administrador con error en el email (sin dominio)
            // Usuario admin3 = new Administrador("Pedro", "Diaz", "pedro.diaz@gmail", "pedroDiaz456");
            // AgregarUsuario(admin3);

            // // Administrador con error en la contraseña (muy corta)
            // Usuario admin4 = new Administrador("Ana", "Martinez", "ana.martinez@hotmail.com", "ana12");
            // AgregarUsuario(admin4);

            // // Administrador con error en el nombre (nulo)
            // Usuario admin5 = new Administrador(null, "Sanchez", "sanchez.admin@outlook.com", "sanchezAdmin789");
            // AgregarUsuario(admin5);

            // // Administrador con error en el apellido (nulo)
            // Usuario admin6 = new Administrador("Laura", null, "laura.admin@gmail.com", "lauraAdmin101");
            // AgregarUsuario(admin6);
        }

        private void PrecargarClientes()
        {
            Usuario cliente1 = new Cliente("Carlos", "Garcia", "carlos.garcia@gmail.com", "passCarlos1", 1000);
            AgregarUsuario(cliente1);

            Usuario cliente2 = new Cliente("María", "Lopez", "maria.lopez@gmail.com", "mariaLopez22", 2000);
            AgregarUsuario(cliente2);

            Usuario cliente3 = new Cliente("Juan", "Martinez", "juan.martinez@hotmail.com", "juanMartinez33", 1500);
            AgregarUsuario(cliente3);

            Usuario cliente4 = new Cliente("Ana", "Sanchez", "ana.sanchez@outlook.com", "anaSanchez44", 1800);
            AgregarUsuario(cliente4);

            Usuario cliente5 = new Cliente("Miguel", "Perez", "miguel.perez@gmail.com", "miguelPerez55", 1200);
            AgregarUsuario(cliente5);

            Usuario cliente6 = new Cliente("Laura", "Fernandez", "laura.fernandez@gmail.com", "lauraFernandez66", 1700);
            AgregarUsuario(cliente6);

            Usuario cliente7 = new Cliente("Pedro", "Diaz", "pedro.diaz@gmail.com", "pedroDiaz77", 1300);
            AgregarUsuario(cliente7);

            Usuario cliente8 = new Cliente("Lucia", "Gomez", "lucia.gomez@gmail.com", "luciaGomez88", 2200);
            AgregarUsuario(cliente8);

            Usuario cliente9 = new Cliente("Sofia", "Rodriguez", "sofia.rodriguez@gmail.com", "sofiaRodriguez99", 1400);
            AgregarUsuario(cliente9);

            Usuario cliente10 = new Cliente("Diego", "Molina", "diego.molina@gmail.com", "diegoMolina1010", 1600);
            AgregarUsuario(cliente10);

            // Cliente con error en el email (falta el dominio)
            // Usuario cliente11 = new Cliente("Paula", "Cruz", "paula.cruz@gmail", "paulaCruz123", 1500);
            // AgregarCliente(cliente11);

            // // Cliente con error en el nombre (nulo)
            // Usuario cliente12 = new Cliente(null, "Vega", "vega@hotmail.com", "vegaPassword123", 1000);
            // AgregarCliente(cliente12);

            // // Cliente con error en el saldo (negativo)
            // Usuario cliente13 = new Cliente("Ramiro", "Santos", "ramiro.santos@gmail.com", "ramiroSantos123", -500);
            // AgregarCliente(cliente13);

            // // Cliente con error en la contraseña (demasiado corta)
            // Usuario cliente14 = new Cliente("Clara", "Ortiz", "clara.ortiz@gmail.com", "cla12", 1100);
            // AgregarCliente(cliente14);

            // // Cliente con error en el apellido (nulo)
            // Usuario cliente15 = new Cliente("Gabriel", null, "gabriel@outlook.com", "gabrielOut123", 1700);
            // AgregarCliente(cliente15);
        }

        private void PrecargarArticulos()
        {
            Articulo articulo1 = new Articulo("Sombrero", "Playa", 1000);
            AgregarArticulo(articulo1);

            Articulo articulo2 = new Articulo("Gafas de sol", "Accesorios", 500);
            AgregarArticulo(articulo2);

            Articulo articulo3 = new Articulo("Camiseta", "Ropa", 1200);
            AgregarArticulo(articulo3);

            Articulo articulo4 = new Articulo("Pantalón", "Ropa", 2000);
            AgregarArticulo(articulo4);

            Articulo articulo5 = new Articulo("Bolso", "Accesorios", 1500);
            AgregarArticulo(articulo5);

            Articulo articulo6 = new Articulo("Zapatos", "Calzado", 2500);
            AgregarArticulo(articulo6);

            Articulo articulo7 = new Articulo("Reloj", "Accesorios", 4000);
            AgregarArticulo(articulo7);

            Articulo articulo8 = new Articulo("Gorra", "Accesorios", 800);
            AgregarArticulo(articulo8);

            Articulo articulo9 = new Articulo("Abrigo", "Ropa", 3500);
            AgregarArticulo(articulo9);

            Articulo articulo10 = new Articulo("Bufanda", "Accesorios", 600);
            AgregarArticulo(articulo10);

            // Articulo articulo11 = new Articulo("Cinturón", "Accesorios", 700);
            // AgregarArticulo(articulo11);

            // Articulo articulo12 = new Articulo("Chaqueta", "Ropa", 3000);
            // AgregarArticulo(articulo12);

            // Articulo articulo13 = new Articulo("Vestido", "Ropa", 2800);
            // AgregarArticulo(articulo13);

            // Articulo articulo14 = new Articulo("Traje de baño", "Playa", 1100);
            // AgregarArticulo(articulo14);

            // Articulo articulo15 = new Articulo("Chanclas", "Playa", 900);
            // AgregarArticulo(articulo15);

            // Articulo articulo16 = new Articulo("Sombrilla", "Playa", 2000);
            // AgregarArticulo(articulo16);

            // Articulo articulo17 = new Articulo("Mochila", "Accesorios", 1700);
            // AgregarArticulo(articulo17);

            // Articulo articulo18 = new Articulo("Bañador", "Playa", 1300);
            // AgregarArticulo(articulo18);

            // Articulo articulo19 = new Articulo("Pulsera", "Accesorios", 400);
            // AgregarArticulo(articulo19);

            // Articulo articulo20 = new Articulo("Anillo", "Accesorios", 1200);
            // AgregarArticulo(articulo20);

            // Articulo articulo21 = new Articulo("Lentes de natación", "Playa", 500);
            // AgregarArticulo(articulo21);

            // Articulo articulo22 = new Articulo("Chaleco", "Ropa", 2500);
            // AgregarArticulo(articulo22);

            // Articulo articulo23 = new Articulo("Guantes", "Accesorios", 600);
            // AgregarArticulo(articulo23);

            // Articulo articulo24 = new Articulo("Cartera", "Accesorios", 1600);
            // AgregarArticulo(articulo24);

            // Articulo articulo25 = new Articulo("Falda", "Ropa", 1400);
            // AgregarArticulo(articulo25);

            // Articulo articulo26 = new Articulo("Pareo", "Playa", 850);
            // AgregarArticulo(articulo26);

            // Articulo articulo27 = new Articulo("Sandalias", "Calzado", 1800);
            // AgregarArticulo(articulo27);

            // Articulo articulo28 = new Articulo("Botas", "Calzado", 3200);
            // AgregarArticulo(articulo28);

            // Articulo articulo29 = new Articulo("Chalina", "Accesorios", 450);
            // AgregarArticulo(articulo29);

            // Articulo articulo30 = new Articulo("Corbata", "Accesorios", 750);
            // AgregarArticulo(articulo30);

            // Articulo articulo31 = new Articulo("Camisa", "Ropa", 1900);
            // AgregarArticulo(articulo31);

            // Articulo articulo32 = new Articulo("Short", "Ropa", 1350);
            // AgregarArticulo(articulo32);

            // Articulo articulo33 = new Articulo("Capa", "Ropa", 2600);
            // AgregarArticulo(articulo33);

            // Articulo articulo34 = new Articulo("Pantaloneta", "Playa", 1150);
            // AgregarArticulo(articulo34);

            // Articulo articulo35 = new Articulo("Sombrero de paja", "Playa", 1250);
            // AgregarArticulo(articulo35);

            // Articulo articulo36 = new Articulo("Tirantes", "Accesorios", 700);
            // AgregarArticulo(articulo36);

            // Articulo articulo37 = new Articulo("Medias", "Accesorios", 400);
            // AgregarArticulo(articulo37);

            // Articulo articulo38 = new Articulo("Pantuflas", "Calzado", 2200);
            // AgregarArticulo(articulo38);

            // Articulo articulo39 = new Articulo("Calzoncillos", "Ropa", 950);
            // AgregarArticulo(articulo39);

            // Articulo articulo40 = new Articulo("Gorro", "Accesorios", 650);
            // AgregarArticulo(articulo40);

            // Articulo articulo41 = new Articulo("Bikini", "Playa", 1600);
            // AgregarArticulo(articulo41);

            // Articulo articulo42 = new Articulo("Top", "Ropa", 1100);
            // AgregarArticulo(articulo42);

            // Articulo articulo43 = new Articulo("Traje formal", "Ropa", 5000);
            // AgregarArticulo(articulo43);

            // Articulo articulo44 = new Articulo("Botines", "Calzado", 2700);
            // AgregarArticulo(articulo44);

            // Articulo articulo45 = new Articulo("Camiseta sin mangas", "Ropa", 1000);
            // AgregarArticulo(articulo45);

            // Articulo articulo46 = new Articulo("Zapatillas deportivas", "Calzado", 3500);
            // AgregarArticulo(articulo46);

            // Articulo articulo47 = new Articulo("Riñonera", "Accesorios", 900);
            // AgregarArticulo(articulo47);

            // Articulo articulo48 = new Articulo("Bandolera", "Accesorios", 1300);
            // AgregarArticulo(articulo48);

            // Articulo articulo49 = new Articulo("Jersey", "Ropa", 2800);
            // AgregarArticulo(articulo49);

            // Articulo articulo50 = new Articulo("Gorro de lana", "Accesorios", 550);
            // AgregarArticulo(articulo50);

            // Artículo con error en el nombre (nulo)
            // Articulo articulo51 = new Articulo(null, "Ropa", 1000);
            // AgregarArticulo(articulo51);

            // // Artículo con error en la categoría (nulo)
            // Articulo articulo52 = new Articulo("Camisa", null, 1800);
            // AgregarArticulo(articulo52);

            // // Artículo con error en el precio (negativo)
            // Articulo articulo53 = new Articulo("Zapatos de vestir", "Calzado", -1500);
            // AgregarArticulo(articulo53);

            // // Artículo con error en el precio (valor cero)
            // Articulo articulo54 = new Articulo("Cinturón de cuero", "Accesorios", 0);
            // AgregarArticulo(articulo54);

            // // Artículo con nombre vacío
            // Articulo articulo55 = new Articulo("", "Playa", 700);
            // AgregarArticulo(articulo55);
        }

        private void PrecargarVentas()
        {
            // Publicacion venta1 = new Venta("Sombrero", false, 1000);
            // AgregarPublicacion(venta1);

            // Publicacion venta2 = new Venta("Gafas de sol", true, 450);
            // AgregarPublicacion(venta2);

            // Publicacion venta3 = new Venta("Camiseta", false, 1200);
            // AgregarPublicacion(venta3);

            // Publicacion venta4 = new Venta("Pantalón", true, 1800);
            // AgregarPublicacion(venta4);

            // Publicacion venta5 = new Venta("Bolso", false, 1500);
            // AgregarPublicacion(venta5);

            // Publicacion venta6 = new Venta("Zapatos", true, 2200);
            // AgregarPublicacion(venta6);

            // Publicacion venta7 = new Venta("Reloj", false, 4000);
            // AgregarPublicacion(venta7);

            // Publicacion venta8 = new Venta("Gorra", true, 800);
            // AgregarPublicacion(venta8);

            // Publicacion venta9 = new Venta("Abrigo", false, 3500);
            // AgregarPublicacion(venta9);

            // Publicacion venta10 = new Venta("Bufanda", true, 600);
            // AgregarPublicacion(venta10);

            // Publicacion venta11 = new Venta("Cinturón", false, -700);
            // AgregarPublicacion(venta11);

            // Publicacion venta12 = new Venta(null, true, 1800);
            // AgregarPublicacion(venta12);

            // Publicacion venta13 = new Venta("Zapatos deportivos", false, 0);
            // AgregarPublicacion(venta13);

            // Publicacion venta14 = new Venta("", true, 900);
            // AgregarPublicacion(venta14);

            // Publicacion venta15 = new Venta("Chaqueta", null, 2500);  // Si `null` es válido para `oferta_relampago`.
            // AgregarPublicacion(venta15);

        }

        private void PrecargarSubastas()
        {
            // Publicacion subasta1 = new Subasta("Subasta1");
            // AgregarPublicacion(subasta1);

            // Publicacion subasta2 = new Subasta("Subasta2");
            // AgregarPublicacion(subasta2);

            // Publicacion subasta3 = new Subasta("Subasta3");
            // AgregarPublicacion(subasta3);

            // Publicacion subasta4 = new Subasta("Subasta4");
            // AgregarPublicacion(subasta4);

            // Publicacion subasta5 = new Subasta("Subasta5");
            // AgregarPublicacion(subasta5);

            // Publicacion subasta6 = new Subasta("Subasta6");
            // AgregarPublicacion(subasta6);

            // Publicacion subasta7 = new Subasta("Subasta7");
            // AgregarPublicacion(subasta7);

            // Publicacion subasta8 = new Subasta("Subasta8");
            // AgregarPublicacion(subasta8);

            // Publicacion subasta9 = new Subasta("Subasta9");
            // AgregarPublicacion(subasta9);

            // Publicacion subasta10 = new Subasta("Subasta10");
            // AgregarPublicacion(subasta10);
        }

        private void PrecargarOfertas()
        {
            // Usuario cliente1 = new Cliente("Bruno", "Gomez", "brunogomez2312@gmail.com", "123", 0);
            // Oferta oferta1 = new Oferta(cliente1, 1000, DateTime.Now);

            // Usuario cliente2 = new Cliente("Hernan", "Hernandez", "hernanhernandez@gmail.com", "1234", 1000);
            // Oferta oferta2 = new Oferta(cliente2, 1000, DateTime.Now);

            // Publicacion subasta1 = new Subasta("Subasta11");
            // subasta1.AgregarOferta(oferta1);
            // subasta1.AgregarOferta(oferta2);
        }
        /*-------------- Precarga de datos --------------*/

        // Metodo para usuarios de tipo Cliente y Administrador
        public void AgregarUsuario(Usuario unUsuario) 
        {
            if (unUsuario == null)
            {
                throw new Exception("Invalido");
            }
            if (_usuarios.Contains(unUsuario))
            {
                throw new Exception("Usuario ya existente");
            }
            unUsuario.Validar();
            _usuarios.Add(unUsuario);
        }

        // Agregar articulo a la lista
        public void AgregarArticulo(Articulo unArticulo) 
        {
            if (unArticulo == null)
            {
                throw new Exception("Articulo invalido");
            }
            if (_articulos.Contains(unArticulo))
            {
                throw new Exception($"Articulo ya existente: {unArticulo}");
            }
            unArticulo.Validar();
            _articulos.Add(unArticulo);
        }

        // Agregar publicacion a la lista
        public void AgregarPublicacion(Publicacion unaPublicacion)
        {
             if (unaPublicacion == null)
            {
                throw new Exception("Publicacion invalida");
            }
            unaPublicacion.Validar();
            _publicaciones.Add(unaPublicacion);
        }

        public void CrearVenta(Publicacion unaPublicacion)
        {
            Venta esVenta = unaPublicacion as Venta;
            if (unaPublicacion == null)
            {
                throw new Exception("Invalido");
            }
            _publicaciones.Add(unaPublicacion);
        }

        public void CrearSubasta(Publicacion unaPublicacion)
        {
            Subasta esSubasta = unaPublicacion as Subasta;
            if (esSubasta == null)
            {
                throw new Exception("Invalido");
            }
            _publicaciones.Add(unaPublicacion);
        }

        public void AgregarOferta(Oferta unaOferta)
        {
            if (unaOferta == null)
            {
                throw new Exception("Invalido");
            }
        }

        public void ListadoPublicaciones(int pFechaInicio, int pFechaFin)
        {
            foreach (Publicacion item in _publicaciones)
            {
                Console.WriteLine(item);
            }
        }

        public void ListadoArticulos(string unaCategoria)
        {
            foreach (Articulo item in _articulos)
            {
                if (item.Categoria == unaCategoria)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}