using Atividade6.Models;

namespace Atividade6.Services
{
    public class ClienteService
    {
        private readonly List<Cliente> _clientes;
        private int _proximoId = 1;

        public ClienteService()
        {
            _clientes = new List<Cliente>
            {
                new Cliente { Id = _proximoId++, Nome = "João Silva", Email = "joao@email.com" },
                new Cliente { Id = _proximoId++, Nome = "Maria Santos", Email = "maria@email.com" },
                new Cliente { Id = _proximoId++, Nome = "Pedro Oliveira", Email = "pedro@email.com" },
                new Cliente { Id = _proximoId++, Nome = "Ana Costa", Email = "ana@email.com" }
            };
        }

        public async Task<List<Cliente>> ObterTodosClientesAsync()
        {
            await Task.Delay(50); // Simula operação assíncrona
            return _clientes.ToList();
        }

        public async Task<Cliente?> ObterClientePorIdAsync(int id)
        {
            await Task.Delay(50);
            return _clientes.FirstOrDefault(c => c.Id == id);
        }

        public async Task<Cliente> AdicionarClienteAsync(Cliente cliente)
        {
            await Task.Delay(50);
            cliente.Id = _proximoId++;
            _clientes.Add(cliente);
            return cliente;
        }
    }
}