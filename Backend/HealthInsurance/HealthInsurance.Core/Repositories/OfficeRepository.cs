using System.Collections.Generic;
using System.Linq;
using HealthInsurance.Core.Data;
using HealthInsurance.Core.Interfaces.Repositories;
using HealthInsurance.Core.Models;

namespace HealthInsurance.Core.Repositories
{
    public class OfficeRepository : IOfficeRepository
    {
        public IList<Office> GetAll()
        {
            using(var context = new HealthInsuranceContext())
            {
                var offices = context.Offices.ToList();
                return offices;
            }
        }
    }
}
