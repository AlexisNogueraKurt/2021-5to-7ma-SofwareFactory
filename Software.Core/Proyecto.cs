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
        public string Descripcion { get; set; }
        public decimal Presupuesto { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public Proyecto (){List<Requerimiento> requerimientos = new List<Requerimiento>();}
        public Proyecto (string descripcion) => descripcion = Descripcion;
        public Proyecto (DateTime incio) => incio = Inicio;

    }
}
