using System.Threading.Tasks;
using HealthInsurance.Core.Data;
using HealthInsurance.Core.Interfaces.Specifications;

namespace HealthInsurance.Core.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private HealthInsuranceContext _context;
        //public IRepository<T> Repository { get; }

        public UnitOfWork(HealthInsuranceContext healthInsuranceContext/*, IRepository<T> repository*/)
        {
            _context = healthInsuranceContext;
            //Repository = repository;
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
