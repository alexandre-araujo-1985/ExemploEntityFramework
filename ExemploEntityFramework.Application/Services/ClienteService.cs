using ExemploEntityFramework.Domain.Contracts.Entities;
using ExemploEntityFramework.Domain.Contracts.Services;
using ExemploEntityFramework.Domain.Contracts.Repositories;

namespace ExemploEntityFramework.Application.Services
{
	public class ClienteService : IClienteService
	{
		private readonly IClienteRepository _clienteRepository;

		public ClienteService(IClienteRepository clienteRepository)
		{
			_clienteRepository = clienteRepository;
		}

		public void Alterar(Cliente cliente) => _clienteRepository.Alterar(cliente);

		public void Excluir(int id) => _clienteRepository.Excluir(id);

		public void Incluir(Cliente cliente) => _clienteRepository.Incluir(cliente);

		public IEnumerable<Cliente> ListarTodos() => _clienteRepository.ListarTodos();

		public Cliente Pesquisar(int id) => _clienteRepository.Pesquisar(id);
	}
}
