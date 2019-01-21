﻿using HealthInsurance.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthInsurance.Core.Data.Maps
{
    public static class OfficeReviewMap
    {
        public static void Map(EntityTypeBuilder<OfficeReview> builder)
        {
            // Table
            builder.ToTable("OfficeReviews");

            // Keys
            builder.HasKey(review => new { review.AuthorId, review.RecipientId });

            // Properties
            builder.Property(review => review.Description).HasMaxLength(500).IsRequired();
            builder.Property(review => review.Mark).IsRequired();

            // One-To-Many Relationship between User(Author) and CreatedOfficeReviews
            builder
                .HasOne(review => review.Author)
                .WithMany(user => user.CreatedOfficeReviews)
                .HasForeignKey(review => review.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            // One-To-Many Relationship between Office(Recipient) and RecievedReviews
            builder
                .HasOne(review => review.Recipient)
                .WithMany(user => user.RecievedReviews)
                .HasForeignKey(review => review.RecipientId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
