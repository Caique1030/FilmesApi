using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Controllers.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get;  set; }
        [Required (ErrorMessage =" Titulo obrigatorio")]
        public required string Titulo { get; set; }

        [Required(ErrorMessage ="Descricao obrigatoria")]
        [MaxLength (50, ErrorMessage ="Extrapolou na descricao")]
        public required string Descricao { get; set; }

        [Required(ErrorMessage ="Ano obrigatorio")]
        public int Ano { get; set; }

        [Required(ErrorMessage ="Necessario por o tempo do filme ")]
        [Range(70 ,600,ErrorMessage ="Duracao muito pequena ")]
        public  int Duracao { get; set; }
        
    }
}
