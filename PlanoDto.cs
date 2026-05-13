using System.ComponentModel.DataAnnotations;

namespace Academia.Api.DTOs
{
    public class PlanoCreateDto
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        [MaxLength(100, ErrorMessage = "Nome deve ter no máximo 100 caracteres")]
        public string Nome { get; set; } = string.Empty;

        [MaxLength(255, ErrorMessage = "Descrição deve ter no máximo 255 caracteres")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "Preço é obrigatório")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Preço deve ser maior que zero")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Duração é obrigatória")]
        [Range(1, 60, ErrorMessage = "Duração deve ser entre 1 e 60 meses")]
        public int DuracaoMeses { get; set; }
    }

    public class PlanoResponseDto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public int DuracaoMeses { get; set; }
    }
}
