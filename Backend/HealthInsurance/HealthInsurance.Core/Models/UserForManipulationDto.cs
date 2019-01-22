using HealthInsurance.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace HealthInsurance.Core.Models
{
    public abstract class UserForManipulationDto
    {
        public DateTime BirthDate { get; set; }


        [Required(ErrorMessage = "The Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Firstname is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lastname is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "UserType is required")]
        public UserType UserType { get; set; }

        [Required(ErrorMessage = "The Address is required")]
        public AddressForCreationDto Address { get; set; }
    }
}
