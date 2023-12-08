using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalFelipe.Models
{
    [Table("Estado")]
    public class Estado
    {
        [Column("Id")]
        [Display(Name = "Cód Do Estado")]
        public int Id { get; set; }

        [Column("NomeEstado")]
        [Display(Name = "Nome Do Estado")]

        public string NomeEstado { get; set; } = string.Empty; 
    }
}
