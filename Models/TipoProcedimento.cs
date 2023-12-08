using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalFelipe.Models
{
    [Table("TipoProcedimento")]
    public class TipoProcedimento
    {
        [Column("TipoProcedimentoId")]
        [Display(Name = "Id Do Tipo De Procedimento")]

        public int TipoProcedimentoId { get; set; }

        [Column("TipoProcedimentoNome")]
        [Display(Name = "Nome Do Tipo De Procedimento")]

        public string Nome { get; set; } = string.Empty;
    }
}
