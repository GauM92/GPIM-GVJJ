using System.ComponentModel.DataAnnotations;

namespace PIMVIII_Front_End.Models
{
    public class TelefoneTipoModel
    {
        [Key]
        public int idTipoTelefone { get; set; }
        public string tipoTelefone { get;set; }

        public List<TelefoneModel> Telefones { get; set; }
    }
}
