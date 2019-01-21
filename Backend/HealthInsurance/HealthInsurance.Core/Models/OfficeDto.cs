using System.Collections.Generic;

namespace HealthInsurance.Core.Models
{
	public class OfficeDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public UserDto Owner { get; set; }
		public AddressDto Address { get; set; }

		public ICollection<DepartmentDto> Departments { get; set; }
	}
}
