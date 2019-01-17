using HealthInsurance.Core.Interfaces.Services;
using HealthInsurance.Core.Interfaces.Specifications;
using HealthInsurance.Core.Models;
using HealthInsurance.Core.Specifications;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthInsurance.Core.Services
{
	public class OfficeService : IOfficeService
    {
        private IUnitOfWork _unitOfWork;
		private IRepository _repository;

        public OfficeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
			_repository = unitOfWork.Repository;
        }

		public async Task<IReadOnlyList<Office>> GetAll()
		{
			return await _repository.GetAll<Office>();
		}

		public async Task<Office> GetById(int id)
		{
			return await _repository.GetById<Office>(id);
		}

		public async Task<Office> GetFullById(int id)
		{
			var specification = new FullOfficeByIdSpecification(id);
			return await _repository.GetSingleBySpecification(specification);
		}

		public async Task<IReadOnlyList<Office>> SearchByName(string name)
		{
			var specification = new OfficeByNameSpecification(name);
			return await _repository.GetBySpecification(specification);
		}

		public async Task<Office> Add(Office office)
		{
			var addedOffice = await _repository.Add(office);
			await _unitOfWork.SaveChanges();
			return addedOffice;
		}

		public async Task<Office> Update(Office office)
		{
			_repository.Update(office);
			await _unitOfWork.SaveChanges();
			return office;
		}

		public async Task<Office> Delete(int id)
		{
			var office = GetById(id);

			if(office != null)
				_repository.Delete(office.Result);

			await _unitOfWork.SaveChanges();
			return office.Result;
		}	
	}
}
