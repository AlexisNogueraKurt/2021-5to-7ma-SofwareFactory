using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Core
{
    public class Empleado
    {
        public int Cuil { get; set; } 
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Contratacion { get; set; }
        public Empleado () {List<Experiencia> experiencias = new List<Experiencia>();}
        public Empleado(int cuil) =>  cuil = Cuil;
        public Empleado(string nombre) => nombre = Nombre;
        

        

        

        

    }
}
