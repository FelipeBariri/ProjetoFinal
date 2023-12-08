using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalFelipe.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("UsuarioId")]
        [Display(Name = "Código Do Usuário")]

        public int UsuarioId { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]

        public string Email { get; set; } = string.Empty;

        [Column("Senha")]
        [Display(Name = "Senha")]

        public string Senha { get; set; } = string.Empty;
    }
}
