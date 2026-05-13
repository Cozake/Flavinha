using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academia.Api.Models
{
    public class TreinoExercicio
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int TreinoId { get; set; }

        [ForeignKey("TreinoId")]
        public Treino? Treino { get; set; }

        [Required]
        public int ExercicioId { get; set; }

        [ForeignKey("ExercicioId")]
        public Exercicio? Exercicio { get; set; }
    }
}
