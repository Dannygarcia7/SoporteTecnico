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
        ServiciosBL _serviciosBL;

        public ServiciosController()
        {
            _serviciosBL = new ServiciosBL();
        }
        // GET: Productos
        public ActionResult Index()
        {
            var listadeServicios= _serviciosBL.ObtenerSevicios();

            return View(listadeServicios);
        }
    }
}