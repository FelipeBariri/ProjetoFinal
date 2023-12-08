using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalFelipe.Models
{
    [Table("Procedimento")]
    public class Procedimento
    {
        [Column("ProcedimentoId")]
        [Display(Name = "Id Do Procedimento")]

        public int Id { get; set; }


        [Column("ProcedimentoNome")]
        [Display(Name = "Nome Do Procedimento")]

        public string Name { get; set; } = string.Empty;

        [Column("ProcedimentoObservacao")]
        [Display(Name = "Observação Do Procedimento")]

        public string Observacao { get; set; } = string.Empty;


        [ForeignKey("TipoProcedimentoId")]
        public int TipoProcedimentoId { get; set; }
        public TipoProcedimento? TipoProcedimento { get; set; }
    }
}
