using System;
using System.Collections.Generic;
using System.Text;

namespace HealthInsurance.Core.Models
{
	public class OfficeForUpdateDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public int? OwnerId { get; set; }
		public AddressDto Address { get; set; }
	}
}
