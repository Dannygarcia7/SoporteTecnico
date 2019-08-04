using SoporteTecnico.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoporteTecnico.WebAdmin.Controllers
{
    public class ServiciosController : Controller
    {
        ServiciosBL _serviciosBL;

        public ServiciosController()
        {
            _serviciosBL = new ServiciosBL();
        }

        // GET: Servicios
        public ActionResult Index()
        {
            var listadeServicios = _serviciosBL.ObtenerSevicios();

            return View(listadeServicios);
        }

        public  ActionResult Crear()
        {
            var nuevoServicio = new Servicio();

            return View(nuevoServicio);
        }

        [HttpPost]
        public ActionResult Crear(Servicio servicio)
        {
            return RedirectToAction("Index");
        }
    }
}