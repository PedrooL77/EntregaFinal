using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("TipoProduto")]
    public class TipoProduto
    {
        [Column("Id")]
        [Display(Name = "Código do Tipo do Prod.")]
        public int Id { get; set; }

        [Column("TipoProdutoDescricao")]
        [Display(Name = "Descrição")]
        public string TipoProdutoDescricao { get; set; } = string.Empty;
    }
}
