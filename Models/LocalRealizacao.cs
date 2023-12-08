using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalFelipe.Models
{
    [Table("LocalRealizacao")]
    public class LocalRealizacao
    {
        [Column("LocalRealizacaoId")]
        [Display(Name = "Cód Do Local De Realizacao")]
        public int LocalRealizacaoId { get; set; }

        [Column("LocalNome")]
        [Display(Name = "Nome Do Local")]
        public string LocalNome { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }
    }
}
