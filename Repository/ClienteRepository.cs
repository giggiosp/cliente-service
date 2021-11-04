using cliente_service.Domain;
using cliente_service.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cliente_service.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DatabaseContext _context;

        public ClienteRepository(DatabaseContext context)
        {
            _context = context;
        }

        public Cliente Alterar(Cliente obj)
        {
            _context.Update(obj);
            _context.SaveChanges();
            return obj;
        }

        public Cliente Consultar(int id)
        {
            return _context.Clientes.Where(x => x.Id == id).FirstOrDefault();
        }

        public Cliente Incluir(Cliente obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
            return obj;
        }
    }
}
