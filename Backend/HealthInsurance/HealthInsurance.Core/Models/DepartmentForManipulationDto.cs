

using System.ComponentModel.DataAnnotations;

namespace HealthInsurance.Core.Models
{
    public abstract class DepartmentForManipulationDto
    {
        [Required(ErrorMessage = "You should fill out a Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The Name length must be greater that 3 and smaller that 50")]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
