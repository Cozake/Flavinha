using System.ComponentModel.DataAnnotations;

namespace Academia.Api.DTOs
{
    public class TreinoCreateDto
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        [MaxLength(100, ErrorMessage = "Nome deve ter no máximo 100 caracteres")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Data é obrigatória")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Aluno é obrigatório")]
        public int AlunoId { get; set; }

        public List<int> ExercicioIds { get; set; } = new List<int>();
    }

    public class TreinoResponseDto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public DateTime Data { get; set; }
        public int AlunoId { get; set; }
        public string? AlunoNome { get; set; }
        public List<ExercicioResponseDto> Exercicios { get; set; } = new List<ExercicioResponseDto>();
    }
}
