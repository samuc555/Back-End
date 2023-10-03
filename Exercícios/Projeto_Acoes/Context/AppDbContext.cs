using Microsoft.EntityFrameworkCore; 
using Projeto_Acoes.Models;

namespace Projeto_Acoes.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Acao> Acoes {get; set;}
    }
}