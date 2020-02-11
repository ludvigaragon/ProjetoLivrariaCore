using Microsoft.EntityFrameworkCore;

namespace ProjetoLivrariaCore.Models
{
    public class ProjetoLivrariaCoreContext : DbContext
    {
        public ProjetoLivrariaCoreContext (DbContextOptions<ProjetoLivrariaCoreContext> options)
            : base(options)
        {
        }

        public DbSet<Livro> Livro { get; set; }
    }
}
