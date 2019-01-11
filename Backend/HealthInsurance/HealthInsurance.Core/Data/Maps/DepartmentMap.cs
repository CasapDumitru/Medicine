using HealthInsurance.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthInsurance.Core.Data.Maps
{
    public static class DepartmentMap
    {
        public static void Map(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");
            builder.HasKey(department => department.Id);

            builder.Property(department => department.Name).HasMaxLength(40).IsRequired();
            builder.Property(department => department.Description).HasMaxLength(500).IsRequired();

            // department belongs to an office, and it will be deleted if office is deleted
            builder
                .HasOne(department => department.Office)
                .WithMany(office => office.Departments)
                .HasForeignKey(department => department.OfficeId)
                .OnDelete(DeleteBehavior.Cascade);

            // if the speciality is deleted the speciality of department is set to null
            builder
                .HasOne(department => department.MedicineSpeciality)
                .WithMany(medicineSpeciality => medicineSpeciality.Departments)
                .HasForeignKey(department => department.MedicineSpecialityId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
