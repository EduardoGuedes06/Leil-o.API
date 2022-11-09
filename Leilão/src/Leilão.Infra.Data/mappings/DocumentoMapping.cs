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
    public class DocumentoMapping : IEntityTypeConfiguration<Documento>
    {
        public void Configure(EntityTypeBuilder<Documento> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.TipoDocumento)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Anexo)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.DataEnvio)
                .IsRequired()
                .HasColumnType("datetime");

            // 1 : N => Fornecedor : Produtos
            builder.HasMany(f => f.)
                .WithOne(p => p.Categoria)
                .HasForeignKey(p => p.CategoriaId);

            builder.ToTable("Categoria");
        }
    }
}
