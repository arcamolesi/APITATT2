using Microsoft.EntityFrameworkCore;

namespace APITATT2.Model
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Aluno> ALunos { get; set; }
        public DbSet<Disciplina> Disciplinas  { get; set; }
    }
}
