using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Filtros
{
    public class FAdmin : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            string email = context.HttpContext.Session.GetString("email");
            string rol = context.HttpContext.Session.GetString("rol");
            if (rol != "Administrador" || email == null)
            {
                context.Result = new RedirectResult("/Login/Index");
            }
        }
    }
}