using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("TipoSaida")]
    public class TipoSaida
    {
        [Column("Id")]
        [Display(Name = "Código da Saída")]
        public int Id { get; set; }

        [Column("TipoSaidaDescricao")]
        [Display(Name = "Descrição")]
        public string TipoSaidaDescricao { get; set; } = string.Empty;
    }
}
