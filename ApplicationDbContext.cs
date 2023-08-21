using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Atendimento> Atendimentos { get; set; }
    public DbSet<Sala> Salas { get; set; }
}
