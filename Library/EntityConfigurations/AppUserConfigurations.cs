using Library.Data;
using Library.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.EntityConfigurations
{
    public class AppUserConfigurations : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(p => p.FirstName).IsRequired();
            builder.Property(p => p.LastName).IsRequired();
            builder.Property(p => p.DateOfBirth).IsRequired().HasColumnType("Date");


            builder.HasMany(p => p.Books)
                .WithOne(p => p.Borrower)
                .HasForeignKey(p => p.BorrowerId);
        }

    }
}
