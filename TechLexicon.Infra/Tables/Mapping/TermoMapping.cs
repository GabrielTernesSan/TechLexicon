using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechLexicon.Domain.Enums;

namespace TechLexicon.Infra.Tables.Mapping
{
    public class TermoMapping : IEntityTypeConfiguration<Termo>
    {
        public void Configure(EntityTypeBuilder<Termo> builder)
        {
            builder.ToTable("Termos");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Titulo).IsRequired();
            builder.Property(x => x.Significado).HasColumnType("TEXT").IsRequired();
            builder.Property(x => x.Categoria).HasComment(string.Join(", ", Enum.GetValues<ECategoria>().Select(e => e.ToString()))).IsRequired();
            builder.Property(x => x.DataPublicacao).IsRequired();

            builder.Property(x => x.Referencias)
                .HasColumnType("TEXT[]")
                .IsRequired();
        }
    }
}
