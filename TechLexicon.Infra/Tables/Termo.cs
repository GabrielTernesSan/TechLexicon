using TechLexicon.Domain.Enums;

namespace TechLexicon.Infra.Tables
{
    public class Termo
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public string Significado { get; set; } = null!;
        public ECategoria Categoria { get; set; }
        public DateTimeOffset DataPublicacao { get; set; }
        public string[] Referencias { get; set; } = null!;
    }
}
