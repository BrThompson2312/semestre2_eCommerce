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
            ViewBag.CantVentas = _sistema.CantidadVentas();
            ViewBag.CantSubastas = _sistema.CantidadSubastas();
            ViewBag.CantidadTotal = _sistema.CantidadVentas() + _sistema.CantidadSubastas();

            ViewBag.Titulo = "Publicaciones";
            if (HttpContext.Session.GetString("rol") == "Administrador")
            {
                ViewBag.Titulo = "Subastas";
            }
            return View();
        }

        [HttpGet]
        [FCliente]
        public IActionResult ListadoVentas(string mensaje)
        {
            ViewBag.mensaje = mensaje;
            ViewBag.Titulo = "Ventas";

            ViewBag.Publicaciones = _sistema.ListadoVentas();
            ViewBag.CantVentas = _sistema.CantidadVentas();
            ViewBag.CantSubastas = _sistema.CantidadSubastas();
            ViewBag.CantidadTotal = _sistema.CantidadVentas() + _sistema.CantidadSubastas();
            
            return View("Index");
        }

        [HttpGet]
        public IActionResult ListadoSubastas(string mensaje)
        {
            ViewBag.mensaje = mensaje;
            ViewBag.Titulo = "Subastas";

            ViewBag.Publicaciones = _sistema.ListadoSubastas();
            ViewBag.CantVentas = _sistema.CantidadVentas();
            ViewBag.CantSubastas = _sistema.CantidadSubastas();
            ViewBag.CantidadTotal = _sistema.CantidadVentas() + _sistema.CantidadSubastas();

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
            try
            {
                Venta venta = _sistema.FiltrarVentaXId(id);
                if (venta == null)
                {
                    throw new Exception("Venta inexistente");
                }

                Cliente cliente = _sistema.FiltrarClienteXId(idSession);
                if (cliente == null)
                {
                    throw new Exception("Error");
                }

                ViewBag.Venta = venta;
                ViewBag.IdSession = idSession;
                decimal saldo = cliente.Saldo;
                ViewBag.Saldo = saldo;

            } catch (Exception e)
            {
                ViewBag.mensaje_error = e.Message;
            }
            return View();
        }

        [HttpPost]
        [FCliente]
        public IActionResult VerVenta(int Id, int n)
        {
            int idSession = (int)HttpContext.Session.GetInt32("id");
            try
            {
                Cliente cliente = _sistema.FiltrarClienteXId(idSession);
                Venta venta = _sistema.FiltrarVentaXId(Id);

                ViewBag.Venta = venta;
                ViewBag.IdSession = idSession;
                decimal saldo = cliente.Saldo;
                ViewBag.Saldo = saldo;

                _sistema.FinalizarVenta(cliente, venta, saldo);
                return RedirectToAction("Index", new {mensaje="Compra realizada con exito"});
            } catch (Exception e)
            {
                ViewBag.mensaje_error = e.Message;
            }
            return View();
        }

        [HttpGet]
        public IActionResult VerSubasta(int Id)
        {
            try
            {
                Subasta subasta = _sistema.FiltrarSubastaXId(Id);
                if (subasta == null)
                {
                    throw new Exception("Subasta inexistente");
                }

                ViewBag.Subasta = subasta;
                ViewBag.Oferta = subasta.OfertaConMasValor();
                ViewBag.Vendido = subasta.OfertaFinal;

            } catch (Exception e)
            {
                return RedirectToAction("Index", new {mensaje_error=e.Message});
            }   
            return View();
        }

        [HttpPost]
        public IActionResult VerSubasta(int Id, int monto)
        {
            int idSession = (int)HttpContext.Session.GetInt32("id");
            try
            {
                Subasta subasta = _sistema.FiltrarSubastaXId(Id);

                ViewBag.Subasta = subasta;
                ViewBag.Oferta = subasta.OfertaConMasValor();
                ViewBag.Vendido = subasta.OfertaFinal;

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