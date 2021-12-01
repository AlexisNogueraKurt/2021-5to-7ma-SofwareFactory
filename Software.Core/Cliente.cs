using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Core
{
    public class Cliente
    {
        public int Cuit { get; set; }
        public string RazonSocial { get; set; }
        public Cliente(){}

        public Cliente(string razonSocial) => razonSocial = RazonSocial;
        public Cliente(int cuit) => cuit = Cuit;
        


    }
}
