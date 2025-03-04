using Microsoft.EntityFrameworkCore;
using TechLexicon.Infra.Tables;

namespace TechLexicon.Infra
{
    public class TechLexiconContext : DbContext
    {
        public DbSet<Termo> Termos { get; set; }

        public TechLexiconContext(DbContextOptions<TechLexiconContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TechLexiconContext).Assembly);
        }
    }
}
