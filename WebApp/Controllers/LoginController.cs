using Microsoft.AspNetCore.Mvc;
using Dominio.Entidades;
using Dominio;

namespace WebApp.Controllers
{
    public class LoginController : Controller
    {
        private Sistema _sistema = Sistema.Instancia;

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string email, string contrasenia)
        {
            try
            {
                Usuario unU = _sistema.ObtenerUsuarios(email, contrasenia);
                
                if (unU == null)
                {
                    throw new Exception("Credenciales inválidas");
                }

                HttpContext.Session.SetInt32("id", unU.Id);
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
        public IActionResult Signin(Cliente usuario, string Contrasenia2)
        {
            try
            {
                if (usuario == null)
                {
                    throw new Exception("Error en el registro");
                }
                if (usuario.Contrasenia != Contrasenia2)
                {
                    throw new Exception("Las contraseñas no coinciden");
                }
                usuario.Rol = "Cliente";
                _sistema.AgregarUsuario(usuario);
                return RedirectToAction("Index");
            } catch (Exception e)
            {
                ViewBag.mensaje = e.Message;
            }
            return View(usuario);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

    }
}