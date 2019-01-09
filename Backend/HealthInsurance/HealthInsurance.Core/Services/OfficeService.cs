using HealthInsurance.Core.Models;
using System.Collections.Generic;

namespace HealthInsurance.Core.Services
{
    public class OfficeService
    {
        public IList<Office> GetAll()
        {
            var offices = new List<Office>
            {
                new Office { Id = 1, Name = "Office1" },
                new Office { Id = 2, Name = "Office2" },
                new Office { Id = 3, Name = "Office3" },
                new Office { Id = 4, Name = "Office4" },
                new Office { Id = 5, Name = "Office5" },
            };

            return offices;
        }
    }
}
