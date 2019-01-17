using HealthInsurance.Core.Data;
using HealthInsurance.Core.Interfaces.Specifications;
using HealthInsurance.Core.Models;
using HealthInsurance.Core.Specifications;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsurance.Core.Repositories
{
	public class Repository<T> : IRepository<T> where T : BaseIdentity
	{
		private DbSet<T> _dbSet;

		public Repository(HealthInsuranceContext context)
		{
			_dbSet = context.Set<T>();
		}

		public async Task<T> GetById(int id)
		{
			return await _dbSet.FindAsync(id);
		}

		public async Task<T> GetSingleBySpecification(ISpecification<T> spec)
		{
			return await ApplySpecification(spec).FirstOrDefaultAsync();
		}

		public async Task<IReadOnlyList<T>> GetAll()
		{
			return await _dbSet.ToListAsync();
		}

		public async Task<IReadOnlyList<T>> GetBySpecification(ISpecification<T> spec)
		{
			return await ApplySpecification(spec).ToListAsync();
		}

		public async Task<int> Count(ISpecification<T> spec)
		{
			return await ApplySpecification(spec).CountAsync();
		}

		public async Task<T> Add(T entity)
		{
			await _dbSet.AddAsync(entity);
			return entity;
		}

		public void Update(T entity)
		{
			_dbSet.Update(entity);
		}

		public void Delete(T entity)
		{
			_dbSet.Remove(entity);
		}

		private IQueryable<T> ApplySpecification(ISpecification<T> spec)
		{
			return SpecificationEvaluator<T>.GetQuery(_dbSet.AsQueryable(), spec); 
		}
	}
}
