using HealthInsurance.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthInsurance.Core.Data.Maps
{
    public static class OfficeReviewMap
    {
        public static void Map(EntityTypeBuilder<OfficeReview> builder)
        {
            builder.ToTable("OfficeReviews");
            builder.HasKey(review => review.Id);

            builder.Property(review => review.Description).HasMaxLength(500).IsRequired();
            builder.Property(review => review.Mark).IsRequired();

            // review has an author and if he is deleted the review also will be deleted
            // !currently is restricted
            builder
                .HasOne(review => review.Author)
                .WithMany(user => user.CreatedOfficeReviews)
                .HasForeignKey(review => review.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            // review has an recipient office and if it is deleted the review also will be deleted
            // !currently is restricted
            builder
                .HasOne(review => review.Recipient)
                .WithMany(user => user.Reviews)
                .HasForeignKey(review => review.RecipientId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
