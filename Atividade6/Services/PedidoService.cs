using Atividade6.Models;

namespace Atividade6.Services
{
    public class PedidoService
    {
        private readonly List<Pedido> _pedidos;
        private int _proximoId = 1;
        private int _proximoItemId = 1;

        public PedidoService()
        {
            _pedidos = new List<Pedido>();
        }

        public async Task<List<Pedido>> ObterTodosPedidosAsync()
        {
            await Task.Delay(50); // Simula operação assíncrona
            return _pedidos.ToList();
        }

        public async Task<Pedido?> ObterPedidoPorIdAsync(int id)
        {
            await Task.Delay(50);
            return _pedidos.FirstOrDefault(p => p.Id == id);
        }

        public async Task<Pedido> AdicionarPedidoAsync(Pedido pedido)
        {
            await Task.Delay(50);
            pedido.Id = _proximoId++;
            
            // Atribuir IDs aos itens
            foreach (var item in pedido.Itens)
            {
                if (item.Id == 0)
                    item.Id = _proximoItemId++;
            }
            
            _pedidos.Add(pedido);
            return pedido;
        }

        public async Task<Pedido> AtualizarPedidoAsync(Pedido pedido)
        {
            await Task.Delay(50);
            var pedidoExistente = _pedidos.FirstOrDefault(p => p.Id == pedido.Id);
            if (pedidoExistente != null)
            {
                var index = _pedidos.IndexOf(pedidoExistente);
                
                // Atribuir IDs aos novos itens
                foreach (var item in pedido.Itens)
                {
                    if (item.Id == 0)
                        item.Id = _proximoItemId++;
                }
                
                _pedidos[index] = pedido;
            }
            return pedido;
        }

        public async Task<bool> RemoverPedidoAsync(int id)
        {
            await Task.Delay(50);
            var pedido = _pedidos.FirstOrDefault(p => p.Id == id);
            if (pedido != null)
            {
                _pedidos.Remove(pedido);
                return true;
            }
            return false;
        }

        public async Task<List<Pedido>> FiltrarPedidosAsync(string? status = null, int? clienteId = null)
        {
            await Task.Delay(50);
            var query = _pedidos.AsQueryable();

            if (!string.IsNullOrEmpty(status))
                query = query.Where(p => p.Status.Equals(status, StringComparison.OrdinalIgnoreCase));

            if (clienteId.HasValue)
                query = query.Where(p => p.Cliente.Id == clienteId.Value);

            return query.ToList();
        }
    }
}