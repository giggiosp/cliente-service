using cliente_service.Domain;
using cliente_service.Model;
using cliente_service.Repository.Interface;
using cliente_service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cliente_service.Service
{
    public class ClienteService : IClienteService
    {
        public readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente Alterar(int id, ClienteModel clienteModel)
        {
            var cliente = new Cliente
            {
                Id = id,
                Nome = clienteModel.Nome,
                Cpf = clienteModel.Cpf,
                DataNascimento = clienteModel.DataNascimento,
                Logradouro = clienteModel.Logradouro,
                Numero = clienteModel.Numero,
                Bairro = clienteModel.Bairro,
                Cidade = clienteModel.Cidade,
                UF = clienteModel.UF,
                Cep = clienteModel.Cep
            };

            return _clienteRepository.Alterar(cliente);
        }

        public Cliente Consultar(int id)
        {
            return _clienteRepository.Consultar(id);
        }

        public Cliente Incluir(ClienteModel clienteModel)
        {
            var cliente = new Cliente
            {
                Nome = clienteModel.Nome,
                Cpf = clienteModel.Cpf,
                DataNascimento = clienteModel.DataNascimento,
                Logradouro = clienteModel.Logradouro,
                Numero = clienteModel.Numero,
                Bairro = clienteModel.Bairro,
                Cidade = clienteModel.Cidade,
                UF = clienteModel.UF,
                Cep = clienteModel.Cep
            };

            return _clienteRepository.Incluir(cliente);
        }
    }
}
