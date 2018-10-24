using demomvc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demomvc2.Controllers
{
    public class Busqueda2Controller : Controller
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
            var usuario = new UsuarioLista() { Apellido = "aaa" , ID = 2};
            
            // ponet lista en view bag
            ViewBag.Datos = usuario; 

            return View();
        }
    }
}
