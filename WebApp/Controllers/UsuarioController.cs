using Dominio;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using WebApp.Filtros;

namespace WebApp.Controllers
{
    [FLogueado]
    [FCliente]
    public class UsuarioController : Controller
    {
        Sistema _sistema = Sistema.Instancia;

        [HttpGet]
        public IActionResult RecargarSaldo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RecargarSaldo(int Recarga)
        {
            int idSession = (int)HttpContext.Session.GetInt32("id");

            try
            {
                _sistema.RecargarSaldoCliente(idSession, Recarga);
                ViewBag.mensaje = "Saldo recargado exitosamente";
            } catch (Exception e)
            {
                ViewBag.mensaje_error = e.Message;
            }
            return View();
        }

        [HttpGet]
        public IActionResult ConsultarSaldo()
        {
            int idSession = (int)HttpContext.Session.GetInt32("id");
            Usuario usuario = _sistema.FiltrarUsuarioXId(idSession);
            decimal saldo = usuario.ObtenerSaldo();
            ViewBag.Saldo = saldo;
            return View();
        }
    }
}