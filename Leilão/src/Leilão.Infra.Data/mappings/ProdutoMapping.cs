using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Business.Models;

namespace Data.mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Edital)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Meta)
                .IsRequired()
                .HasColumnType("DECIMAL");

            builder.Property(p => p.Comitentes)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Natureza)
                .IsRequired()
                .HasColumnType("varchar(200)");

            // 1 : N => Categoria : Produtos
            builder.HasMany(f => f.Leiloes)
                .WithOne(p => p.Produto)
                .HasForeignKey(p => p.produtoId);


            builder.ToTable("Produtos");
        }
    }
}
