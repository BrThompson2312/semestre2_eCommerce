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
            Cliente cliente = _sistema.FiltrarClienteXId(idSession);
            if (cliente == null)
            {
                throw new Exception("Error");
            }

            decimal saldo = cliente.Saldo;
            ViewBag.Saldo = saldo;
            return View();
        }
    }
}