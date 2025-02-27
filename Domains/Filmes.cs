using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_filmes_senai.Domains
{
    [Table("Filme")]
    public class Filmes
    {
        [Key]
        public Guid IdFilme { get; set; }
        [Column(TypeName ="VARCHAR(50)")]
        
        [Required(ErrorMessage = "O titulo do filme é obrigatório!!")]
        public string? Titulo {  get; set; }

        /// <summary>
        /// Referencia da tabela Genero
        /// </summary>
        public Guid IdGenero { get; set; }

        public Generos? Genero { get; set; }
    }
}
