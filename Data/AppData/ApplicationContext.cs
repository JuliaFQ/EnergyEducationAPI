using EnergyEducationAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
public class ApplicationDbContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Turma> Turmas { get; set; }
    public DbSet<ProgressoEstudante> ProgressoEstudantes { get; set; }
    public DbSet<Avaliacao> Avaliacoes { get; set; }
    public DbSet<Modulo> Modulos { get; set; }
    public DbSet<Conteudo> Conteudos { get; set; }
    public DbSet<Atividade> Atividades { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Relacionamento Muitos-para-Muitos entre Usuário e Turma
        modelBuilder.Entity<Usuario>()
            .HasMany(u => u.Turmas)
            .WithMany(t => t.Usuarios)
            .UsingEntity(j => j.ToTable("UsuarioTurmas"));

        // Relacionamento Um-para-Muitos entre Conteúdo e Atividade
        modelBuilder.Entity<Conteudo>()
            .HasMany(c => c.Atividades)
            .WithOne(a => a.Conteudo)
            .HasForeignKey(a => a.ConteudoId);
    }
}
