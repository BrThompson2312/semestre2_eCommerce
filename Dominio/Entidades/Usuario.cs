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

        public Usuario(string _nombre, string _apellido, string _email, string _contrasenia, string _rol)
        {
            Id = ultimoId++;
            Nombre = _nombre;
            Apellido = _apellido;
            Email = _email;
            Contrasenia = _contrasenia;
            Rol = _rol;
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
            //if(string.IsNullOrEmpty(Contrasenia)) 
            //{
            //    throw new Exception($"{res}: Contraseña invalido");
            //}

            if (!ValidarContrasenia(Contrasenia))
            {
                throw new Exception($"{res}: Contraseña invalida");
            }

            //var (resb, ms) = ValidarContrasenia2(Contrasenia);
            //if (!resb)
            //    throw new Exception(ms);
        }

        //public (bool res, string ms) ValidarContrasenia2(string pass)
        //{
        //    if (string.IsNullOrEmpty(pass))
        //        return (false, "vacio");
        //    if (pass.Length < 8)
        //        return (false, "minimo de caracteres");

        //    //bool numbers = false;
        //    //string nums = "1234567890";
        //    //for (int i = 0; i < pass.Length; i++)
        //    //{
        //    //    for (int k = 0; k < nums.Length; k++)
        //    //    {
        //    //        if (pass[i] == nums[k])
        //    //        {
        //    //            numbers = true;
        //    //            break;
        //    //        }
        //    //    }
        //    //    if (numbers) break;
        //    //}

        //    //if (numbers == false)
        //    //    return (false, "no numbers");

        //    bool letter = false;
        //    bool mayus = false;
        //    bool minus = false;
        //    bool symbol = false;
        //    bool digit = false;

        //    for (int i = 0; i < pass.Length; i++)
        //    {
        //        if (char.IsLetter(pass[i]))
        //            letter = true;

        //        if (char.IsSymbol(pass[i]) || char.IsPunctuation(pass[i]))
        //            symbol = true;

        //        if (char.IsUpper(pass[i]))
        //            mayus = true;

        //        if (char.IsLower(pass[i]))
        //            minus = true;

        //        if (char.IsDigit(pass[i]))
        //            digit = true;

        //        if (letter && symbol && mayus && minus && digit)
        //            break;
        //    }

        //    //if (!numbers)
        //    //    return (false, "no numbers");

        //    if (!letter)
        //        return (false, "no letters");

        //    if (!mayus)
        //        return (false, "no mayus");

        //    if (!minus)
        //        return (false, "no minus");

        //    if (!symbol)
        //        return (false, "no symbol");

        //    if (!digit)
        //        return (false, "no digits");

        //    return (true, "cumple todo");
        //}

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