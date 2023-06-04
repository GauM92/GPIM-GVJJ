using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Pessoa
    {
        [Key]
        protected int ID_pessoa { get; set; }
        [Required]
        public string nome { get; set; }
        [Required]
        public long CPF { get; set; }

        public int endereco { get; set; }
        [ForeignKey("endereco")]
        public Endereco Endereco { get; set; }

        public ICollection<PessoaTelefone> PessoaTelefones { get; set; }

    }
}