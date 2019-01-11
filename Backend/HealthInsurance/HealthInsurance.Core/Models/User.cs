using System;
using System.Collections.Generic;

namespace HealthInsurance.Core.Models
{
    public enum  UserType
    {
        None = 0,
        Admin = 1,
        Doctor = 2
    }

    public class User
    {
        public User()
        {
            Offices = new List<Office>();
        }

        public int Id { get; set; }
        public UserType UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Address Address { get; set; }
        public int? AddressId { get; set; }
        public IList<Office> Offices { get; set; }
        public IList<Experience> Experiences { get; set; }
        public IList<UserReview> CreatedUserReviews { get; set; }
        public IList<OfficeReview> CreatedOfficeReviews { get; set; }
        public IList<UserReview> RecievedReviews { get; set; }
        public IList<DoctorDepartment> DoctorDepartments { get; set; }
    }
}
