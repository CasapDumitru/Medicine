using HealthInsurance.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthInsurance.Core.Interfaces.Services
{
    public interface IOfficeService
    {
        Task<IReadOnlyList<Office>> GetAll();
        Task<Office> GetById(int id);
    }
}
