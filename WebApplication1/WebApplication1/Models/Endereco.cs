using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Endereco
    {
        [Key]
        protected int ID_endereco { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public int cep { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }

        // Propriedade de navegação para o relacionamento com a tabela "pessoa"
        public ICollection<Pessoa> Pessoas { get; set; }
    }
}
