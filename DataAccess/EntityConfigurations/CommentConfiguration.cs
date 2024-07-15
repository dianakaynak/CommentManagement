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
	public class CommentConfiguration : IEntityTypeConfiguration<Comment>
	{
		public void Configure(EntityTypeBuilder<Comment> builder)
		{
			builder.ToTable("Comments").HasKey(op => op.Id);

			builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
			builder.Property(a => a.AccountId).HasColumnName("AccountId").IsRequired();
			builder.Property(a => a.AssignmentId).HasColumnName("AssignmentId").IsRequired();
			builder.Property(a => a.Content).HasColumnName("Content").IsRequired();
			builder.Property(a => a.CommentDate).HasColumnName("CommentDate").IsRequired();
			

			builder.HasOne(c => c.Assignment)
							   .WithMany(a => a.Comments)
							   .HasForeignKey(c => c.AssignmentId);


			builder.HasOne(c => c.Account)
				   .WithMany(a => a.Comments)
				   .HasForeignKey(c => c.AccountId);

			builder.HasQueryFilter(op => !op.DeletedDate.HasValue);
		}
	}
}
