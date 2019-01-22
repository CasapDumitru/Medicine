using System.ComponentModel.DataAnnotations;

namespace HealthInsurance.Core.Models
{
	public class DepartmentForUpdateDto : DepartmentForManipulationDto
	{
        [Required(ErrorMessage = "You should specify the Id of Department to update")]
        public int Id { get; set; }
    }
}
