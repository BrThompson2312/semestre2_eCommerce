using Microsoft.AspNetCore.Mvc;
using Dominio.Entidades;

namespace WebApp.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Signin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string Email, string Contrasenia)
        { 
            HttpContext.Session.SetString("email", Email);
            HttpContext.Session.SetString("contrasenia", Contrasenia);
            return Redirect("/Usuario/Index");
        }
        
    }
}
