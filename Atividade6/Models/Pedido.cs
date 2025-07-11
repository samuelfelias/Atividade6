using System.ComponentModel.DataAnnotations;

namespace Atividade6.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Cliente é obrigatório")]
        public Cliente Cliente { get; set; } = new Cliente();
        
        [Required(ErrorMessage = "Data do pedido é obrigatória")]
        public DateTime DataPedido { get; set; } = DateTime.Now;
        
        public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();
        
        public decimal Total => Itens.Sum(item => item.Subtotal);
        
        [Required(ErrorMessage = "Status é obrigatório")]
        public string Status { get; set; } = "Pendente";
    }
}