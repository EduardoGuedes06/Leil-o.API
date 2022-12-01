using Leilão.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leilão.Data.mappings
{
    public class LanceMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(c => c.cpf)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Senha)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.HasMany(f => f.lances)
               .WithOne(p => p.Usuario)
               .HasForeignKey(p => p.UsuarioId);

            builder.HasOne(f => f.Pessoa)
           .WithOne(e => e.Usuario);



            builder.ToTable("Lances");
        }
    }
}
