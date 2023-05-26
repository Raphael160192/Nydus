using Microsoft.EntityFrameworkCore;
using empresa.Models;

namespace empresa.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<HistoricoCargo> HistoricoCargos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=empresa.db");
            // Substitua "nome-do-arquivo.db" pelo nome do arquivo do banco de dados SQLite que você definiu na configuração do ambiente.
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aqui você pode adicionar configurações adicionais, como chaves primárias compostas ou restrições.
            // Por exemplo, se desejar definir uma chave primária composta na tabela HistoricoCargo:
            // modelBuilder.Entity<HistoricoCargo>().HasKey(hc => new { hc.Id, hc.ColaboradorId });
        }
    }
}