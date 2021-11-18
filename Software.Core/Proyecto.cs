using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Core
{
    public class Proyecto
    {
        public int id { get; set; }
        public Empleado empleado { get; set; }
        public string descripcion { get; set; }
        public decimal presupuesto { get; set; }
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
        public Proyecto ()
        {
            List<Requerimiento> requerimientos = new List<Requerimiento>();
        }

    }
}
