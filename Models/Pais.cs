using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Pais")]
    public class Pais
    {
        [Column("Id")]
        [Display(Name = "Código do País")]
        public int Id { get; set; }

        [Column("PaisNome")]
        [Display(Name = "Nome do País")]
        public string PaisNome { get; set; } = string.Empty;
    }
}
