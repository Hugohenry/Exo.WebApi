using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {
        }
        public ExoContext(DbContextOptions<ExoContext> options) :
        base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder
        optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Essa string de conexão depende da SUA máquina.
                optionsBuilder.UseSqlServer("Server=QUEIXADA876414\\SQLEXPRESS;Database=ExoApi;User Id=sa;Password=123456;Encrypt=False; Trusted_Connection=True;");
                // Exemplo 1 de string de conexão:
                // User

            }
        }
        public DbSet<Projeto> Projetos { get; set; }
    }
}
