using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Column("Id")]
        [Display(Name = "Código do Fornecedor")]
        public int Id { get; set; }

        [Column("NomeFornecedor")]
        [Display(Name = "Nome do Fornecedor")]
        public string NomeFornecedor { get; set; } = string.Empty;

        [Column("EmailFornecedor")]
        [Display(Name = "Email")]
        public string EmailFornecedor { get; set; } = string.Empty;

        [Column("CnpjFornecedor")]
        [Display(Name = "Cnpj do Fornecedor")]
        public string CnpjFornecedor { get; set; } = string.Empty;
    }
}
