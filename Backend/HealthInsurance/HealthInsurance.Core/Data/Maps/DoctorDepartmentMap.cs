using HealthInsurance.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthInsurance.Core.Data.Maps
{
    public static class DoctorDepartmentMap
    {
        public static void Map(EntityTypeBuilder<DoctorDepartment> builder)
        {
            builder.ToTable("DoctorDepartments");
            builder.HasKey(doctorDepartment =>  new { doctorDepartment.DoctorId, doctorDepartment.DepartmentId });

            // it will be deleted if the doctor is deleted
            builder
                .HasOne(doctorDepartment => doctorDepartment.Doctor)
                .WithMany(doctor => doctor.DoctorDepartments)
                .HasForeignKey(doctorDepartment => doctorDepartment.DoctorId)
                .OnDelete(DeleteBehavior.Cascade);

            // it will be deleted if the office is deleted
            builder
                .HasOne(doctorDepartment => doctorDepartment.Department)
                .WithMany(department => department.DoctorDepartments)
                .HasForeignKey(doctorDepartment => doctorDepartment.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
