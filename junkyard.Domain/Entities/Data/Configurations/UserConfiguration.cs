using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using junkyard.Domain.Entities.Models;

namespace junkyard.Domain.Entities.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder) 
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.Id);
            
            builder.Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(32);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(128);

            builder.Property(u => u.PasswordHash)
                 .HasMaxLength(256);

            builder.Property(u => u.PasswordSalt)
                .HasMaxLength(128);

            builder.Property(u => u.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");

            builder.Property(u => u.LastLogin)
                .IsRequired(false);

            builder.HasIndex(u => u.Email)
                .IsUnique();
        }
    }
}
