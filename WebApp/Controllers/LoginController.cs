using Microsoft.AspNetCore.Mvc;
using Dominio.Entidades;
using Dominio;
using System.Linq.Expressions;

namespace WebApp.Controllers
{
    public class LoginController : Controller
    {

        private Sistema _sistema = Sistema.Instancia;


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

       



        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

      

        [HttpPost]
        public IActionResult Login(string email, string contrasenia)
        {
            try
            {
                Usuario unU = _sistema.obtenerUsuarios(email, contrasenia);

                if (unU == null)
                {
                    throw new Exception("Credenciales inválidas");
                }

                HttpContext.Session.SetString("email", unU.Email);
                HttpContext.Session.SetString("rol", unU.Rol);

                if (unU.Rol == "Administrador")
                {
                    return RedirectToAction("Index", "Usuario");
                }
                else
                {
                    return RedirectToAction("Index", "Publicacion");
                }
            }
            catch (Exception e)
            {
                // En caso de error, enviamos el mensaje a la vista para mostrarlo
                ViewBag.mensaje = e.Message;
            }

            // En caso de error, se vuelve a cargar la vista Ingresar con el mensaje de error
            return View(); // Esto asegura que se vuelve a cargar la vista "Ingresar.cshtml"
        }








    }
}
