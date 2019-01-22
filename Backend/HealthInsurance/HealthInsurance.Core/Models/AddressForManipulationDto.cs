using System.ComponentModel.DataAnnotations;

namespace HealthInsurance.Core.Models
{
    public abstract class AddressForManipulationDto
    {
        [Required(ErrorMessage = "You should fill out a Country")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "The Country name length must be greater that 3 and smaller that 30")]
        public string Country { get; set; }

        [[Required(ErrorMessage = "You should fill out a City")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "The City name length must be greater that 3 and smaller that 30")]
        public string City { get; set; }

        [Required(ErrorMessage = "You should fill out a Street")]
        [StringLength(70, MinimumLength = 3, ErrorMessage = "The Street name length must be greater that 3 and smaller that 70")]
        public string Street { get; set; }

        [Required(ErrorMessage = "You should fill out a Street Number")]
        [MaxLength(10, ErrorMessage = "The Street Number length must be smaller that 10")]
        public string StreetNumber { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "The PostalCode length must be greater that 3 and smaller that 20")]
        public string PostalCode { get; set; }
    }
}
