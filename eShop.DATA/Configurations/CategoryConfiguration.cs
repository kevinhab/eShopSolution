using eShop.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.DATA.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(c => c.SeoAlias)
                .HasMaxLength(200);
            builder.Property(c => c.Description)
                .HasMaxLength(1000);
            builder.Property(c => c.DateCreated)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");
            builder.Property(c => c.DisplayOrder)
                .IsRequired()
                .HasDefaultValue(0);
            builder.Property(c => c.Status)
                .IsRequired();
        }
    }
}
