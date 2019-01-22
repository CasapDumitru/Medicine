using System.ComponentModel.DataAnnotations;

namespace HealthInsurance.Core.Models
{
	public class UserForUpdateDto : UserForManipulationDto
	{
        [Required(ErrorMessage = "You should specify the Id of User to update")]
        public int Id { get; set; }
    }
}
