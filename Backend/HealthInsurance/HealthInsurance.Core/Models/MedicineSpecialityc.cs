using System.Collections.Generic;

namespace HealthInsurance.Core.Models
{
    public class MedicineSpeciality
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Department> Departments { get; set; }
    }
}
