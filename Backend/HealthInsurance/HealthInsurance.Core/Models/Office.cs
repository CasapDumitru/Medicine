using System.Collections.Generic;

namespace HealthInsurance.Core.Models
{
    public class Office
    {
        public Office()
        {
            Departments = new List<Department>();
            RecievedReviews = new List<OfficeReview>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public User Owner { get; set; }
        public int? OwnerId { get; set; }
        public Address Address { get; set; }
        public int? AddressId { get; set; }

        public IList<Department> Departments { get; set; }
        public IList<OfficeReview> RecievedReviews { get; set; }
    }
}
