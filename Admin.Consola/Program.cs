using et12.edu.ar.AGBD.Ado;
using Software.Core;
using Software.AdoMysql;
using et12.edu.ar.MenuesConsola;

namespace Admin.Consola
{
    public class Program
    {
        public static IAdo Ado { get; private set; }
        static void Main(string[] args)
        {
            InstanciarAdo();

            var menuAltaCliente = new MenuAltaCliente() { Nombre = "Alta Cliente" };

            var menuListasCliente = new MenuListadorCliente() { Nombre = "Listado de Clientes" };
            
            var menuCliente = new MenuCompuesto() { Nombre = "Cliente"};
            menuCliente.agregarMenu(menuAltaCliente);
            menuCliente.agregarMenu(menuListasCliente);

            var menuPrincipal = new MenuCompuesto() { Nombre = "Menu Cliente" };
            menuPrincipal.agregarMenu(menuCliente);


            menuPrincipal.mostrar();

        }

        static void InstanciarAdo()
        {
            var adoAGBD = FactoryAdoAGBD.GetAdoMySQL("appSettings.json", "root");
            Ado = new AdoSoftware(adoAGBD);
        }
    }
}
