using HealthInsurance.Core.Interfaces.Repositories;
using HealthInsurance.Core.Interfaces.Services;
using HealthInsurance.Core.Models;
using System.Collections.Generic;

namespace HealthInsurance.Core.Services
{
    public class OfficeService : IOfficeService
    {
        private readonly IOfficeRepository _officeRepository;

        public OfficeService(IOfficeRepository officeRepository)
        {
            _officeRepository = officeRepository;
        }

        public IList<Office> GetAll()
        {
            var offices = _officeRepository.GetAll();
            return offices;
        }
    }
}
