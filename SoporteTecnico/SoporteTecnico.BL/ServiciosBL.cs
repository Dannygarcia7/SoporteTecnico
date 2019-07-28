using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoporteTecnico.BL
{
    public class ServiciosBL
    {
        Contexto _contexto;

        public ServiciosBL()
        {
            _contexto = new Contexto();
        }
       public  List<Servicio> ObtenerServicios()
        {
          //  _contexto.Servicios.ToList();

            var servicio1 = new Servicio();
            servicio1.Id = 1;
            servicio1.Descripcion = "Mantenimiento Preventivo";

            var servicio2 = new Servicio();
            servicio2.Id = 2;
            servicio2.Descripcion = "Reparaciones";

            var servicio3 = new Servicio();
            servicio3.Id = 3;
            servicio3.Descripcion = "Instalaciones";

            var servicio4 = new Servicio();
            servicio4.Id = 4;
            servicio4.Descripcion = "Diagnosticos";

            var listdeServicios = new List<Servicio>();
            listdeServicios.Add(servicio1);
            listdeServicios.Add(servicio2);
            listdeServicios.Add(servicio3);
            listdeServicios.Add(servicio4);

            return listdeServicios;
        }
    }
}
