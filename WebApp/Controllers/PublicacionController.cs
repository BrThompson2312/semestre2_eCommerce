using Dominio;
using Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Filtros;

namespace WebApp.Controllers
{
    [FLogueado]
    public class PublicacionController : Controller
    {
        Sistema _sistema = Sistema.Instancia;

        [HttpGet]
        public IActionResult Index(string mensaje)
        {
            ViewBag.mensaje = mensaje;
            ViewBag.Publicaciones = _sistema.Publicaciones;

            ViewBag.Titulo = "Publicaciones";
            if (HttpContext.Session.GetString("rol") == "Administrador")
            {
                ViewBag.Titulo = "Subastas";
            }

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
        public IActionResult ListadoSubastas(string mensaje)
        {
            ViewBag.Publicaciones = _sistema.ListadoSubastas();
            ViewBag.mensaje = mensaje;
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
        public IActionResult VerVenta(int id)
        {
            int idSession = (int)HttpContext.Session.GetInt32("id");
            ViewBag.Publicacion = _sistema.FiltrarPublicacionXId(id);
            ViewBag.IdSession = idSession;
            decimal saldo = _sistema.FiltrarUsuarioXId(idSession).ObtenerSaldo();
            ViewBag.Saldo = saldo;

            if (ViewBag.Publicacion == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult VerVenta(int id, int n)
        {
            int idSession = (int)HttpContext.Session.GetInt32("id");
            ViewBag.Publicacion = _sistema.FiltrarPublicacionXId(id);
            ViewBag.IdSession = idSession;
            decimal saldo = _sistema.FiltrarUsuarioXId(idSession).ObtenerSaldo();
            ViewBag.Saldo = saldo;

            try
            {
                _sistema.ComprarVenta(idSession, id, saldo);
                return RedirectToAction("Index", new { mensaje = "Compra realizada con exito"});
            } catch (Exception e)
            {
                ViewBag.mensaje = e.Message; 
            }
            return View();
        }

        public IActionResult VerSubasta(int id)
        {
            Publicacion subasta = _sistema.FiltrarPublicacionXId(id);
            ViewBag.Publicacion = subasta;
            ViewBag.Oferta = subasta.OfertaConMasValor();

            if (ViewBag.Publicacion == null)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public IActionResult VerSubasta(int id, int monto)
        {
            Publicacion subasta = _sistema.FiltrarPublicacionXId(id);
            ViewBag.Publicacion = subasta;
            ViewBag.Oferta = subasta.OfertaConMasValor();

            int idSession = (int)HttpContext.Session.GetInt32("id");
            Usuario usuario = _sistema.FiltrarUsuarioXId(idSession);
            decimal saldo = usuario.ObtenerSaldo();

            try
            {
                if (saldo < monto)
                {
                    throw new Exception("No dispone del saldo insuficiente");
                }
                _sistema.OfertarSubasta(subasta, idSession, monto);
                return RedirectToAction("ListadoSubastas", new { mensaje = "Subasta realizada con exito"});
            } catch (Exception e)
            {
                ViewBag.mensaje_error = e.Message;
            }

            return View();
        }
    }
}