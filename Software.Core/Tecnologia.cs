using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Core
{
    public class Tecnologia
    {
        public int id { get; set; }
        public string tecnologia { get; set; }
        public decimal CostoBase { get; set; }
        public Tecnologia(){}
        public Tecnologia(decimal costoBase) => costoBase = CostoBase;
    }
}
