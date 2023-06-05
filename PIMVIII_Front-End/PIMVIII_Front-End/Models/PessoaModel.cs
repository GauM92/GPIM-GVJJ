using System.ComponentModel.DataAnnotations;

namespace PIMVIII_Front_End.Models
{
    public class PessoaModel
    {
        [Key]
        public int idPessoa { get; set; }
        public string nome { get; set; }
        public int cpf { get; set; }

        // FK
        public int idEndereco { get; set; }

        // Propriedade de navegação
        public EnderecoModel Endereco { get; set; }


    }
}
