using TechLexicon.Domain.Enums;

namespace TechLexicon.Domain.Entidades
{
    public class Termo
    {
        public int Id { get; }
        public string Titulo { get; private set; } = null!;
        public string Significado { get; private set; } = null!;
        public ECategoria Categoria { get; private set; }
        public DateTimeOffset DataPublicacao { get; set; }
        public IEnumerable<string> Referencias { get; private set; } = null!;
    }
}
