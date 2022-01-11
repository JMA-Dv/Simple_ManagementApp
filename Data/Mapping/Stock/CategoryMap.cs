using Common.Stock;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping.Stock
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("category")
                .HasKey(c => c.IdCategory);
            builder.Property(c => c.Name)
              .HasMaxLength(50);
            builder.Property(c => c.Description)
                .HasMaxLength(250);
        }
    }
}
