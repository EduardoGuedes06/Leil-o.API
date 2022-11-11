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
                .HasColumnType("datetime");

           
            builder.ToTable("Documentos");
        }
    }
}
