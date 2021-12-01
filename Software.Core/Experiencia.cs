using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Core
{
    public class Experiencia
    {
        public Empleado empleado { get; set; }
        public Tecnologia tecnologia { get; set; }
        public int Calificacion { get; set; }
        public Experiencia (){}
        public Experiencia(int calificacion ) => calificacion = Calificacion;
    }
}
