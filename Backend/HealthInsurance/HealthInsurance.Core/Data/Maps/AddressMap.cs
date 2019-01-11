using HealthInsurance.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthInsurance.Core.Data.Maps
{
    public static class AddressMap
    {
        public static void Map(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses");
            builder.HasKey(address => address.Id);

            builder.Property(address => address.Country).HasMaxLength(30).IsRequired();
            builder.Property(address => address.City).HasMaxLength(30).IsRequired();
            builder.Property(address => address.Street).HasMaxLength(70).IsRequired();
            builder.Property(address => address.StreetNumber).HasMaxLength(10);
            builder.Property(address => address.PostalCode).HasMaxLength(20);

        }
    }
}
