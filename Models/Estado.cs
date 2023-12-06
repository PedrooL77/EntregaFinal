using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Estado")]
    public class Estado
    {
        [Column("Id")]
        [Display(Name = "Código do Estado")]
        public int Id { get; set; }

        [Column("EstadoNome")]
        [Display(Name = "Nome do Estado")]
        public string EstadoNome { get; set; } = string.Empty;

        [ForeignKey("PaisId")]
        public int PaisId { get; set; }
        public Pais? Pais { get; set; }
    }
}
