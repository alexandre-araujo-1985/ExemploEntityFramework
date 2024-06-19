using ExemploEntityFramework.Domain.Contracts.Entities;
using ExemploEntityFramework.Domain.Contracts.Repositories;
using ExemploEntityFramework.Infra.Contexts;

namespace ExemploEntityFramework.Infra.Repositories
{
	public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
	{
		public ClienteRepository(ExemploEntityFrameworkContext context) : base(context)
		{
		}
	}
}
