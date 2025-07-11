using System.ComponentModel.DataAnnotations;

namespace Atividade6.Models
{
    public class ItemPedido
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Produto é obrigatório")]
        public Produto Produto { get; set; } = new Produto();
        
        [Required(ErrorMessage = "Quantidade é obrigatória")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantidade deve ser maior que zero")]
        public int Quantidade { get; set; }
        
        public decimal Subtotal => Produto?.Preco * Quantidade ?? 0;
    }
}