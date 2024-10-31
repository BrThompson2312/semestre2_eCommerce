using Dominio;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApp.Controllers
{
    public class UsuarioController : Controller
    {

        static Sistema _sistema = Sistema.Instancia;

        public IActionResult Index()
        {
            ViewBag.Usuarios = _sistema.Usuarios;
            return View();
        }

        public IActionResult Administradores()
        {
            ViewBag.Usuarios = _sistema.ListadoAdministradores();
            return View("index");
        }

        public IActionResult Clientes()
        {
            ViewBag.Usuarios = _sistema.ListadoClientes();
            return View("index");
        }

        public IActionResult ListadoUsuariosXNombre(string nombre)
        {
            ViewBag.Usuarios = _sistema.ListadoUsuariosXNombre(nombre);
            return View("index");
        }

        [HttpGet]
        public IActionResult AltaAdministrador()
        {
            ViewBag.Usuarios = _sistema.Usuarios;
            return View();
        }

        [HttpPost]
        public IActionResult AltaAdministrador(Usuario usuario)
        {
            try
            {
                _sistema.AgregarUsuario(usuario);
                return RedirectToAction("index", new { mensaje = "Se dio de alta el administrador en forma exitosa." });

                
            }
            catch (Exception e)
            {
                ViewBag.mensaje = e.Message;
                ViewBag.Usuarios = _sistema.ListadoAdministradores();
            }
            return View(usuario);
        }


        [HttpGet]
        public IActionResult AltaCliente()
        {
            ViewBag.Usuarios = _sistema.Usuarios;
            return View();
        }

        [HttpPost]
        public IActionResult AltaCliente(Usuario usuario)
        {
            try
            {
                _sistema.AgregarUsuario(usuario);
                return RedirectToAction("index", new { mensaje = "Se dio de alta el cliente en forma exitosa." });


            }
            catch (Exception e)
            {
                ViewBag.mensaje = e.Message;
                ViewBag.Usuarios = _sistema.ListadoClientes();
            }
            return View(usuario);
        }
        
    }
}






   