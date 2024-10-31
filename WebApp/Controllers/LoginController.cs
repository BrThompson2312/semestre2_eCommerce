using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string Email, string Contrasenia)
        { 
            HttpContext.Session.SetString ("email", Email);
            HttpContext.Session.SetString("contrasenia", Contrasenia);
            return Redirect("/Usuario/index");
        }
        

    }
}
