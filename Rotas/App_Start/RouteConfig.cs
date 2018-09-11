using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Rotas
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Todas as Noticias",
                url: "Noticias/",
                defaults: new { Controller = "Home", action = "TodasAsNoticias" }
                );

            routes.MapRoute(
                name: "Categorias",
                url: "Noticias/{categoria}/",
                defaults: new { Controller = "Home", action = "MostrarCategoria" }
                );

            routes.MapRoute(
                name: "Titulo Noticia",
                url: "Noticias/{categoria}/{titulo}-{noticiaId}",
                defaults: new { Controller = "Home", action = "MostrarNoticia" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
