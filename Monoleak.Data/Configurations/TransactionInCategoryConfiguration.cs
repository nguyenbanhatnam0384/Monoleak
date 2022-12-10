using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monoleak.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoleak.Data.Configurations
{
    public class TransactionInCategoryConfiguration : IEntityTypeConfiguration<TransactionInCategory>
    {
        public void Configure(EntityTypeBuilder<TransactionInCategory> builder)
        {
            builder.ToTable("TransactionInCategories");
            builder.HasKey(t => new { t.TransactionId, t.CategoryId });
            builder.HasOne(t => t.Transaction).WithMany(tc => tc.TransactionInCategories)
                .HasForeignKey(tc => tc.TransactionId);
            builder.HasOne(c => c.Category).WithMany(tc => tc.TransactionInCategories)
                .HasForeignKey(tc => tc.CategoryId);
        }
    }
}
