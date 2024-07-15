using Core.Entities;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
	public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
	{

		public void Configure(EntityTypeBuilder<Assignment> builder)
		{
			builder.ToTable("Assignments").HasKey(op => op.Id);

			builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
			builder.Property(a => a.Title).HasColumnName("Title").IsRequired();
			builder.Property(a => a.Description).HasColumnName("Description").IsRequired();
			builder.Property(a => a.ImagePath).HasColumnName("ImagePath").IsRequired();


			builder.HasMany(a => a.Comments)
			  .WithOne(c => c.Assignment)
			  .HasForeignKey(c => c.AssignmentId);

			builder.HasQueryFilter(op => !op.DeletedDate.HasValue);
		}
	}
}
