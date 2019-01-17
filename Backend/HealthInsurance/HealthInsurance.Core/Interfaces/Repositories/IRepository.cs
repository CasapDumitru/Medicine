using HealthInsurance.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthInsurance.Core.Interfaces.Specifications
{
	public interface IRepository<T> where T : BaseIdentity
    {
		Task<T> GetById(int id);
		Task<T> GetSingleBySpecification(ISpecification<T> spec);
		Task<IReadOnlyList<T>> GetAll();
		Task<IReadOnlyList<T>> GetBySpecification(ISpecification<T> spec);
		Task<int> Count(ISpecification<T> spec);
		Task<T> Add(T entity);
		void Update(T entity);
		void Delete(T entity);
	}
}
