using Microsoft.EntityFrameworkCore;
using Academia.Api.Models;

namespace Academia.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Plano> Planos { get; set; }
        public DbSet<Exercicio> Exercicios { get; set; }
        public DbSet<Treino> Treinos { get; set; }
        public DbSet<TreinoExercicio> TreinosExercicios { get; set; }
    }
}
