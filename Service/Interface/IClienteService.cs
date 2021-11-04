using cliente_service.Domain;
using cliente_service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cliente_service.Service.Interface
{
    public interface IClienteService
    {
        Cliente Incluir(ClienteModel clienteModel);
        Cliente Consultar(int id);
        Cliente Alterar(int id, ClienteModel clienteModel);
    }
}
