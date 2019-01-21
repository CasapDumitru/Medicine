using HealthInsurance.Core.Entities;
using System;

namespace HealthInsurance.Core.Models
{
	public class UserDto
	{
		public int Id { get; set; }
		public DateTime BirthDate { get; set; }
		public string Email { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PhoneNumber { get; set; }
		public string UserName { get; set; }
		public UserType UserType { get; set; }
	}
}
