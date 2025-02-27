using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_filmes_senai.Domains
{
    [Table("Genero")]
    public class Generos
    {
        [Key]
        public Guid IdGenero { get; set; }

        [Column(TypeName = "VARCHAR(30)")]
        [Required(ErrorMessage ="Nome do Genero é obrigatório!")]
        public string? Nome { get; set; }
    }
}
