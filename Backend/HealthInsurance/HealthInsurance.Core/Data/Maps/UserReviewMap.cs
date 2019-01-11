using HealthInsurance.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthInsurance.Core.Data.Maps
{
    public static class UserReviewMap
    {
        public static void Map(EntityTypeBuilder<UserReview> builder)
        {
            builder.ToTable("UserReviews");
            builder.HasKey(u => u.Id);

            builder.Property(review => review.Description).HasMaxLength(500).IsRequired();
            builder.Property(review => review.Mark).IsRequired();

            // review has an author and if he is deleted the review also will be deleted
            // !currently is restricted
            builder
                .HasOne(review => review.Author)
                .WithMany(user => user.CreatedUserReviews)
                .HasForeignKey(review => review.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            // review has an recipient and if he is deleted the review also will be deleted
            // !currently is restricted
            builder
                .HasOne(review => review.Recipient)
                .WithMany(user => user.RecievedReviews)
                .HasForeignKey(review => review.RecipientId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
