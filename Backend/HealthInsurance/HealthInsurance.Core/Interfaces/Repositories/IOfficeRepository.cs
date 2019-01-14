using HealthInsurance.Core.Models;
using System.Collections.Generic;

namespace HealthInsurance.Core.Interfaces.Repositories
{
    public interface IOfficeRepository
    {
        IList<Office> GetAll();
    }
}
