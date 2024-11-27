using System.Globalization;
using System.Linq;

namespace Dominio.Entidades
{
    public abstract class Usuario : IValidar
    {
        public int Id {get; set;}
        private static int ultimoId = 0;
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string Email {get; set;}
        public string Contrasenia {get; set;}
        public string Rol { get; set; }

        public Usuario()
        {
            Id = ultimoId++;
        }

        public Usuario(string _nombre, string _apellido, string _email, string _contrasenia)
        {
            Id = ultimoId++;
            Nombre = _nombre;
            Apellido = _apellido;
            Email = _email;
            Contrasenia = _contrasenia;
        }

        public virtual void Validar()
        {
            string res = $"Usuario id_{Id}({Nombre})";
            if (string.IsNullOrEmpty(Nombre))
            {
                throw new Exception($"{res}: Nombre invalido");
            } 
            if(string.IsNullOrEmpty(Apellido)) 
            {
                throw new Exception($"{res}: Apellido invalido");
            }
            if(string.IsNullOrEmpty(Email)) 
            {
                throw new Exception($"{res}: Email invalido");
            }
            if (!ValidarContrasenia(Contrasenia))
            {
                throw new Exception($"{res}: Contraseña invalida");
            }
        }

        public bool ValidarContrasenia(string pass)
        {
            if (string.IsNullOrEmpty(pass))
                return false;
            if (pass.Length < 8)
                return false;

            bool letter = false;
            bool mayus = false;
            bool minus = false;
            bool symbol = false;
            bool digit = false;

            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsLetter(pass[i]))
                    letter = true;

                if (char.IsSymbol(pass[i]) || char.IsPunctuation(pass[i]))
                    symbol = true;

                if (char.IsUpper(pass[i]))
                    mayus = true;

                if (char.IsLower(pass[i]))
                    minus = true;

                if (char.IsDigit(pass[i]))
                    digit = true;

                if (letter && symbol && mayus && minus && digit)
                    break;
            }

            if (!letter)
                return false;

            if (!mayus)
                return false;

            if (!minus)
                return false;

            if (!symbol)
                return false;

            if (!digit)
                return false;

            return true;
        }

        public abstract void RecargarSaldo(int monto);

        public abstract decimal ObtenerSaldo();

        public abstract void DescontarSaldo(decimal monto);

        public override string ToString()
        {
            string res = $" Id: {Id} ";
            res += $" Nombre: {Nombre} ";
            res += $" Apellido: {Apellido} ";
            res += $" Email: {Email} ";
            res += $" Contraseña: {Contrasenia} ";
            return res;
        }

        public override bool Equals(object obj)
        {
            Usuario usuario = obj as Usuario;
            return usuario != null && Id == usuario.Id || usuario.Email == Email;
        }

    }
}