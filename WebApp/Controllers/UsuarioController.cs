using Dominio;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

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

        public IActionResult AltaAdministrador(Usuario usuario)
        {
            return View();
        }

    }
}