using et12.edu.ar.MenuesConsola;
using Software;
using Software.Core;
using Admin.Consola;
using System;


namespace Admin.Consola
{
    public class MenuAltaCliente : MenuComponente 
    {
        public Cliente cliente {get; set;}
        public override void mostrar()
        {
            base.mostrar();

            var cuit = Convert.ToInt32(prompt("Ingrese Cuit"));
            var razonSocial = prompt("Ingrese RazonSocial");

            cliente = new Cliente() 
            {
                Cuit = cuit,
                RazonSocial = razonSocial

            };
            try
            {
                Program.Ado.AltaCliente(cliente);
                Console.WriteLine("Cliente dado de alta con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo dar de alta: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}


        