using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class CadastroContext : DbContext
    {
        public class PessoaDAO
        {
            private readonly CadastroContext _context;

            public PessoaDAO(CadastroContext context)
            {
                _context = context;
            }

            public CadastroContext(DbContextOptions<CadastroContext> options) : base(options)
            {
            }

            public DbSet<Pessoa> Pessoas { get; set; }
            public DbSet<Endereco> Enderecos { get; set; }
            public DbSet<Telefone> Telefones { get; set; }
            public DbSet<TipoTelefone> TiposTelefone { get; set; }
            public DbSet<Pessoa_Telefone> PessoasTelefones { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Pessoa>()
                    .HasOne(p => p.Endereco)
                    .WithMany(e => e.Pessoas)
                    .HasForeignKey(p => p.endereco);

                modelBuilder.Entity<Pessoa_Telefone>()
                    .HasKey(pt => new { pt.ID_pessoa, pt.id_telefone });

                modelBuilder.Entity<Pessoa_Telefone>()
                            .HasOne(pt => pt.Pessoa)
                            .WithMany(p => p.PessoasTelefones)
                            .HasForeignKey(pt => pt.ID_pessoa);

                modelBuilder.Entity<Pessoa_Telefone>()
                    .HasOne(pt => pt.Telefone)
                    .WithMany(t => t.PessoasTelefones)
                    .HasForeignKey(pt => pt.id_telefone);

                modelBuilder.Entity<Telefone>()
                    .HasOne(t => t.TiposTelefone)
                    .WithMany(tt => tt.Telefones)
                    .HasForeignKey(t => t.tipo);
            }
        }
    }

}
