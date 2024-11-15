using Dominio;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class PublicacionController : Controller
    {
        Sistema _sistema = Sistema.Instancia;

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Publicaciones = _sistema.Publicaciones;
            ViewBag.Titulo = "Publicaciones";
            return View();
        }

        [HttpGet]
        public IActionResult ListadoVentas()
        {
            ViewBag.Publicaciones = _sistema.ListadoVentas();
            ViewBag.Titulo = "Ventas";
            return View("Index");
        }

        [HttpGet]
        public IActionResult ListadoSubastas()
        {
            ViewBag.Publicaciones = _sistema.ListadoSubastas();
            ViewBag.Titulo = "Subastas";
            return View("Index");
        }

        [HttpPost]
        public IActionResult ListadoPublicacionXNombre(string nombre)
        {
            ViewBag.Publicaciones = _sistema.ListadoPublicacionesXNombre(nombre);
            ViewBag.Titulo = "Subastas";
            return View("Index");
        }

        [HttpGet]
        public IActionResult Ver(int id)
        {

            ViewBag.Publicacion = _sistema.FiltrarPublicacionXId(id);
            if (ViewBag.Publicacion == null)
            {
                return RedirectToAction("index");
            }
            
            return View();
        
        }
      
    }
}
