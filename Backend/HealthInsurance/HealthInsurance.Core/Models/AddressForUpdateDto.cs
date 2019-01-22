using System.ComponentModel.DataAnnotations;

namespace HealthInsurance.Core.Models
{
	public class AddressForUpdateDto : AddressForManipulationDto
	{
        [Required(ErrorMessage = "You should specify the Id of Address to update")]
		public int Id { get; set; }
	}
}
