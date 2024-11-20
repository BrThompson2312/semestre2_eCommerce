using Microsoft.AspNetCore.Mvc;
using Dominio.Entidades;
using Dominio;

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

        [HttpPost]
        public IActionResult Login(string email, string contrasenia)
        {
            try
            {
                Usuario unU = _sistema.ObtenerUsuarios(email, contrasenia);
                
                if (unU == null)
                {
                    throw new Exception("Credenciales inválidas");
                }

                HttpContext.Session.SetString("email", unU.Email);
                HttpContext.Session.SetString("rol", unU.Rol);

                if (unU.Rol == "Administrador")
                {
                    return Redirect("/Publicacion/Index");
                }
                else
                {
                    return Redirect("/Publicacion/Index");
                }
            }
            catch (Exception e)
            {
                ViewBag.mensaje = e.Message;
            }
            return View();
        }

        [HttpGet]
        public IActionResult Signin()
        {
            return View(new Cliente());
        }

        [HttpPost]
        public IActionResult Signin(Cliente usuario)
        {
            try
            {
                if (usuario == null)
                {
                    throw new Exception("Error en el registro");
                }
                usuario.Rol = "cliente";
                _sistema.AgregarUsuario(usuario);
                return Redirect("Login");
            } catch (Exception e)
            {
                ViewBag.mensaje = e.Message;
            }
            return View(usuario);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

    }
}