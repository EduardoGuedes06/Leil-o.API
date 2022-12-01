using Leilão.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Models;

namespace Leilão.Data.mappings
{
    public class LeilaoMapping : IEntityTypeConfiguration<Leilao>
    {
        public void Configure(EntityTypeBuilder<Leilao> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(c => c.lanceMin)
                .IsRequired()
                .HasColumnType("INT");

            builder.ToTable("Lances");
        }
    }
}
