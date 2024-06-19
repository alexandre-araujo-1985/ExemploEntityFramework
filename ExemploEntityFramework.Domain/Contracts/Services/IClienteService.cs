using ExemploEntityFramework.Domain.Contracts.Entities;

namespace ExemploEntityFramework.Domain.Contracts.Services
{
	public interface IClienteService
	{
		Cliente Pesquisar(int id);
		void Incluir(Cliente cliente);
		void Alterar(Cliente cliente);
		IEnumerable<Cliente> ListarTodos();
		void Excluir(int id);
	}
}
