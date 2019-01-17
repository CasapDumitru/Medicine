using HealthInsurance.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthInsurance.Core.Interfaces.Services
{
    public interface IOfficeService
    {
		Task<Office> GetById(int id);
		Task<Office> GetFullById(int id);
		Task<IReadOnlyList<Office>> GetAll();
		Task<IReadOnlyList<Office>> SearchByName(string name);
		Task<Office> Add(Office office);
		Task<Office> Update(Office office);
		Task<Office> Delete(int id);
	}
}
