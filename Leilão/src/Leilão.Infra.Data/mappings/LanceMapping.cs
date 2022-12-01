using Leilão.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leilão.Data.mappings
{
    public class dLanceMapping : IEntityTypeConfiguration<Lance>
    {
        public void Configure(EntityTypeBuilder<Lance> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(c => c.Valor)
                .IsRequired()
                .HasColumnType("INT");

            builder.ToTable("Lances");
        }
    }
}
