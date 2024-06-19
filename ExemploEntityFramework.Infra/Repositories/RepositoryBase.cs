using Microsoft.EntityFrameworkCore;
using ExemploEntityFramework.Infra.Contexts;
using ExemploEntityFramework.Domain.Contracts.Repositories;

namespace ExemploEntityFramework.Infra.Repositories
{
	public class RepositoryBase<T> : IRepositoryBase<T> where T : class
	{
		protected ExemploEntityFrameworkContext _context;

		public RepositoryBase(ExemploEntityFrameworkContext context)
		{
			_context = context;
		}

		public void Alterar(T obj)
		{
			MontarInstancia().Update(obj);
			_context.Entry(obj).State = EntityState.Modified;
			_context.SaveChanges();
		}

		public void Excluir(int id)
		{
			var entity = Pesquisar(id);
			MontarInstancia().Remove(entity);
			_context.SaveChanges();
		}

		public void Incluir(T obj)
		{
			MontarInstancia().Add(obj);
			_context.SaveChanges();
		}

		public IEnumerable<T> ListarTodos()
		{
			return [.. MontarInstancia()];
		}

		public T Pesquisar(int id)
		{
			return MontarInstancia().Find(id)!;
		}

		private DbSet<T> MontarInstancia() => _context.Set<T>();

	}
}
