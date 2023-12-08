using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalFelipe.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Column("Id")]
        [Display(Name = "Cód Da Cidade")]
        public int Id { get; set; }

        [Column("CidadeNome")]
        [Display(Name = "Nome Da Cidade")]
        public string CidadeNome { get; set; } = string.Empty;

        [ForeignKey("EstadoId")]
        public int EstadoId { get; set; }
        public Estado? Estado { get; set; }
    }
}
