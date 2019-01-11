namespace HealthInsurance.Core.Models
{
    public class DoctorDepartment
    {
        public User Doctor { get; set; }
        public int DoctorId { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
    }
}
