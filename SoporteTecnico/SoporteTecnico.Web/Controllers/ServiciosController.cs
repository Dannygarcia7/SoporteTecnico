using SoporteTecnico.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoporteTecnico.Web.Controllers
{
    public class ServiciosController : Controller
    {
        // GET: Servicios
        public ActionResult Index()
        {
            var serviciosBL = new ServiciosBL();
            var listadeServicios = serviciosBL.ObtenerServicios();

            return View(listadeServicios);
        }
    }
}