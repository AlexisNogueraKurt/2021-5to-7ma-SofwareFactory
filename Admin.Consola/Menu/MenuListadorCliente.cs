using et12.edu.ar.MenuesConsola;
using Software.AdoMysql;
using Software.Core;
using System;
using System.Collections.Generic;

namespace Admin.Consola
{
    public class MenuListadorCliente : MenuListador<Cliente>
    {
        public override void imprimirElemento(Cliente c)
            => Console.WriteLine($"RazonSocial: {c.RazonSocial}, Cuit: {c.Cuit}");

        public override List<Cliente> obtenerLista() => Program.Ado.ObtenerClientes();
    }
}