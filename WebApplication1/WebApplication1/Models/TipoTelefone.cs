using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class TipoTelefone
    {
        [Key]
        protected int id_tipo_telefone { get; set; }
        public string tipo { get; set; }

        public ICollection<Telefone> Telefones { get; set; }

    }
}
