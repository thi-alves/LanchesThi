using LanchesThi.Data;
using LanchesThi.Models;
using LanchesThi.Repositories.Interfaces;

namespace LanchesThi.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
