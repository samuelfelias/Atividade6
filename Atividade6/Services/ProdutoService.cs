using Atividade6.Models;

namespace Atividade6.Services
{
    public class ProdutoService
    {
        private readonly List<Produto> _produtos;

        public ProdutoService()
        {
            _produtos = new List<Produto>
            {
                new Produto { Id = 1, Nome = "Notebook Dell", Preco = 2500.00m, Categoria = "Eletrônicos" },
                new Produto { Id = 2, Nome = "Mouse Logitech", Preco = 85.00m, Categoria = "Eletrônicos" },
                new Produto { Id = 3, Nome = "Teclado Mecânico", Preco = 350.00m, Categoria = "Eletrônicos" },
                new Produto { Id = 4, Nome = "Monitor 24\"", Preco = 800.00m, Categoria = "Eletrônicos" },
                new Produto { Id = 5, Nome = "Cadeira Gamer", Preco = 1200.00m, Categoria = "Móveis" },
                new Produto { Id = 6, Nome = "Mesa de Escritório", Preco = 450.00m, Categoria = "Móveis" },
                new Produto { Id = 7, Nome = "Smartphone Samsung", Preco = 1800.00m, Categoria = "Eletrônicos" },
                new Produto { Id = 8, Nome = "Fone de Ouvido", Preco = 150.00m, Categoria = "Eletrônicos" },
                new Produto { Id = 9, Nome = "Webcam HD", Preco = 200.00m, Categoria = "Eletrônicos" },
                new Produto { Id = 10, Nome = "Impressora HP", Preco = 650.00m, Categoria = "Eletrônicos" }
            };
        }

        public async Task<List<Produto>> ObterTodosProdutosAsync()
        {
            await Task.Delay(50); // Simula operação assíncrona
            return _produtos.ToList();
        }

        public async Task<Produto?> ObterProdutoPorIdAsync(int id)
        {
            await Task.Delay(50);
            return _produtos.FirstOrDefault(p => p.Id == id);
        }
    }
}