using et12.edu.ar.AGBD.Mapeadores;
using et12.edu.ar.AGBD.Ado;
using System;
using System.Data;
using System.Collections.Generic;
using Software.Core;
using Software.AdoMysql;

namespace Software.AdoMysql.Mapeadores
{
    public class MapCliente : Mapeador<Cliente>
    {
        public MapCliente(AdoAGBD ado) : base(ado)
        {
            Tabla = "Cliente";
        }
        public override Cliente ObjetoDesdeFila(DataRow fila)
        => new Cliente()
        {
            Cuit = Convert.ToInt32(fila["Cuit"]),
            RazonSocial = fila["RazonSocial"].ToString()
        };
        public void AltaCliente(Cliente cliente)
            => EjecutarComandoCon("altaCliente", ConfigurarAltaCliente, cliente);

        public void ConfigurarAltaCliente(Cliente cliente)
        {
            SetComandoSP("altaCliente");

            BP.CrearParametro("unCuit")
                    .SetTipo(MySql.Data.MySqlClient.MySqlDbType.Int32)
                    .SetValor(cliente.Cuit)
                    .AgregarParametro();

            BP.CrearParametro("unaRazonSocial")
                    .SetTipoVarchar(45)
                    .SetValor(cliente.RazonSocial)
                    .AgregarParametro();
        }

        public Cliente ClientePorCuit(int Cuit)
        {
            SetComandoSP("ClientePorCuit");

            BP.CrearParametro("unCuit")
                .SetTipo(MySql.Data.MySqlClient.MySqlDbType.Int32)
                .SetValor(Cuit)
                .AgregarParametro();

            return ElementoDesdeSP();
        }
        public List<Cliente> ObtenerClientes() => ColeccionDesdeTabla();
    }

}
