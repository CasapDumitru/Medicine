using HealthInsurance.Core.Interfaces.Specifications;
using HealthInsurance.Core.Interfaces.Services;
using HealthInsurance.Core.Models;
using HealthInsurance.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HealthInsurance.Core.Services
{
    public class OfficeService : IOfficeService
    {
        //private readonly IOfficeRepository _officeRepository;
        private IUnitOfWork _unitOfWork;
		private IRepository<Office> _officeRepository;

        public OfficeService(IUnitOfWork unitOfWork, IRepository<Office> officeRepository)
        {
			_officeRepository = officeRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Office>> GetAll()
        {
			//var specification = new GenericSpecification<Office>();

			/*specification.Expression = o => o.Name.Contains("Regina");

			specification.AddInclude($"{nameof(Office.Address)}");
			specification.AddInclude($"{nameof(Office.Owner)}");*/

			//var offices = await _officeRepository.GetAllOffices();
			/*var offices = await _unitOfWork.Repository.Get<Office>(specification);
            return offices;*/

			var specification = new Specification<Office>(o => o.Name.Contains("Maria"));

			specification.AddInclude(o => o.Owner);
			specification.AddInclude(o => o.Address);

			var offices = await _officeRepository.GetBySpecification(specification);
			return offices;
        }

        public async Task<Office> GetById(int id)
        {
			var specification = new GenericSpecification<Office>();// = new GenericSpecification<Office>(o => o.Name.Contains("Regina") && o.Description.Contains("dsadas"));



			specification.AddInclude($"{nameof(Office.Address)}");
			specification.AddInclude($"{nameof(Office.Owner)}");

			//var office = await _unitOfWork.Repository.GetById<Office>(specification);
            return null;
        }
    }
}
