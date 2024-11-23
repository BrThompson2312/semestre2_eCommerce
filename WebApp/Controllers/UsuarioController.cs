using Dominio;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using WebApp.Filtros;

namespace WebApp.Controllers
{
    [FLogueado]
    //[FAdmin]
    public class UsuarioController : Controller
    {
        Sistema _sistema = Sistema.Instancia;

        [HttpGet]
        public IActionResult Index(string mensaje)
        {
            ViewBag.mensaje = mensaje;
            ViewBag.Usuarios = _sistema.Usuarios;
            return View();
        }

        [HttpGet]
        public IActionResult ListadoAdministradores()
        {
            ViewBag.Usuarios = _sistema.ListadoAdministradores();
            return View("Index");
        }

        [HttpGet]
        public IActionResult ListadoClientes()
        {
            ViewBag.Usuarios = _sistema.ListadoClientes();
            return View("Index");
        }

        [HttpGet]
        public IActionResult ListadoUsuariosXNombre(string nombre)
        {
            ViewBag.Usuarios = _sistema.ListadoUsuariosXNombre(nombre);
            return View("Index");
        }

        [HttpGet]
        public IActionResult ListadoUsuariosXEmail(string email)
        {
            ViewBag.Usuarios = _sistema.ListadoUsuariosXEmail(email);
            return View("Index");
        }

        [HttpGet]
        [FAdmin]
        public IActionResult AltaCliente()
        {
            return View(new Cliente());
        }

        [HttpPost]
        [FAdmin]
        public IActionResult AltaCliente(Cliente usuario)
        {
            try
            {
                _sistema.AgregarUsuario(usuario);
                return RedirectToAction("Index", new { mensaje = "Se dio de alta el cliente en forma exitosa." });
            }
            catch (Exception e)
            {
                ViewBag.mensaje = e.Message;
            }
            return View(usuario);
        }

        [HttpGet]
        [FAdmin]
        public IActionResult AltaAdministrador()
        {
            ViewBag.Usuarios = _sistema.Usuarios;
            return View(new Administrador());
        }

        [HttpPost]
        [FAdmin]
        public IActionResult AltaAdministrador(Administrador administrador)
        {
            try
            {
                _sistema.AgregarUsuario(administrador);
                return RedirectToAction("index", new { mensaje = "Se dio de alta el administrador en forma exitosa." });
            }
            catch (Exception e)
            {
                ViewBag.mensaje = e.Message;
            }
            return View(administrador);
        }

        [HttpGet]
        public IActionResult Ver(int id)
        {
            string emailSession = HttpContext.Session.GetString("email");
            ViewBag.Email = emailSession;
            ViewBag.Usuario = _sistema.FiltrarUsuarioXId(id);
            if (ViewBag.Usuario == null)
            {
                return RedirectToAction("index", new { mensaje = "Error, no se ha encontrado el usuario" });
            }
            return View();
        }

        [HttpGet]
        public IActionResult Modificar(int id)
        {
            ViewBag.Usuario = _sistema.FiltrarUsuarioXId(id);
            if (ViewBag.Usuario == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Modificar(int id, string Nombre, string Apellido, string Email, string Contrasenia, string Password2)
        {
            Usuario usuario = _sistema.FiltrarUsuarioXId(id);
            ViewBag.Usuario = usuario;
            try
            {
                _sistema.ModificarUsuario(id, Nombre, Apellido, Email, Contrasenia, Password2);

                return RedirectToAction("Index", new {mensaje="Datos modificados con Exito"});
            } catch (Exception e)
            {
                ViewBag.mensaje_error = e.Message;
            }
            return View();
        }

        [HttpGet]
        public IActionResult RecargarSaldo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RecargarSaldo(int Recarga)
        {
            int idSession = (int)HttpContext.Session.GetInt32("id");

            try
            {
                _sistema.RecargarSaldoCliente(idSession, Recarga);
                ViewBag.mensaje = "Saldo recargado exitosamente";
            } catch (Exception e)
            {
                ViewBag.mensaje_error = e.Message;
            }
            return View();
        }

        [HttpGet]
        [FCliente]
        public IActionResult ConsultarSaldo()
        {
            int idSession = (int)HttpContext.Session.GetInt32("id");
            Usuario usuario = _sistema.FiltrarUsuarioXId(idSession);
            decimal saldo = usuario.ObtenerSaldo();
            ViewBag.Saldo = saldo;
            return View();
        }
    }
}