using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Core
{
    public class Tarea
    {
        public Requerimiento requerimiento { get; set; }
        public Empleado empleado { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public Tarea(){}
        public Tarea(DateTime inicio, DateTime fin) => inicio = Inicio;

    }
}
