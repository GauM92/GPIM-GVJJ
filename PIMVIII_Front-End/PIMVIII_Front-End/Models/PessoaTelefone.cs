using System.ComponentModel.DataAnnotations;

namespace PIMVIII_Front_End.Models
{
    public class PessoaTelefone
    {
        [Key]
        public int idPessoa { get; set; }
        // Propriedade de navegação
        public PessoaModel pessoa { get; set; }

        public int idTelefone { get; set; }

        public TelefoneModel telefone { get; set; }
    }
}
