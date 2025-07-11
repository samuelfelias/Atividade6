using System.ComponentModel.DataAnnotations;

namespace Atividade6.Models
{
    public class Produto
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(100, ErrorMessage = "Nome deve ter no máximo 100 caracteres")]
        public string Nome { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Preço é obrigatório")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Preço deve ser maior que zero")]
        public decimal Preco { get; set; }
        
        [Required(ErrorMessage = "Categoria é obrigatória")]
        [StringLength(50, ErrorMessage = "Categoria deve ter no máximo 50 caracteres")]
        public string Categoria { get; set; } = string.Empty;
    }
}