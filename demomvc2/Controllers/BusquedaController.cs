using demomvc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demomvc2.Controllers
{
    public class BusquedaController : Controller
    {
        public ActionResult BusquedaUsuario()
        {
            var form = new ParametrosBusqueda();
            form.Apellido = "valor inicial";

            return View(form);
        }

        [HttpPost]
        public ActionResult BusquedaUsuario(ParametrosBusqueda input)
        {

            //poner en viewvag el resultado de la busqueda
            var usuarios = new List<UsuarioLista>();
            usuarios.Add(new UsuarioLista() { Apellido = "aaa" });
            usuarios.Add(new UsuarioLista() { Apellido = "bbb" });

            // ponet lista en view bag
            ViewBag.Datos = usuarios; 

            return View();
        }
    }
}
