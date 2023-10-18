using EmprestimosLivros.API.Interfaces;
using EmprestimosLivros.API.Models;

namespace EmprestimosLivros.API.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ControleEmprestimoLivroContext _context;

        public ClienteRepository(ControleEmprestimoLivroContext context)
        {
            _context = context;
        }

        public void Alterar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Incluir(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> SelecionarByPk(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cliente>> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
