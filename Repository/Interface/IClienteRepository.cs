using cliente_service.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cliente_service.Repository.Interface
{
    public interface IClienteRepository
    {
        public Cliente Incluir(Cliente obj);
        public Cliente Consultar(int id);
        public Cliente Alterar(Cliente obj);
    }
}
