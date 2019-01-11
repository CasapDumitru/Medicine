using System.Collections.Generic;

namespace HealthInsurance.Core.Models
{
    public class MedicineSpeciality
    {
        public MedicineSpeciality() {
            Departments = new List<Department>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IList<Department> Departments { get; set; }
    }
}
