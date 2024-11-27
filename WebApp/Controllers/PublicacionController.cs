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
        public IActionResult Index(string mensaje, string mensaje_error)
        {
            ViewBag.mensaje = mensaje;
            ViewBag.mensaje_error = mensaje_error;
            ViewBag.Publicaciones = _sistema.Publicaciones;
            ViewBag.Subastas = _sistema.Publicaciones;
            //_sistema.VaciarPublicaciones();

            ViewBag.CantVentas = _sistema.CantidadVentas();
            ViewBag.CantSubastas = _sistema.CantidadSubastas();

            ViewBag.Titulo = "Publicaciones";
            if (HttpContext.Session.GetString("rol") == "Administrador")
            {
                ViewBag.Titulo = "Subastas";
            }

            return View();
        }

        [HttpGet]
        [FCliente]
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
            ViewBag.Titulo = "Publicaciones";
            return View("Index");
        }

        [HttpGet]
        [FCliente]
        public IActionResult VerVenta(int id)
        {
            int idSession = (int)HttpContext.Session.GetInt32("id");
            ViewBag.Publicacion = _sistema.FiltrarPublicacionXId(id);
            ViewBag.IdSession = idSession;
            decimal saldo = _sistema.FiltrarUsuarioXId(idSession).ObtenerSaldo();
            ViewBag.Saldo = saldo;

            if (ViewBag.Publicacion == null)
            {
                return RedirectToAction("Index", new {mensaje_error="Venta inexistente"});
            }
            return View();
        }

        [HttpPost]
        [FCliente]
        public IActionResult VerVenta(int Id, int n)
        {
            int idSession = (int)HttpContext.Session.GetInt32("id");
            ViewBag.Publicacion = _sistema.FiltrarPublicacionXId(Id);
            ViewBag.IdSession = idSession;
            decimal saldo = _sistema.FiltrarUsuarioXId(idSession).ObtenerSaldo();
            ViewBag.Saldo = saldo;

            try
            {
                _sistema.FinalizarVenta(idSession, Id, saldo);
                return RedirectToAction("Index", new {mensaje="Compra realizada con exito"});
            } catch (Exception e)
            {
                ViewBag.mensaje_error = e.Message; 
            }
            return View();
        }

        [HttpGet]
        public IActionResult VerSubasta(int id)
        {
            try
            {
                Publicacion subasta = _sistema.FiltrarPublicacionXId(id);
                if (subasta == null)
                {
                    throw new Exception("Subasta no existente");
                }
                ViewBag.Publicacion = subasta;
                ViewBag.Oferta = subasta.OfertaConMasValor();
            } catch (Exception e)
            {
                return RedirectToAction("Index", new {mensaje_error=e.Message});
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

            try
            {
                _sistema.OfertarSubasta(subasta, idSession, monto);
                return RedirectToAction("Index", new {mensaje="Subasta realizada con exito"});
            } catch (Exception e)
            {
                ViewBag.mensaje_error = e.Message;
            }
            return View();
        }

        [HttpPost]
        [FAdmin]
        public IActionResult FinalizarSubasta(int Id)
        {
            int idSession = (int)HttpContext.Session.GetInt32("id");

            try
            {
                _sistema.FinalizarSubasta(idSession, Id);
                return RedirectToAction("Index", new{mensaje="Subasta finalizada con exito"});
            }
            catch (Exception e)
            {
                ViewBag.mensaje_error = e.Message;
            }
            return View("Index");
        }
    }
}