using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Código do Cliente")]
        public int Id { get; set; }

        [Column("NomeCliente")]
        [Display(Name = "Nome do Cliente")]
        public string NomeCliente { get; set; } = string.Empty;

        [Column("DataNascimento")]
        [Display(Name = "Data da Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Column("CpfCliente")]
        [Display(Name = "Cpf do Cliente")]
        public string CpfCliente { get; set; } = string.Empty;

        [Column("EnderecoCliente")]
        [Display(Name = "Endereço do Cliente")]
        public string EnderecoCliente { get; set; } = string.Empty;

        [Column("NumeroCasaCliente")]
        [Display(Name = "Número da Casa do Cliente")]
        public string NumeroCasaCliente { get; set; } = string.Empty;

        [Column("BairroCliente")]
        [Display(Name = "Bairro do Cliente")]
        public string BairroCliente { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }

        [Column("TelefoneCliente")]
        [Display(Name = "Telefone do Cliente")]
        public string TelefoneCliente { get; set; } = string.Empty;
    }
}
