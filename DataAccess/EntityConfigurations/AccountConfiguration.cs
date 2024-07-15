using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.ToTable("Accounts").HasKey(a => a.Id);

        builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
        builder.Property(a => a.UserId).HasColumnName("UserId").IsRequired();

        builder.HasIndex(indexExpression: a => a.Id, name: "UK_Id").IsUnique();
        builder.HasIndex(indexExpression: a => a.UserId, name: "UK_UserId").IsUnique();


        builder.HasOne(a => a.User);  

        builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
    }
}