using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("SaidaProduto")]
    public class SaidaProduto
    {
        [Column("Id")]
        [Display(Name = "Código da Saída do Prod.")]
        public int Id { get; set; }

        [ForeignKey("ProdutoId")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        [Column("DataSaida")]
        [Display(Name = "Data da Saída")]
        public DateTime DataSaida { get; set; }

        [Column("QuantidadeSaida")]
        [Display(Name = "Quantidade")]
        public int QuantidadeSaida { get; set; } 

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        [ForeignKey("ClienteId")]
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        [ForeignKey("TipoSaidaId")]
        public int TipoSaidaId { get; set; }
        public TipoSaida? TipoSaida { get; set; }
    }
}
