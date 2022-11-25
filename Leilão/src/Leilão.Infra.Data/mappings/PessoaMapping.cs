using Business.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leilão.Domain.Models;

namespace Leilão.Data.mappings
{
    public class PessoaMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Telefone)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.HasOne(f => f.Endereco)
                  .WithOne(e => e.Pessoa);

            builder.HasOne(f => f.Documento)
               .WithOne(e => e.Pessoa);

            builder.HasOne(f => f.Usuario)
               .WithOne(e => e.Pessoa);


            builder.ToTable("Pessoas");
        }
    }
}
