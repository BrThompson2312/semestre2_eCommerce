using Dominio;
using Dominio.Entidades;

namespace Main
{
    internal class Program
    {
        static Sistema _sistema = new Sistema();
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
                    "------------------------------------\n"
                );

                salida = int.Parse(Console.ReadLine());
                switch (salida)
                {
                    case 0:
                        AgregarAdministrador();
                        return;
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

            _sistema.AgregarUsuario(administrador);
        }

        public void AgregarCliente()
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

            _sistema.AgregarUsuario(cliente);
        }
    }
}