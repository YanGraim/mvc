using Microsoft.EntityFrameworkCore;
using mvc.Data.Mapeamento;
using mvc.Models;

namespace mvc.Data;

public class BancoContext : DbContext
{
    public BancoContext(DbContextOptions<BancoContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AlunoMapeamento());
    }
    
    public DbSet<Aluno> Aluno { get; set; }
}