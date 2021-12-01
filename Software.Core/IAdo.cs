using System.Collections.Generic;

namespace Software.Core
{
    public interface IAdo
    {
        void AltaCliente(Cliente cliente);
        List<Cliente> ObtenerClientes();
        
    }
}
