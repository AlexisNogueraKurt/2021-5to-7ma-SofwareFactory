using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Core
{
    public class Requerimiento
    {

        public int id { get; set; }
        public Proyecto proyecto { get; set; }
        public Tecnologia tecnologia { get; set; }
        public string descripcion { get; set; }
        public int complejidad { get; set; }


    }
}
