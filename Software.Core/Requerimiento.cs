using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Core
{
    public class Requerimiento
    {

        public int Id { get; set; }
        public Proyecto proyecto { get; set; }
        public Tecnologia tecnologia { get; set; }
        public string Descripcion { get; set; }
        public int Complejidad { get; set; }
        public Requerimiento(){}
        public Requerimiento (string descripcion) => descripcion = Descripcion;
        public Requerimiento (int complejidad) => complejidad = Complejidad;



    }
}
