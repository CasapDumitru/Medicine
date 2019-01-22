using System.ComponentModel.DataAnnotations;

namespace HealthInsurance.Core.Models
{
	public class OfficeForUpdateDto : OfficeForManipulationDto
	{
        [Required(ErrorMessage = "You should specify the Id of Office to update")]
        public int Id { get; set; }
    }
}
