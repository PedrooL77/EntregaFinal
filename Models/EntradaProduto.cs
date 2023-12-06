using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("EntradaProduto")]
    public class EntradaProduto
    {
        [Column("Id")]
        [Display(Name = "Código da Entrada do Prod.")]
        public int Id { get; set; }

        [ForeignKey("ProdutoId")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        [Column("DataEntrada")]
        [Display(Name = "Data da Entrega")]
        public DateTime DataEntrada { get; set; }

        [Column("QuantidadeEntrada")]
        [Display(Name = "Quantidade")]
        public int QuantidadeEntrada { get; set; } 
    }
}
