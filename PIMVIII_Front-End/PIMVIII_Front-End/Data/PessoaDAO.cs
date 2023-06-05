using Microsoft.EntityFrameworkCore;
using PIMVIII_Front_End.Models;

namespace PIMVIII_Front_End.Data
{
    public class PessoaDAO : DbContext
    {
        public PessoaDAO(DbContextOptions<PessoaDAO> options) :base(options)
        {

        }
        public DbSet<EnderecoModel> Enderecos { get; set;}
        public DbSet<PessoaModel> pessoa { get; set;}
        public DbSet<TelefoneModel> telefone { get; set;}
        public DbSet<TelefoneTipoModel> telefoneTipo { get; set;}
    }
}
