using System.Collections.Generic;

namespace HealthInsurance.Core.Models
{
	public class OfficeForCreationDto : OfficeForManipulationDto
	{
		public ICollection<DepartmentForCreationDto> Departments { get; set; } 
			= new List<DepartmentForCreationDto>();
	}
}
