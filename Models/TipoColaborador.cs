using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalFelipe.Models
{
    [Table("TipoColaborador")]
    public class TipoColaborador
    {
        [Column("TipoColaboradorId")]
        [Display(Name = "Tipo Colaborador Id")]
        public int TipoColaboradorId { get; set; }

        [Column("NomeTipoColaborador")]
        [Display(Name = "Nome Do Tipo De Colaborador")]
        public string TipoColaboradorName { get; set; } = string.Empty;
    }
}
