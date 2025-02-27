using API_filmes_senai.Domains;
using Microsoft.EntityFrameworkCore;

namespace API_filmes_senai.Context
{
    public class Filmes_Context : DbContext
        

  
    {
        internal object Filmes;

        public Filmes_Context() { }
        public Filmes_Context(DbContextOptions<Filmes_Context>options) : base(options) { }
        /// <summary>
        /// define que as classes se transformaram em tabelas no BD
        /// </summary>
        public DbSet<Generos> Genero { get; set; }
        public DbSet<Filmes> Filme { get; set; }
        public object Generos { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {if(!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer("Server = NOTE23-S28\\SQLEXPRESS; Database = Filmes; User Id = sa; Pwd = Senai@134; TrustServerCertificate=true; ");
           
        }
    }
}
