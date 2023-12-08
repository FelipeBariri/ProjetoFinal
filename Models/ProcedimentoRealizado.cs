using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalFelipe.Models
{
    [Table("ProcedimentoRealizado")]
    public class ProcedimentoRealizado
    {
        [Column("ProcedimentoRealizadoId")]
        [Display(Name = "Procedimento Id")]
        public int ProcedimentoRealizadoId { get; set; }

        [ForeignKey("ClienteId")]
        public int? ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        [ForeignKey("ProcedimentoId")]
        public int? ProcedimentoId { get; set; }
        public Procedimento? Procedimento { get; set; }

        [ForeignKey("ColaboradorId")]
        public int? ColaboradorId { get; set; }
        public Colaborador? Colaborador { get; set; }

        [ForeignKey("LocalRealizacaoId")]
        public int? LocalRealizacaoId { get; set; }
        public LocalRealizacao? LocalRealizacao { get; set; }

        [Column("DataRealizacao")]
        [Display(Name = "Data Realização")]
        public DateTime DataRealizacao { get; set; }
    }
}
