using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Telefone
    {
        [Key]
        public int id_telefone { get; set; }
        public int numero { get; set; }
        public int ddd { get; set; }

        public int tipo { get; set; }
        [ForeignKey("tipo")]
        public TipoTelefone TipoTelefone { get; set; }

        public ICollection<Pessoa_Telefone> Pessoa_Telefones { get; set; }
    }
}
