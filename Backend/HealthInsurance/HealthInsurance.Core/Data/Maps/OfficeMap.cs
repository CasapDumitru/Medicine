using HealthInsurance.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthInsurance.Core.Data.Maps
{
    public static class OfficeMap
    {
        public static void Map(EntityTypeBuilder<Office> builder)
        {
            builder.ToTable("Offices");
            builder.HasKey(office => office.Id);

            builder.Property(office => office.Name).HasMaxLength(50);
            builder.Property(office => office.Description).HasMaxLength(500);

            // office has an address and it will not be deleted if the address is deleted
            builder
                .HasOne(office => office.Address)
                .WithMany()
                .HasForeignKey(office => office.AddressId)
                .OnDelete(DeleteBehavior.SetNull);

            // office has an owner and it will not be deleted if the owner is deleted
            builder
                .HasOne(office => office.Owner)
                .WithMany(user => user.Offices)
                .HasForeignKey(office => office.OwnerId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
