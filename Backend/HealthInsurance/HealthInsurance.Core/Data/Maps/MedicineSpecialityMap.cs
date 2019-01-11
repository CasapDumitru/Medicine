using HealthInsurance.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthInsurance.Core.Data.Maps
{
    public static class MedicineSpecialityMap
    {
        public static void Map(EntityTypeBuilder<MedicineSpeciality> builder)
        {
            builder.ToTable("MedicineSpeciality");
            builder.HasKey(speciality => speciality.Id);

            builder.Property(speciality => speciality.Name).HasMaxLength(50).IsRequired();
            builder.Property(speciality => speciality.Description).HasMaxLength(1000).IsRequired();
        }
    }
}
