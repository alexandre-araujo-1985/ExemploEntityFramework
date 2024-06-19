using Microsoft.EntityFrameworkCore;
using ExemploEntityFramework.Infra.Configurations;
using ExemploEntityFramework.Domain.Contracts.Entities;

namespace ExemploEntityFramework.Infra.Contexts
{
	public class ExemploEntityFrameworkContext : DbContext
	{
		public DbSet<Cliente> Clientes { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new ClienteConfiguration());
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source =.\sqlexpress; Initial Catalog=exemplo_entity_framawork_tsql; Integrated Security = True; Encrypt=False");
		}
	}
}
