using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class UsuarioController : Controller
    {

Sistema _sistema = new Sistema();

        public IActionResult Index()
        {
            ViewBag.Usuarios = _sistema.Usuarios;
            return View();
        }

        public IActionResult Ver(int id)
        {
            ViewBag.Id = id;
            return View();
        }


    }
}
