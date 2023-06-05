using System.ComponentModel.DataAnnotations;

namespace PIMVIII_Front_End.Models
{
    public class EnderecoModel
    {
        [Key]
        public int idEndereco { get; set; }

        public string logradouro { get; set; }
        public int numero { get; set; }
        public int cep { get; set; } 
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set;}

        public List<PessoaModel> Pessoas { get; set; }
    }
}
