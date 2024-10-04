﻿using Dominio.Entidades;

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
            PrecargarAdministradores( );
            PrecargarClientes();
            PrecargarPublicaciones();
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

            // Usuario admin3 = new Administrador("Pedro", "Diaz", "pedro.diaz@gmail", null); // Contrasenia no puede ser null o vacia
            // AgregarUsuario(admin3);

            // Usuario admin4 = new Administrador("Ana", "Martinez", null, "ana12"); // Email no puede ser null o vacia
            // AgregarUsuario(admin4);

            // Usuario admin5 = new Administrador(null, "Sanchez", "sanchez.admin@outlook.com", "sanchezAdmin789"); // Nombre no puede ser null o vacia
            // AgregarUsuario(admin5);

            // Usuario admin6 = new Administrador("Laura", null, "laura.admin@gmail.com", "lauraAdmin101"); // Apellido no puede ser null o vacia
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

            // Usuario cliente12 = new Cliente(null, "Vega", "vega@hotmail.com", "vegaPassword123", 1000); // Nombre null
            // AgregarCliente(cliente12);

            // Usuario cliente13 = new Cliente("Ramiro", "Santos", "ramiro.santos@gmail.com", "ramiroSantos123", -500); // Saldo negativo
            // AgregarCliente(cliente13);

            // Usuario cliente15 = new Cliente("Gabriel", null, "gabriel@outlook.com", "gabrielOut123", 1700); // Apellido null
            // AgregarCliente(cliente15);
        }

        private void PrecargarPublicaciones()
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

            Articulo articulo11 = new Articulo("Cinturón", "Accesorios", 700);
            AgregarArticulo(articulo11);

            Articulo articulo12 = new Articulo("Chaqueta", "Ropa", 3000);
            AgregarArticulo(articulo12);

            Articulo articulo13 = new Articulo("Vestido", "Ropa", 2800);
            AgregarArticulo(articulo13);

            Articulo articulo14 = new Articulo("Traje de baño", "Playa", 1100);
            AgregarArticulo(articulo14);

            Articulo articulo15 = new Articulo("Chanclas", "Playa", 900);
            AgregarArticulo(articulo15);

            Articulo articulo16 = new Articulo("Sombrilla", "Playa", 2000);
            AgregarArticulo(articulo16);

            Articulo articulo17 = new Articulo("Mochila", "Accesorios", 1700);
            AgregarArticulo(articulo17);

            Articulo articulo18 = new Articulo("Bañador", "Playa", 1300);
            AgregarArticulo(articulo18);

            Articulo articulo19 = new Articulo("Pulsera", "Accesorios", 400);
            AgregarArticulo(articulo19);

            Articulo articulo20 = new Articulo("Anillo", "Accesorios", 1200);
            AgregarArticulo(articulo20);

            Articulo articulo21 = new Articulo("Lentes de natación", "Playa", 500);
            AgregarArticulo(articulo21);

            Articulo articulo22 = new Articulo("Chaleco", "Ropa", 2500);
            AgregarArticulo(articulo22);

            Articulo articulo23 = new Articulo("Guantes", "Accesorios", 600);
            AgregarArticulo(articulo23);

            Articulo articulo24 = new Articulo("Cartera", "Accesorios", 1600);
            AgregarArticulo(articulo24);

            Articulo articulo25 = new Articulo("Falda", "Ropa", 1400);
            AgregarArticulo(articulo25);

            Articulo articulo26 = new Articulo("Pareo", "Playa", 850);
            AgregarArticulo(articulo26);

            Articulo articulo27 = new Articulo("Sandalias", "Calzado", 1800);
            AgregarArticulo(articulo27);

            Articulo articulo28 = new Articulo("Botas", "Calzado", 3200);
            AgregarArticulo(articulo28);

            Articulo articulo29 = new Articulo("Chalina", "Accesorios", 450);
            AgregarArticulo(articulo29);

            Articulo articulo30 = new Articulo("Corbata", "Accesorios", 750);
            AgregarArticulo(articulo30);

            Articulo articulo31 = new Articulo("Camisa", "Ropa", 1900);
            AgregarArticulo(articulo31);

            Articulo articulo32 = new Articulo("Short", "Ropa", 1350);
            AgregarArticulo(articulo32);

            Articulo articulo33 = new Articulo("Capa", "Ropa", 2600);
            AgregarArticulo(articulo33);

            Articulo articulo34 = new Articulo("Pantaloneta", "Playa", 1150);
            AgregarArticulo(articulo34);

            Articulo articulo35 = new Articulo("Sombrero de paja", "Playa", 1250);
            AgregarArticulo(articulo35);

            Articulo articulo36 = new Articulo("Tirantes", "Accesorios", 700);
            AgregarArticulo(articulo36);

            Articulo articulo37 = new Articulo("Medias", "Accesorios", 400);
            AgregarArticulo(articulo37);

            Articulo articulo38 = new Articulo("Pantuflas", "Calzado", 2200);
            AgregarArticulo(articulo38);

            Articulo articulo39 = new Articulo("Calzoncillos", "Ropa", 950);
            AgregarArticulo(articulo39);

            Articulo articulo40 = new Articulo("Gorro", "Accesorios", 650);
            AgregarArticulo(articulo40);

            Articulo articulo41 = new Articulo("Bikini", "Playa", 1600);
            AgregarArticulo(articulo41);

            Articulo articulo42 = new Articulo("Top", "Ropa", 1100);
            AgregarArticulo(articulo42);

            Articulo articulo43 = new Articulo("Traje formal", "Ropa", 5000);
            AgregarArticulo(articulo43);

            Articulo articulo44 = new Articulo("Botines", "Calzado", 2700);
            AgregarArticulo(articulo44);

            Articulo articulo45 = new Articulo("Camiseta sin mangas", "Ropa", 1000);
            AgregarArticulo(articulo45);

            Articulo articulo46 = new Articulo("Zapatillas deportivas", "Calzado", 3500);
            AgregarArticulo(articulo46);

            Articulo articulo47 = new Articulo("Riñonera", "Accesorios", 900);
            AgregarArticulo(articulo47);

            Articulo articulo48 = new Articulo("Bandolera", "Accesorios", 1300);
            AgregarArticulo(articulo48);

            Articulo articulo49 = new Articulo("Jersey", "Ropa", 2800);
            AgregarArticulo(articulo49);

            Articulo articulo50 = new Articulo("Gorro de lana", "Accesorios", 550);
            AgregarArticulo(articulo50);

            // Articulo articulo51 = new Articulo(null, "Ropa", 1000); //Nombre nulo, no valido
            // AgregarArticulo(articulo51);

            // Articulo articulo52 = new Articulo("Camisa", null, 1800); // Categoria nula, no valido
            // AgregarArticulo(articulo52);

            // Articulo articulo53 = new Articulo("Zapatos de vestir", "Calzado", -1500); // Precio negativo
            // AgregarArticulo(articulo53);

            // Articulo articulo54 = new Articulo("Cinturón de cuero", "Accesorios", 0); // Precio invalido, no puede ser 0
            // AgregarArticulo(articulo54);

            // Articulo articulo55 = new Articulo("", "Playa", 700); //Nombre vacio
            // AgregarArticulo(articulo55);

            /* ---------------- Precarga de ventas ---------------- */
            Publicacion venta1 = new Venta("Descuento Playero! xd", new DateTime(2024, 5, 12), false, 1000);
            AgregarPublicacion(venta1);
            venta1.AgregarArticulo(articulo1);
            venta1.AgregarArticulo(articulo2);
            venta1.AgregarArticulo(articulo3);

            Publicacion venta2 = new Venta("Oferta de Verano", new DateTime(2024, 6, 20), true, 850);
            AgregarPublicacion(venta2);
            venta2.AgregarArticulo(articulo1);
            venta2.AgregarArticulo(articulo2);
            venta2.AgregarArticulo(articulo3);

            Publicacion venta3 = new Venta("Liquidación de Invierno", new DateTime(2024, 12, 1), false, 1200);
            AgregarPublicacion(venta3);
            venta3.AgregarArticulo(articulo1);
            venta3.AgregarArticulo(articulo2);
            venta3.AgregarArticulo(articulo3);

            Publicacion venta4 = new Venta("Descuento Primavera", new DateTime(2024, 4, 15), true, 900);
            AgregarPublicacion(venta4);
            venta4.AgregarArticulo(articulo1);
            venta4.AgregarArticulo(articulo2);
            venta4.AgregarArticulo(articulo3);

            Publicacion venta5 = new Venta("Promoción Otoñal", new DateTime(2024, 10, 10), false, 1500);
            AgregarPublicacion(venta5);
            venta5.AgregarArticulo(articulo4);
            venta5.AgregarArticulo(articulo5);
            venta5.AgregarArticulo(articulo6);

            Publicacion venta6 = new Venta("Oferta Relámpago Accesorios", new DateTime(2024, 3, 5), true, 600);
            AgregarPublicacion(venta6);
            venta6.AgregarArticulo(articulo7);
            venta6.AgregarArticulo(articulo8);
            venta6.AgregarArticulo(articulo9);

            Publicacion venta7 = new Venta("Descuento en Electrónica", new DateTime(2024, 7, 25), false, 2200);
            AgregarPublicacion(venta7);
            venta7.AgregarArticulo(articulo10);
            venta7.AgregarArticulo(articulo11);
            venta7.AgregarArticulo(articulo12);

            Publicacion venta8 = new Venta("Black Friday 2024", new DateTime(2024, 11, 29), true, 3500);
            AgregarPublicacion(venta8);
            venta8.AgregarArticulo(articulo13);
            venta8.AgregarArticulo(articulo14);
            venta8.AgregarArticulo(articulo15);

            Publicacion venta9 = new Venta("Oferta en Moda", new DateTime(2024, 8, 18), false, 1800);
            AgregarPublicacion(venta9);
            venta9.AgregarArticulo(articulo16);
            venta9.AgregarArticulo(articulo17);
            venta9.AgregarArticulo(articulo18);

            Publicacion venta10 = new Venta("Promoción Especial Festiva", new DateTime(2024, 12, 20), true, 2000);
            AgregarPublicacion(venta10);
            venta10.AgregarArticulo(articulo19);
            venta10.AgregarArticulo(articulo20);
            venta10.AgregarArticulo(articulo21);

            /* Precarga de ofertas */
            Usuario cliente1 = new Cliente("Bruno", "Gomez", "brunogomez2312@gmail.com", "123", 1000);
            Usuario cliente2 = new Cliente("Hernan", "Hernandez", "hernanhernandez@gmail.com", "123", 2000);
            Usuario cliente3 = new Cliente("Juan", "Benitez", "juan@gmail.com", "123", 2000);
            Usuario cliente4 = new Cliente("Jorge", "Casuriaga", "jorg@gmail.com", "123", 2000);

            Oferta oferta1 = new Oferta(cliente1, 1000, new DateTime(2024, 10, 3));
            oferta1.Validar();
            
            Oferta oferta2 = new Oferta(cliente1, 1000, new DateTime(2024, 12, 3)); // Error, no puede haber otra oferta con el mismo monto del mismo cliente.
            oferta2.Validar();

            Oferta oferta3 = new Oferta(cliente1, 2000, new DateTime(2024, 11, 25));
            oferta3.Validar();

            // Oferta oferta4 = new Oferta(cliente1, 0, new DateTime(2024, 10, 3)); // Monto menor o igual a 0
            // oferta4.Validar();

            // Oferta oferta5 = new Oferta(null, 2000, new DateTime(2024, 10, 3)); // Usuario null
            // oferta5.Validar();

            Oferta oferta6 = new Oferta(cliente2, 1800, new DateTime(2024, 10, 3));
            oferta6.Validar();

            Oferta oferta7 = new Oferta(cliente2, 2200, new DateTime(2024, 7, 11));
            oferta7.Validar();

            Oferta oferta8 = new Oferta(cliente2, 3000, new DateTime(2024, 9, 7));
            oferta8.Validar();

            Oferta oferta9 = new Oferta(cliente3, 2750, new DateTime(2024, 11, 29));
            oferta9.Validar();

            Oferta oferta10 = new Oferta(cliente3, 3200, new DateTime(2024, 8, 19));
            oferta10.Validar();

            Oferta oferta11 = new Oferta(cliente3, 2100, new DateTime(2024, 8, 5));
            oferta11.Validar();

            Oferta oferta12 = new Oferta(cliente4, 2900, new DateTime(2024, 12, 1));
            oferta12.Validar();

            Oferta oferta13 = new Oferta(cliente4, 2400, new DateTime(2024, 3, 25));
            oferta13.Validar();

            /* ---------------- Precarga de subastas ---------------- */
            Publicacion subasta1 = new Subasta("Subasta de accesorios", new DateTime(2024, 10, 3));
            AgregarPublicacion(subasta1);
            subasta1.AgregarArticulo(articulo22);
            subasta1.AgregarArticulo(articulo23);
            subasta1.AgregarArticulo(articulo24);
            subasta1.AgregarOferta(oferta1);
            // subasta1.AgregarOferta(oferta2); // Oferta debe tener diferente monto si que el usuario ya ha publicado previamente
            // subasta1.AgregarOferta(oferta3); // Oferta con fecha de publicacion invalida

            Publicacion subasta2 = new Subasta("Subasta de relojes", new DateTime(2024, 11, 5));
            AgregarPublicacion(subasta2);
            subasta2.AgregarArticulo(articulo25);
            subasta2.AgregarArticulo(articulo26);
            subasta2.AgregarArticulo(articulo27);
            // subasta2.AgregarOferta(oferta1); // Error, fecha es menor a la de publicacion
            subasta2.AgregarOferta(oferta2);
            subasta2.AgregarOferta(oferta3);
            // subasta2.AgregarOferta(oferta13); // Mismo error de fecha
            
            Publicacion subasta3 = new Subasta("Subasta de ropa de verano", new DateTime(2024, 6, 15));
            AgregarPublicacion(subasta3);
            subasta3.AgregarArticulo(articulo28);
            subasta3.AgregarArticulo(articulo29);
            subasta3.AgregarArticulo(articulo30);
            subasta3.AgregarOferta(oferta6);
            // subasta3.AgregarOferta(oferta6); // Misma oferta
            subasta3.AgregarOferta(oferta7);
            subasta3.AgregarOferta(oferta8);
            subasta3.AgregarOferta(oferta12);

            Publicacion subasta4 = new Subasta("Subasta de tecnología", new DateTime(2024, 7, 20));
            AgregarPublicacion(subasta4);
            subasta4.AgregarArticulo(articulo31);
            subasta4.AgregarArticulo(articulo32);
            subasta4.AgregarArticulo(articulo33);
            subasta4.AgregarOferta(oferta9);
            subasta4.AgregarOferta(oferta10);
            subasta4.AgregarOferta(oferta11);

            Publicacion subasta5 = new Subasta("Subasta de calzado deportivo", new DateTime(2024, 9, 12));
            AgregarPublicacion(subasta5);
            subasta5.AgregarArticulo(articulo34);
            subasta5.AgregarArticulo(articulo35);
            subasta5.AgregarArticulo(articulo36);

            Publicacion subasta6 = new Subasta("Subasta de productos de invierno", new DateTime(2024, 12, 1));
            AgregarPublicacion(subasta6);
            subasta6.AgregarArticulo(articulo37);
            subasta6.AgregarArticulo(articulo38);
            subasta6.AgregarArticulo(articulo39);

            Publicacion subasta7 = new Subasta("Subasta de bolsos y carteras", new DateTime(2024, 5, 10));
            AgregarPublicacion(subasta7);
            subasta7.AgregarArticulo(articulo40);
            subasta7.AgregarArticulo(articulo41);
            subasta7.AgregarArticulo(articulo42);

            Publicacion subasta8 = new Subasta("Subasta de artículos de cocina", new DateTime(2024, 8, 22));
            AgregarPublicacion(subasta8);
            subasta8.AgregarArticulo(articulo43);
            subasta8.AgregarArticulo(articulo44);
            subasta8.AgregarArticulo(articulo45);

            Publicacion subasta9 = new Subasta("Subasta de libros y revistas", new DateTime(2024, 3, 17));
            AgregarPublicacion(subasta9);
            subasta9.AgregarArticulo(articulo46);
            subasta9.AgregarArticulo(articulo47);
            subasta9.AgregarArticulo(articulo48);

            Publicacion subasta10 = new Subasta("Subasta de muebles", new DateTime(2024, 4, 25));
            AgregarPublicacion(subasta10);
            subasta10.AgregarArticulo(articulo49);
            subasta10.AgregarArticulo(articulo50);
        }
        /*-------------- Precarga de datos --------------*/

        // Metodo para usuarios de tipo Cliente y Administrador
        public void AgregarUsuario(Usuario unUsuario) 
        {
            if (unUsuario == null)
            {
                throw new Exception("Usuario null");
            }
            if (_usuarios.Contains(unUsuario))
            {
                throw new Exception($"Usuario ya existente: {unUsuario}");
            }
            unUsuario.Validar();
            _usuarios.Add(unUsuario);
        }

        // Agregar articulo a la lista
        public void AgregarArticulo(Articulo unArticulo) 
        {
            if (unArticulo == null)
            {
                throw new Exception("Articulo null");
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
                throw new Exception("Publicacion null");
            }
            unaPublicacion.Validar();
            _publicaciones.Add(unaPublicacion);
        }

        public void ListadoPublicaciones(DateTime pFechaInicio, DateTime pFechaFin)
        {
            foreach (Publicacion item in _publicaciones)
            {
                if (item.FechaPublicacion >= pFechaInicio && item.FechaFinalizacionCompra <= pFechaFin)
                {
                    Console.WriteLine(item);
                }
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