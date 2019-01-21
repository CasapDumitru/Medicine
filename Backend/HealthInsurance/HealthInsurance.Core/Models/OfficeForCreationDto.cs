using System.Collections.Generic;

namespace HealthInsurance.Core.Models
{
	public class OfficeForCreationDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public int? OwnerId { get; set; }
		public AddressDto Address { get; set; }

		public ICollection<DepartmentForCreationDto> Departments { get; set; } 
			= new List<DepartmentForCreationDto>();
	}
}
