using SoporteTecnico.Web.Models;
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
            var servicio1 = new ServicioModel();
            servicio1.ID = 1;
            servicio1.Descripcion = "Mantenimiento Preventivo";

            var servicio2 = new ServicioModel();
            servicio2.ID = 2;
            servicio2.Descripcion = "Reparaciones";

            var servicio3 = new ServicioModel();
            servicio3.ID = 3;
            servicio3.Descripcion = "Instalaciones";

            var servicio4 = new ServicioModel();
            servicio4.ID = 4;
            servicio4.Descripcion = "Diagnosticos";

            var listdeServicios = new List<ServicioModel>();
            listdeServicios.Add(servicio1);
            listdeServicios.Add(servicio2);
            listdeServicios.Add(servicio3);
            listdeServicios.Add(servicio4);


            return View(listdeServicios);
        }
    }
}