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
        public List<Servicio> ListadeServicios { get; set; }

        public ServiciosBL()
        {
            _contexto = new Contexto();
            ListadeServicios = new List<Servicio>();
        }

        public List<Servicio> ObtenerSevicios()
        {
            ListadeServicios = _contexto.Servicios.ToList();
            return ListadeServicios;
        }
    }
}
    