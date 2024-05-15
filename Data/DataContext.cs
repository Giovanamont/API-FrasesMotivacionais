using FrasesMAPI.Models;
using Microsoft.EntityFrameworkCore;
// dotnet add package Microsoft.EntityFrameworkCore.SqlServer

namespace FrasesMAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<FM> TB_frasesM { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FM>().ToTable("TB_frasesM");
            modelBuilder.Entity<FM>().HasData(

                new FM() { ID = 1, frase = "Não deixe que a tristeza atrapalhe seus sonhos e objetivos...", autor = "Donald Trump", sentimento = "Tristeza" },
                new FM() { ID = 2, frase = "A vida é maravilhosa se não se tem medo dela.", autor = "Charlie Chaplin", sentimento = "Medo" },
                new FM() { ID = 3, frase = "A sorrir eu pretendo levar a vida..", autor = "Cartola", sentimento = "Felicidade" },
                new FM() { ID = 4, frase = "Não tenha medo do caminho, tenha medo de não caminhar", autor = "augusto Cury", sentimento = "Ansiedade" },
                new FM() { ID = 5, frase = "Saudade é um sentimento que, quando não cabe no coração, escorre pelos olhos.", autor = "Bob Marley", sentimento = "Saudade" },
                new FM() { ID = 6, frase = "A desilusão é a visita da verdade.", autor = "Chico Xavier", sentimento = "Decepção" },
                new FM() { ID = 7, frase = "A raiva é um veneno que bebemos esperando que os outros morram.", autor = "Shakespeare", sentimento = "Raiva" }

            );
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveColumnType("varchar").HaveMaxLength(100);
        }
    }
}