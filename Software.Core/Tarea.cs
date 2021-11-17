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
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }

    }
}
