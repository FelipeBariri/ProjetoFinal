using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalFelipe.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("ClienteId")]
        [Display(Name = "Cliente Id")]
        public int ClienteID { get; set; }

        [Column("ClienteNome")]
        [Display(Name = "Nome Do Cliente")]
        public string ClienteName { get; set; } = string.Empty;

        [Column("ClienteCpf")]
        [Display(Name = "Cpf Do Cliente")]
        public string ClienteCpf { get; set; } = string.Empty;

        [Column("ClienteSexo")]
        [Display(Name = "Sexo Do Cliente")]
        public string ClienteSexo { get; set; } = string.Empty;

        [Column("ClienteTelefone")]
        [Display(Name = "Telefone Do Cliente")]
        public string ClienteTelefone { get; set; } = string.Empty;

        [Column("ClienteEndereco")]
        [Display(Name = "Endereço Do Cliente")]
        public string ClienteEndereco { get; set; } = string.Empty;

        [Column("ClienteNumero")]
        [Display(Name = "Numero Do Cliente")]
        public string ClienteNumero { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; } 

    }
}
