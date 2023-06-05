using System.ComponentModel.DataAnnotations;

namespace PIMVIII_Front_End.Models
{
    public class TelefoneModel
    {
        [Key]
        public int idTelefone {  get; set; }
        public int numero { get;  set; }
        public int ddd { get; set; }

        //FK
        public int tipo { get; set; }
        public TelefoneTipoModel idTelefoneTipo { get; set; }
    }
}
