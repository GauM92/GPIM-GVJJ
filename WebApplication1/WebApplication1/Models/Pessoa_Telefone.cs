using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Pessoa_Telefone
    {
        [Key, Column(Order = 0)]
        public int ID_pessoa { get; set; }
        [ForeignKey("ID_pessoa")]
        public Pessoa Pessoa { get; set; }



        [Key, Column(Order = 1)]
        public int id_telefone { get; set; }
        [ForeignKey("id_telefone")]
        public Telefone Telefone { get; set; }
    }
}
