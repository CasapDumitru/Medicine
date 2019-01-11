using System.Collections.Generic;

namespace HealthInsurance.Core.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Office Office { get; set; }
        public int OfficeId { get; set; }
        public MedicineSpeciality MedicineSpeciality { get; set; }
        public int? MedicineSpecialityId { get; set; }
        public IList<DoctorDepartment> DoctorDepartments { get; set; }
    }
}
