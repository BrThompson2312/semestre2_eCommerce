using Dominio;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApp.Controllers
{
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
        public IActionResult AltaCliente()
        {
            //ViewBag.Usuarios = _sistema.Usuarios;
            return View(new Cliente());
        }

        [HttpPost]
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
                //ViewBag.Usuarios = _sistema.ListadoClientes();
            }
            return View(usuario);
        }

        [HttpGet]
        public IActionResult AltaAdministrador()
        {
            ViewBag.Usuarios = _sistema.Usuarios;
            return View(new Administrador());
        }

        [HttpPost]
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
                //ViewBag.Usuarios = _sistema.ListadoAdministradores();
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
            string emailSession = HttpContext.Session.GetString("email");

            ViewBag.Email = emailSession;
            ViewBag.Usuario = _sistema.FiltrarUsuarioXId(id);
            if (ViewBag.Usuario == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }



    }
}






   