using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Código do Produto")]
        public int Id { get; set; }

        [Column("NomeProduto")]
        [Display(Name = "Nome do Produto")]
        public string NomeProduto { get; set; } = string.Empty;

        [Column("QuantidadeEstoque")]
        [Display(Name = "Quantidade")]
        public int QuantidadeEstoque { get; set; } 

        [ForeignKey("TipoProdutoId")]
        public int TipoProdutoId { get; set; }
        public TipoProduto? TipoProduto { get; set; }

        [ForeignKey("FornecedorId")]
        public int FornecedorId { get; set; }
        public Fornecedor? Fornecedor { get; set; }
    }
}
