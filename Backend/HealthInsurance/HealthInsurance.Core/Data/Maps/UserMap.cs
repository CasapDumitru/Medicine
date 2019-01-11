using HealthInsurance.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthInsurance.Core.Data.Maps
{
    public static class UserMap
    {
        public static void Map(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(user => user.Id);

            builder.Property(user => user.UserType).HasDefaultValue(UserType.None).IsRequired();
            builder.Property(user => user.BirthDate).IsRequired();
            builder.Property(user => user.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(user => user.LastName).HasMaxLength(50).IsRequired();
            builder.Property(user => user.PhoneNumber).HasMaxLength(20).IsRequired();
            builder.Property(user => user.Email).HasMaxLength(50).IsRequired();
            builder.Property(user => user.UserName).HasMaxLength(30).IsRequired();
            builder.Property(user => user.Password).HasMaxLength(30).IsRequired();

            // user has an address and he will not be deleted if the address is deleted
            builder
                .HasOne(user => user.Address)
                .WithMany()
                .HasForeignKey(user => user.AddressId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
